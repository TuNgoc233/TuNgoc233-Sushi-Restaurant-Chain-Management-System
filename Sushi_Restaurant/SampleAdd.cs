using System;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        // Phương thức xử lý sự kiện khi nhấn nút "LƯU"
        public virtual void btnLuu_Click(object sender, EventArgs e)
        {
            // TODO: Thêm logic lưu dữ liệu vào database hoặc file
            MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Phương thức xử lý sự kiện khi nhấn nút "ĐÓNG"
        public virtual void btnDong_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đóng cửa sổ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Sự kiện khi nhấn vào label1 (nếu cần)
        public virtual void label1_Click(object sender, EventArgs e)
        {
            // TODO: Thêm logic xử lý (nếu có)
        }

        // Sự kiện khi nhấn vào PictureBox (nếu cần)
        public virtual void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            // TODO: Thêm logic xử lý (nếu có)
        }

        // Sự kiện khi form được tải
        private void SampleAdd_Load(object sender, EventArgs e)
        {
            // TODO: Thêm logic khởi tạo dữ liệu ban đầu (nếu cần)
            this.label1.Text = "Thêm dữ liệu mới";
        }

        // Sự kiện khi vẽ Panel2
        public virtual void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            // TODO: Thêm logic vẽ hoặc thiết kế giao diện Panel2 (nếu cần)
        }
    }
}
