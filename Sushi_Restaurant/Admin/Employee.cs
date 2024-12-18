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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
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
                    Tranfer tranfer = new Tranfer(dgvID);
                    tranfer.TransferCompleted += ReloadEmployeeData;
                    tranfer.ShowDialog();
                }
            }
            else if (e.ColumnIndex == Dataview.Columns["dgvAdjust"].Index)
            {
                int rowIndex = e.RowIndex;
                if (rowIndex >= 0)
                {
                    string dgvID = Dataview.Rows[rowIndex].Cells["dgvID"].Value.ToString(); 

                    // Tạo đối tượng Tranfer và truyền tham số
                    Tranfer tranfer = new Tranfer(dgvID);
                    tranfer.TransferCompleted += ReloadEmployeeData;
                    tranfer.ShowDialog();
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
                        using (SqlConnection conn = new SqlConnection("Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;")) // Thay "your_connection_string" bằng chuỗi kết nối của bạn
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
    }
}
