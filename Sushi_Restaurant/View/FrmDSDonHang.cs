using Guna.UI2.WinForms;
using Sushi_Restaurant.View;
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

namespace Sushi_Restaurant.Model
{
    public partial class FrmDSDonHang : Form
    {
        private DataTable allOrders = new DataTable();
        private DataTable datBanOrders = new DataTable();
        private DataTable giaoHangOrders = new DataTable();
        private string maHoaDon;
        public FrmDSDonHang()
        {
            InitializeComponent();
            cmb_soDong.SelectedItem = "Tất cả";
            dataGridViewDSDonHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default; // Tắt theme
            dataGridViewDSDonHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 55, 89);
            dataGridViewDSDonHang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold); // Chỉnh font
            dataGridViewDSDonHang.AutoGenerateColumns = false;

        }

        private void FrmDSDonHang_Load_1(object sender, EventArgs e)
        {
            try
            {
                // Gọi procedure để lấy dữ liệu từ DB
                LoadDataFromDatabase();

                // Gán dữ liệu mặc định cho DataGridView
                rbtnAll.Checked = true;
                dataGridViewDSDonHang.DataSource = allOrders;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataFromDatabase()
        {
            // Xóa dữ liệu cũ nếu có
            allOrders.Clear();
            giaoHangOrders.Clear();
            datBanOrders.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    // Gọi procedure
                    using (SqlCommand cmd = new SqlCommand("NXHanh_LayDSDonHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaKhachHang", GlobalVariables.MaKH);

                        // Đổ dữ liệu vào DataTable
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(allOrders); // Nạp toàn bộ dữ liệu vào allOrders
                        }
                    }
                }

                // Thêm cột STT vào đầu nếu chưa có
                if (!allOrders.Columns.Contains("STT"))
                {
                    DataColumn sttColumn = new DataColumn("STT", typeof(int));
                    allOrders.Columns.Add(sttColumn);
                    sttColumn.SetOrdinal(0); // Đặt cột "STT" ở vị trí đầu tiên
                }

                if (!allOrders.Columns.Contains("Đánh giá"))
                {
                    DataColumn danhGiaColumn = new DataColumn("Đánh giá", typeof(object));
                    allOrders.Columns.Add(danhGiaColumn);
                }

                // Gán số thứ tự và chuyển đổi giá trị cột "Loại Đơn Hàng"
                for (int i = 0; i < allOrders.Rows.Count; i++)
                {
                    allOrders.Rows[i]["STT"] = i + 1; // Gán STT bắt đầu từ 1

                    // Chuyển đổi giá trị cột "Loại Đơn Hàng"
                    if (allOrders.Rows[i]["Loại Đơn Hàng"].ToString() == "GH")
                        allOrders.Rows[i]["Loại Đơn Hàng"] = "Giao hàng tận nơi";
                    else if (allOrders.Rows[i]["Loại Đơn Hàng"].ToString() == "DB")
                        allOrders.Rows[i]["Loại Đơn Hàng"] = "Đặt bàn";

                    // Kiểm tra trạng thái và đánh giá
                    string maDonHang = allOrders.Rows[i]["Mã đơn hàng"].ToString();
                    string trangThai = allOrders.Rows[i]["Trạng thái"].ToString();

                    this.maHoaDon = LayMaHoaDonTuMaPhieu(maDonHang);

                    if (trangThai == "Đã giao" && !KiemTraDaDanhGia(maHoaDon))
                    {
                        allOrders.Rows[i]["Đánh giá"] = Properties.Resources.icon_danhGia; // Thêm hình ảnh Like
                    }
                    else
                    {
                        allOrders.Rows[i]["Đánh giá"] = new Bitmap(1, 1);
                    }

                }
                // Phân loại dữ liệu
                var datBanRows = allOrders.Select("[Loại Đơn Hàng] = 'Đặt bàn'");
                if (datBanRows.Length > 0)
                    datBanOrders = datBanRows.CopyToDataTable();

                var giaoHangRows = allOrders.Select("[Loại Đơn Hàng] = 'Giao hàng tận nơi'");
                if (giaoHangRows.Length > 0)
                    giaoHangOrders = giaoHangRows.CopyToDataTable();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gọi dữ liệu từ Database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ham danh so thu tu lai cho ca dong
        private void ReindexRows()
        {
            for (int i = 0; i < dataGridViewDSDonHang.Rows.Count; i++)
            {
                dataGridViewDSDonHang.Rows[i].Cells["STT"].Value = i + 1;
            }
        }

        private void rbtnAll_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnAll.Checked)
            {
                dataGridViewDSDonHang.DataSource = allOrders; // Hien thi tat ca don hang
            }
        }
        private void rbtnGiaoHang_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnGiaoHang.Checked)
            {
                dataGridViewDSDonHang.DataSource = giaoHangOrders; // Hien thi giao hang tan noi
                ReindexRows(); // Đánh số thứ tự lại
            }
        }

        private void rbtnDatBan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnDatBan.Checked)
            {
                dataGridViewDSDonHang.DataSource = datBanOrders; // Hien thi dat ban
                ReindexRows(); // Đánh số thứ tự lại
            }
        }

        private void cmb_soDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmb_soDong.SelectedItem.ToString();
            DataTable tempListOder = new DataTable();

            // kiem tra xem dang chon loai don hang nao
            if (rbtnAll.Checked)
            {
                tempListOder = allOrders;
            }
            if (rbtnGiaoHang.Checked)
            {
                tempListOder = giaoHangOrders;
            }
            if (rbtnDatBan.Checked)
            {
                tempListOder = datBanOrders;
            }

            // Hien thi dong theo ý muốn của người dùng
            if (selectedValue == "Tất cả")
            {
                // Hiển thị tất cả các dòng
                dataGridViewDSDonHang.DataSource = allOrders;
            }
            else
            {
                // Hiển thị số dòng được chọn
                int rowsToShow = int.Parse(selectedValue);

                // Lọc dữ liệu và tạo bảng tạm để hiển thị
                DataTable tempTable = tempListOder.AsEnumerable()
                                                  .Take(rowsToShow)
                                                  .CopyToDataTable();

                dataGridViewDSDonHang.DataSource = tempTable;
            }
        }

        private string LayMaHoaDonTuMaPhieu(string maPhieu)
        {
            string maHoaDon = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    string query = "SELECT MaHoaDon FROM HOA_DON WHERE MaPhieuDatMon = @MaPhieuDatMon";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieuDatMon", maPhieu);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            maHoaDon = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy mã hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return maHoaDon;
        }

        private void dataGridViewDSDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào cột hình ảnh không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridViewDSDonHang.Columns[e.ColumnIndex].Name;

                // Nếu nhấn vào cột "ChiTiet"
                if (columnName == "xemLai")
                {
                    // Lấy mã đơn hàng từ dòng được chọn
                    string maDonHang = dataGridViewDSDonHang.Rows[e.RowIndex].Cells["maDH"].Value.ToString();

                    // Lấy loại Đơn Hàng từ dòng được chọn
                    string loaiDonHang = dataGridViewDSDonHang.Rows[e.RowIndex].Cells["loaiDH"].Value.ToString();

                    // Lấy trạng thái đơn hàng từ dòng được chọn
                    string trangThai = dataGridViewDSDonHang.Rows[e.RowIndex].Cells["trangThai"].Value.ToString();


                    if (loaiDonHang == "Giao hàng tận nơi")
                    {
                        xemLaiGiaoHangView frm = new xemLaiGiaoHangView(maDonHang, trangThai);
                        frm.Show();
                    }
                    else
                    {
                        xemLaiDatBanView frm = new xemLaiDatBanView(maDonHang, trangThai);
                        frm.Show();
                    }

                }

                if (columnName == "danhGia")
                {
                    string maDonHang = dataGridViewDSDonHang.Rows[e.RowIndex].Cells["maDH"].Value.ToString();

                    // Lấy mã hóa đơn từ mã phiếu
                    string maHoaDon = LayMaHoaDonTuMaPhieu(maDonHang);

                    if (string.IsNullOrEmpty(maHoaDon))
                    {
                        MessageBox.Show("Không tìm thấy mã hóa đơn cho mã phiếu này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Hiển thị form đánh giá
                    using (ThemDanhGia formDanhGia = new ThemDanhGia(maHoaDon))
                    {
                        if (formDanhGia.ShowDialog() == DialogResult.OK)
                        {
                            // Nếu đánh giá thành công => Xóa hình ảnh "Like"
                            dataGridViewDSDonHang.Rows[e.RowIndex].Cells["danhGia"].Value = new Bitmap(1, 1); ;
                        }
                    }
                }


            }


        }

        private bool KiemTraDaDanhGia(string maDonHang)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM DANH_GIA_DICH_VU WHERE MaHoaDon = @MaHoaDon";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDon", maDonHang);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0; // Trả về true nếu đã tồn tại đánh giá
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra đánh giá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void dataGridViewDSDonHang_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Lấy thông tin lỗi
            string columnName = dataGridViewDSDonHang.Columns[e.ColumnIndex].Name;
            int rowIndex = e.RowIndex + 1; // Dòng bị lỗi (bắt đầu từ 1)

            // Hiển thị thông báo lỗi chi tiết
            MessageBox.Show($"Lỗi tại dòng {rowIndex}, cột '{columnName}'.\nChi tiết lỗi: {e.Exception.Message}",
                            "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Đánh dấu lỗi đã xử lý, không cần hiển thị dialog mặc định
            e.ThrowException = false;
        }
    }
}
