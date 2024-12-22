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
    public partial class addOrderForm : SampleAdd
    {
        public addOrderForm()
        {
            InitializeComponent();
        }

        public override void btnLuu_Click(object sender, EventArgs e)
        {
            // Thực hiện các hành động khi nhấn nút "LƯU"
            MessageBox.Show("Lưu thành công!");
        }

        // Phương thức xử lý sự kiện khi nhấn nút "ĐÓNG"
        public override void btnDong_Click(object sender, EventArgs e)
        {
            // Đóng cửa sổ hiện tại
            this.Close();
        }

        public override void label1_Click(object sender, EventArgs e)
        {

        }

        //public override void guna2PictureBox1_Click(object sender, EventArgs e)
        //{

        //}

        private void addStaff_Load(object sender, EventArgs e)
        {

        }

        private void addOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
