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
    public partial class ThemDanhGia : Form
    {
        private string maHoaDon;
        
        public ThemDanhGia(string maHoaDon)
        {
            InitializeComponent();
            text_MaHD.Text = maHoaDon;
            this.maHoaDon = maHoaDon;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            // Kiểm tra các ComboBox không được để trống hoặc null
            if (cmb_monAn.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng đánh giá chất lượng món ăn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmb_giaCa.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng đánh giá về giá của các món ăn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string)) // Sử dụng chuỗi kết nối
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_TaoDanhGiaDichVu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số đầu vào cho stored procedure
                        cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                        cmd.Parameters.AddWithValue("@DiemChatLuongMonAn", int.Parse(cmb_monAn.SelectedItem.ToString()));
                        cmd.Parameters.AddWithValue("@DiemGiaCa", int.Parse(cmb_giaCa.SelectedItem.ToString()));

                        // Thêm tham số BinhLuan (nếu có)
                        string binhLuan = richBox_ghi_chu.Text.Trim();
                        if (string.IsNullOrEmpty(binhLuan))
                        {
                            cmd.Parameters.AddWithValue("@BinhLuan", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@BinhLuan", binhLuan);
                        }

                        // Thêm tham số OUTPUT để nhận kết quả
                        SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.Int);
                        resultParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(resultParam);

                        // Thực thi procedure
                        cmd.ExecuteNonQuery();

                        // Lấy giá trị OUTPUT
                        int result = (int)resultParam.Value;

                        if (result == 1)
                        {
                            MessageBox.Show("Đánh giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close(); // Đóng form
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi đánh giá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Đóng form sau khi đánh giá thành công
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
