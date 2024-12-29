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

namespace Sushi_Restaurant.View
{
    public partial class CapNhatThongTinView : Form
    {
        // Biến tạm để lưu trữ thông tin ban đầu
        private string _fullName, _idNumber, _email, _phoneNumber, _password, _gender, _membershipType, _totalPoints;
        public CapNhatThongTinView()
        {
            InitializeComponent();
        }

        private void but_edit_FullName_Click(object sender, EventArgs e)
        {
            text_User.Enabled = true;
            text_User.Focus();
        }

        private void text_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_User.Enabled = false;
                e.SuppressKeyPress = true;
            }

        }

        private void but_edit_CCCD_Click(object sender, EventArgs e)
        {
            text_CCCD.Enabled = true;
            text_CCCD.Focus();
        }

        private void text_CCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_CCCD.Enabled = false;
                e.SuppressKeyPress = true;
            }
        }

        private void but_edit_Email_Click(object sender, EventArgs e)
        {
            text_email.Enabled = true;
            text_email.Focus();
        }

        private void text_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_email.Enabled = false;
                e.SuppressKeyPress = true;
            }
        }

        private void but_edit_SDT_Click(object sender, EventArgs e)
        {
            text_SDT.Enabled = true;
            text_SDT.Focus();
        }

        private void text_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_SDT.Enabled = false;
                e.SuppressKeyPress = true;
            }
        }

        private void CapNhatThongTinView_Load(object sender, EventArgs e)
        {
            LoadInitialData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin có thay đổi không
            if (IsInformationUnchanged())
            {
                MessageBox.Show("Bạn chưa chỉnh sửa thông tin nào!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện cập nhật thông tin
            if (UpdateCustomerInfo())
            {
                // Lưu thông tin mới vào các biến tạm
                _fullName = text_User.Text.Trim();
                _email = text_email.Text.Trim();
                _phoneNumber = text_SDT.Text.Trim();
                _password = text_pass.Text.Trim();
                _gender = text_gioiTinh.SelectedItem.ToString();

                MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsInformationUnchanged()
        {
            return text_User.Text.Trim() == _fullName &&
                   text_email.Text.Trim() == _email &&
                   text_SDT.Text.Trim() == _phoneNumber &&
                   text_pass.Text.Trim() == _password &&
                   text_gioiTinh.Text.Trim() == _gender &&
                   text_CCCD.Text.Trim() == _idNumber;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //Hàm thực hiện gọi stored procedure để cập nhật thông tin
        private bool UpdateCustomerInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("NXHanh_CapNhatKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@MaKhachHang", GlobalVariables.MaKH);
                        cmd.Parameters.AddWithValue("@HoTen", text_User.Text.Trim());
                        cmd.Parameters.AddWithValue("@CCCD", text_CCCD.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", text_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@SoDienThoai", text_SDT.Text.Trim());
                        cmd.Parameters.AddWithValue("@MatKhau", text_pass.Text.Trim());
                        cmd.Parameters.AddWithValue("@GioiTinh", text_gioiTinh.SelectedItem.ToString());

                        // Thực thi stored procedure
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Nếu có ít nhất một dòng bị ảnh hưởng => thành công
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 50000) // Xử lý lỗi từ RAISERROR
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Xóa thông tin gây lỗi dựa trên thông báo lỗi
                if (ex.Message.Contains("Số điện thoại đã tồn tại"))
                {
                    text_SDT.Text = string.Empty;
                    text_SDT.Focus(); // Đưa con trỏ về ô TextBox
                }
                else if (ex.Message.Contains("Số CCCD đã tồn tại"))
                {
                    text_CCCD.Text = string.Empty;
                    text_CCCD.Focus(); // Đưa con trỏ về ô TextBox
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    


        private void but_pass_Click(object sender, EventArgs e)
        {
            text_pass.Enabled = true;
            text_pass.Focus();
        }

        private void text_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                text_pass.Enabled = false;
                e.SuppressKeyPress = true;
            }
        }

        private void but_edit_gioiTinh_Click(object sender, EventArgs e)
        {
            text_gioiTinh.Enabled = true;
        }

        private void LoadInitialData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    // Truy vấn lấy thông tin khách hàng dựa trên một điều kiện (ví dụ: ID khách hàng)
                    string query = @"SELECT 
                                        kh.HoTen, 
                                        kh.CCCD, 
                                        kh.Email, 
                                        kh.SoDienThoai, 
                                        kh.MatKhau, 
                                        kh.GioiTinh, 
                                        ttv.LoaiThe, 
                                        ttv.TongDiemTichLuy
                                    FROM KHACH_HANG kh
                                    LEFT JOIN THE_THANH_VIEN ttv ON kh.MaKhachHang = ttv.MaKhachHang
                                    WHERE kh.MaKhachHang = @MaKhachHang;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số MaKhachHang
                        cmd.Parameters.AddWithValue("@MaKhachHang", GlobalVariables.MaKH);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Đọc thông tin từ database và gán vào biến tạm
                                _fullName = reader["HoTen"].ToString();
                                _idNumber = reader["CCCD"].ToString();
                                _email = reader["Email"].ToString();
                                _phoneNumber = reader["SoDienThoai"].ToString();
                                _password = reader["MatKhau"].ToString();
                                _gender = reader["GioiTinh"].ToString();
                                // Kiểm tra thông tin thẻ thành viên
                                if (reader["LoaiThe"] == DBNull.Value)
                                {
                                    _membershipType = "Chưa đăng kí thẻ thành viên";
                                    label_TongTichLuy.Visible = false; // Ẩn label Tổng điểm tích lũy
                                    textBox_TongTichLuy.Visible = false; // Ẩn textbox Tổng điểm tích lũy
                                }
                                else
                                {
                                    _membershipType = reader["LoaiThe"].ToString();
                                    _totalPoints = reader["TongDiemTichLuy"].Equals(DBNull.Value)
                                    ? "0"
                                    : reader["TongDiemTichLuy"].ToString();

                                    textBox_TongTichLuy.Visible = true; // Hiện textbox Tổng điểm tích lũy
                                    textBox_TongTichLuy.Text = _totalPoints.ToString(); // Hiển thị tổng điểm tích lũy
                                }

                                // Hiển thị thông tin lên các TextBox và ComboBox
                                text_User.Text = _fullName;
                                text_email.Text = _email;
                                text_CCCD.Text = _idNumber;
                                text_SDT.Text = _phoneNumber;
                                text_pass.Text = _password;
                                text_gioiTinh.Text = _gender;
                                textbox_LoaiTTV.Text = _membershipType;
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    
}
