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
            InitializeCustomButtons();
        }

        public override void btnLuu_Click(object sender, EventArgs e)
        {
            // Thực hiện các hành động khi nhấn nút "LƯU"
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
            // Có thể để trống hoặc thực hiện hành động nào đó
        }

        public override void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thực hiện hành động nào đó
        }

        private void addStaff_Load(object sender, EventArgs e)
        {
            // Có thể thực hiện các hành động khi form được tải
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thực hiện hành động nào đó
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi checkbox thay đổi
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi radio button thay đổi
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void texName_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi text box tên thay đổi
        }

        private void texID_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi text box ID thay đổi
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi radio button thay đổi
        }

        private void texMark_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi text box mark thay đổi
        }

        private void texRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Chuỗi kết nối với cơ sở dữ liệu
            string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;";

            // Truy vấn SQL
            string query = @"
                            SELECT 
                                M.TenMuc
                            FROM 
                                CHI_NHANH CN
                            JOIN 
                                THUC_DON_MUC TDM ON CN.MaThucDon = TDM.MaThucDon AND CN.ThanhPho = TDM.KhuVuc
                            JOIN 
                                MUC M ON TDM.MaMuc = M.MaMuc
                            WHERE 
                                CN.MaChiNhanh = @MaChiNhanh";

            // Giá trị tham số
            string maChiNhanh = "CN001"; // Thay bằng mã chi nhánh cụ thể

            try
            {
                using (SqlConnection conn = new SqlConnection(con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số cho truy vấn
                        cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);

                        // Đọc dữ liệu
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Xóa dữ liệu cũ trong ComboBox (nếu có)
                            textRole.Items.Clear();

                            // Đổ dữ liệu vào ComboBox
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}