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

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class viewOrderForm : SampleView
    {
        public viewOrderForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Vô hiệu hóa Theme mặc định để toàn quyền điều chỉnh
            // Thiết lập font chữ cho Header
            this.Load_Invoice.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Load_Invoice.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 16);

            // Thiết lập màu nền và màu chữ cho Header
            this.Load_Invoice.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 55, 89);
            this.Load_Invoice.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.Load_Invoice.EnableHeadersVisualStyles = false; // Bắt buộc phải tắt thuộc tính này để màu tùy chỉnh có hiệu lực

            // Tăng chiều cao Header
            this.Load_Invoice.ColumnHeadersHeight = 60;
            this.Load_Invoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Load_Invoice.RowTemplate.Height = 35; // Tăng chiều cao lên 50 (hoặc giá trị bạn muốn)
            this.Load += new EventHandler(viewOrderForm_Load); // Đăng ký sự kiện Load

        }

        public override void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text.Trim(); // Lấy chuỗi tìm kiếm từ TextBox
            string branchID = Branch.MaChiNhanh; // Lấy mã chi nhánh từ lớp Branch

            // Gọi phương thức tìm kiếm hóa đơn
            List<Invoice> invoices = Invoice.SearchInvoicesItem(searchTerm, branchID);

            // Xóa các dòng hiện có trong DataGridView
            Load_Invoice.Rows.Clear();

            // Hiển thị kết quả tìm kiếm
            foreach (var invoice in invoices)
            {
                // Kiểm tra nếu TongTien không null và định dạng giá trị
                string formattedTotal = invoice.TongTien.ToString("N0", CultureInfo.InvariantCulture) + " VND";

                // Thêm một dòng mới vào DataGridView với các giá trị được định dạng
                Load_Invoice.Rows.Add(
                    invoice.MaHoaDon,
                    invoice.TenNhanVienLap,
                    invoice.HoTenKhachHang,
                    invoice.ThoiGianLap, // Định dạng ngày thành dd/MM/yyyy
                    formattedTotal
                );
            }
        }

        public override void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void viewOrderForm_Load(object sender, EventArgs e)
        {
            // Lấy mã chi nhánh từ thuộc tính của lớp Branch
            string branchID = Branch.MaChiNhanh;

            // Kiểm tra mã chi nhánh có hợp lệ hay không
            if (string.IsNullOrEmpty(branchID))
            {
                MessageBox.Show("Mã chi nhánh không hợp lệ hoặc chưa được xác định.");
                return;
            }

            // Lấy danh sách hóa đơn từ stored procedure
            List<Invoice> invoices = Invoice.LoadInvoicesFromProcedure(branchID);

            // Kiểm tra danh sách hóa đơn có dữ liệu không
            if (invoices == null || invoices.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu hóa đơn nào để hiển thị.");
                return;
            }

            // Thiết lập DataGridView
            Load_Invoice.Rows.Clear(); // Xóa các dòng cũ nếu có

            // Lặp qua danh sách hóa đơn và thêm vào DataGridView
            foreach (var invoice in invoices)
            {
                // Kiểm tra nếu TongTien không null và định dạng giá trị
                string formattedTotal = invoice.TongTien.ToString("N0", CultureInfo.InvariantCulture) + " VND";

                // Thêm một dòng mới vào DataGridView với các giá trị được định dạng
                Load_Invoice.Rows.Add(
                    invoice.MaHoaDon,
                    invoice.TenNhanVienLap,
                    invoice.HoTenKhachHang,
                    invoice.ThoiGianLap, // Định dạng ngày thành dd/MM/yyyy
                    formattedTotal
                );
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewOrderForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Date.Value.Date; // Lấy ngày từ DateTimePicker
            string branchID = Branch.MaChiNhanh; // Lấy mã chi nhánh từ lớp Branch
            List<Invoice> invoices = Invoice.SearchInvoicesDate(selectedDate, branchID);

            // Xóa các dòng hiện có trong DataGridView
            Load_Invoice.Rows.Clear();

            // Hiển thị kết quả tìm kiếm
            foreach (var invoice in invoices)
            {
                Load_Invoice.Rows.Add(invoice.MaHoaDon, invoice.TenNhanVienLap, invoice.HoTenKhachHang, invoice.ThoiGianLap.ToString("dd/MM/yyyy"), invoice.TongTien);
            }

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewStaff staff = new viewStaff();
            staff.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewFood viewFood = new viewFood(); 
            viewFood.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewID_Card viewID_Card = new viewID_Card();
            viewID_Card.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            branch_revenue brand = new branch_revenue(Branch.MaChiNhanh);
            brand.Show();

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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brand branch = new Brand(Branch.MaChiNhanh);
            branch.Show();
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ControlMini_Click_1(object sender, EventArgs e)
        {

        }

        private void ControlMax_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Logout(); // Call the logout method
            }
        }

        private void Logout()
        {
            Branch.MaChiNhanh = null; // Xóa dữ liệu phiên
            Sushi_Restaurant.Chi_Nhanh.Login loginForm = new Sushi_Restaurant.Chi_Nhanh.Login(); // Sử dụng không gian tên đầy đủ
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
                e.Cancel = true; // Prevent closing
            }
        }
    }
}
