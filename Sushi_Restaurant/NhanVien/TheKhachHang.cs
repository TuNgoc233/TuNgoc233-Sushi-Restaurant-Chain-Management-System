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

namespace Sushi_Restaurant.NhanVien
{
    public partial class TheKhachHang : Form
    {
        public TheKhachHang()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length != 10 || !txtTimKiem.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 ký tự và chỉ chứa số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early if the phone number is invalid
            }

            using (SqlConnection conn = new SqlConnection(MainClass.con_string))
            {
                SqlCommand cmd = new SqlCommand("usp_TimKiemKhachHangCoThe", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SoDienThoai", txtTimKiem.Text); // txtTimKiem là textbox nhập số điện thoại

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                string soDienThoai = txtTimKiem.Text; // The phone number entered by the user
                if (reader.Read())
                {
                    int result = reader.GetInt32(0); // Lấy giá trị KQ (0: không tồn tại, 1: tạo thẻ, 2: đã có thẻ)

                    if (result == 0)
                    {
                        // Show a MessageBox asking whether to open the "ThemTheKhachHang" form
                        DialogResult dialogResult = MessageBox.Show("Khách hàng không tồn tại. Bạn có muốn thêm thẻ khách hàng mới?",
                                                                   "Thông báo",
                                                                   MessageBoxButtons.YesNo,
                                                                   MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Close();
                            // If the user clicks Yes, open the "ThemTheKhachHang" form
                            ThemTheKhachHang frmThemThe = new ThemTheKhachHang();
                            frmThemThe.SoDienThoai = soDienThoai;
                            frmThemThe.ShowDialog(); // Use ShowDialog to open it as a modal form
                        }
                    }
                    else if (result == 1)
                    {
                        string maKhachHang = reader.GetString(1); // Retrieve the customer code as a string
                        DialogResult dialogResult = MessageBox.Show("Khách hàng đã tồn tại nhưng chưa có thẻ thành viên. Bạn có muốn thêm thẻ khách hàng mới?",
                                                                   "Thông báo",
                                                                   MessageBoxButtons.YesNo,
                                                                   MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Close();
                            ThemTheKhachHang_1 frmThemThe = new ThemTheKhachHang_1();
                            frmThemThe.MaKhachHang = maKhachHang;
                            frmThemThe.StartPosition = FormStartPosition.CenterScreen;
                            frmThemThe.ShowDialog(); // Open it as a modal form
                        }
                    }
                    else if (result == 2)
                    {
                        // Hỏi người dùng có muốn đóng thẻ hiện tại hay không
                        DialogResult dialogResult = MessageBox.Show("Khách hàng đã có thẻ thành viên. Bạn có muốn đóng thẻ hiện tại không?",
                                                                   "Thông báo",
                                                                   MessageBoxButtons.YesNo,
                                                                   MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Close();
                            // Giả sử bạn đã lấy được mã thẻ từ kết quả của stored procedure tìm kiếm
                            string maSoThe = reader.GetString(1); // Gán giá trị mã thẻ từ kết quả trước

                            // Đóng DataReader trước khi tiếp tục
                            if (!reader.IsClosed)
                            {
                                reader.Close(); // Đóng reader để giải phóng connection
                            }

                            // Thực hiện đóng thẻ (gọi stored procedure để cập nhật trạng thái thẻ)
                            using (SqlCommand cmdDongThe = new SqlCommand("usp_DongTheKhachHang", conn))
                            {
                                cmdDongThe.CommandType = CommandType.StoredProcedure;
                                cmdDongThe.Parameters.AddWithValue("@MaSoThe", maSoThe); // Truyền mã thẻ vào

                                try
                                {
                                    // Thực thi stored procedure
                                    int rowsAffected = cmdDongThe.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Thẻ thành viên đã được đóng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Đóng thẻ không thành công. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }

                }
            }
        }


    }
}
