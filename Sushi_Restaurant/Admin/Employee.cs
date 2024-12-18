using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                // Kiểm tra nếu MucLuong không null
                string formattedPrice = emp.MucLuong.ToString("N0", CultureInfo.InvariantCulture) + " VND";

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
            // Bỏ qua trường hợp header hoặc hàng không hợp lệ
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Kiểm tra cột nào được click
            if (e.ColumnIndex == Dataview.Columns["Chuyen"].Index) // Thay "Chuyen" là tên cột
            {
                Tranfer tranfer = new Tranfer();
                this.Show();
            }
            else if (e.ColumnIndex == Dataview.Columns["XoaNhanVien"].Index) // Thay "XoaNhanVien" là tên cột
            {
                // Xử lý sự kiện xóa nhân viên
                MessageBox.Show("Xóa nhân viên!");
            }
        }
    }
}
