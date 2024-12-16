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
    public partial class viewFood : SampleView
    {
        public viewFood()
        {
            InitializeComponent();
            this.Load += new EventHandler(viewAdd_Load); // Đăng ký sự kiện Load

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
    }
}
