using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public partial class branch_revenue : Form
    {       
        public branch_revenue()
        {
            InitializeComponent();

            // Thêm các mục vào ComboBox thời gian
            cboTimeSelection.Items.AddRange(new string[] { "NGAY", "THANG", "QUY", "NAM" });
            cboTimeSelection.SelectedIndex = 0;

            // Load danh sách mã chi nhánh
            cboBranchId.Items.AddRange(new string[] { "CN01", "CN02", "CN03" }); // Thay bằng dữ liệu thật từ DB
            cboBranchId.SelectedIndex = 0;
        }


        private void LoadRevenueData(string timeFrame, int month = 0, int quarter = 0, int year = 0)
        {
            year = (year == 0) ? dtpDate.Value.Year : year;

            // Gọi stored procedure và truyền tham số
            DataTable dt = Branch.GetRevenueReport(timeFrame, Branch.MaChiNhanh, month, year, quarter);

            // Hiển thị dữ liệu lên DataGridView
            dgvRevenue.DataSource = dt;

            // Tính tổng doanh thu
            if (dt.Rows.Count > 0)
            {
                decimal totalRevenue = dt.AsEnumerable().Sum(row => row.Field<decimal>("TongDoanhThu"));
                txtRevenue.Text = $"{totalRevenue:N0} VND";
            }
            else
            {
                txtRevenue.Text = "0 VND";
                MessageBox.Show("Không có dữ liệu cho thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void cboTimeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTime = cboTimeSelection.SelectedItem?.ToString().ToUpper();


            // Ẩn tất cả các điều khiển không cần thiết trước khi hiển thị đúng điều khiển
            dtpDate.Visible = false;
            cboMonth.Visible = false;
            cboQuarter.Visible = false;

            // Hiển thị điều khiển phù hợp
            if (selectedTime == "NGAY")
            {
                dtpDate.Visible = true;
                dtpDate.Format = DateTimePickerFormat.Short;
            }
            else if (selectedTime == "THANG")
            {
                cboMonth.Visible = true; // Hiển thị ComboBox chọn tháng
                if (cboMonth.Items.Count == 0) // Thêm danh sách tháng nếu chưa có
                {
                    for (int i = 3; i <= 11; i++)
                    {
                        cboMonth.Items.Add($"Tháng {i}");
                    }
                    cboMonth.SelectedIndex = 0; // Mặc định chọn tháng đầu tiên
                }
            }
            else if (selectedTime == "QUY")
            {
                cboQuarter.Visible = true; // Hiển thị ComboBox chọn quý
                if (cboQuarter.Items.Count == 0) // Thêm danh sách quý nếu chưa có
                {
                    cboQuarter.Items.AddRange(new string[] { "Quý 1", "Quý 2", "Quý 3", "Quý 4" });
                    cboQuarter.SelectedIndex = 0; // Mặc định chọn quý đầu tiên
                }
            }
            else if (selectedTime == "NAM")
            {
                dtpDate.Visible = true;
                dtpDate.Format = DateTimePickerFormat.Custom;
                dtpDate.CustomFormat = "yyyy";
            }
        }


        private void cboQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedQuarter = cboQuarter.SelectedIndex + 1; // Quý 1-4
            int currentYear = dtpDate.Value.Year; // Lấy năm từ DateTimePicker

            LoadRevenueData("QUY", quarter: selectedQuarter, year: currentYear);
        }



        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMonth = cboMonth.SelectedIndex + 1; // Tháng 1-12
            int currentYear = dtpDate.Value.Year;

            LoadRevenueData("THANG", month: selectedMonth, year: currentYear);
        }



        private void btnViewRevenue_Click(object sender, EventArgs e)
        {
            string selectedTime = cboTimeSelection.SelectedItem?.ToString().ToUpper();

            if (selectedTime == "NGAY")
                LoadRevenueData("NGAY");
            else if (selectedTime == "THANG")
                LoadRevenueData("THANG");
            else if (selectedTime == "QUY")
                LoadRevenueData("QUY");
            else if (selectedTime == "NAM")
                LoadRevenueData("NAM");
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
