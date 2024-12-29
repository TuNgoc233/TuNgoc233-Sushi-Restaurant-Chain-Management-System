using Guna.UI2.WinForms;
using Sushi_Restaurant.Chi_Nhanh;
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
            this.StartPosition = FormStartPosition.CenterScreen;
            // Vô hiệu hóa Theme mặc định để toàn quyền điều chỉnh
            // Thiết lập font chữ cho Header
            this.DataLoad.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.DataLoad.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 16);

            // Thiết lập màu nền và màu chữ cho Header
            this.DataLoad.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 55, 89);
            this.DataLoad.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataLoad.EnableHeadersVisualStyles = false; // Bắt buộc phải tắt thuộc tính này để màu tùy chỉnh có hiệu lực

            // Tăng chiều cao Header
            this.DataLoad.ColumnHeadersHeight = 60;
            this.DataLoad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataLoad.RowTemplate.Height = 35; // Tăng chiều cao lên 50 (hoặc giá trị bạn muốn)
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
                    card.NgayCapNhat.ToString("dd/MM/yyyy"), // Định dạng ngày
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
                    card.NgayCapNhat.ToString("dd/MM/yyyy"),
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
            string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_; Trusted_Connection=True; Connection Timeout=120;";

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

        private void ThemThe(string maChiNhanh)
        {
            string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_; Trusted_Connection=True; Connection Timeout=120;";

            using (SqlConnection connection = new SqlConnection(con_string))
            {
                using (SqlCommand command = new SqlCommand("sp_CapNhatPhanHangKhachHang", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số
                    command.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);
                    try
                    {
                        // Mở kết nối
                        connection.Open();

                        // Thực thi thủ tục
                        command.ExecuteNonQuery();

                        // Thông báo cập nhật thành công
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void Btn_Update(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string maChiNhanh = Branch.MaChiNhanh;
            ThemThe(maChiNhanh);
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            branch_revenue brand = new branch_revenue(Branch.MaChiNhanh);
            brand.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewOrderForm oder = new viewOrderForm();
            oder.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewFood food = new viewFood();
            food.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            viewStaff staff = new viewStaff();
            staff.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
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
