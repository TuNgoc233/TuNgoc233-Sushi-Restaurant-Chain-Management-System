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

namespace Sushi_Restaurant.Admin
{
    public partial class Load_Food : SampleView
    {
        public Load_Food()
        {
            InitializeComponent();

            // Vô hiệu hóa Theme mặc định để toàn quyền điều chỉnh
            // Thiết lập font chữ cho Header
            this.Data_Load.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Data_Load.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 16);

            // Thiết lập màu nền và màu chữ cho Header
            this.Data_Load.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 55, 89);
            this.Data_Load.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.Data_Load.EnableHeadersVisualStyles = false; // Bắt buộc phải tắt thuộc tính này để màu tùy chỉnh có hiệu lực

            // Tăng chiều cao Header
            this.Data_Load.ColumnHeadersHeight = 60;
            this.Data_Load.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Data_Load.RowTemplate.Height = 35; // Tăng chiều cao lên 50 (hoặc giá trị bạn muốn)
        }

        private void Load_Food_Load(object sender, EventArgs e)
        {

        }

        private void Data_Load_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
