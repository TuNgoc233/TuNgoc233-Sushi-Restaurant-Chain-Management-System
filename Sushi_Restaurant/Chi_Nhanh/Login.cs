using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLoginBranch(object sender, EventArgs e)
        {
            //this.Hide();
            //Brand branch = new Brand(); // Khởi tạo UserControl viewStaff
            //branch.Show();
            string username = TextUser.Text;
            string password = TextPassword.Text;

            //// Băm mật khẩu
            //string hashedPassword = SecurityUtils.HashPassword(password);

            // Kết nối và kiểm tra đăng nhập
            // Kết nối và kiểm tra đăng nhập
            string branchId = Branch.CheckLogin(username, password);
            if (!string.IsNullOrEmpty(branchId))
            {
                this.Hide();
                // Truyền branchId khi tạo form Brand
                Brand branchForm = new Brand(branchId);
                branchForm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ControlExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Username(object sender, EventArgs e)
        {

        }

        private void Password(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt trạng thái mặc định cho TextBox: Ẩn mật khẩu
            TextPassword.PasswordChar = '•'; // Mặc định dùng ký tự che mật khẩu
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu checkbox được tích
            if (guna2CheckBox1.Checked)
            {
                // Hiển thị mật khẩu
                TextPassword.PasswordChar = '\0'; // '\0' là ký tự null, không che mật khẩu
            }
            else
            {
                // Ẩn mật khẩu bằng dấu ...
                TextPassword.PasswordChar = '•'; // Ký tự để thay thế mật khẩu (ví dụ: '•', '*', ...)
            }
        }

       


    }
}
