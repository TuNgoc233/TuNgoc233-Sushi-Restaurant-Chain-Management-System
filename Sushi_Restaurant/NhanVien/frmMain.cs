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
            //lbl.UserName.Text = MainClass.USER
            _obj=this;
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

        private void but_logOut_Click(object sender, EventArgs e)
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
