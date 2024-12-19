using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public partial class CompanyRevenue : Form
    {
        public CompanyRevenue()
        {
            InitializeComponent();

            // Thêm các mục vào ComboBox thời gian
            cboTimeSelection.Items.AddRange(new string[] { "NGAY", "THANG", "QUY", "NAM" });
            cboTimeSelection.SelectedIndex = 0;
        }

        private void LoadRevenueData(string timeFrame, int? month = null, int? quarter = null, int? year = null)
        {
            // Gọi stored procedure và chỉ truyền tham số ThoiGian
            DataTable dt = Branch.GetRevenueReportCompany(timeFrame);

            // Hiển thị dữ liệu vào DataGridView
            if (dt.Rows.Count > 0)
            {
                dgvRevenue.DataSource = dt;  // Hiển thị tất cả dữ liệu chi nhánh vào DataGridView
                dgvRevenue.Visible = true;
            }
            else
            {
                dgvRevenue.DataSource = null;  // Nếu không có dữ liệu, ẩn DataGridView
                MessageBox.Show("Không có dữ liệu cho thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void cboQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý logic khi người dùng chọn một quý
            int selectedQuarter = cboQuarter.SelectedIndex + 1; // Quý bắt đầu từ 1
            int year = dtpDate.Value.Year; // Lấy năm từ DateTimePicker

            // Gọi LoadRevenueData để tải dữ liệu theo quý
            LoadRevenueData("QUY", quarter: selectedQuarter, year: year);
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý logic khi người dùng chọn một tháng
            int selectedMonth = cboMonth.SelectedIndex + 1; // Chỉ số tháng bắt đầu từ 0
            int year = dtpDate.Value.Year; // Lấy năm từ DateTimePicker

            // Gọi LoadRevenueData để tải dữ liệu theo tháng
            LoadRevenueData("THANG", month: selectedMonth, year: year);
        }

        private void btnViewRevenue_Click(object sender, EventArgs e)
        {
            string selectedTime = cboTimeSelection.SelectedItem?.ToString().ToUpper();

            int? month = null, quarter = null, year = null;

            // Lấy năm từ DateTimePicker
            year = dtpDate.Value.Year;

            if (selectedTime == "NGAY" || selectedTime == "NAM")
            {
                if (selectedTime == "NGAY")
                    LoadRevenueData("NGAY", year: year);
                else
                    LoadRevenueData("NAM", year: year);
            }
            else if (selectedTime == "THANG")
            {
                month = cboMonth.SelectedIndex + 1;
                LoadRevenueData("THANG", month: month, year: year);
            }
            else if (selectedTime == "QUY")
            {
                quarter = cboQuarter.SelectedIndex + 1;
                LoadRevenueData("QUY", quarter: quarter, year: year);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
