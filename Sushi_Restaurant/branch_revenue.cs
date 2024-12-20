using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Sushi_Restaurant
{
    public partial class branch_revenue : Form
    {
        private string _branchId; // Khai báo biến lưu mã chi nhánh
        public branch_revenue(string branchID)
        {
            InitializeComponent();
            // Lưu mã chi nhánh vào biến tạm
            _branchId = branchID;
            // Thêm các mục vào ComboBox thời gian
            cboTimeSelection.Items.AddRange(new string[] { "NGAY", "THANG", "QUY", "NAM" });
            cboTimeSelection.SelectedIndex = 0;

            // Load mã chi nhánh từ CSDL
            //List<string> branchIds = Branch.GetBranchIds();
            //if (branchIds.Count > 0)
            //{
            //    cboBranchId.Items.Clear(); // Xóa dữ liệu cũ nếu có
            //    cboBranchId.Items.AddRange(branchIds.ToArray());
            //    cboBranchId.SelectedIndex = 0; // Chọn mục đầu tiên
            //}
            //else
            //{
            //    MessageBox.Show("Không có chi nhánh nào được tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            List<string> months = Branch.GetMonths();
            if (months == null || months.Count == 0)
            {
                MessageBox.Show("Danh sách tháng rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cboMonth.Items.Clear();
            cboMonth.Items.AddRange(months.ToArray());
            cboMonth.SelectedIndex = 0; // Chọn mục đầu tiên

        }


        
        private void LoadRevenueData(string timeFrame, DateTime? specificDate = null, int? month = null, int? quarter = null, int? year = null)
        {
            // Nếu year chưa truyền vào, lấy năm từ DateTimePicker
            if (year == null)
            {
                year = dtpDate.Value.Year;
            }

            // Lấy mã chi nhánh từ ComboBox
            //string branchId = cboBranchId.SelectedItem?.ToString();

            // Gọi stored procedure và truyền các tham số phù hợp
            DataTable dt;

            if (timeFrame == "NGAY" && specificDate.HasValue)
            {
                // Gọi stored procedure với ngày cụ thể
                dt = Branch.GetRevenueReport("NGAY", _branchId, null, year.Value, null, specificDate.Value);

                // Debug dữ liệu trả về
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Stored Procedure không trả về dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRevenue.Text = "0 VND";
                    return;
                }

                // Kiểm tra cột "TongDoanhThu" có tồn tại không
                if (!dt.Columns.Contains("TongDoanhThu"))
                {
                    MessageBox.Show("Cột 'TongDoanhThu' không tồn tại trong kết quả trả về.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalRevenue = dt.Rows[0].Field<decimal?>("TongDoanhThu") ?? 0;
                txtRevenue.Text = $"{totalRevenue:N0} VND";
                return;
            }
            else
            {
                dt = Branch.GetRevenueReport(timeFrame, _branchId, month ?? 0, year.Value, quarter ?? 0);
            }

            // Trường hợp lấy doanh thu theo tháng, quý hoặc năm
            if (timeFrame == "NAM")
            {
                dgvRevenue.DataSource = null; // Ẩn DataGridView
                dgvRevenue.Visible = false;

                decimal totalRevenue = dt.AsEnumerable().Sum(row => row.Field<decimal>("TongDoanhThu"));
                txtRevenue.Text = $"{totalRevenue:N0} VND";
            }
            else
            {
                // Hiển thị dữ liệu lên DataGridView
                dgvRevenue.DataSource = dt;
                dgvRevenue.Visible = true;

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
                cboQuarter.Items.AddRange(new string[] { "Quý 1", "Quý 2", "Quý 3", "Quý 4" });
                cboQuarter.SelectedIndex = 0;
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
            int selectedMonth = cboMonth.SelectedIndex + 3; // Chỉ số tháng bắt đầu từ 0
            int year = dtpDate.Value.Year; // Lấy năm từ DateTimePicker

            // Gọi LoadRevenueData để tải dữ liệu theo tháng
            LoadRevenueData("THANG", month: selectedMonth, year: year);
        }





        private void btnViewRevenue_Click(object sender, EventArgs e)
        {
            string selectedTime = cboTimeSelection.SelectedItem?.ToString().ToUpper();

            if (selectedTime == "NGAY")
            {
                DateTime selectedDate = dtpDate.Value.Date;
                LoadRevenueData("NGAY", specificDate: selectedDate);
            }
            else if (selectedTime == "THANG")
            {
                int selectedMonth = cboMonth.SelectedIndex + 1;
                LoadRevenueData("THANG", month: selectedMonth, year: dtpDate.Value.Year);
            }
            else if (selectedTime == "QUY")
            {
                int selectedQuarter = cboQuarter.SelectedIndex + 1;
                LoadRevenueData("QUY", quarter: selectedQuarter, year: dtpDate.Value.Year);
            }
            else if (selectedTime == "NAM")
            {
                LoadRevenueData("NAM", year: dtpDate.Value.Year);
            }
        }



        //private void cboBranchId_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string branchId = cboBranchId.SelectedItem?.ToString();
        //}



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // Lấy ngày được chọn từ DateTimePicker
            DateTime selectedDate = dtpDate.Value.Date;

            // Gọi phương thức LoadRevenueData để tải doanh thu cho ngày được chọn
            LoadRevenueData("NGAY", specificDate: selectedDate);
        }

    }
}
