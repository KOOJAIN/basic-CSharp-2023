﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf07_myexplorer
{
    public partial class FrmExplorer : Form
    {
        public FrmExplorer()
        {
            InitializeComponent();
        }



        private void FrmExplorer_Load(object sender, EventArgs e)
        {
            // 현재 사용자 출력
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            LblPath.Text = identity.Name;

            // 현재 컴퓨터에 존재하는 드라이브 정보검색, 트리뷰 추가
            DriveInfo[] drives = DriveInfo.GetDrives();

            // 트리뷰에 전부 추가
            foreach (DriveInfo drive in drives)
            {
                // 실제 존재하는 하드드라이브만...
                if (drive.DriveType == DriveType.Fixed)
                {
                    TreeNode rootNode = new TreeNode(drive.Name);
                    rootNode.ImageIndex = 0;
                    rootNode.SelectedImageIndex = 0;
                    TrvDrive.Nodes.Add(rootNode);
                    FillNodes(rootNode);
                }
            }
            TrvDrive.Nodes[0].Expand();

            //리스트뷰 설정
            LsvFolder.View = View.Details;

            LsvFolder.Columns.Add("이름", (LsvFolder.Width / 2), HorizontalAlignment.Left);
            LsvFolder.Columns.Add("날짜", (LsvFolder.Width / 4), HorizontalAlignment.Left);
            LsvFolder.Columns.Add("유형", (LsvFolder.Width / 5), HorizontalAlignment.Left);
            LsvFolder.Columns.Add("크기", (LsvFolder.Width / 5), HorizontalAlignment.Right);

            LsvFolder.FullRowSelect = true; // 한행을 전부 선택
            CboView.SelectedIndex = 0; // View.Detail로 초기화
        }

        private void FillNodes(TreeNode curNode)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(curNode.FullPath);
                // 드라이브 하위폴더
                foreach (DirectoryInfo item in dir.GetDirectories())
                {
                    TreeNode newNode = new TreeNode(item.Name);
                    newNode.ImageIndex = 1;
                    newNode.SelectedImageIndex = 2;
                    curNode.Nodes.Add(newNode);
                    newNode.Nodes.Add("*");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류발생!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrvDrive_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                e.Node.ImageIndex = 1;//folder nomal
                e.Node.SelectedImageIndex = 2;//folder -open
                FillNodes(e.Node);//하위 폴더를 만들어준다
            }
        }
        /// <summary>
        /// 트리뷰 접기 전 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrvDrive_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.ImageIndex = 1;
                e.Node.SelectedImageIndex = 1;
            }
        }

        private void TrvDrive_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SetLsvFolder(e.Node.FullPath);
        }
        /// <summary>
        /// 리스트뷰에 폴더내 내용 그리기 매서드 
        /// </summary>
        /// <param name="fullPath">선택한 폴더 경로</param>
        private void SetLsvFolder(string fullPath)
        {
            try
            {
                TxtPath.Text = fullPath;// 현재 경로 입력
                LsvFolder.Items.Clear(); // 기존 리스트 삭제
                DirectoryInfo dir = new DirectoryInfo(fullPath);
                int dirCount = 0;

                foreach (DirectoryInfo item in dir.GetDirectories())
                {
                    ListViewItem lvi = new ListViewItem();

                    lvi.ImageIndex = 1;
                    lvi.Text = item.Name;

                    LsvFolder.Items.Add(lvi);
                    LsvFolder.Items[dirCount].SubItems.Add(item.CreationTime.ToString());
                    LsvFolder.Items[dirCount].SubItems.Add("폴더");
                    LsvFolder.Items[dirCount].SubItems.Add(string.Format("{0} files", item.GetFiles().Length.ToString()));

                    dirCount++;
                }
                // 폴더내 디렉토리 리스트뷰에 리스트업

                // 파일목록 리스트업
                FileInfo[] files = dir.GetFiles();
                int fileCount = dirCount;//이전 카운트가 승계

                foreach (FileInfo file in files)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = file.Name;
                    lvi.ImageIndex = 4;
                    lvi.ImageIndex = SetExtImg(file.Name);
                    LsvFolder.Items.Add(lvi);
                    if (file.LastWriteTime != null)
                    {
                        LsvFolder.Items[fileCount].SubItems.Add(file.LastWriteTime.ToString());
                    }
                    else
                    {
                        LsvFolder.Items[fileCount].SubItems.Add(file.CreationTime.ToString());
                    }
                    LsvFolder.Items[fileCount].SubItems.Add(file.Attributes.ToString());
                    LsvFolder.Items[fileCount].SubItems.Add(file.Length.ToString());

                    fileCount++;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("오류발생!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// 파일확장자에 따라 아이콘 변경
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private int SetExtImg(string name)
        {
            FileInfo fInfo = new FileInfo(name);
            string ext = fInfo.Extension; //확장자를 가져옴
            var exVal = 0;
            switch (ext)
            {
                case ".": //실행파일
                    exVal = 3; //ex 아이콘
                    break;

                case ".png"://
                case ".jpg":
                case ".gif":
                    exVal = 5;
                    break;

                default:
                    exVal = 4;
                    break;

            }
            return exVal;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // View.Details
            //View.SmallIcon
            //View.LargeIcon
            //View.List
            //View.Tile
            switch (CboView.SelectedIndex)
            {
                case 0:
                    LsvFolder.View = View.Details; break;
                case 1:
                    LsvFolder.View = View.SmallIcon; break;
                case 2:
                    LsvFolder.View = View.LargeIcon; break;
                case 3:
                    LsvFolder.View = View.List; break;
                case 4:
                    LsvFolder.View = View.Tile; break;
                    //위와 같은 경우에는 defalt 없어도 됨
            }
        }
        /// <summary>
        /// 디렉토리 경로를 바꿨을 때 처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//엔터키를 누르면
            {
                try
                {
                    SetLsvFolder(TxtPath.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("경로를 찾을 수 없습니다. 다시 시도하십시오", "나의 탐색기",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// 파일을 더블 클릭처리 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LsvFolder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LsvFolder.SelectedItems.Count == 1)
            {
                string processPath;

                processPath = TxtPath.Text + "\\" + LsvFolder.SelectedItems[0].Text;

                Process.Start(processPath);

            }
        }
    }
}