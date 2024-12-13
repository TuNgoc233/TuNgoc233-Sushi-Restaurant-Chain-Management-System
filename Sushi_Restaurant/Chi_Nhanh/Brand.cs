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
        public string _branchId;  // Biến lưu trữ ID chi nhánh
        // Constructor nhận ID từ form Login
        public Brand(string branchId)
        {
            InitializeComponent();
            _branchId = branchId; // Lưu giá trị ID vào biến toàn cục
        }

        //Control exit
        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnNhanVien(object sender, EventArgs e)
        {
            viewStaff staffPage = new viewStaff();
            staffPage.Owner = this; // Gán form Brand làm Owner của form con
            this.Hide(); // Chỉ ẩn form Brand
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

        private void Btn_Envoice_click(object sender, EventArgs e)
        {
            viewEnvoice viewEnvoice = new viewEnvoice();
            viewEnvoice.Owner = this; // Gán form Brand làm Owner của form con
            this.Hide(); // Chỉ ẩn form Brand
            viewEnvoice.Show();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CardID_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Logo(object sender, EventArgs e)
        {

        }
    }
}
