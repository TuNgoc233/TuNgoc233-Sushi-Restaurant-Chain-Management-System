using Sushi_Restaurant.Chi_Nhanh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void Brand_Load(object sender, EventArgs e)
        {
            try
            {
                // Gọi các hàm từ lớp Branch và hiển thị lên giao diện
                lblTotalEmployees.Text = Branch.GetTotalEmployees(_branchId).ToString("N0"); // Định dạng số nguyên (1,234)
                lblTotalCustomers.Text = Branch.GetTotalCustomers(_branchId).ToString("N0"); // Định dạng số nguyên (1,234)
                lblTotalInvoices.Text = Branch.GetTotalInvoices(_branchId).ToString("N0"); // Định dạng số nguyên (1,234)

                // Hiển thị doanh thu theo định dạng tiền tệ (1,234,567 VND)
                lblTotalRevenue.Text = string.Format("{0:N0} VND", Branch.GetTotalRevenue(_branchId));

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
        private void btn_Food_Click(object sender, EventArgs e)
        {
            viewFood Page = new viewFood();
            this.Hide(); // Chỉ ẩn form Brand
            Page.Show();
        }

        private void btn_Statistic_Click(object sender, EventArgs e)
        {
            branch_revenue form = new branch_revenue(_branchId);
            form.Show();
            this.Hide(); // Ẩn form đăng nhập
        }

        private void lblTotalEmployees_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // Confirm logout action
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Logout(); // Call the logout method
            }
        }

        private void Logout()
        {
            Branch.MaChiNhanh = null; // Xóa dữ liệu phiên
            Sushi_Restaurant.Chi_Nhanh.Login loginForm = new Sushi_Restaurant.Chi_Nhanh.Login(); // Sử dụng không gian tên đầy đủ
            loginForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Logout();
            }
            else
            {
                e.Cancel = true; // Prevent closing
            }
        }
    }
}
