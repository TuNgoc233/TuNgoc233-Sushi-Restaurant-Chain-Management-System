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
    public partial class ThemTheKhachHang : SampleAdd
    {

        public string SoDienThoai { get; set; }

        public ThemTheKhachHang()
        {
            InitializeComponent();
            ThemTheKhachHang_Load();
        }

        DateTime date = DateTime.Now;
        public string MaThe = "";
        public override void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ form
            string matKhau = "123456"; // Mặc định là "123456
            string maKhachHang = txtmakh.Text.Trim();
            string tenKhachHang = txthoten.Text.Trim();
            string cccd = txtcccd.Text.Trim();
            string gioiTinh = rdbnam.Checked ? "Nam" : "Nữ"; // RadioButton lựa chọn giới tính
            string soDienThoai = SoDienThoai;
            string email = txtemail.Text.Trim();

            string maSoThe = txtMaThe.Text.Trim();
            string loaiThe = "MEMBERSHIP"; // Hoặc lấy từ radio button
            DateTime ngayLap = guna2DateTimePicker1.Value;
            string maChiNhanh = MainClass.user.MaChiNhanh;
            string maNhanVien = MainClass.user.MaNhanVien;

            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_LuuKhachHangVaTheThanhVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                        cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        cmd.Parameters.AddWithValue("@HoTen", tenKhachHang);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@CCCD", cccd);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        cmd.Parameters.AddWithValue("@Email", email);

                        cmd.Parameters.AddWithValue("@MaSoThe", maSoThe);
                        cmd.Parameters.AddWithValue("@LoaiThe", loaiThe);
                        cmd.Parameters.AddWithValue("@TongDiemTichLuy", 0);
                        cmd.Parameters.AddWithValue("@NgayLap", ngayLap);
                        cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);
                        cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                        // Thực thi Procedure
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string result = reader["Result"].ToString();
                            string message = reader["Message"].ToString();

                            if (result == "Success")
                            {
                                MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        reader.Close();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string LayMaTheTiepTheo()
        {
            string nextId = "";

            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.LayMaTheTiepTheo()", con))
                    {
                        nextId = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã thẻ thành viên: " + ex.Message);
            }
            MaThe = nextId;

            return nextId;
        }

        private string LayMaKhachHangTiepTheo()
        {
            string nextId = "";

            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.LayMaKhachHangTiepTheo()", con))
                    {
                        nextId = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã khách hàng: " + ex.Message);
            }
            MaThe = nextId;

            return nextId;
        }

        private void ThemTheKhachHang_Load()
        {
            txtMaThe.Text = LayMaTheTiepTheo();
            guna2DateTimePicker1.Value = date;
            txtNhanVien.Text = MainClass.user.MaNhanVien;
            txtmakh.Text = LayMaKhachHangTiepTheo(); // Gán giá trị vào textbox
        }


    }
}
