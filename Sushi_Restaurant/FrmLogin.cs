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
            if (string.IsNullOrWhiteSpace(text_User.Text) ||string.IsNullOrWhiteSpace(text_pass.Text))
            {
                err_noFullInfor_Login.Show("Vui lòng nhập đầy đủ thông tin");
            }
            this.Hide();  // Ẩn Form Login
            Brand frmBrand = new Brand();
            frmBrand.ShowDialog();  // Hiển thị form Brand theo kiểu hộp thoại
            this.Show();  // Hiển thị lại form Login sau khi đóng form Brand
            }

        private void tex_pass_TextChanged(object sender, EventArgs e)
            {

        }   

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
