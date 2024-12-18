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
            // Vô hiệu hóa Theme mặc định để toàn quyền điều chỉnh
            // Thiết lập font chữ cho Header
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.guna2DataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 16);

            // Thiết lập màu nền và màu chữ cho Header
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 55, 89);
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false; // Bắt buộc phải tắt thuộc tính này để màu tùy chỉnh có hiệu lực

            // Tăng chiều cao Header
            this.guna2DataGridView1.ColumnHeadersHeight = 60;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.RowTemplate.Height = 35; // Tăng chiều cao lên 50 (hoặc giá trị bạn muốn)
            string machinhanh = MainClass.user.MaChiNhanh;
            string manhanvien = MainClass.user.MaNhanVien;
            LoadDanhSachPhieu(machinhanh, manhanvien);
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            guna2DataGridView1.CellClick += guna2DataGridView1_CellClick;
            LoadTinhTrangComboBox();
            this.cbtinhtrang.SelectedIndexChanged += new System.EventHandler(this.cbtinhtrang_SelectedIndexChanged);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
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
                            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                            // Add columns manually and map them to DataTable columns
                            guna2DataGridView1.Columns.Add("dgvSTT", "STT"); // Header text: "Mã Phiếu"
                            guna2DataGridView1.Columns["dgvSTT"].Width = 80;
                            guna2DataGridView1.Columns["dgvSTT"].DataPropertyName = "STT"; // Map to DataTable column "MaPhieu"

                            guna2DataGridView1.Columns.Add("dgvMaPhieu", "Mã Phiếu"); // Header text: "Tên Nhân Viên"
                            guna2DataGridView1.Columns["dgvMaPhieu"].Width = 200;
                            guna2DataGridView1.Columns["dgvMaPhieu"].DataPropertyName = "MaPhieu"; // Map to DataTable column "TenNhanVien"

                            guna2DataGridView1.Columns.Add("dgvMaKH", "Mã Khách Hàng"); // Header text: "Tổng Tiền"
                            guna2DataGridView1.Columns["dgvMaKH"].Width = 200;
                            guna2DataGridView1.Columns["dgvMaKH"].DataPropertyName = "MaKhachHang"; // Map to DataTable column "TongTien"

                            guna2DataGridView1.Columns.Add("dgvNgayDat", "Ngày Đặt"); // Header text: "Tổng Tiền"
                            guna2DataGridView1.Columns["dgvNgayDat"].Width = 200;
                            guna2DataGridView1.Columns["dgvNgayDat"].DataPropertyName = "Ngay"; // Map to DataTable column "TongTien"

                            guna2DataGridView1.Columns.Add("dgvTinhTrangxn", "Tình Trạng Xác Nhận"); // Header text: "Tổng Tiền"

                            guna2DataGridView1.Columns["dgvTinhTrangxn"].Width = 255;
                            guna2DataGridView1.Columns["dgvTinhTrangxn"].DataPropertyName = "TinhTrangXacNhan"; // Map to DataTable column "TongTien"


                            guna2DataGridView1.Columns.Add("dgvTinhTrangdh", "Tình Trạng Đơn Hàng"); // Header text: "Tổng Tiền"
                            guna2DataGridView1.Columns["dgvTinhTrangdh"].Width = 250;
                            guna2DataGridView1.Columns["dgvTinhTrangdh"].DataPropertyName = "TinhTrangDonHang"; // Map to DataTable column "TongTien"

                            // Add delete icon column
                            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn
                            {
                                HeaderText = "",                 // Header text for the column
                                Name = "dgvDel",                   // Unique name for the column
                                Image = Properties.Resources.del, // Set your delete icon here
                                ImageLayout = DataGridViewImageCellLayout.Zoom, // Resize the icon to fit the cell
                                Width = 50               // Optional: Set fixed width
                            };

                            // Add the delete column to DataGridView
                            guna2DataGridView1.Columns.Add(deleteColumn);

                            // Set the DataSource
                            guna2DataGridView1.DataSource = dt;
                            guna2DataGridView1.CellFormatting += Guna2DataGridView1_CellFormatting;

                            // Apply a filter to exclude rows where TìnhTrạngXacNhan = 1 (Đã xác nhận) and TìnhTrạngDonHang = 'Chưa giao'
                            string filterExpression = "NOT (TinhTrangXacNhan = 1 AND TinhTrangDonHang = 'Chưa giao')";
                            dt.DefaultView.RowFilter = filterExpression;
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
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    try
                    {
                        // Xóa trong cơ sở dữ liệu
                        XoaPhieuTuDB(maPhieu);

                        // Cập nhật lại DataGridView (xóa dòng)
                        guna2DataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa phiếu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Ngăn không mở form khi nhấn vào delete icon
                return;
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
                    using (SqlCommand cmd = new SqlCommand("sp_XoaPhieuDatMon", conn))
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
            // Kiểm tra nếu cột được nhấp không phải là cột Delete
            if (e.ColumnIndex != guna2DataGridView1.Columns["dgvDel"].Index && e.RowIndex >= 0)
            {
                // Lấy mã phiếu từ cột dgvMaPhieu
                string maPhieu = guna2DataGridView1.Rows[e.RowIndex].Cells["dgvMaPhieu"].Value.ToString();
                // Mở form PhieuDatBan nếu Loại là DB
                // Truyền mã phiếu vào form PhieuDatBan
                // Mở form PhieuDatBan và truyền mã phiếu
                PhieuGiaoHangTanNoi formGH = new PhieuGiaoHangTanNoi(maPhieu);
                formGH.StartPosition = FormStartPosition.CenterScreen;
                MainClass.BlurBackground(formGH); // Làm mờ nền
            }
        }

        private DataTable originalDataTable; // Lưu trữ DataTable gốc

        private void LoadTinhTrangComboBox()
        {
            // Tạo DataTable chứa dữ liệu cho ComboBox
            DataTable dt = new DataTable();
            dt.Columns.Add("Text", typeof(string));  // Cột hiển thị
            dt.Columns.Add("Value", typeof(int));    // Cột giá trị

            // Thêm các mục vào DataTable
            dt.Rows.Add("Tất cả", -1);               // Tất cả
            dt.Rows.Add("Chưa xác nhận", 0);         // Chưa xác nhận
            dt.Rows.Add("Đang giao", 1);              // Đang giao
            dt.Rows.Add("Đã giao", 2);                // Đã giao

            // Gán DataTable làm nguồn dữ liệu cho ComboBox
            cbtinhtrang.DataSource = dt;
            cbtinhtrang.DisplayMember = "Text";  // Hiển thị tên mục
            cbtinhtrang.ValueMember = "Value";   // Giá trị tương ứng
        }

        private void cbtinhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem dữ liệu trong DataGridView có tồn tại không
            if (guna2DataGridView1.DataSource is DataTable dt)
            {
                // Lấy giá trị được chọn từ ComboBox
                int selectedValue = Convert.ToInt32(cbtinhtrang.SelectedValue);

                // Tạo bộ lọc cho DataTable
                string filterExpression = "";

                if (selectedValue == 0) // Chưa xác nhận
                {
                    filterExpression = "TinhTrangXacNhan = 0";
                }
                else if (selectedValue == 1) // Đang giao
                {
                    filterExpression = "TinhTrangDonHang = 'Đang giao'";
                }
                else if (selectedValue == 2) // Đã giao
                {
                    filterExpression = "TinhTrangDonHang = 'Đã giao'";
                }
                else if (selectedValue == -1) // Tất cả
                {
                    filterExpression = ""; // Không lọc
                }

                // Điều kiện để không hiển thị những dòng "Đã xác nhận" nhưng "Chưa giao"
                if (string.IsNullOrEmpty(filterExpression))
                {
                    // Bộ lọc mặc định sẽ không hiển thị các dòng "Đã xác nhận" nhưng "Chưa giao"
                    filterExpression = "NOT (TinhTrangXacNhan = 1 AND TinhTrangDonHang = 'Chưa giao')";
                }
                else
                {
                    // Thêm điều kiện vào bộ lọc
                    filterExpression += " AND NOT (TinhTrangXacNhan = 1 AND TinhTrangDonHang = 'Chưa giao')";
                }

                // Áp dụng bộ lọc
                dt.DefaultView.RowFilter = filterExpression;
            }
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.DataSource is DataTable dt) // Kiểm tra nguồn dữ liệu
            {
                // Lấy nội dung tìm kiếm từ TextBox
                string searchValue = txtTimKiem.Text.Trim().ToLower();

                // Tạo biểu thức lọc (Filter Expression)
                string filterExpression = string.Format("MaPhieu LIKE '%{0}%' OR MaKhachHang LIKE '%{0}%'", searchValue);

                // Áp dụng bộ lọc
                dt.DefaultView.RowFilter = filterExpression;
            }
        }

    }
}

