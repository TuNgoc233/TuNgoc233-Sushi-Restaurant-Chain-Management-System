using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sushi_Restaurant.Admin
{
    public partial class UpdateSalary_Employeee : Form
    {
        private string connectionString = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_; Trusted_Connection=True; Connection Timeout=120;";

        public UpdateSalary_Employeee()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadTenBoPhan(); // Tải danh sách bộ phận khi khởi động form
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
                        Combox_.Items.Clear(); // Sử dụng Guna2ComboBox
                        while (reader.Read())
                        {
                            Combox_.Items.Add(reader["TenBoPhan"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void UpdateSalaryForDepartment(string departmentName, decimal newSalary)
        {
           

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE BO_PHAN SET MucLuong = @NewSalary WHERE TenBoPhan = @DepartmentName";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewSalary", newSalary);
                        cmd.Parameters.AddWithValue("@DepartmentName", departmentName);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật lương thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bộ phận để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật lương: " + ex.Message);
                }
            }
        }


        private void Combox__SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            // Lấy tên bộ phận đã chọn từ ComboBox
            string selectedDepartment = Combox_.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedDepartment))
            {
                MessageBox.Show("Vui lòng chọn một bộ phận.");
                return;
            }

            // Kiểm tra và lấy lương mới từ TextBox
            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Vui lòng nhập lương mới.");
                return;
            }

          
            if (!decimal.TryParse(txtRole.Text, out decimal newSalary) || newSalary <= 5000000|| newSalary > 40000000)
            {
                MessageBox.Show("Mức lương không hợp lệ. Mức lương phải nằm trong khoảng từ 5 triệu đến 40 triệu.");
                return;
            }

            // Cập nhật lương cho bộ phận đã chọn
            UpdateSalaryForDepartment(selectedDepartment, newSalary);
            this.Close();
        }


        private void UpdateSalary_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}