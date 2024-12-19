using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sushi_Restaurant.Admin
{
    public partial class Add_Employee : Form
    {
        private string connectionString = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;"; // Chuỗi kết nối CSDL
        public event Action Add_Completed;
        public Add_Employee()
        {
            InitializeComponent();
            LoadTenBoPhan(); // Tải danh sách bộ phận khi khởi động form
            LoadBranches(); // Tải danh sách
        }
        private void LoadBranches()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaChiNhanh FROM CHI_NHANH"; // Lấy cả mã và tên chi nhánh
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        ComboBoxBranch.Items.Clear(); // Xóa các mục cũ trong ComboBox
                        while (reader.Read())
                        {
                            // Thêm tên chi nhánh vào ComboBox
                            ComboBoxBranch.Items.Add(reader["MaChiNhanh"].ToString());
                         
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        
        private void Add_Employee_Load(object sender, EventArgs e)
        {
            // Có thể thực hiện các hành động khác khi form được tải
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            AddNewEmployee(); // Gọi phương thức thêm nhân viên mới
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện thay đổi mã nhân viên nếu cần
        }

        private void texName_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện thay đổi tên nhân viên nếu cần
        }

        private void AddNewEmployee()
        {
            // Kiểm tra xem tất cả các trường thông tin đã được điền đầy đủ chưa
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.");
                txtID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(texName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên.");
                texName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(texAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.");
                texAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(texPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                texPhone.Focus();
                return;
            }

            if (texRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bộ phận.");
                texRole.Focus();
                return;
            }

            // Lấy mã chi nhánh đã chọn
            var selectedBranch = ComboBoxBranch.SelectedItem;
            if (selectedBranch == null)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh.");
                ComboBoxBranch.Focus();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ThemNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNhanVien", txtID.Text.Trim());
                    cmd.Parameters.AddWithValue("@HoTen", texName.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgaySinh", guna2DateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", guna2RadioButton1.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@DiaChi", texAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@SoDienThoai", texPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaBoPhan", GetMaBoPhan(texRole.Text.Trim()));
                    cmd.Parameters.AddWithValue("@MaChiNhanh", selectedBranch); // Thêm mã chi nhánh vào tham số

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!");
                    Add_Completed?.Invoke();
                    this.Close(); // Đóng form sau khi thêm thành công
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
            // Xử lý sự kiện thay đổi địa chỉ nếu cần
        }

        private void ComboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}