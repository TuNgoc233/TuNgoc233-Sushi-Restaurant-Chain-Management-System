using Sushi_Restaurant.Chi_Nhanh;
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
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }

        //Control exit
        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnNhanVien(object sender, EventArgs e)
        {
            this.Hide();
            viewStaff staffPage = new viewStaff(); // Khởi tạo UserControl viewStaff
            staffPage.Show();
          
        }


        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
