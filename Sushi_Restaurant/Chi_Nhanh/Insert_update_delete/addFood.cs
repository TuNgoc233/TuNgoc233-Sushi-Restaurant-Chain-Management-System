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

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class addFood : SampleAdd
    {
        public addFood()
        {
            //base.InitializeComponent();
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

        }

        public override void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void addStaff_Load(object sender, EventArgs e)
        {


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

        private void texID_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void texMark_TextChanged(object sender, EventArgs e)
        {
            // Xóa các mục hiện có trong texRole
            texRole.Items.Clear();

            // Truy vấn SQL để lấy tên mục
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
                    CN.MaChiNhanh = @MaChiNhanh"; // Sử dụng mã chi nhánh cụ thể

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Thay thế @MaChiNhanh bằng giá trị thực tế
                    cmd.Parameters.AddWithValue("@MaChiNhanh", Branch.MaChiNhanh); // Sử dụng mã chi nhánh tĩnh

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Chỉ lấy tên mục và thêm vào texRole
                            string menuItem = reader["TenMuc"].ToString(); // Lấy tên mục
                            texRole.Items.Add(menuItem); // Thêm tên mục vào texRole
                        }

                        // Kiểm tra xem có mục nào được thêm vào không
                        if (texRole.Items.Count == 0)
                        {
                            MessageBox.Show("Không có mục nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void texRole_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    // Xóa các mục hiện có trong texRole
        //    texRole.Items.Clear();

        //    // Truy vấn SQL để lấy tên mục
        //            string query = @"
        //        SELECT 
        //            M.TenMuc
        //        FROM 
        //            CHI_NHANH CN
        //        JOIN 
        //            THUC_DON_MUC TDM ON CN.MaThucDon = TDM.MaThucDon AND CN.ThanhPho = TDM.KhuVuc
        //        JOIN 
        //            MUC M ON TDM.MaMuc = M.MaMuc
        //        WHERE 
        //            CN.MaChiNhanh = @MaChiNhanh"; // Sử dụng mã chi nhánh cụ thể

        //    using (SqlConnection con = new SqlConnection(Branch.con_string))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            // Thay thế @MaChiNhanh bằng giá trị thực tế
        //            cmd.Parameters.AddWithValue("@MaChiNhanh", Branch.MaChiNhanh); // Sử dụng mã chi nhánh tĩnh

        //            try
        //            {
        //                con.Open();
        //                SqlDataReader reader = cmd.ExecuteReader();
        //                while (reader.Read())
        //                {
        //                    // Chỉ lấy tên mục và thêm vào texRole
        //                    string menuItem = reader["TenMuc"].ToString(); // Lấy tên mục
        //                    texRole.Items.Add(menuItem); // Thêm tên mục vào texRole
        //                }

        //                // Kiểm tra xem có mục nào được thêm vào không
        //                if (texRole.Items.Count == 0)
        //                {
        //                    MessageBox.Show("Không có mục nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}
    }
}
