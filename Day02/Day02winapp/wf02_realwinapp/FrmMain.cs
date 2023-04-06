using System;
using System.Windows.Forms;

namespace wf02_realwinapp
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("버튼 클릭!!!", "클릭");
            return;
        }

        private void BtnOK_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("마우스만 올려도 이벤트가 발생돼요");
        }
    }
}
