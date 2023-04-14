using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace wf13_bookrentalshop
{
    public partial class FrmLogin : Form
    {
        private bool isLogined = false; //로그인이 성공했는지 변수

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            isLogined = LoginProcess();     // 로그인을 성공해야만 true가 됨

            if (isLogined)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Application.Exit();     
            Environment.Exit(0); // 가장 완벽하게 프로그램 종료
        }

        // 이게 없으면 x버튼이나 ALT + f4 했을 때 메인폼이 나타남
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLogined != true)
            {  // 로그인 안됐을때 창을 닫으면 프로그램 모두 종료
                Environment.Exit(0);
            }
        }



        //DB userTbl에서 정보확인 로그인처리
        private bool LoginProcess()
        {
            // Valtdation check     => 아이디와 페스워드에 내용이 들어가 있는지 검증
            if (string.IsNullOrEmpty(TxtUserId.Text))  //string.IsNullOrEmpty
            {
                MessageBox.Show("유저아이디를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))  //string.IsNullOrEmpty
            {
                MessageBox.Show("패스워드를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string strUserId = "";
            string strPassword = "";

            try
            {
                // string connectionString = "Server=localhost;Port=3306;Database=bookrentalshop;Uid=root;Pwd=12345";
                // DB처리
                using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))
                {
                    conn.Open();
                    #region <<DB쿼리를 위한 구성>>
                    string selQuery = @"SELECT userId
                                             , password
                                          FROM usertbl
                                         Where userID = @userID
                                           And password = @password";
                    MySqlCommand selCmd = new MySqlCommand(selQuery, conn);
                    // @userID , @password 파라미터 할당
                    MySqlParameter prmUserID = new MySqlParameter("@userID", TxtUserId.Text);
                    MySqlParameter prmPassword = new MySqlParameter("@password", TxtPassword.Text);
                    selCmd.Parameters.Add(prmUserID);
                    selCmd.Parameters.Add(prmPassword);
                    #endregion

                    MySqlDataReader reader = selCmd.ExecuteReader(); // 실한한 다음에 userId, password
                    if (reader.Read())
                    {

                        strUserId = reader["userID"] != null ? reader["userID"].ToString() : "-";
                        strPassword = reader["password"] != null ? reader["password"].ToString() : "-";
                    }
                    else
                    {
                        MessageBox.Show($"로그인정보가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                }// conn.Close();

                // MessageBox.Show($"{strUserId} / {strPassword}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상정 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 엔터키 누르면
            {
                BtnLogin_Click(sender, e);
            }// 버튼 누르면 이벤트 핸들러 호출
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 엔터키 누르면
            {
                BtnLogin_Click(sender, e);
            }// 버튼 누르면 이벤트 핸들러 호출
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

