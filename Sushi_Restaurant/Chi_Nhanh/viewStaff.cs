using Guna.UI2.WinForms;
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

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class viewStaff : SampleView
    {
        public viewStaff()
        {
            InitializeComponent();
            this.Load += new EventHandler(viewStaff_Load); // Đăng ký sự kiện Load
        }

        public override void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text.Trim(); // Lấy chuỗi tìm kiếm từ TextBox
            string branchID = Branch.MaChiNhanh; // Lấy mã chi nhánh từ lớp Branch

            // Gọi phương thức tìm kiếm
            List<Employee> employees = Employee.SearchEmployees(searchTerm, branchID);

            // Xóa các dòng hiện có trong DataGridView
            GridViewStaff.Rows.Clear();

            // Hiển thị kết quả tìm kiếm
            foreach (var emp in employees)
            {
                GridViewStaff.Rows.Add(emp.MaNhanVien, emp.HoTen, emp.NgaySinh, emp.GioiTinh, emp.DiaChi, emp.SDT, emp.NgayVaoLam, emp.TenBoPhan, emp.MucLuong, emp.DiemPhucVu);
            }
        }

        public override void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void viewStaff_Load(object sender, EventArgs e)
        {
            // Lấy mã chi nhánh từ thuộc tính của lớp Branch
            string branchID = Branch.MaChiNhanh;

            // Kiểm tra mã chi nhánh có hợp lệ hay không
            if (string.IsNullOrEmpty(branchID))
            {
                MessageBox.Show("Mã chi nhánh không hợp lệ hoặc chưa được xác định.");
                return;
            }

            // Lấy danh sách nhân viên từ stored procedure
            List<Employee> employees = Employee.LoadEmployeeFromProcedure(branchID);

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
                // Thêm một dòng mới vào DataGridView
                Dataview.Rows.Add(emp.MaNhanVien, emp.HoTen, emp.NgaySinh, emp.GioiTinh, emp.DiaChi, emp.SDT, emp.NgayVaoLam, emp.TenBoPhan, emp.MucLuong, emp.DiemPhucVu);
            }
        }
    
        
        //List
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            addStaff addStaff = new addStaff();
            addStaff.Show();
        }

        //Text
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Back(object sender, EventArgs e)
        {
            this.Close(); // Đóng form viewIDCard
            if (Owner != null) // Kiểm tra nếu Owner tồn tại
            {
                Owner.Show(); // Hiển thị lại form Brand
            }
        }


        //AVT
        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Staff(object sender, EventArgs e)
        {

        }

        private void Btn_Invoice(object sender, EventArgs e)
        {

        }

        //Btn_CardID
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Insert
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStaff addStaff = new addStaff();
            addStaff.Show();
        }

        //text
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
