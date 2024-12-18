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
                            UpdateControlStates();
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
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    // Kiểm tra xem cbtinhtrangxacnhan đã enabled hay chưa
                    if (!cbttxn.Enabled)
                    {
                        // Nếu cbtinhtrangxacnhan enabled, xử lý tình trạng đơn hàng
                        string tinhTrangDonHang = cbttdh.SelectedItem?.ToString(); // Lấy giá trị từ ComboBox tình trạng đơn hàng

                        if (tinhTrangDonHang == "Đã giao")
                        {
                            // Cập nhật thời gian nhận đơn hàng
                            using (SqlCommand cmd = new SqlCommand("usp_CapNhatTinhTrangDonHang", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                // Thêm tham số Mã Phiếu, Tình trạng đơn hàng và Thời gian nhận
                                cmd.Parameters.AddWithValue("@MaPhieu", maPhieu); // Mã phiếu giao hàng
                                cmd.Parameters.AddWithValue("@TinhTrangDonHang", "Đã giao");
                                cmd.Parameters.AddWithValue("@ThoiGianNhan", DateTime.Now.ToString("HH:mm:ss")); // Chỉ lấy giờ, phút, giây
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Cập nhật tình trạng đơn hàng và thời gian nhận thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (tinhTrangDonHang == "Chưa giao")
                        {
                            // Không làm gì thêm nếu chưa giao
                            MessageBox.Show("Đơn hàng đã xác nhận nhưng vẫn trong trạng thái 'Chưa giao'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Nếu cbtinhtrangxacnhan không enabled, xử lý tình trạng xác nhận
                        bool tinhTrangXacNhan = cbttxn.SelectedItem.ToString() == "Đã xác nhận";

                        using (SqlCommand cmd = new SqlCommand("usp_CapNhatTinhTrangXacNhan", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Thêm tham số Mã Phiếu và Tình trạng xác nhận
                            cmd.Parameters.AddWithValue("@MaPhieu", maPhieu); // Mã phiếu giao hàng
                            cmd.Parameters.AddWithValue("@TinhTrangXacNhan", tinhTrangXacNhan ? 1 : 0); // Chuyển đổi Boolean thành 1 (Đã xác nhận) hoặc 0 (Chưa xác nhận)

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật tình trạng xác nhận thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    // Đóng form sau khi lưu
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Hàm cập nhật trạng thái các control dựa trên tình trạng
        private void UpdateControlStates()
        {
            // Lấy giá trị hiện tại của các ComboBox
            string tinhTrangXacNhan = cbttxn.SelectedItem?.ToString();
            string tinhTrangDonHang = cbttdh.SelectedItem?.ToString();

            // Điều kiện cho tình trạng xác nhận
            if (tinhTrangXacNhan == "Chưa xác nhận")
            {
                cbttdh.Enabled = false; // Bật chỉnh sửa tình trạng đơn hàng
                cbttxn.Enabled = true; // Bật chỉnh sửa tình trạng xác nhận
                btnLuu.Enabled = true; // Cho phép lưu
                btnLuu.BackColor = SystemColors.Control; // Màu mặc định
            }
            else if (tinhTrangXacNhan == "Đã xác nhận")
            {
                cbttdh.Enabled = true; // Bật chỉnh sửa tình trạng đơn hàng
                cbttxn.Enabled = false; // Khóa tình trạng xác nhận
                btnLuu.Enabled = true; // Cho phép lưu
                btnLuu.BackColor = SystemColors.Control; // Màu mặc định
            }

            // Điều kiện cho tình trạng đơn hàng
            if (tinhTrangDonHang == "Đã giao")
            {
                cbttdh.Enabled = true; // Bật chỉnh sửa tình trạng đơn hàng
                btnLuu.Enabled = false; // Khóa nút Lưu
                btnLuu.BackColor = Color.Gray; // Tô xám nút Lưu
            }
        }

        // Thêm sự kiện thay đổi cho ComboBox
        private void cbttxn_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControlStates();
        }

        private void cbttdh_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControlStates();
        }
    }
}