using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf05_login2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "abcd" && TxtPass.Text == "1234")
            {
                LblResult.Text = "로그인 성공";

            }
            else
            {
                LblResult.Text = "로그인 실패";
            }
        }
    }
}
