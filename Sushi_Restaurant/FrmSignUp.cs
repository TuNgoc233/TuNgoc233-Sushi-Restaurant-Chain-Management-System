using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void text_SDT_TextChanged(object sender, EventArgs e)
        {

            if (text_SDT.Text.Length > 10) // Kiểm tra nếu độ dài chuỗi vượt quá 12
            {
                text_SDT.Text = text_SDT.Text.Substring(0, 10);
                text_SDT.SelectionStart = text_SDT.Text.Length; // Đưa con trỏ về cuối
            }
        }

        private void text_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem có phải là số hoặc phím Backspace không
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ngừng xử lý nếu ký tự không phải là số
            }
        }
        private void but_DK_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường thông tin có bị bỏ trống hay không
          
             if  ( string.IsNullOrWhiteSpace(text_SDT.Text) ||
                string.IsNullOrWhiteSpace(text_HoTen.Text) ||
                string.IsNullOrWhiteSpace(text_Email.Text)) {  
             
                error_noFullInfor_SignUp.Show("Vui lòng nhập đầy đủ thông tin");
             }
             else {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_ThemKhachHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số
                    cmd.Parameters.AddWithValue("@HoTen", text_HoTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", text_Email.Text.Trim());
                    cmd.Parameters.AddWithValue("@SoDienThoai", text_SDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@MatKhau", text_pass.Text.Trim());

                    // Tham số OUTPUT
                    SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(resultParam);

                    // Thực thi procedure
                    cmd.ExecuteNonQuery();

                    // Kiểm tra kết quả
                    int result = (int)resultParam.Value;

                    if (result == 1)
                    {
                        SignUp_sucess.Show("Đăng ký thành công! Vui lòng đăng nhập lại.");
                        this.Hide();
                        FrmLogin frm = new FrmLogin();
                        frm.Show();
                    }
                    else
                    {
                        error_noFullInfor_SignUp.Show("Email hoặc số điện thoại đã tồn tại.");
                    }
                }
            }
            
        }
        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
