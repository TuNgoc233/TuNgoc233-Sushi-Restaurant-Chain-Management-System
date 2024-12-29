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
using System.Globalization;
using Sushi_Restaurant.Admin;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class viewStaff : SampleView
    {
        public viewStaff()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Vô hiệu hóa Theme mặc định để toàn quyền điều chỉnh
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
            this.Load += new EventHandler(viewStaff_Load); // Đăng ký sự kiện Load
        }

        public override void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text.Trim(); // Lấy chuỗi tìm kiếm từ TextBox
            string branchID = Branch.MaChiNhanh; // Lấy mã chi nhánh từ lớp Branch

            // Gọi phương thức tìm kiếm
            List<Employee> employees = Employee.SearchEmployees(searchTerm, branchID);

            // Xóa các dòng hiện có trong DataGridView
            Dataview.Rows.Clear();

            // Hiển thị kết quả tìm kiếm
            foreach (var emp in employees)
            {
                // Kiểm tra nếu MucLuong không null
                string formattedPrice = emp.MucLuong.ToString("N0", CultureInfo.InvariantCulture) + " VND";

                // Thêm dữ liệu vào DataGridView
                Dataview.Rows.Add(
                    emp.MaNhanVien,
                    emp.HoTen,
                    emp.NgaySinh, // Định dạng ngày sinh (nếu cần)
                    emp.GioiTinh,
                    emp.DiaChi,
                    emp.SDT,
                    emp.NgayVaoLam, // Định dạng ngày vào làm
                    emp.TenBoPhan,
                    formattedPrice
                );
            }

        }

        public override void btnThem_Click(object sender, EventArgs e)
        {

        }

        public void viewStaff_Load(object sender, EventArgs e)
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
                // Kiểm tra nếu MucLuong không null
                string formattedPrice = emp.MucLuong.ToString("N0", CultureInfo.InvariantCulture) + " VND";

                // Thêm dữ liệu vào DataGridView
                Dataview.Rows.Add(
                    emp.MaNhanVien,
                    emp.HoTen,
                    emp.NgaySinh, // Định dạng ngày sinh (nếu cần)
                    emp.GioiTinh,
                    emp.DiaChi,
                    emp.SDT,
                    emp.NgayVaoLam, // Định dạng ngày vào làm
                    emp.TenBoPhan,
                    formattedPrice
                );
            }
        }
    
        
        //List
        public void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            addFood addStaff = new addFood();
            addStaff.Show();
        }

        //Text
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        public void Btn_Back(object sender, EventArgs e)
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

        public void Btn_Staff(object sender, EventArgs e)
        {
            viewFood viewFood = new viewFood();
            this.Hide();
            viewFood.Show();
        }

        public void Btn_Invoice(object sender, EventArgs e)
        {
            viewOrderForm Page = new viewOrderForm();
            this.Hide(); // Chỉ ẩn form Brand
            Page.Show();
        }

        //Btn_CardID
        public void guna2Button2_Click(object sender, EventArgs e)
        {
            viewID_Card Page = new viewID_Card();
            this.Hide(); // Chỉ ẩn form Brand
            Page.Show();
        }

        public void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Insert
        public void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            addFood addStaff = new addFood();
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
            string maNhanVien = Dataview.Rows[e.RowIndex].Cells[0].Value.ToString();
            PointServiceStaff pointServiceStaff = new PointServiceStaff(maNhanVien,Branch.MaChiNhanh);
            this.Opacity = 0.9;
            pointServiceStaff.ShowDialog();
            this.Opacity = 1.0;

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            branch_revenue brand = new branch_revenue(Branch.MaChiNhanh);
            brand.Show();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brand brand = new Brand(Branch.MaChiNhanh);
            brand.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Logout(); 
            }
        }

        private void Logout()
        {
            Branch.MaChiNhanh = null; 
            Sushi_Restaurant.Chi_Nhanh.Login loginForm = new Sushi_Restaurant.Chi_Nhanh.Login(); 
            loginForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Logout();
            }
            else
            {
                e.Cancel = true; 
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
