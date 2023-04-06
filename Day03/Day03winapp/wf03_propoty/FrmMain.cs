using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf03_property
{
    public partial class FrmMain : Form
    {
        Random rnd = new Random(45); // 45사이에서 골라짐 랜덤으로
        public FrmMain()
        {
            InitializeComponent();
            // 생성자에는 되도록 설정부분을 넣지마세요.
            // Form_Load() 이벤트 핸들러에 작성할 것
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            GbxMain.Text = "컨트롤 학습";
            var fonts = FontFamily.Families.ToList(); // 내 OS 폰트이름 가져오기
            foreach (var font in fonts)
            {
                CboFontFamily.Items.Add(font.Name);
            }
            // 글자크기 최소값, 최대값 지정
            NudFontSize.Minimum = 5;
            NudFontSize.Maximum = 40;
            // 텍스트박스 초기화
            TxtResult.Text = "Hello, WinForms!!";

            NudFontSize.Value = 9; // 글자체 크기를 9로 지정
        }

        /// <summary>
        /// 글자 스타일, 크기, 글자체를 변경해주는 메서드
        /// </summary>
        private void ChangeFontStyle()
        {
            if (CboFontFamily.SelectedIndex < 0)
            {
                CboFontFamily.SelectedIndex = 257; // 디폴트는 나눔 고딕으로 지정
            }

            FontStyle style = FontStyle.Regular; // 기본
            if (ChkBold.Checked == true)
            {
                style |= FontStyle.Bold; // Bit연산 or
            }
            if (ChkItalic.Checked == true)
            {
                style |= FontStyle.Italic;
            }

            decimal fontSize = NudFontSize.Value;

            TxtResult.Font = new Font((string)CboFontFamily.SelectedItem, (float)fontSize, style);

            if(RdoNomal.Checked)
            {
                TxtResult.Text = TxtResult.Text.Trim();
            }
            else if(Rdoindent.Checked)
            {
                TxtResult.Text = "  " + TxtResult.Text;     
            }
        }

        private void CboFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void NudFontSize_ValueChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void PgnDummy_Click(object sender, EventArgs e)
        {

        }
        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PgnDummy.Value = TrbDummy.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form
            {
                Text = "Modal Form",
                Width = 300,
                Height = 200,
                Left = 10,
                Top = 20,
                BackColor = Color.AliceBlue,
            };
            frm.ShowDialog(); // 모달 방식으로 자식창 띄우기 추가창 안 켜짐
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form()
            {
                Text = "Modaless Form",
                Width = 300,
                Height = 200,
                StartPosition = FormStartPosition.CenterParent, 
                BackColor = Color.GreenYellow,
            };
            //frm.ShowDialog();
            frm.Show(); // 창이 여러개 켜짐
        }

        private void BtnMessageBox_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(TxtResult.Text, "알림");
            // MessageBox.Show(TxtResult.Text, caption:"메세지창"); // 갭션
            // MessageBox.Show(TxtResult.Text, "메세지창",MessageBoxButtons.YesNoCancel);
            // MessageBox.Show(TxtResult.Text, "알림", MessageBoxButtons.AbortRetryIgnore);
            MessageBox.Show(TxtResult.Text, "알림",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            // MessageBox.Show(TxtResult.Text,TxtResult.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tvDummy_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void lvDummy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(rnd.Next(45).ToString());
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (tvDummy.SelectedNode != null) { 
            tvDummy.SelectedNode.Nodes.Add(rnd.Next(50,100).ToString());
            tvDummy.SelectedNode.Expand();
            }
        }
        void TreeToList()
        {
                lvDummy.Items.Clear();  // 리스트뷰,트리뷰 모든 아이템을 제거 초기화 메서드
                foreach(TreeNode item in tvDummy.Nodes)
                {
                    TreeToList(item);
                }
        }

        private void TreeToList(TreeNode item)
        {
            lvDummy.Items.Add(
                new ListViewItem(new[] {item.Text,item.FullPath.ToString()} ) );

                foreach(TreeNode node in item.Nodes)
                {
                    TreeToList(node); // 재귀 호출
                }
        }

        private void RdoNomal_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }
        private void Rdoindent_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void Btnload_Click(object sender, EventArgs e)
        {
            PcbDummy.Image = Bitmap.FromFile("dog.png");
        }

        private void PcbDummy_Click(object sender, EventArgs e)
        {
            if(PcbDummy.SizeMode == PictureBoxSizeMode.Normal)
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}