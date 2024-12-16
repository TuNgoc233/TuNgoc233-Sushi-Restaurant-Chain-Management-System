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
            this.Load += Brand_Load; // Gán sự kiện Load
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
            //viewEnvoice viewEnvoice = new viewEnvoice();
            //viewEnvoice.Owner = this; // Gán form Brand làm Owner của form con
            //this.Hide(); // Chỉ ẩn form Brand
            //viewEnvoice.Show();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {


        }

        private void Btn_ID_Card(object sender, EventArgs e)
        {
            viewID_Card Page = new viewID_Card();
            this.Hide(); // Chỉ ẩn form Brand
            Page.Show();
        }

        private void Btn_Bill_Click(object sender, EventArgs e)
        {
            viewOrderForm Page = new viewOrderForm();
            this.Hide(); // Chỉ ẩn form Brand
            Page.Show();
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void Brand_Load(object sender, EventArgs e)
        {
            try
            {
                // Gọi các hàm từ lớp Branch và hiển thị lên giao diện
                lblTotalEmployees.Text = $"Số nhân viên: {Branch.GetTotalEmployees(_branchId)}";
                lblTotalCustomers.Text = $"Số khách hàng: {Branch.GetTotalCustomers(_branchId)}";
                lblTotalInvoices.Text = $"Số hóa đơn: {Branch.GetTotalInvoices(_branchId)}";
                lblTotalRevenue.Text = $"Doanh thu: {Branch.GetTotalRevenue(_branchId):C}"; // Hiển thị theo định dạng tiền tệ
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
