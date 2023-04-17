using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using wf13_bookrentalshop.Helpers;


namespace wf13_bookrentalshop
{
    public partial class FrmBooks : Form
    {
        bool isNew = false; //false(UPDATE) / true(INSERT)
        #region<생성자>
        public FrmBooks()
        {
            InitializeComponent();
        }
        #endregion  
        #region<이벤트 핸들러>
        private void FrmGenre_Load(object sender, EventArgs e)
        {
            isNew = true;   // 신규부터 시작
            RefreshData();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
            //TxtDivision.Text = TxtNames.Text = string.Empty;
            //isNew = true; // 신규
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (isNew == true)  // 신규
            {
                MessageBox.Show("삭제할 데이터를 선택하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // FK제약조건으로 지울수없는 데이터인지 먼저 확인
            using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))      //mysql 쿼리 만들고
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string strChkQuery = "SELECT COUNT(*) FROM bookstbl WHERE Division = @Division";
                MySqlCommand chkCmd = new MySqlCommand(strChkQuery, conn);
                MySqlParameter prmDivision = new MySqlParameter("@Division", TxtBookIdx.Text);
                chkCmd.Parameters.Add(prmDivision); 
                var result = chkCmd.ExecuteScalar();     // Execut none 커리는 delete이다.

                if (result.ToString() != "0" )
                {
                    MessageBox.Show(this, "이미 사용중인 코드입니다.", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //삭제여부를 물을때 아니오를 누르면 삭제진행 취소
            if (MessageBox.Show(this, "삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            // Yes를 누르면 계속 진행 // S
            DeleteData(); // 데이터 삭제처리
            RefreshData(); // 지우고나서 재조회
            ClearInputs(); // 입력창 데이터 지우기
        }
        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)    // 아무것도 선택안하면 -1
            {
                var selData = DgvResult.Rows[e.RowIndex];
                // Debug.WriteLine(selData.ToString());
                Debug.WriteLine(selData.Cells[0].Value);
                Debug.WriteLine(selData.Cells[1].Value);
                TxtBookIdx.Text = selData.Cells[0].Value.ToString();
                TxtAuthor.Text = selData.Cells[1].Value.ToString();
                TxtBookIdx.ReadOnly = true; // PK는 수정하면 안됨

                isNew = false; // 수정
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation() != true) return;

            SaveData(); // 데이터 저장/수정
            RefreshData(); // 데이터 재조회
            ClearInputs();  //입력창 클리어
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
        #region<커스텀 메서트>
        private void RefreshData()
        {
            // DB divtbl 데이터 조회 DgvResult 뿌림
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    // 쿼리 작성
                    var selQuery = @"SELECT b.bookIdx,
							b.Author,
							b.Division,
                            d.Names AS DivNames,
							b.Names,
							b.ReleaseDate,
							b.ISBN,
							b.Price
                            FROM  bookstbl AS b
                            INNER JOIN divtbl AS d
                            ON b.Division = d.Division
                            ORDER BY b.bookIdx ASC"; // 정렬때문에 추가
                    MySqlDataAdapter adapter = new MySqlDataAdapter(selQuery, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "divtbl"); // divtbl로 dataSet 접근가능

                    DgvResult.DataSource = ds.Tables[0];
                    //DgvResult.DataSource = ds;
                    //DgvResult.DataMember = "divtbl";

                    DgvResult.Columns[0].HeaderText = "번호";
                    DgvResult.Columns[1].HeaderText = "저자명";
                    DgvResult.Columns[2].HeaderText = "책장르";
                    DgvResult.Columns[3].HeaderText = "책장르";
                    DgvResult.Columns[4].HeaderText = "책제목";
                    DgvResult.Columns[5].HeaderText = "출판일자";
                    DgvResult.Columns[6].HeaderText = "ISBN";
                    DgvResult.Columns[7].HeaderText = "책가격";

                    DgvResult.Columns[0].Width = 50;
                    DgvResult.Columns[2].Visible = false;       // B001 코드영역 보일필요 없습 
                    DgvResult.Columns[5].Width = 78;
                    DgvResult.Columns[7].Width = 80;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            TxtBookIdx.Text = TxtAuthor.Text = string.Empty;
            TxtBookIdx.ReadOnly = false; // 신규일땐 입력가능
            TxtBookIdx.Focus();
            isNew = true; // 신규
        }

        private bool CheckValidation()
        {
            var result = true;
            var errorMsg = string.Empty;

            if (string.IsNullOrEmpty(TxtBookIdx.Text))
            {
                result = false;
                errorMsg += "● 장르코드를 입력하세요.\r\n";
            }

            if (string.IsNullOrEmpty(TxtAuthor.Text))
            {
                result = false;
                errorMsg += "● 장르명을 입력하세요.\r\n";
            }

            if (result == false)
            {
                MessageBox.Show(errorMsg, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
            else
            {
                return result;
            }

        }


        private void SaveData()
        {


            // INSERT부터 시작
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = "";
                    if (isNew)
                    {
                        query = @"INSERT INTO divtbl
                                        VALUES ( @Division, @Names )";
                    }
                    else
                    {
                        query = @"UPDATE divtbl
                        SET Names = @Names
                        WHERE Division = @Division";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlParameter prmDivision = new MySqlParameter("@Division", TxtBookIdx.Text);
                    MySqlParameter prmNames = new MySqlParameter("@Names", TxtAuthor.Text);
                    cmd.Parameters.Add(prmDivision);
                    cmd.Parameters.Add(prmNames);

                    var result = cmd.ExecuteNonQuery(); // INSERT, UPDATE, DELETE

                    if (result != 0)
                    {
                        // 저장성공
                        MessageBox.Show("저장성공!!!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // 저장실패
                        MessageBox.Show("저장성공!!!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }



        private void DeleteData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"DELETE FROM divtbl
                                      WHERE Division = @Division";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlParameter prmDivision = new MySqlParameter("@Division", TxtBookIdx.Text);
                    cmd.Parameters.Add(prmDivision);

                    var result = cmd.ExecuteNonQuery(); // INSERT, UPDATE, DELETE

                    if (result != 0)
                    {
                        // 저장성공
                        MessageBox.Show("삭제성공!!!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // 저장실패
                        MessageBox.Show("삭제실패!!!", "삭제-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion












        // 그리드뷰 클릭하8/면 발생이벤트

    }
}
// 생성자, 이벤트, 커스텀 나누는 기준 꿀팁?


// 생성자는 참조가 없다?
// 이벤트 헨들러는 objec sender, Eventargs e  가 있고
// 커스텀 메서드는 지멋대로임