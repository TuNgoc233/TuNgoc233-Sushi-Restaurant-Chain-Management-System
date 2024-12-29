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

namespace Sushi_Restaurant.Admin
{
    public partial class Load_Employee : Form
    {
        public Load_Employee()
        {
            InitializeComponent();
            // Thiết lập font chữ cho Header
            this.Dataview.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Dataview.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 16);

            // Thiết lập màu nền và màu chữ cho Header
            this.Dataview.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 55, 89);
            this.Dataview.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.Dataview.EnableHeadersVisualStyles = false; // Bắt buộc phải tắt thuộc tính này để màu tùy chỉnh có hiệu lực

            // Tăng chiều cao Header
            this.Dataview.ColumnHeadersHeight = 60;
            this.Dataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dataview.RowTemplate.Height = 35; // Tăng chiều cao lên 50 (hoặc giá trị bạn muốn)
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(Employee_Load); // Đăng ký sự kiện Load

        }
        private void Employee_Load(object sender, EventArgs e)
        {
            ReloadEmployeeData(); // Gọi phương thức để tải dữ liệu
        }

        private void ReloadEmployeeData()
        {
            // Lấy danh sách nhân viên từ stored procedure
            List<Employee_> employees = Employee_.LoadEmployeeFromProcedure();

            // Kiểm tra danh sách nhân viên có dữ liệu không
            if (employees == null || employees.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nhân viên nào để hiển thị.");
                return;
            }

            // Thiết lập DataGridView
            Dataview.Rows.Clear(); // Xóa các dòng cũ nếu có

            // Lặp qua danh sách nhân viên và thêm vào DataGridView
            foreach (var emp in employees)
            {
                // Thêm dữ liệu vào DataGridView
                Dataview.Rows.Add(
                    emp.MaNhanVien,         // Mã nhân viên
                    emp.HoTen,              // Họ tên
                    emp.NgaySinh,           // Ngày sinh (đã định dạng)
                    emp.TenBoPhan,          // Tên bộ phận
                    emp.MucLuong.ToString("N0"), // Mức lương (định dạng theo số có dấu phẩy)
                    emp.MaChiNhanh,       // Mã chi nhánh
                    emp.NgayBatDau,         // Ngày bắt đầu làm việc (đã định dạng)
                    emp.NgayKetThuc       // Ngày kết thúc làm việc (đã định dạng hoặc "Chưa xác định")
                );
            }
        }
        private void Dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dataview.Columns["dgvUpdate"].Index) 
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    string dgvID = Dataview.Rows[rowIndex].Cells["dgvID"].Value.ToString(); 
                    // Tạo đối tượng Tranfer và truyền tham số
                    Tranfer_Employee tranfer = new Tranfer_Employee(dgvID);
                    this.Opacity = 0.9;
                  
                    tranfer.TransferCompleted += ReloadEmployeeData;
                    tranfer.ShowDialog();
                    this.Opacity = 1.0;
                }
            }
            else if (e.ColumnIndex == Dataview.Columns["dgvAdjust"].Index)
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    string dgvID = Dataview.Rows[rowIndex].Cells["dgvID"].Value.ToString(); 

                    // Tạo đối tượng Tranfer và truyền tham số
                    Adjust_Employee adjust = new Adjust_Employee(dgvID);
                    this.Opacity = 0.9;
                    adjust.Adjust_Completed += ReloadEmployeeData;
                    adjust.ShowDialog();
                    this.Opacity = 1.0;
                }
            }    
            else if (e.ColumnIndex == Dataview.Columns["dgvDelete"].Index) 
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    string maNhanVien = Dataview.Rows[rowIndex].Cells["dgvID"].Value.ToString(); 

                    // Xác nhận xóa
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Gọi proc xóa nhân viên
                        using (SqlConnection conn = new SqlConnection("Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_; Trusted_Connection=True; Connection Timeout=120;")) // Thay "your_connection_string" bằng chuỗi kết nối của bạn
                        {
                            using (SqlCommand cmd = new SqlCommand("sp_XoaNhanVien", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                                try
                                {
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Xóa nhân viên thành công!");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                                }
                            }
                        }

                        // Tải lại dữ liệu
                        ReloadEmployeeData();
                    }
                }
            }
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            Add_Employee add = new Add_Employee();
            this.Opacity = 0.9;
            add.FormClosed += (s, args) =>
            {
  
                this.Opacity = 1.0;
            };
            add.Add_Completed += ReloadEmployeeData;
            add.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ControlMini_Click(object sender, EventArgs e)
        {

        }

        private void ControlMax_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Manage admin_Manage = new Admin_Manage();
            admin_Manage.Show();
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text.Trim(); // Lấy chuỗi tìm kiếm từ TextBox
          
            // Gọi phương thức tìm kiếm
            List<Employee_> employees = Employee_.SearchEmployees(searchTerm);

            // Xóa các dòng hiện có trong DataGridView
            Dataview.Rows.Clear();

            // Hiển thị kết quả tìm kiếm
            // Lặp qua danh sách nhân viên và thêm vào DataGridView
            foreach (var emp in employees)
            {
                // Thêm dữ liệu vào DataGridView
                Dataview.Rows.Add(
                    emp.MaNhanVien,         // Mã nhân viên
                    emp.HoTen,              // Họ tên
                    emp.NgaySinh,           // Ngày sinh (đã định dạng)
                    emp.TenBoPhan,          // Tên bộ phận
                    emp.MucLuong.ToString("N0"), // Mức lương (định dạng theo số có dấu phẩy)
                    emp.MaChiNhanh,       // Mã chi nhánh
                    emp.NgayBatDau,         // Ngày bắt đầu làm việc (đã định dạng)
                    emp.NgayKetThuc       // Ngày kết thúc làm việc (đã định dạng hoặc "Chưa xác định")
                );
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
