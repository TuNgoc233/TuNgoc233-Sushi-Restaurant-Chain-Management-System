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
    public partial class FrmMonAnYeuThichView : Form
    {
        private DataTable monAnYeuThich = new DataTable();

        private DataTable allOrders = new DataTable();
        public FrmMonAnYeuThichView()
        {
            InitializeComponent();
            LoadMonAnYeuThich(GlobalVariables.MaKH);

            dataGridViewMonAn.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default; // Tắt theme
            dataGridViewMonAn.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 55, 89);
            dataGridViewMonAn.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold); // Chỉnh font
           
        }

        private void LoadMonAnYeuThich(string maKhachHang)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("NXHanh_LayMonAnYeuThichKH", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        monAnYeuThich.Clear();
                        da.Fill(monAnYeuThich);
                    }
                }

                if (!monAnYeuThich.Columns.Contains("STT"))
                {
                    DataColumn sttColumn = new DataColumn("STT", typeof(int));
                    monAnYeuThich.Columns.Add(sttColumn);
                    sttColumn.SetOrdinal(0); // Đặt cột STT ở vị trí đầu tiên
                }

                // Thêm cột hình ảnh vào DataTable
                if (!monAnYeuThich.Columns.Contains("Hình ảnh"))
                {
                    monAnYeuThich.Columns.Add("Hình ảnh", typeof(Image));
                }

                for (int i = 0; i < monAnYeuThich.Rows.Count; i++)
                {
                    monAnYeuThich.Rows[i]["STT"] = i + 1; // Gán số thứ tự
                    string productCode = monAnYeuThich.Rows[i]["Mã món ăn"].ToString(); // Lấy mã món ăn
                    monAnYeuThich.Rows[i]["Hình ảnh"] = ResizeImage(LoadImageFromResources(productCode), 150, 100); // Resize ảnh
                }

                dataGridViewMonAn.AutoGenerateColumns = false;

                // Gán dữ liệu cho DataGridView
                dataGridViewMonAn.DataSource = monAnYeuThich;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải món ăn yêu thích: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return resizedImage;
        }

        private Image LoadImageFromResources(string productCode)
        {
            try
            {
                // Truy xuất hình ảnh từ Resources bằng mã món ăn (key)
                var image = (Image)Properties.Resources.ResourceManager.GetObject(productCode);
                if (image != null)
                {
                    return image;
                }
                else
                {
                    return Properties.Resources.icon_login; // Hình ảnh mặc định
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load hình ảnh: {ex.Message}");
                return Properties.Resources.icon_login; // Hình ảnh mặc định nếu lỗi
            }
        }
    

        private void icon_Dat_Mon_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Kiểm tra xem cột được click có phải cột hình ảnh không (giả sử cột hình ảnh là cột cuối cùng)
                if (dataGridViewMonAn.Columns[e.ColumnIndex].Name == "butXoa")
                {
                    // Lấy mã món ăn từ dòng được click
                    string maMonAn = dataGridViewMonAn.Rows[e.RowIndex].Cells["maMon"].Value.ToString();

                    // Hiển thị xác nhận xóa
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này khỏi danh sách yêu thích?",
                                                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Gọi stored procedure xóa món ăn yêu thích
                        if (DeleteFavoriteItem(maMonAn))
                        {
                            // Xóa dòng khỏi DataGridView
                            dataGridViewMonAn.Rows.RemoveAt(e.RowIndex);

                            // Cập nhật lại số thứ tự
                            UpdateRowNumbers();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa món ăn. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool DeleteFavoriteItem(string maMonAn)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("NXHanh_XoaMonAnYeuThich", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số
                        cmd.Parameters.AddWithValue("@MaKhachHang", GlobalVariables.MaKH);
                        cmd.Parameters.AddWithValue("@MaMon", maMonAn);

                        // Thực thi stored procedure
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0; // Trả về true nếu xóa thành công
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void UpdateRowNumbers()
        {
            for (int i = 0; i < dataGridViewMonAn.Rows.Count; i++)
            {
                dataGridViewMonAn.Rows[i].Cells["STT"].Value = (i + 1).ToString(); // Cột STT là cột đầu tiên
            }
        }
    }
    
}
