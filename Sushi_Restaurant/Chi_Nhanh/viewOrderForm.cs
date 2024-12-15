using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
