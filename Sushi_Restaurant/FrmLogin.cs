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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sushi_Restaurant
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            LoadData();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_dk_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSignUp frm = new FrmSignUp();
            frm.Show();
        }

        private void bt_dn_Click(object sender, EventArgs e)
        {


            string maChiNhanh = chinhanhname.SelectedValue.ToString();
            string maNhanVien = text_User.Text;
            string matKhau = text_pass.Text;

            string query = "SELECT * FROM LICH_SU_LAM_VIEC WHERE MaChiNhanh = @MaChiNhanh AND MaNhanVien = @MaNhanVien AND NgayKetThuc IS NULL";

            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);
            cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Kiểm tra các trường thông tin có bị bỏ trống hay không
            if (string.IsNullOrWhiteSpace(text_User.Text) ||
                string.IsNullOrWhiteSpace(text_pass.Text))
            {
                err_noFullInfor_Login.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if (dt.Rows.Count > 0)
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");

                // Lưu mã nhân viên và mã chi nhánh vào lớp user
                MainClass.user.MaNhanVien = maNhanVien;
                MainClass.user.MaChiNhanh = maChiNhanh;

                // Mở form chính
                NhanVien.frmMain formChinh = new NhanVien.frmMain();
                formChinh.Show();
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void LoadData()
        {
            string query = "SELECT MaChiNhanh, TenChiNhanh FROM CHI_NHANH";

            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chinhanhname.DataSource = dt;
            chinhanhname.DisplayMember = "TenChiNhanh";
            chinhanhname.ValueMember = "MaChiNhanh";
        }
    }
}
