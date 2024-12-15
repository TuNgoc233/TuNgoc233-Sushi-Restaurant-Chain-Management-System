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
    public partial class viewOrderForm : SampleView
    {
        public viewOrderForm()
        {
            InitializeComponent();
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
                Load_Invoice.Rows.Add(invoice.MaHoaDon, invoice.TenNhanVienLap, invoice.HoTenKhachHang, invoice.ThoiGianLap.ToString("dd/MM/yyyy"), invoice.TongTien);
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
                // Thêm một dòng mới vào DataGridView
                Load_Invoice.Rows.Add(invoice.MaHoaDon, invoice.TenNhanVienLap, invoice.HoTenKhachHang, invoice.ThoiGianLap.ToString("dd/MM/yyyy"), invoice.TongTien);
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
    }
}
