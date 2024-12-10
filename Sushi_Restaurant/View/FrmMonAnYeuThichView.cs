using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.View
{
    public partial class FrmMonAnYeuThichView : Form
    {
        private DataTable allOrders = new DataTable();
        public FrmMonAnYeuThichView()
        {
            InitializeComponent();
            KhoiTaoDuLieu();

            dataGridViewMonAn.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default; // Tắt theme
            dataGridViewMonAn.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 55, 89);
            dataGridViewMonAn.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold); // Chỉnh font
        }

        private void KhoiTaoDuLieu()
        {

            // Tạo các cột
            allOrders.Columns.Add("STT", typeof(int));
            allOrders.Columns.Add("Mã món ăn", typeof(string));
            allOrders.Columns.Add("Tên Món Ăn", typeof(string));     // Cột Tên Món Ăn
            allOrders.Columns.Add("Hình ảnh", typeof(Image));      // Cột Hình Ảnh (Loại Image)

            // Thêm dữ liệu mẫu vào DataTable
            allOrders.Rows.Add(1,"MM001" , "Súp Miso", Image.FromFile(@"C:\Users\HanhSpring\Downloads\Khai vị\súp miso.jpg"));
            allOrders.Rows.Add(2,"MM002", "Trứng Hấp", Image.FromFile(@"C:\Users\HanhSpring\Downloads\Khai vị\trứng hấp.jpg"));
            allOrders.Rows.Add(3, "MM003","Sashimi Cá Hồi Đặc Biệt", Image.FromFile(@"C:\Users\HanhSpring\Downloads\Sashimi combo\sashimi cá hồi đặt biệt.png"));
            dataGridViewMonAn.DataSource = allOrders;
        }

        private void icon_Dat_Mon_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
