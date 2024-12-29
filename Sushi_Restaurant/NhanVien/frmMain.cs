using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.NhanVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        static frmMain _obj;
        public static frmMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmMain();
                }
                return _obj;
            }
        }
        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = MainClass.user.TenNhanVien;
            lblChiNhanh.Text = MainClass.user.TenChiNhanh;
            _obj = this;
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        public void ActivateHomeButton()
        {
            // Gọi trực tiếp sự kiện Click của nút btnHome
            btnHome.PerformClick();
        }

        private void btnTheTV_Click(object sender, EventArgs e)
        {
            TheKhachHang frm = new TheKhachHang
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            MainClass.BlurBackground(frm); // Làm mờ nền
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            frmPOS frm= new frmPOS();
            frm.Show();
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            AddControls(new CapNhatTrangThai());
        }

        private void btnGiaoHang_Click(object sender, EventArgs e)
        {
            AddControls(new CapNhatTrangThai_1());
        }

        private void btnttmonan_Click(object sender, EventArgs e)
        {
            AddControls(new TrangThaiMonAn());
        }

        private void btnDSDanhGia_Click(object sender, EventArgs e)
        {
            AddControls(new XemDanhGia());
        }
        private void but_logOut_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra người dùng chọn "Yes" (Đồng ý đăng xuất)
            if (result == DialogResult.Yes)
            {
                // Tạo form đăng nhập mới
                FrmLogin loginForm = new FrmLogin();

                // Ẩn form hiện tại
                this.Close();

                // Hiển thị form đăng nhập dưới dạng modal (ngăn các form khác hoạt động)
                loginForm.ShowDialog();
            }
        }

    }
}
