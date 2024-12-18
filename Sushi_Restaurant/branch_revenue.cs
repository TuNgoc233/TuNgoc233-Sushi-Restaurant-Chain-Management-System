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
        private bool isLoaded = false; // Biến kiểm soát
        public branch_revenue()
        {
            InitializeComponent();
          
            // Thêm các mục vào ComboBox
            cboTimeSelection.Items.AddRange(new string[] { "NGAY", "THANG", "QUY", "NAM" });
            cboTimeSelection.SelectedIndex = 0; // Chọn mục đầu tiên

            isLoaded = true; // Đánh dấu form đã load xong
        }


        private void LoadRevenueData(string timeFrame, int quarter = 0, int month = 0, int year = 0, int day = 0)
        {
            try
            {
                // Gọi hàm lấy dữ liệu từ Stored Procedure
                DataTable dt = Branch.GetRevenueReport(timeFrame, Branch.MaChiNhanh, quarter, month, year);

                // Đổ dữ liệu vào DataGridView
                dgvRevenue.DataSource = dt;

                // Tính tổng doanh thu
                if (dt.Rows.Count > 0)
                {
                    decimal totalRevenue = dt.AsEnumerable().Sum(row => row.Field<decimal>("TongDoanhThu"));
                    txtRevenue.Text = $"{totalRevenue:N0} VND"; // Định dạng tiền tệ
                }
                else
                {
                    txtRevenue.Text = "0 VND";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    for (int i = 1; i <= 12; i++)
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
            try
            {
                // Lấy lựa chọn thời gian từ ComboBox
                string selectedTime = cboTimeSelection.SelectedItem?.ToString().ToUpper();
                int selectedMonth = 0, selectedQuarter = 0, selectedYear = dtpDate.Value.Year;


                if (selectedTime == "THANG")
                {
                    selectedMonth = cboMonth.SelectedIndex + 1;
                    LoadRevenueData("THANG", month: selectedMonth, year: selectedYear);
                }
                else if (selectedTime == "QUÝ")
                {
                    selectedQuarter = cboQuarter.SelectedIndex + 1;
                    LoadRevenueData("QUY", quarter: selectedQuarter, year: selectedYear);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tính doanh thu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
