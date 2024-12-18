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

namespace Sushi_Restaurant.NhanVien
{
    public partial class ThemDanhGia : Form
    {
        public ThemDanhGia()
        {
            InitializeComponent();
        }
        public string MaHD_DanhGia = "";

        public void btnLuu_Click(object sender, EventArgs e)
        {

            // Lấy giá trị từ các controls trên form
            string maHoaDon = MainClass.CurMaHD;
            int diemGiaCa = Convert.ToInt32(cmbDiemGiaCa.SelectedItem);
            int diemPhucVu = Convert.ToInt32(cmbDiemPhucVu.SelectedItem);
            int diemViTri = Convert.ToInt32(cmbDiemViTri.SelectedItem);
            int diemMonAn = Convert.ToInt32(cmbDiemMonAn.SelectedItem);
            string binhLuan = txtBinhLuan.Text;

            // Tạo kết nối và gọi Stored Procedure
            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TaoDanhGia", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho Stored Procedure
                        cmd.Parameters.AddWithValue("@MaHoaDon", MainClass.CurMaHD);
                        cmd.Parameters.AddWithValue("@DiemGiaCa", diemGiaCa);
                        cmd.Parameters.AddWithValue("@DiemPhucVu", diemPhucVu);
                        cmd.Parameters.AddWithValue("@DiemViTriChiNhanh", diemViTri);
                        cmd.Parameters.AddWithValue("@DiemChatLuongMonAn", diemMonAn);
                        cmd.Parameters.AddWithValue("@BinhLuan", binhLuan);

                        // Thực thi Stored Procedure
                        cmd.ExecuteNonQuery();

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Lưu đánh giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                MessageBox.Show("Lỗi khi lưu đánh giá: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KiemTraVaHienThiDanhGia()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();

                    // Gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("sp_KiemTraDanhGia", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHoaDon", MainClass.CurMaHD);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Hiển thị dữ liệu lên các controls
                                cmbDiemGiaCa.SelectedItem = reader["DiemGiaCa"].ToString();
                                cmbDiemPhucVu.SelectedItem = reader["DiemPhucVu"].ToString();
                                cmbDiemViTri.SelectedItem = reader["DiemViTriChiNhanh"].ToString();
                                cmbDiemMonAn.SelectedItem = reader["DiemChatLuongMonAn"].ToString();
                                txtBinhLuan.Text = reader["BinhLuan"].ToString();

                                // Ngăn không cho chỉnh sửa
                                cmbDiemGiaCa.Enabled = false;
                                cmbDiemPhucVu.Enabled = false;
                                cmbDiemViTri.Enabled = false;
                                cmbDiemMonAn.Enabled = false;
                                txtBinhLuan.ReadOnly = true;

                                // Vô hiệu hóa nút Lưu
                                btnLuu.Enabled = false;

                                MessageBox.Show("Hóa đơn này đã có đánh giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra đánh giá: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemDanhGia_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = MainClass.CurMaHD;
            KiemTraVaHienThiDanhGia();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
