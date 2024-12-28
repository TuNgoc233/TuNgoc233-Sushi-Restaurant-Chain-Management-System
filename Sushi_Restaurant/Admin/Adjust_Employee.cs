using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Sushi_Restaurant.Admin
{
    public partial class Adjust_Employee : Form
    {
        private string connectionString = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;";
        private string maNhanVien;
        public event Action Adjust_Completed;

        // Constructor
        public Adjust_Employee(string maNhanVien)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.maNhanVien = maNhanVien;
            LoadEmployeeData(maNhanVien);
            LoadTenBoPhan();
     
        }

     

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UpdateEmployee()
        {
            // Kiểm tra các trường thông tin
            if (string.IsNullOrWhiteSpace(texName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                return;
            }
            if (string.IsNullOrWhiteSpace(texAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.");
                return;
            }
            if (string.IsNullOrWhiteSpace(texPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                return;
            }
            if (texRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bộ phận.");
                return;
            }
            if (!guna2RadioButton1.Checked && !guna2RadioButton2.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                return;
            }

            // Lấy mã bộ phận từ tên bộ phận đã chọn
            string maBoPhan = GetMaBoPhan(texRole.SelectedItem.ToString());
            if (string.IsNullOrWhiteSpace(maBoPhan))
            {
                MessageBox.Show("Không tìm thấy mã bộ phận cho bộ phận đã chọn.");
                texRole.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_CapNhatNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                        cmd.Parameters.AddWithValue("@HoTen", texName.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgaySinh", guna2DateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", GetSelectedGender());
                        cmd.Parameters.AddWithValue("@DiaChi", texAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@SoDienThoai", texPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaBoPhan", maBoPhan); 

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                        Adjust_Completed?.Invoke();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật: " + ex.Message);
                return;
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

        private string GetSelectedGender()
        {
            return guna2RadioButton1.Checked ? "Nam" : "Nữ";
        }


        private void LoadEmployeeData(string maNhanVien)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
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
                        string gioiTinh = reader["GioiTinh"].ToString().Trim();
                        if (gioiTinh == "Nam")
                        {
                            guna2RadioButton1.Checked = true;
                        }
                        else
                        {
                            guna2RadioButton2.Checked = true;
                        }

                        texAddress.Text = reader["DiaChi"].ToString();
                        texPhone.Text = reader["SoDienThoai"].ToString();

                        // Chọn bộ phận hiện tại
                        string tenBoPhan = reader["TenBoPhan"].ToString();
                        LoadTenBoPhan();
                        texRole.SelectedItem = tenBoPhan;
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
                        texRole.Items.Clear(); // Xóa các mục cũ trong ComboBox
                        while (reader.Read())
                        {
                            texRole.Items.Add(reader["TenBoPhan"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void texAddress_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Adjust_Employee_Load(object sender, EventArgs e)
        {
            LoadTenBoPhan(); 
            LoadEmployeeData(maNhanVien); 
        }

        private void labBirth_Click(object sender, EventArgs e)
        {

        }

        private void texPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void labAddStaff_Click(object sender, EventArgs e)
        {

        }

        private void labGener_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void texRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = texRole.SelectedItem.ToString();
           
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
