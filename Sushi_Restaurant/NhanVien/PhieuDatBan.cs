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
    public partial class PhieuDatBan : Form
    {
        // Khai báo sự kiện
        public event EventHandler TrangThaiCapNhat;
        public string maPhieu; // Biến lưu mã phiếu
        public PhieuDatBan(string maPhieu)
        {
            InitializeComponent();
            this.maPhieu = maPhieu; // Gán giá trị mã phiếu
            LoadThongTin();
            LoadThongTinPhieu();
        }

        private void LoadThongTinPhieu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_LayThongTinPhieuDatBan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Hiển thị dữ liệu lên các control
                            txtMaKH.Text = reader["MaKhachHang"].ToString();
                            txtsdt.Text = reader["SoDienThoai"].ToString();
                            txtdate.Text = Convert.ToDateTime(reader["NgayDat"]).ToString("dd/MM/yyyy");
                            txttime.Text = reader["GioDen"].ToString();
                            txtSL.Text = reader["SoLuongKhach"].ToString();
                            txtGhiChu.Text = reader["GhiChu"].ToString();

                            // Xử lý tình trạng phiếu
                            cbtt.Items.Clear();
                            cbtt.Items.AddRange(new string[] { "Chưa xác nhận", "Đã xác nhận" });
                            bool tinhTrang = reader["TinhTrangXacNhan"] != DBNull.Value && (bool)reader["TinhTrangXacNhan"];
                            cbtt.SelectedItem = tinhTrang ? "Đã xác nhận" : "Chưa xác nhận";
                            // Nếu phiếu đã được xác nhận, vô hiệu hóa ComboBox và nút Lưu
                            if (tinhTrang)
                            {
                                cbtt.Enabled = false; // Vô hiệu hóa ComboBox
                                btnLuu.Enabled = false; // Vô hiệu hóa nút Lưu
                                btnLuu.BackColor = Color.Gray; // Tô xám nút Lưu
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin phiếu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm load thông tin nhân viên
        private void LoadThongTin()
        {
            txtMaPhieu.Text = maPhieu; // Hiển thị mã phiếu
            txtMaNV.Text = MainClass.user.MaNhanVien; // Hiển thị mã nhân viên
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_LayThongTinNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNhanVien", MainClass.user.MaNhanVien);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txttennv.Text = reader["HoTen"].ToString(); // Load họ tên nhân viên
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ combobox: "Đã Xác Nhận" => true, "Chưa Xác Nhận" => false
                bool tinhTrang = cbtt.SelectedItem.ToString() == "Đã xác nhận";

                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_CapNhatTinhTrangPhieu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu); // Mã phiếu hiện tại
                        cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang); // true hoặc false
                        cmd.Parameters.AddWithValue("@MaNhanVien", MainClass.user.MaNhanVien); // true hoặc false
                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật tình trạng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Gọi sự kiện TrangThaiCapNhat nếu có người đăng ký
                        TrangThaiCapNhat?.Invoke(this, EventArgs.Empty);
                        this.Close(); // Đóng form
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật tình trạng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
