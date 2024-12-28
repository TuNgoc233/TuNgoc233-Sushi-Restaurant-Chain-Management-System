using Sushi_Restaurant.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public partial class company_revenue : Form
    {
        public company_revenue()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadBranchIds();

            // Thêm các mục vào ComboBox thời gian
            cboTimeSelection.Items.AddRange(new string[] { "NGAY", "THANG", "QUY", "NAM" });
            cboTimeSelection.SelectedIndex = 0;
        }

        private void LoadRevenueData(string timeFrame, string branchId = null, int? month = null, int? quarter = null, int? year = null, DateTime? specificDate = null)
        {
            if (year == null)
            {
                year = DateTime.Now.Year; // Mặc định là năm hiện tại
            }

            // Gọi Stored Procedure để lấy dữ liệu
            DataTable dt = Branch.GetRevenueReportCompany(timeFrame, branchId, specificDate);

            // Xử lý khi chọn "Tất cả" chi nhánh và lọc theo ngày
            if (timeFrame == "NGAY" && specificDate.HasValue && branchId == null)
            {
                var groupedRows = dt.AsEnumerable()
                    .GroupBy(row => row.Field<string>("MaChiNhanh"))
                    .Select(group => new
                    {
                        MaChiNhanh = group.Key,
                        Ngay = specificDate.Value.ToString("dd/MM/yyyy"),
                        TongDoanhThu = group.Sum(row => row.Field<decimal>("TongDoanhThu"))
                    }).ToList();

                // Chuyển dữ liệu nhóm vào DataTable
                DataTable resultTable = new DataTable();
                resultTable.Columns.Add("MaChiNhanh", typeof(string));
                resultTable.Columns.Add("Ngay", typeof(string));
                resultTable.Columns.Add("TongDoanhThu", typeof(decimal));

                foreach (var row in groupedRows)
                {
                    resultTable.Rows.Add(row.MaChiNhanh, row.Ngay, row.TongDoanhThu);
                }

                dt = resultTable; // Gán kết quả vào DataTable chính
            }

            // Lọc theo tháng
            if (month.HasValue)
            {
                var filteredRows = dt.AsEnumerable()
                    .Where(row => row.Field<int>("Thang") == month.Value);

                if (filteredRows.Any())
                {
                    dt = filteredRows.CopyToDataTable();
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy dữ liệu cho tháng {month.Value}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRevenue.DataSource = null;
                    txtRevenue.Text = "0 VND";
                    return;
                }
            }

            // Lọc theo quý
            if (quarter.HasValue)
            {
                var filteredRows = dt.AsEnumerable()
                    .Where(row => !row.IsNull("Quy") && Convert.ToInt32(row.Field<decimal>("Quy")) == quarter.Value);

                if (filteredRows.Any())
                {
                    dt = filteredRows.CopyToDataTable();
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy dữ liệu cho quý {quarter.Value}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRevenue.DataSource = null;
                    txtRevenue.Text = "0 VND";
                    return;
                }
            }

            // Hiển thị dữ liệu lên DataGridView
            dgvRevenue.DataSource = dt;

            // Thêm cột "Mã Chi Nhánh" nếu chưa có
            //if (!dgvRevenue.Columns.Contains("MaChiNhanh"))
            //{
            //    dgvRevenue.Columns.Insert(0, new DataGridViewTextBoxColumn
            //    {
            //        Name = "MaChiNhanh",
            //        HeaderText = "Mã Chi Nhánh",
            //        DataPropertyName = "MaChiNhanh"
            //    });
            //}

            // Tính tổng doanh thu
            decimal totalRevenue = dt.AsEnumerable()
                .Where(row => !row.IsNull("TongDoanhThu"))
                .Sum(row => row.Field<decimal>("TongDoanhThu"));

            txtRevenue.Text = $"{totalRevenue:N0} VND";

            // Hiển thị thông báo nếu không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRevenue.Text = "0 VND";
            }
        }


        private void cboTimeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTime = cboTimeSelection.SelectedItem?.ToString().ToUpper();

            // Ẩn tất cả các điều khiển
            dtpDate.Visible = false;
            cboMonth.Visible = false;
            cboQuarter.Visible = false;

            if (selectedTime == "NGAY" || selectedTime == "NAM")
            {
                dtpDate.Visible = true;
                dtpDate.Format = (selectedTime == "NAM") ? DateTimePickerFormat.Custom : DateTimePickerFormat.Short;
                dtpDate.CustomFormat = (selectedTime == "NAM") ? "yyyy" : "dd/MM/yyyy";
            }
            else if (selectedTime == "THANG")
            {
                cboMonth.Visible = true;
                cboMonth.Items.Clear();

                // Lấy danh sách tháng từ database hoặc mặc định
                List<string> months = Branch.GetMonths(); // Lấy danh sách tháng từ database hoặc mặc định

                if (months != null && months.Count > 0)
                {
                    cboMonth.Items.AddRange(months.ToArray());
                    cboMonth.SelectedIndex = 0; // Chọn tháng đầu tiên
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu tháng để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (selectedTime == "QUY")
            {
                cboQuarter.Visible = true;
                cboQuarter.Items.Clear();

                // Lấy danh sách quý từ database
                List<string> quarters = Branch.GetQuarters(); // Lấy danh sách quý từ cơ sở dữ liệu
                if (quarters != null && quarters.Count > 0)
                {
                    cboQuarter.Items.AddRange(quarters.ToArray());
                    cboQuarter.SelectedIndex = 0; // Chọn quý đầu tiên
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu quý để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMonth = cboMonth.SelectedIndex + 3; // 
            LoadRevenueData("THANG", month: selectedMonth);
        }

        private void cboQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedQuarter = cboQuarter.SelectedIndex + 1; // Chọn quý (bắt đầu từ 1)
            LoadRevenueData("QUY", quarter: selectedQuarter);
        }


        private void btnViewRevenue_Click(object sender, EventArgs e)
        {
            string selectedTime = cboTimeSelection.SelectedItem?.ToString().ToUpper();

            int? month = null, quarter = null, year = null;
            DateTime? specificDate = null;

            // Lấy năm và ngày cụ thể từ DateTimePicker
            year = dtpDate.Value.Year;
            specificDate = dtpDate.Value.Date;

            // Kiểm tra chi nhánh được chọn
            string selectedBranch = cboBranch.SelectedItem?.ToString();

            if (selectedTime == "NGAY")
            {
                if (selectedBranch == "Tất cả")
                {
                    // Hiển thị tổng doanh thu cho tất cả chi nhánh trong ngày đã chọn
                    LoadRevenueData("NGAY", branchId: null, specificDate: specificDate);
                }
                else
                {
                    // Hiển thị doanh thu cho chi nhánh cụ thể trong ngày đã chọn
                    LoadRevenueData("NGAY", branchId: selectedBranch, specificDate: specificDate);
                }
            }
            else if (selectedTime == "THANG")
            {
                month = cboMonth.SelectedIndex + 3; // Chỉ số tháng bắt đầu từ 0
                if (selectedBranch == "Tất cả")
                {
                    LoadRevenueData("THANG", branchId: null, month: month, year: year);
                }
                else
                {
                    LoadRevenueData("THANG", branchId: selectedBranch, month: month, year: year);
                }
            }
            else if (selectedTime == "QUY")
            {
                quarter = cboQuarter.SelectedIndex + 1; // Chỉ số quý bắt đầu từ 1
                if (selectedBranch == "Tất cả")
                {
                    LoadRevenueData("QUY", branchId: null, quarter: quarter, year: year);
                }
                else
                {
                    LoadRevenueData("QUY", branchId: selectedBranch, quarter: quarter, year: year);
                }
            }
            else if (selectedTime == "NAM")
            {
                if (selectedBranch == "Tất cả")
                {
                    LoadRevenueData("NAM", branchId: null, year: year);
                }
                else
                {
                    LoadRevenueData("NAM", branchId: selectedBranch, year: year);
                }
            }
        }


        private void LoadBranchIds()
        {
            try
            {
                List<string> branchIds = Branch.GetBranchIds();
                branchIds.Insert(0, "Tất cả"); // Thêm tùy chọn "Tất cả" để hiển thị tất cả chi nhánh
                cboBranch.DataSource = branchIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách chi nhánh: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBranch = cboBranch.SelectedItem?.ToString();

            if (selectedBranch == "Tất cả")
            {
                LoadRevenueData(timeFrame: "NGAY"); // Hiển thị doanh thu của tất cả chi nhánh
            }
            else
            {
                LoadRevenueData(timeFrame: "NGAY", branchId: selectedBranch);
            }
        }

        private void btnViewByDate_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpDate.Value.Date;
            LoadRevenueData(timeFrame: "NGAY", branchId: cboBranch.SelectedItem.ToString());
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Manage admin = new Admin_Manage();
            admin.Show();
        }

        private void company_revenue_Load(object sender, EventArgs e)
        {

        }
    }
}
