using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class addFood : SampleAdd
    {
        // Chuỗi kết nối với cơ sở dữ liệu
        public static readonly string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;";

        public addFood()
        {
            InitializeComponent();
            this.Load += addFood_Load;
        }

        private void addFood_Load(object sender, EventArgs e)
        {
            // Tải danh sách mục vào ComboBox khi form được tải
            LoadRoles();
        }

        private void LoadRoles()
        {
            // Truy vấn SQL
            string query = @"
                SELECT M.TenMuc
                FROM MUC M";

            try
            {
                using (SqlConnection conn = new SqlConnection(con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            textRole.Items.Clear(); // Xóa dữ liệu cũ trong ComboBox
                            while (reader.Read())
                            {
                                textRole.Items.Add(reader["TenMuc"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        public override void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường dữ liệu có được nhập đầy đủ không
            if (string.IsNullOrWhiteSpace(texName.Text) ||
                string.IsNullOrWhiteSpace(texID.Text) ||
                string.IsNullOrWhiteSpace(texMark.Text) ||
                textRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra giá trị giá có hợp lệ không
            if (!int.TryParse(texMark.Text, out int gia)) // Chuyển đổi sang kiểu int
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy dữ liệu từ các trường
            string maMonAn = texID.Text.Trim();
            string tenMonAn = texName.Text.Trim();
            string tenMuc = textRole.SelectedItem.ToString();
            int giaoMon = guna2RadioButton1.Checked ? 1 : 0; // 1 = Có, 0 = Không

            string storedProcedure = "sp_ThemMonAn";

            try
            {
                using (SqlConnection conn = new SqlConnection(con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số vào thủ tục
                        cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
                        cmd.Parameters.AddWithValue("@TenMonAn", tenMonAn);
                        cmd.Parameters.AddWithValue("@GiaHienTai", gia); // Sử dụng giá kiểu int
                        cmd.Parameters.AddWithValue("@TenMuc", tenMuc);
                        cmd.Parameters.AddWithValue("@GiaoMon", giaoMon);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới các trường nhập liệu
                texName.Text = "";
                texID.Text = "";
                texMark.Text = ""; // Đặt lại giá
                textRole.SelectedIndex = -1;
                guna2RadioButton1.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void btnDong_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }

        private void tex_CheckedChanged(object sender, EventArgs e)
        {
            // Có thể thêm logic xử lý nếu cần thiết
        }

        private void textRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể thêm logic xử lý nếu cần thiết khi chọn một mục trong ComboBox
        }

        private void texName_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi text box tên thay đổi
        }

        private void texID_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi text box ID thay đổi
        }

        private void textMark_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi text box mark thay đổi
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi radio button thay đổi
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi radio button thay đổi
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Đóng ứng dụng
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thực hiện hành động nào đó
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thực hiện hành động nào đó
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thực hiện hành động nào đó
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thực hiện hành động nào đó
        }

        private void addFood_Load_1(object sender, EventArgs e)
        {

        }
    }
}