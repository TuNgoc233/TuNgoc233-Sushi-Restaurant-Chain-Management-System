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
    public partial class CapNhatTrangThai_1 : SampleView
    {
        public CapNhatTrangThai_1()
        {
            InitializeComponent();
            string machinhanh = MainClass.user.MaChiNhanh;
            string manhanvien = MainClass.user.MaNhanVien;
            LoadDanhSachPhieu(machinhanh, manhanvien);
            guna2DataGridView1.CellContentClick += Guna2DataGridView1_CellContentClick;
            guna2DataGridView1.CellClick += guna2DataGridView1_CellClick;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        // Phương thức để tải danh sách phiếu với tham số chi nhánh và nhân viên xác nhận
        private void LoadDanhSachPhieu(string chiNhanhId, string nhanVienId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_LayDanhSachPhieuGiaoHangTanNoi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ChiNhanhId", string.IsNullOrEmpty(chiNhanhId) ? (object)DBNull.Value : chiNhanhId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Clear existing columns (to avoid duplicate columns when reloading data)
                            guna2DataGridView1.Columns.Clear();

                            // Add columns manually and map them to DataTable columns
                            guna2DataGridView1.Columns.Add("dgvSTT", "STT"); // Header text: "Mã Phiếu"
                            guna2DataGridView1.Columns["dgvSTT"].DataPropertyName = "STT"; // Map to DataTable column "MaPhieu"

                            guna2DataGridView1.Columns.Add("dgvMaPhieu", "Mã Phiếu"); // Header text: "Tên Nhân Viên"
                            guna2DataGridView1.Columns["dgvMaPhieu"].DataPropertyName = "MaPhieu"; // Map to DataTable column "TenNhanVien"

                            guna2DataGridView1.Columns.Add("dgvMaKH", "Mã Khách Hàng"); // Header text: "Tổng Tiền"
                            guna2DataGridView1.Columns["dgvMaKH"].DataPropertyName = "MaKhachHang"; // Map to DataTable column "TongTien"

                            guna2DataGridView1.Columns.Add("dgvNgayDat", "Ngày Đặt"); // Header text: "Tổng Tiền"
                            guna2DataGridView1.Columns["dgvNgayDat"].DataPropertyName = "Ngay"; // Map to DataTable column "TongTien"

                            guna2DataGridView1.Columns.Add("dgvTinhTrangxn", "Tình Trạng Xác Nhận"); // Header text: "Tổng Tiền"
                            guna2DataGridView1.Columns["dgvTinhTrangxn"].DataPropertyName = "TinhTrangXacNhan"; // Map to DataTable column "TongTien"

                            guna2DataGridView1.Columns.Add("dgvTinhTrangdh", "Tình Trạng Đơn Hàng"); // Header text: "Tổng Tiền"
                            guna2DataGridView1.Columns["dgvTinhTrangdh"].DataPropertyName = "TinhTrangDonHang"; // Map to DataTable column "TongTien"

                            // Add delete icon column
                            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn
                            {
                                HeaderText = "",                 // Header text for the column
                                Name = "dgvDel",                   // Unique name for the column
                                Image = Properties.Resources.del, // Set your delete icon here
                                ImageLayout = DataGridViewImageCellLayout.Zoom, // Resize the icon to fit the cell
                                Width = 50                          // Optional: Set fixed width
                            };

                            // Add the delete column to DataGridView
                            guna2DataGridView1.Columns.Add(deleteColumn);

                            // Set the DataSource
                            guna2DataGridView1.DataSource = dt;

                            // Add CellFormatting event to customize display
                            guna2DataGridView1.CellFormatting += Guna2DataGridView1_CellFormatting;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách phiếu: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Event to format the "Tình Trạng" column
        private void Guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (guna2DataGridView1.Columns[e.ColumnIndex].DataPropertyName == "TinhTrangXacNhan")
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool isConfirmed = (bool)e.Value;
                    e.Value = isConfirmed ? "Đã xác nhận" : "Chưa xác nhận";
                    e.FormattingApplied = true;
                }
            }
        }
        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được nhấp là cột DeleteColumn
            if (e.ColumnIndex == guna2DataGridView1.Columns["dgvDel"].Index && e.RowIndex >= 0)
            {
                // Lấy thông tin dòng cần xóa (ví dụ: Mã Phiếu)
                string maPhieu = guna2DataGridView1.Rows[e.RowIndex].Cells["dgvMaPhieu"].Value.ToString();

                // Hiển thị xác nhận xóa
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu {maPhieu}?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Xóa trong cơ sở dữ liệu
                    XoaPhieuTuDB(maPhieu);

                    // Cập nhật lại DataGridView
                    guna2DataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        // Hàm xóa phiếu trong cơ sở dữ liệu
        private void XoaPhieuTuDB(string maPhieu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_XoaPhieu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa phiếu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn vào một dòng hợp lệ
            if (e.RowIndex >= 0)
            {
                string maPhieu = guna2DataGridView1.Rows[e.RowIndex].Cells["dgvMaPhieu"].Value.ToString();
                // Mở form PhieuDatBan nếu Loại là DB
                // Truyền mã phiếu vào form PhieuDatBan
                // Mở form PhieuDatBan và truyền mã phiếu
                PhieuGiaoHangTanNoi formGH = new PhieuGiaoHangTanNoi(maPhieu);
                formGH.StartPosition = FormStartPosition.CenterScreen;
                MainClass.BlurBackground(formGH); // Làm mờ nền
            }
        }

    }
}

