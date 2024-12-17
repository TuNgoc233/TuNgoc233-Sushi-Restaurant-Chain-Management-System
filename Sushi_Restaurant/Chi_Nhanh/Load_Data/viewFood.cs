using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class viewFood : SampleView
    {
        public viewFood()
        {
            InitializeComponent();
            this.Load += new EventHandler(viewAdd_Load); // Đăng ký sự kiện Load

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

                // Thêm dữ liệu vào DataGridView
                Data_Load.Rows.Add(
                    item.MaMonAn,
                    item.TenMonAn,
                    item.MaMuc,
                    formattedPrice,
                    item.TinhTrangPhucVu
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
                string formattedPrice = item.GiaHienTai.ToString("N0") + " VND";

                Data_Load.Rows.Add(
                    item.MaMonAn,
                    item.TenMonAn,
                    item.MaMuc,
                    formattedPrice,
                    item.TinhTrangPhucVu
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

        private void Insert_Item_Click(object sender, EventArgs e)
        {
            addFood Page = new addFood();
            this.Hide(); // Chỉ ẩn form Brand
            Page.Show();
        }
    }
}
