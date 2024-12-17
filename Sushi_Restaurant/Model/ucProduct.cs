using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.NhanVien
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent(); // Khởi tạo giao diện

            txtImage.Click += txtImage_Click; // Sự kiện cho hình ảnh

            but_themDSMAYT.Click += but_themDSMAYT_Click; // Sự kiện cho nút thêm vào yêu thích
        }

        public event EventHandler onSelect = null;
        public event EventHandler onAddFavorite = null;

        public string id { get; set; }
        public string PPrice {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value;} 
        }
        public string PCategory { get; set; }
        public string PName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public Image PImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }


        // Hàm xử lý khi `ucProduct` được nhấn
        protected void OnClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show($"onSelect triggered by: {sender.GetType().Name}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            onSelect?.Invoke(this, e); // Kích hoạt sự kiện `onSelect`
        }

        // Gắn sự kiện Click riêng cho hình ảnh
        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e); // Kích hoạt sự kiện `onSelect`
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void but_themDSMAYT_Click(object sender, EventArgs e)
        {
            onAddFavorite?.Invoke(this, EventArgs.Empty);
        }
    }
}
