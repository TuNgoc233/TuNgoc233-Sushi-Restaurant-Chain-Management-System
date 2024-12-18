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

namespace Sushi_Restaurant.Admin
{
    public partial class Adjust_Employee : SampleAdd
    {
        private string connectionString = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;"; // Thay thế bằng chuỗi kết nối của bạn
        private string maNhanVien;
        public event Action Adjust_Completed;

     

        // Constructor mới
        public Adjust_Employee(string maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien; // Gán mã nhân viên
            LoadEmployeeData(maNhanVien); // Tải dữ liệu nhân viên

        }

        private void UpdateEmployee()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_CapNhatNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@HoTen", texName.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgaySinh", guna2DateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", guna2RadioButton1.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@DiaChi", texAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@SoDienThoai", texPhone.Text.Trim());

                    // Lấy mã bộ phận từ tên bộ phận
                    string maBoPhan = GetMaBoPhan(texRole.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaBoPhan", maBoPhan); // Sửa lại tham số

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                    Adjust_Completed?.Invoke(); // Gọi sự kiện sau khi thành công
                    this.Close(); // Đóng form
                }
            }
        }
        private string GetMaBoPhan(string tenBoPhan)
        {
            string maBoPhan = string.Empty;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaBoPhan FROM BO_PHAN WHERE TenBoPhan = @TenBoPhan";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenBoPhan", tenBoPhan);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        maBoPhan = reader["MaBoPhan"].ToString();
                    }
                }
            }
            return maBoPhan;
        }
        private void LoadEmployeeData(string maNhanVien)
        {
            using (SqlConnection conn = new SqlConnection("Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;"))
            {
                string query = @"
            SELECT 
                NV.HoTen, 
                NV.NgaySinh, 
                NV.GioiTinh, 
                NV.DiaChi, 
                NV.SoDienThoai, 
                BP.TenBoPhan 
            FROM 
                NHAN_VIEN NV
            JOIN 
                BO_PHAN BP ON NV.MaBoPhan = BP.MaBoPhan 
            WHERE 
                NV.MaNhanVien = @MaNhanVien";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        texName.Text = reader["HoTen"].ToString();
                        guna2DateTimePicker1.Value = Convert.ToDateTime(reader["NgaySinh"]);
                        guna2RadioButton1.Checked = reader["GioiTinh"].ToString() == "Nam";
                        texAddress.Text = reader["DiaChi"].ToString();
                        texPhone.Text = reader["SoDienThoai"].ToString();
                        texRole.Text = reader["TenBoPhan"].ToString(); // Hiển thị tên bộ phận
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên.");
                    }
                }
            }
        }

        private void LoadTenBoPhan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TenBoPhan FROM BO_PHAN";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        texRole.Items.Clear();
                        while (reader.Read())
                        {
                            var tenBoPhan = reader["TenBoPhan"].ToString();
                            texRole.Items.Add(tenBoPhan);
                            //MessageBox.Show("Đã thêm bộ phận: " + tenBoPhan); // Kiểm tra
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        public override void btnLuu_Click(object sender, EventArgs e)
        {
            // Thực hiện các hành động khi nhấn nút "LƯU"
            UpdateEmployee();
            MessageBox.Show("Lưu thành công!");
        }

        // Phương thức xử lý sự kiện khi nhấn nút "ĐÓNG"
        public override void btnDong_Click(object sender, EventArgs e)
        {
            // Đóng cửa sổ hiện tại
            this.Close();
        }

        public override void label1_Click(object sender, EventArgs e)
        {

        }

        public override void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void addStaff_Load(object sender, EventArgs e)
        {
            LoadTenBoPhan(); // Tải danh sách bộ phận

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void texName_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void texRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Chuỗi kết nối với cơ sở dữ liệu
            //string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;";

            //// Truy vấn SQL
            //string query = "SELECT TenMuc FROM MUC";

            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(con_string))
            //    {
            //        conn.Open();
            //        using (SqlCommand cmd = new SqlCommand(query, conn))
            //        {
            //            // Đọc dữ liệu
            //            using (SqlDataReader reader = cmd.ExecuteReader())
            //            {
            //                texRole.Items.Clear(); // Xóa các mục hiện có trong ComboBox

            //                // Đổ dữ liệu vào ComboBox
            //                while (reader.Read())
            //                {
            //                    // Kiểm tra xem giá trị có null không trước khi thêm vào ComboBox
            //                    if (reader["TenMuc"] != DBNull.Value)
            //                    {
            //                        texRole.Items.Add(reader["TenMuc"].ToString());
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            //}
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
