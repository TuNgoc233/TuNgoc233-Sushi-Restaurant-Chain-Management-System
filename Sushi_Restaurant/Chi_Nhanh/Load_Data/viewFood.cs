using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class viewFood : SampleView
    {
        public viewFood()
        {
            InitializeComponent();
            this.Load += new EventHandler(viewAdd_Load); // Đăng ký sự kiện Load
            //texRole.SelectedIndexChanged += textRole_SelectedIndexChanged;

        }

        public override void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text.Trim(); // Lấy chuỗi tìm kiếm từ TextBox
            string branchID = Branch.MaChiNhanh; // Lấy mã chi nhánh từ lớp Branch

            // Gọi phương thức tìm kiếm món ăn
            List<FoodItem> foodItems = FoodItem.SearchFoodItems(searchTerm, branchID);

            // Xóa các dòng hiện có trong DataGridView
            Data_Load.Rows.Clear();

            // Hiển thị kết quả tìm kiếm
            foreach (var item in foodItems)
            {
                // Định dạng giá theo định dạng 000.000 VND
                string formattedPrice = item.GiaHienTai.ToString("N0", CultureInfo.InvariantCulture) + " VND";

                // Chuyển đổi tình trạng phục vụ từ BIT sang "Có" hoặc "Không"
                string serviceStatus = item.TinhTrangPhucVu == 1 ? "Có" : "Không";

                // Thêm dữ liệu vào DataGridView
                Data_Load.Rows.Add(
                    item.MaMonAn,
                    item.TenMonAn,
                    item.TenMuc,
                    formattedPrice,
                    serviceStatus // Sử dụng biến serviceStatus
                );
            }
        }

        private void viewAdd_Load(object sender, EventArgs e)
        {
            // Lấy chuỗi tìm kiếm từ TextBox
            string searchTerm = txtTimKiem.Text.Trim();
            // Lấy mã chi nhánh từ lớp Branch
            string branchID = Branch.MaChiNhanh;

            // Gọi phương thức tìm kiếm món ăn
            List<FoodItem> foodItems = FoodItem.LoadFoodItemsFromProcedure(branchID);

            // Xóa các dòng hiện có trong DataGridView
            Data_Load.Rows.Clear();

            // Hiển thị kết quả tìm kiếm
            foreach (var item in foodItems)
            {
                // Chuyển đổi tình trạng phục vụ từ BIT sang "Có" hoặc "Không"
                string serviceStatus = item.TinhTrangPhucVu == 1 ? "Có" : "Không";
                string formattedPrice = item.GiaHienTai.ToString("N0") + " VND";

                Data_Load.Rows.Add(
                    item.MaMonAn,
                    item.TenMonAn,
                    item.TenMuc,
                    formattedPrice,
                    serviceStatus
                );
            }
        }

        public void label2_Click_1(object sender, EventArgs e)
        {

        }

        public void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void data_Load(object sender, DataGridViewCellEventArgs e)
        {
          
        }


        private void texRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void texName_TextChanged(object sender, EventArgs e)
        {

        }

        private void texID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ControlMini_Click(object sender, EventArgs e)
        {

        }

        private void ControlMax_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewID_Card viewID_Card = new viewID_Card();
            viewID_Card.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RevenueStatistics revenueStatistics = new RevenueStatistics();
            revenueStatistics.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewOrderForm viewOrderForm = new viewOrderForm(); 
            viewOrderForm.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brand brand = new Brand(Branch.MaChiNhanh);
            brand.Show();

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewStaff staff = new viewStaff();
            staff.Show();  
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
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
