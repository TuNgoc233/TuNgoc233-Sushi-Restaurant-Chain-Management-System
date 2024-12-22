using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sushi_Restaurant.Admin
{
    public partial class Adjust_Employee : SampleAdd
    {
        private string connectionString = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;"; // Chuỗi kết nối CSDL
        private string maNhanVien;
        public event Action Adjust_Completed;

        // Constructor
        public Adjust_Employee(string maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;
            LoadEmployeeData(maNhanVien);
        }

        // --- SỰ KIỆN UI ---
        public override void btnLuu_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
        }

        public override void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void label1_Click(object sender, EventArgs e) { }

        //public override void guna2PictureBox1_Click(object sender, EventArgs e) { }

        public void addStaff_Load(object sender, EventArgs e)
        {
            LoadTenBoPhan();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void texName_TextChanged(object sender, EventArgs e) { }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void texRole_SelectedIndexChanged(object sender, EventArgs e) { }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e) { }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e) { }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        // --- XỬ LÝ CƠ SỞ DỮ LIỆU ---

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

                    string maBoPhan = GetMaBoPhan(texRole.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaBoPhan", maBoPhan);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                    Adjust_Completed?.Invoke();
                    this.Close();
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
                        guna2RadioButton1.Checked = reader["GioiTinh"].ToString() == "Nam";
                        texAddress.Text = reader["DiaChi"].ToString();
                        texPhone.Text = reader["SoDienThoai"].ToString();
                        texRole.Text = reader["TenBoPhan"].ToString();
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
    }
}
