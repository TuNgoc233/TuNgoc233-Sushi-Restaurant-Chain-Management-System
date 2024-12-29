using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sushi_Restaurant.Admin
{
    public partial class PointServiceStaff : Form
    {
        private string _employeeId;
        private string _branchId;

        public PointServiceStaff(string employeeId, string branchId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _employeeId = employeeId;
            _branchId = branchId;
            cmbYear.SelectedIndexChanged += cmbYear_SelectedIndexChanged;
            cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;
            cmbQuarter.SelectedIndexChanged += cmbQuarter_SelectedIndexChanged;
            dtpDate.ValueChanged += dtpDate_ValueChanged; // Thêm sự kiện cho DateTimePicker
        }

        private void PointServiceStaff_Load(object sender, EventArgs e)
        {
            LoadYears();
            LoadMonths();
            LoadQuarters();
        }

        private void LoadYears()
        {
            for (int year = 2023; year <= 2030; year++)
            {
                cmbYear.Items.Add(year);
            }
        }

        private void LoadMonths()
        {
            for (int month = 1; month <= 12; month++)
            {
                cmbMonth.Items.Add(month);
            }
        }

        private void LoadQuarters()
        {
            for (int quarter = 1; quarter <= 4; quarter++)
            {
                cmbQuarter.Items.Add("Quý " + quarter);
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedItem != null)
            {
                int selectedYear = (int)cmbYear.SelectedItem;
                LoadServicePoints("YEAR", DateTime.MinValue, 0, 0, selectedYear);
            }
            cmbYear.Enabled = false;
          
        }

        private void cmbQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuarter.SelectedItem != null && cmbYear.SelectedItem != null)
            {
                cmbMonth.Enabled = false;
                dtpDate.Enabled = false;
                int selectedQuarter = cmbQuarter.SelectedIndex + 1;
                int selectedYear = (int)cmbYear.SelectedItem;
                LoadServicePoints("QUARTER", DateTime.MinValue, 0, selectedQuarter, selectedYear);
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedItem != null && cmbYear.SelectedItem != null)
            {
                cmbQuarter.Enabled = false;
                dtpDate.Enabled = false;
                int selectedMonth = (int)cmbMonth.SelectedItem;
                int selectedYear = (int)cmbYear.SelectedItem;
                LoadServicePoints("MONTH", DateTime.MinValue, selectedMonth, 0, selectedYear);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // Khi chọn ngày, gọi LoadServicePoints với ngày đã chọn
            DateTime selectedDate = dtpDate.Value;
            LoadServicePoints("DAY", selectedDate, 0, 0, selectedDate.Year);

            // Tối màu các ComboBox cho năm, tháng, quý
            cmbYear.Enabled = false;
            cmbMonth.Enabled = false;
            cmbQuarter.Enabled = false;
        }

        private void LoadServicePoints(string timeFrame, DateTime date, int month, int quarter, int year)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_; Trusted_Connection=True; Connection Timeout=120"))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_LayDiemPhucVu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TimeFrame", timeFrame);
                        cmd.Parameters.AddWithValue("@EmployeeId", _employeeId);
                        cmd.Parameters.AddWithValue("@Date", timeFrame == "DAY" ? (object)date : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Month", timeFrame == "MONTH" ? (object)month : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Quarter", timeFrame == "QUARTER" ? (object)quarter : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Year", year);

                        conn.Open();

                        // Trực tiếp lấy giá trị từ cột TotalServicePoints bằng ExecuteScalar
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            // Lưu tổng điểm vào biến
                            int totalPoints = Convert.ToInt32(result);

                            // Hiển thị trên label1
                            label1.Text = $"Tổng điểm: {totalPoints}";
                        }
                        else
                        {
                            // Trường hợp không có dữ liệu trả về
                            label1.Text = "Tổng điểm: 0";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "Tổng điểm: Không xác định";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "Tổng điểm: Không xác định";
            }
        }

        private void btnSearch_Click_Click(object sender, EventArgs e)
        {
            ResetComboBoxes();
            cmbYear.Enabled=true;
            cmbQuarter.Enabled=true;
            cmbMonth.Enabled = true;
            dtpDate.Enabled = true;
        }

        private void ResetComboBoxes()
        {
            // Kích hoạt lại các ComboBox
            cmbYear.Enabled = true;
            cmbMonth.Enabled = true;
            cmbQuarter.Enabled = true;

            // Reset giá trị của các ComboBox
            cmbYear.SelectedIndex = -1; // Hoặc 0 nếu bạn muốn chọn mục đầu tiên
            cmbMonth.SelectedIndex = -1; // Hoặc 0 nếu bạn muốn chọn mục đầu tiên
            cmbQuarter.SelectedIndex = -1; // Hoặc 0 nếu bạn muốn chọn mục đầu tiên

            // Đặt lại label
            label1.Text = "Tổng điểm: 0";

            // Reset giá trị của DateTimePicker
            dtpDate.Value = DateTime.Now; // Hoặc giá trị mặc định mà bạn muốn
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Logic vẽ nếu cần
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Logic xử lý khi label1 được nhấp (nếu cần)
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbMonth_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}