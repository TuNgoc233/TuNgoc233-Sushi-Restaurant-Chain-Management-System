using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_dk_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSignUp frm = new FrmSignUp();
            frm.Show();
        }

        private void bt_dn_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường thông tin có bị bỏ trống hay không
            if (string.IsNullOrWhiteSpace(text_User.Text) ||
                string.IsNullOrWhiteSpace(text_pass.Text))
            {
                err_noFullInfor_Login.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (MainClass.IsValidUser(text_User.Text, text_pass.Text) == false)
            {
                error_invalid_User.Show("Tài khoản hoặc mật khẩu không đúng");
            }
            else
            {
                // Gán thời điểm truy cập hiện tại vào biến Global
                GlobalVariables.ThoiDiemTruyCap = DateTime.Now;

                this.Hide();
                FrmCustomer frm = new FrmCustomer();
                frm.Show();
            }
        }   

        private void tex_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
