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
    public partial class PhieuGiaoHangTanNoi : SampleAdd
    {
        public string maPhieu; // Biến lưu mã phiếu
        public PhieuGiaoHangTanNoi(string maPhieu)
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
                    using (SqlCommand cmd = new SqlCommand("usp_LayThongTinPhieuGiaoHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Hiển thị các thông tin lấy từ stored procedure
                            txtdate.Text = reader["NgayDat"].ToString();
                            // Hình thức thanh toán: 1 -> Chuyển khoản, 0 -> Trực tiếp
                            if (reader["HinhThucThanhToan"] != DBNull.Value)
                            {
                                bool isChuyenKhoan = (bool)reader["HinhThucThanhToan"];
                                txtthanhtoan.Text = isChuyenKhoan ? "Chuyển khoản" : "Trực tiếp";
                            }
                            txtDiaChi.Text = reader["DiaChiGiaoHang"].ToString();
                            txtmakh.Text = reader["MaKhachHang"].ToString();
                            txtsdt.Text = reader["SoDienThoai"].ToString(); // Hiển thị số điện thoại

                            // Tình trạng xác nhận
                            cbttxn.Items.Clear();
                            cbttxn.Items.AddRange(new string[] { "Chưa xác nhận", "Đã xác nhận" });
                            bool tinhTrangXacNhan = reader["TinhTrangXacNhan"] != DBNull.Value && (bool)reader["TinhTrangXacNhan"];
                            cbttxn.SelectedItem = tinhTrangXacNhan ? "Đã xác nhận" : "Chưa xác nhận";

                            // Tình trạng đơn hàng
                            // Cấu hình các tùy chọn cho ComboBox trước khi gán dữ liệu
                            cbttdh.Items.Clear();
                            cbttdh.Items.AddRange(new string[] { "Chưa giao", "Đang giao", "Đã giao" });

                            // Load dữ liệu tình trạng đơn hàng từ cơ sở dữ liệu
                            if (reader["TinhTrangDonHang"] != DBNull.Value)
                            {
                                string tinhTrangDonHang = reader["TinhTrangDonHang"].ToString().Trim(); // Loại bỏ khoảng trắng thừa

                                // Đảm bảo chỉ chọn giá trị hợp lệ trong ComboBox
                                if (cbttdh.Items.Contains(tinhTrangDonHang))
                                {
                                    cbttdh.SelectedItem = tinhTrangDonHang;
                                }
                                else
                                {
                                    cbttdh.SelectedItem = "Chưa giao"; // Giá trị mặc định nếu không khớp
                                }
                            }
                            else
                            {
                                cbttdh.SelectedItem = "Chưa giao"; // Mặc định là "Chưa giao" nếu dữ liệu null
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin phiếu giao hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        public override void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ ComboBox
                bool tinhTrangXacNhan = cbttxn.SelectedItem.ToString() == "Đã xác nhận"; // Giả sử có ComboBox chứa các giá trị: "Đã xác nhận" và "Chưa xác nhận"

                // Gọi thủ tục để cập nhật tình trạng xác nhận trong cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_CapNhatTinhTrangXacNhan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số Mã Phiếu và Tình trạng xác nhận
                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);  // Mã phiếu giao hàng
                        cmd.Parameters.AddWithValue("@TinhTrangXacNhan", tinhTrangXacNhan ? 1 : 0); // Chuyển đổi Boolean thành 1 (Đã xác nhận) hoặc 0 (Chưa xác nhận)

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật tình trạng xác nhận thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu tình trạng xác nhận: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}