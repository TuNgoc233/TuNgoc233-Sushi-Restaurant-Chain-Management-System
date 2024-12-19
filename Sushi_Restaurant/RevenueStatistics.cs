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

namespace Sushi_Restaurant
{
    public partial class RevenueStatistics : Form
    {
        public RevenueStatistics()
        {
            InitializeComponent();
        }

        private void RevenueStatistics_Load(object sender, EventArgs e)
        {
            LoadBranches(); // Tải danh sách chi nhánh
            LoadRegions();  // Tải danh sách khu vực
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brand brand = new Brand(Branch.MaChiNhanh);
            brand.ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ giao diện
            string ngayBatDau = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string ngayKetThuc = dtpEndDate.Value.ToString("yyyy-MM-dd");
            string maChiNhanh = cboBranch.SelectedIndex == 0 ? null : cboBranch.SelectedItem.ToString();
            string khuVuc = cboRegion.SelectedIndex == 0 ? null : cboRegion.SelectedItem.ToString();

            // Chuỗi kết nối
            string connectionString = Branch.con_string;

            // Tạo DataTable để chứa dữ liệu
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("ThongKeDoanhThuTheoMon", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho proc
                        cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                        cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                        cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@KhuVuc", khuVuc ?? (object)DBNull.Value);

                        con.Open();

                        // Đọc kết quả từ Stored Procedure
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }

                // Hiển thị dữ liệu vào DataGridView
                dgvRevenue.DataSource = dataTable;

                // Tìm món chạy nhất (bán nhiều nhất) và món bán chậm nhất (bán ít nhất)
                if (dataTable.Rows.Count > 0)
                {
                    // Tìm món chạy nhất (bán nhiều nhất)
                    var bestSelling = dataTable.AsEnumerable().OrderByDescending(row => row.Field<int>("TongSoLuong")).FirstOrDefault();
                    txtBestSelling.Text = bestSelling["TenMonAn"].ToString();

                    // Tìm món bán chậm nhất (bán ít nhất)
                    var slowestSelling = dataTable.AsEnumerable().OrderBy(row => row.Field<int>("TongSoLuong")).FirstOrDefault();
                    txtSlowestSelling.Text = slowestSelling["TenMonAn"].ToString();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBestSelling.Clear();
                    txtSlowestSelling.Clear();
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void groupBoxFilters_Enter(object sender, EventArgs e)
        {

        }

        private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadBranches()
        {
            string connectionString = Branch.con_string;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Truy vấn danh sách chi nhánh
                    using (SqlCommand cmdBranches = new SqlCommand("SELECT DISTINCT MaChiNhanh FROM CHI_NHANH", con))
                    {
                        SqlDataReader reader = cmdBranches.ExecuteReader();
                        cboBranch.Items.Clear(); // Xóa dữ liệu cũ
                        cboBranch.Items.Add("Tất cả"); // Thêm tùy chọn "Tất cả"
                        while (reader.Read())
                        {
                            cboBranch.Items.Add(reader["MaChiNhanh"].ToString());
                        }
                        reader.Close();
                    }
                }

                // Mặc định chọn "Tất cả"
                cboBranch.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách chi nhánh: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRegions()
        {
            string connectionString = Branch.con_string;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Truy vấn danh sách khu vực
                    using (SqlCommand cmdRegions = new SqlCommand("SELECT DISTINCT ThanhPho FROM CHI_NHANH", con))
                    {
                        SqlDataReader reader = cmdRegions.ExecuteReader();
                        cboRegion.Items.Clear(); // Xóa dữ liệu cũ
                        cboRegion.Items.Add("Tất cả"); // Thêm tùy chọn "Tất cả"
                        while (reader.Read())
                        {
                            cboRegion.Items.Add(reader["ThanhPho"].ToString());
                        }
                        reader.Close();
                    }
                }

                // Mặc định chọn "Tất cả"
                cboRegion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khu vực: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RevenueStatistics_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


