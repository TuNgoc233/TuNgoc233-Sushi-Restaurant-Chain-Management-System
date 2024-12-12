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
            string username = Username.Text;
            string password = Password.Text;

            // Băm mật khẩu
            string hashedPassword = SecurityUtils.HashPassword(password);

            // Kết nối và kiểm tra đăng nhập
            string branchId = CheckLogin(username, hashedPassword);
            if (!string.IsNullOrEmpty(branchId))
            {
                // Mở form thông tin chi nhánh nếu đăng nhập thành công
                Brand branchForm = new Brand();
                branchForm.Show();
                this.Hide();
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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Username(object sender, EventArgs e)
        {

        }

        private void Password(object sender, EventArgs e)
        {

        }
    }
}
