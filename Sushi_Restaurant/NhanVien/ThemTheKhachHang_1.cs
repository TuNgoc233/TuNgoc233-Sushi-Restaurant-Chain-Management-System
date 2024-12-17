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
    public partial class ThemTheKhachHang_1:Form
    {

        // Public properties to store the values
        public string MaKhachHang { get; set; }
        public string SoDienThoai { get; set; }

        public ThemTheKhachHang_1()
        {
            InitializeComponent();
            this.Load += ThemTheKhachHang_1_Load; // Liên kết sự kiện `Load`
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DateTime date = DateTime.Now;
        public string MaThe = "";
        public void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ form
            string maSoThe = txtMaThe.Text.Trim();
            string loaiThe = "MEMBERSHIP"; // Hoặc lấy từ radio button, ví dụ: "VIP"
            DateTime ngayLap = guna2DateTimePicker1.Value;
            string maKhachHang = txtmakh.Text.Trim(); // Mã khách hàng
            string maChiNhanh = MainClass.user.MaChiNhanh; // Có thể lấy từ combobox nếu có
            string maNhanVien = txtNhanVien.Text.Trim();
            int tongDiemTichLuy = 0; // Mặc định là 0 khi tạo thẻ mới

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(maKhachHang))
            {
                MessageBox.Show("Mã khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(maSoThe))
            {
                MessageBox.Show("Mã số thẻ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kết nối tới CSDL và gọi stored procedure
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("usp_ThemTheThanhVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền tham số
                        cmd.Parameters.AddWithValue("@MaSoThe", maSoThe);
                        cmd.Parameters.AddWithValue("@LoaiThe", loaiThe);
                        cmd.Parameters.AddWithValue("@TongDiemTichLuy", tongDiemTichLuy);
                        cmd.Parameters.AddWithValue("@NgayLap", ngayLap);
                        cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);
                        cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                        // Xử lý kết quả
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

        private void ThemTheKhachHang_1_Load(object sender, EventArgs e)
        {
            txtMaThe.Text = LayMaTheTiepTheo();
            guna2DateTimePicker1.Value = date;
            txtNhanVien.Text = MainClass.user.MaNhanVien;
            txtmakh.Text = MaKhachHang; // Gán giá trị vào textbox
        }
    }
}

