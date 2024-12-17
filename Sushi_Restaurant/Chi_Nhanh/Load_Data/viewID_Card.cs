using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class viewID_Card : SampleView
    {
        public viewID_Card()
        {
            InitializeComponent();
            this.Load += new EventHandler(viewID_Card_Load); // Đăng ký sự kiện Load
        }

        private void viewID_Card_Load(object sender, EventArgs e)
        {
            // Lấy mã chi nhánh từ thuộc tính của lớp Branch
            string branchID = Branch.MaChiNhanh;

            // Kiểm tra mã chi nhánh có hợp lệ hay không
            if (string.IsNullOrEmpty(branchID))
            {
                MessageBox.Show("Mã chi nhánh không hợp lệ hoặc chưa được xác định.");
                return;
            }

            // Lấy danh sách thẻ khách hàng từ stored procedure
            List<CustomerCard> Card = CustomerCard.LoadCustomerCardsFromProcedure(branchID);

            // Kiểm tra danh sách thẻ khách hàng có dữ liệu không
            if (Card == null || Card.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thẻ khách hàng nào để hiển thị.");
                return;
            }

            // Thiết lập DataGridView
            DataLoad.Rows.Clear(); // Xóa các dòng cũ nếu có

            // Lặp qua danh sách thẻ khách hàng và thêm vào DataGridView
            foreach (var card in Card)
            {
                // Thêm một dòng mới vào DataGridView
                DataLoad.Rows.Add(
                    card.MaSoThe,
                    card.LoaiThe,
                    card.TongDiemTichLuy,
                    card.NgayLap.ToString("dd/MM/yyyy"), // Định dạng ngày
                    card.HoTenKhachHang,
                    card.HoTenNhanVien
                );
            }
        }

        public override void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text.Trim(); // Lấy chuỗi tìm kiếm từ TextBox
            string branchID = Branch.MaChiNhanh; // Lấy mã chi nhánh từ lớp Branch

            // Gọi phương thức tìm kiếm thẻ khách hàng
            List<CustomerCard> customerCards = CustomerCard.SearchCustomerCards(searchTerm, branchID);

            // Xóa các dòng hiện có trong DataGridView
            DataLoad.Rows.Clear();

            // Hiển thị kết quả tìm kiếm
            foreach (var card in customerCards)
            {
                DataLoad.Rows.Add(
                    card.MaSoThe,
                    card.LoaiThe,
                    card.TongDiemTichLuy,
                    card.NgayLap.ToString("dd/MM/yyyy"),
                    card.HoTenKhachHang,
                    card.HoTenNhanVien
                );
            }

        }
        private void icon_Delete_click(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có chọn một hàng không
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.");
                return;
            }

            // Lấy thông tin từ hàng được chọn
            string maSoThe = DataLoad.Rows[e.RowIndex].Cells[0].Value.ToString(); // Nếu "Mã số thẻ" là cột đầu tiên
            string maChiNhanh = Branch.MaChiNhanh;

            // Xác nhận trước khi xóa
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thẻ này không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Gọi phương thức xóa thẻ
                XoaThe(maChiNhanh, maSoThe);
            }
        }

        private void XoaThe(string maChiNhanh, string maSoThe)
        {
            // Kết nối đến cơ sở dữ liệu
            string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;";

            using (SqlConnection connection = new SqlConnection(con_string))
            {
                using (SqlCommand command = new SqlCommand("SP_XoaMotTheThanhVien", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số
                    command.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);
                    command.Parameters.AddWithValue("@MaSoThe", maSoThe);

                    try
                    {
                        // Mở kết nối
                        connection.Open();

                        // Thực thi thủ tục
                        command.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Xóa thẻ thành công.");

                        // Cập nhật lại DataGridView
                        viewID_Card_Load(this, EventArgs.Empty); // Gọi lại phương thức Load
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                    }
                }
            }
        }
        
        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
