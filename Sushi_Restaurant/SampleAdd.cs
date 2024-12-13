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
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        public virtual void btnLuu_Click(object sender, EventArgs e)
        {
            // Thực hiện các hành động khi nhấn nút "LƯU"
            MessageBox.Show("Lưu thành công!");
        }

        // Phương thức xử lý sự kiện khi nhấn nút "ĐÓNG"
        public virtual void btnDong_Click(object sender, EventArgs e)
        {
            // Đóng cửa sổ hiện tại
            this.Close();
        }

        public virtual void label1_Click(object sender, EventArgs e)
        {

        }

        public virtual void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SampleAdd_Load(object sender, EventArgs e)
        {

        }

        public virtual void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
