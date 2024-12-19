using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Sushi_Restaurant.NhanVien
{
    public partial class TrangThaiMonAn : SampleView
    {
        public TrangThaiMonAn()
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
            string maChiNhanh = MainClass.user.MaChiNhanh;
            LoadData(maChiNhanh);
            //this.Load += new EventHandler(viewAdd_Load); // Đăng ký sự kiện Load
            //texRole.SelectedIndexChanged += textRole_SelectedIndexChanged;
            LoadMonAnData(maChiNhanh);
            cbmuc.SelectedIndexChanged += cbmuc_SelectedIndexChanged;
            this.guna2DataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(this.Guna2DataGridView1_CellFormatting);
            this.guna2DataGridView1.CellClick += new DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.txtTimKiem.TextChanged += new EventHandler(this.txtTimKiem_TextChanged);
        }

        private void LoadData(string maChiNhanh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("GetMucByKhuVucAndThucDon", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số vào stored procedure
                        cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);

                        // Adapter và DataTable để lưu kết quả trả về
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Kiểm tra nếu có dữ liệu trả về
                        if (dt.Rows.Count > 0)
                        {
                            // Thêm mục "Tất cả" vào DataTable
                            DataRow allRow = dt.NewRow();
                            allRow["MaMuc"] = DBNull.Value; // Giá trị cho mã mục
                            allRow["TenMuc"] = "Tất cả";   // Tên hiển thị trong ComboBox
                            dt.Rows.InsertAt(allRow, 0);    // Thêm vào đầu DataTable
                            // Gán dữ liệu vào ComboBox
                            cbmuc.DataSource = dt;
                            cbmuc.DisplayMember = "TenMuc"; // Hiển thị tên mục
                            cbmuc.ValueMember = "MaMuc";   // Lấy mã mục khi chọn
                                                           // Đặt mặc định chọn "Tất cả"
                            cbmuc.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mục phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadMonAnData(string maChiNhanh, string maMuc = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("CheckMonAnForChiNhanhByMaChiNhanh", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // Lọc theo mã mục nếu có
                            if (!string.IsNullOrEmpty(maMuc))
                            {
                                if (maMuc != "Tất cả") // Nếu không chọn "Tất cả", lọc theo MaMuc
                                {
                                    var filteredRows = dt.AsEnumerable()
                                        .Where(row => row.Field<string>("MaMuc") == maMuc);

                                    dt = filteredRows.Any() ? filteredRows.CopyToDataTable() : dt.Clone();
                                }
                            }

                            // Thêm cột STT vào DataTable
                            if (!dt.Columns.Contains("STT"))
                            {
                                dt.Columns.Add("STT", typeof(int));
                            }

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                dt.Rows[i]["STT"] = i + 1; // Gán giá trị STT từ 1
                            }

                            guna2DataGridView1.Columns.Clear();

                            // Thêm cột thủ công và ánh xạ vào DataTable
                            guna2DataGridView1.AutoGenerateColumns = false;

                            guna2DataGridView1.Columns.Add("dgvSTT", "STT");
                            guna2DataGridView1.Columns["dgvSTT"].DataPropertyName = "STT";

                            guna2DataGridView1.Columns.Add("dgvMaMonAn", "Mã Món Ăn");
                            guna2DataGridView1.Columns["dgvMaMonAn"].DataPropertyName = "MaMonAn";

                            guna2DataGridView1.Columns.Add("dgvTenMonAn", "Tên Món Ăn");
                            guna2DataGridView1.Columns["dgvTenMonAn"].DataPropertyName = "TenMonAn";

                            guna2DataGridView1.Columns.Add("dgvTinhTrang", "Tình Trạng");
                            guna2DataGridView1.Columns["dgvTinhTrang"].DataPropertyName = "TinhTrangPhucVu";

                            guna2DataGridView1.DataSource = dt;

                            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            guna2DataGridView1.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmuc.SelectedValue != null)
            {
                string maChiNhanh = MainClass.user.MaChiNhanh; // Thay bằng mã chi nhánh hiện tại
                string maMuc = cbmuc.SelectedValue.ToString();

                // Gọi hàm LoadMonAnData với MaChiNhanh và MaMuc
                LoadMonAnData(maChiNhanh, maMuc);
            }
        }

        private void Guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (guna2DataGridView1.Columns[e.ColumnIndex].DataPropertyName == "TinhTrangPhucVu")
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool isConfirmed = (bool)e.Value;
                    e.Value = isConfirmed ? "Đang phục vụ" : "Ngưng phục vụ";
                    e.FormattingApplied = true;
                }
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ các ô của dòng được chọn
                string maMonAn = selectedRow.Cells["dgvMaMonAn"].Value?.ToString();
                string tenMonAn = selectedRow.Cells["dgvTenMonAn"].Value?.ToString();

                // Lấy tình trạng phục vụ (giá trị bool)
                bool tinhTrang = false; // Mặc định là false nếu có lỗi
                if (selectedRow.Cells["dgvTinhTrang"].Value != null)
                {
                    // Xử lý tình trạng phục vụ
                    bool.TryParse(selectedRow.Cells["dgvTinhTrang"].Value.ToString(), out tinhTrang);
                }

                // Mở form cập nhật và truyền dữ liệu
                if (!string.IsNullOrEmpty(maMonAn))
                {
                    // Tạo form cập nhật với dữ liệu dòng được chọn
                    CapNhatMonAn updateForm = new CapNhatMonAn(maMonAn, tenMonAn, tinhTrang);

                    // Đăng ký sự kiện để reload form khi cập nhật xong
                    updateForm.FormClosed += (s, args) =>
                    {
                        LoadMonAnData(MainClass.user.MaChiNhanh); // Reload lại DataGridView
                    };

                    updateForm.StartPosition = FormStartPosition.CenterScreen;

                    // Hiển thị form cập nhật với hiệu ứng mờ nền
                    MainClass.BlurBackground(updateForm);
                }
            }
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.DataSource is DataTable dt) // Kiểm tra nguồn dữ liệu
            {
                // Lấy nội dung tìm kiếm từ TextBox
                string searchValue = txtTimKiem.Text.Trim().ToLower();

                // Tạo biểu thức lọc (Filter Expression)
                string filterExpression = string.Format("MaMonAn LIKE '%{0}%' OR TenMonAn LIKE '%{0}%'", searchValue);

                // Áp dụng bộ lọc
                dt.DefaultView.RowFilter = filterExpression;
            }
        }

    }
}

