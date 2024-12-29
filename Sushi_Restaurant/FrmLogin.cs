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
            string maChiNhanh = chinhanhname.SelectedValue?.ToString();
            string maNhanVien = text_User.Text;
            string matKhau = text_pass.Text;

            if (string.IsNullOrWhiteSpace(maChiNhanh) ||
                string.IsNullOrWhiteSpace(maNhanVien) ||
                string.IsNullOrWhiteSpace(matKhau))
            {
                // Kiểm tra các trường thông tin có bị bỏ trống hay không
                err_noFullInfor_Login.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            string query = @"
            SELECT NV.MatKhau, NV.HoTen , CN.TenChiNhanh
            FROM Nhan_Vien NV
            INNER JOIN LICH_SU_LAM_VIEC LS
            INNER JOIN CHI_NHANH CN ON CN.MaChiNhanh = LS.MaChiNhanh
            ON NV.MaNhanVien = LS.MaNhanVien
            WHERE LS.MaChiNhanh = @MaChiNhanh 
            AND LS.MaNhanVien = @MaNhanVien 
            AND LS.NgayKetThuc IS NULL";

            try
            {
                // Đảm bảo kết nối đã mở
                if (MainClass.con.State == ConnectionState.Closed)
                {
                    MainClass.con.Open();
                }

                using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
                {
                    cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {
                            string storedPassword = reader["MatKhau"].ToString();
                            MainClass.user.TenNhanVien = reader["HoTen"].ToString();
                            MainClass.user.TenChiNhanh = reader["TenChiNhanh"].ToString();

                            if (storedPassword == matKhau)
                            {
                                // Đăng nhập thành công
                                MainClass.user.MaNhanVien = maNhanVien;
                                MainClass.user.MaChiNhanh = maChiNhanh;

                                NhanVien.frmMain formChinh = new NhanVien.frmMain();
                                formChinh.Show();
                                formChinh.ActivateHomeButton();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Sai mật khẩu!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thông tin đăng nhập không hợp lệ!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
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
