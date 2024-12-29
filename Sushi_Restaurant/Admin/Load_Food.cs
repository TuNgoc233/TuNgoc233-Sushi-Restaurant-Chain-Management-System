using Sushi_Restaurant.Chi_Nhanh;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Sushi_Restaurant.Admin
{
    public partial class Load_Food : SampleView
    {
        public Load_Food()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Đăng ký sự kiện Load
            this.Load += new EventHandler(viewAdd_Load);
        }

        private void Load_Food_Load(object sender, EventArgs e)
        {
           
        }

        private void Data_Load_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                    serviceStatus
                );
            }
        }

        private void viewAdd_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu ban đầu
            ReloadFoodData();
        }

        private void ReloadFoodData()
        {
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại và quay về Admin_Manage
            this.Hide();
            Admin_Manage admin_Manage = new Admin_Manage();
            admin_Manage.Show();
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            // Mở form addFood
            addFood add = new addFood();

            // Làm mờ form chính
            this.Opacity = 0.9;

            // Đăng ký sự kiện khi form addFood đóng
            add.FormClosed += (s, args) =>
            {
                // Phục hồi độ trong suốt của form chính
                this.Opacity = 1.0;

                // Gọi lại phương thức để cập nhật DataGridView
                ReloadFoodData();
            };

            // Hiển thị form addFood dưới dạng modal
            add.ShowDialog();
        }
    }
}
