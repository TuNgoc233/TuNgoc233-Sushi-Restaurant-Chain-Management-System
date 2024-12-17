using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            // Gắn sự kiện Click vào chính `ucProduct`
            this.Click += OnClickHandler;

            // Gắn sự kiện Click cho tất cả các thành phần con trong `ucProduct`
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += OnClickHandler;
            }
        }

        public event EventHandler onSelect = null;

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


        // Thuộc tính kiểm tra tình trạng phục vụ
        public bool isAvailable = true;
        public bool IsAvailable
        {
            get { return isAvailable; }
            set
            {
                isAvailable = value;
                UpdateAvailability(); // Cập nhật giao diện dựa trên trạng thái
            }
        }

        // Hàm cập nhật trạng thái giao diện
        private void UpdateAvailability()
        {
            if (!isAvailable)
            {
                // Nếu không phục vụ, tô mờ và vô hiệu hóa
                this.BackColor = Color.Gray; // Nền mờ
                this.Enabled = false;        // Vô hiệu hóa
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.LightGray; // Tô chữ mờ
                }
            }
            else
            {
                // Nếu phục vụ, khôi phục giao diện
                this.BackColor = Color.White; // Nền trắng
                this.Enabled = true;          // Bật chức năng
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.Black; // Tô chữ đen
                }
            }
        }

        // Hàm xử lý khi `ucProduct` được nhấn
        protected void OnClickHandler(object sender, EventArgs e)
        {
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
    }
}
