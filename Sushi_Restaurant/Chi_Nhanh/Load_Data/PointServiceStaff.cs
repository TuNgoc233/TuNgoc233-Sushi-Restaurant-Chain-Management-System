using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sushi_Restaurant.Admin
{
    public partial class PointServiceStaff : Form
    {
        private string _employeeId; // Biến lưu mã nhân viên

        public PointServiceStaff(string employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId; // Lưu mã nhân viên
        }

        private void PointServiceStaff_Load(object sender, EventArgs e)
        {
            LoadYears();
            LoadMonths();
            LoadQuarters();
            // Tải điểm phục vụ mặc định (có thể là theo ngày hiện tại)
            LoadServicePoints("DAY", DateTime.Now, 0, 0, DateTime.Now.Year);
        }

        private void LoadYears()
        {
            for (int year = 2020; year <= 2030; year++)
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

        private void btnSearch_Click_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển
            string selectedTimeFrame = GetSelectedTimeFrame();
            DateTime selectedDate = dtpDate.Value.Date;
            int selectedMonth = (int)cmbMonth.SelectedItem;
            int selectedQuarter = cmbQuarter.SelectedIndex + 1; // Quý bắt đầu từ 1
            int selectedYear = (int)cmbYear.SelectedItem;

            // Gọi phương thức để lấy điểm phục vụ
            LoadServicePoints(selectedTimeFrame, selectedDate, selectedMonth, selectedQuarter, selectedYear);
        }

        private string GetSelectedTimeFrame()
        {
            // Xác định thời gian đã chọn
            if (dtpDate.Visible)
                return "DAY";
            else if (cmbMonth.Visible)
                return "MONTH";
            else if (cmbQuarter.Visible)
                return "QUARTER";
            else
                return "YEAR";
        }

        private void LoadServicePoints(string timeFrame, DateTime date, int month, int quarter, int year)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120"))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_LayDiemPhucVu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TimeFrame", timeFrame);
                        cmd.Parameters.AddWithValue("@EmployeeId", _employeeId); // Truyền mã nhân viên
                        cmd.Parameters.AddWithValue("@Date", timeFrame == "DAY" ? (object)date : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Month", timeFrame == "MONTH" ? (object)month : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Quarter", timeFrame == "QUARTER" ? (object)quarter : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Year", year);

                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Kiểm tra xem DataTable có dữ liệu không
                        if (dt.Rows.Count > 0)
                        {
                            // Hiển thị dữ liệu lên DataGridView
                            guna2DataGridView1.DataSource = dt;

                            // Cập nhật tiêu đề cột sang tiếng Việt
                            if (dt.Columns.Contains("EmployeeId"))
                                guna2DataGridView1.Columns["EmployeeId"].HeaderText = "Mã Nhân Viên";
                            if (dt.Columns.Contains("TotalServicePoints"))
                                guna2DataGridView1.Columns["TotalServicePoints"].HeaderText = "Tổng Điểm Phục Vụ";
                            if (dt.Columns.Contains("ServiceDate"))
                                guna2DataGridView1.Columns["ServiceDate"].HeaderText = "Ngày Phục Vụ";
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu cho thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            guna2DataGridView1.DataSource = null; // Xóa dữ liệu trong DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện để xử lý khi người dùng chọn năm
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể thêm logic nếu cần
        }

        // Sự kiện để xử lý khi người dùng chọn tháng
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể thêm logic nếu cần
        }
         
        // Sự kiện để xử lý khi người dùng chọn quý
        private void cmbQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể thêm logic nếu cần
        }

        // Sự kiện để xử lý khi người dùng thay đổi giá trị trong DateTimePicker
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // Có thể thêm logic nếu cần
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}