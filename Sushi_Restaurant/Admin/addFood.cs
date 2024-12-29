using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class addFood : SampleAdd
    {
       
        public static readonly string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;";

        public addFood()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += addFood_Load;
            texID.Enabled = false; 
        }

        private void addFood_Load(object sender, EventArgs e)
        {
          
            LoadRoles();
            LoadNextFoodID(); 
        }

        private void LoadNextFoodID()
        {
            using (SqlConnection conn = new SqlConnection(con_string))
            {
                using (SqlCommand cmd = new SqlCommand("SP_LayMaMonAnTiepTheo", conn))
                {
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        texID.Text = result.ToString();
                    }
                }
            }
        }

        private void LoadRoles()
        {
          
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
                            textRole.Items.Clear();
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
          
            if (string.IsNullOrWhiteSpace(texName.Text) ||
                string.IsNullOrWhiteSpace(texID.Text) ||
                string.IsNullOrWhiteSpace(texMark.Text) ||
                textRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            if (!int.TryParse(texMark.Text, out int gia)) 
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string maMonAn = texID.Text.Trim();
            string tenMonAn = texName.Text.Trim();
            string tenMuc = textRole.SelectedItem.ToString();
            int giaoMon = guna2RadioButton1.Checked ? 1 : 0; 

            string storedProcedure = "sp_ThemMonAn";

            try
            {
                using (SqlConnection conn = new SqlConnection(con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                      
                        cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
                        cmd.Parameters.AddWithValue("@TenMonAn", tenMonAn);
                        cmd.Parameters.AddWithValue("@GiaHienTai", gia); 
                        cmd.Parameters.AddWithValue("@TenMuc", tenMuc);
                        cmd.Parameters.AddWithValue("@GiaoMon", giaoMon);

                        cmd.ExecuteNonQuery();
                    }
                }

               
                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
                texName.Text = "";
                texID.Text = "";
                texMark.Text = ""; 
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
            this.Close();
        }

        private void tex_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textRole_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void texName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void texID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textMark_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Đóng ứng dụng
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void addFood_Load_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}