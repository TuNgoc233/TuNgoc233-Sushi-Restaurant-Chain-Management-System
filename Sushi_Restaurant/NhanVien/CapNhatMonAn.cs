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
using static Guna.UI2.Native.WinApi;

namespace Sushi_Restaurant.NhanVien
{
    public partial class CapNhatMonAn : Form
    {
        public event Action DataUpdated;
        public CapNhatMonAn(string maMonAn, string tenMonAn, bool tinhTrang)
        {
            InitializeComponent();
            LoadComboBoxTinhTrang(); // Load dữ liệu vào ComboBox

            // Gán giá trị vào các TextBox
            txtmamonan.Text = maMonAn;
            txttenmonan.Text = tenMonAn;

            // Thiết lập giá trị mặc định cho ComboBox
            cbtinhtrangphucvu.SelectedValue = tinhTrang;
        }

        // Hàm load danh sách tình trạng phục vụ vào ComboBox
        private void LoadComboBoxTinhTrang()
        {
            // Tạo danh sách trạng thái (Key là tên hiển thị, Value là bool)
            var tinhTrangList = new List<KeyValuePair<string, bool>>()
        {
            new KeyValuePair<string, bool>("Đang phục vụ", true),
            new KeyValuePair<string, bool>("Ngưng phục vụ", false)
        };

            // Gán dữ liệu vào ComboBox
            cbtinhtrangphucvu.DataSource = tinhTrangList;
            cbtinhtrangphucvu.DisplayMember = "Key";   // Hiển thị tên trạng thái
            cbtinhtrangphucvu.ValueMember = "Value";   // Giá trị bool để xử lý
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string maChiNhanh = MainClass.user.MaChiNhanh; // Lấy mã chi nhánh từ user
                string maMonAn = txtmamonan.Text; // Lấy mã món ăn từ TextBox
                bool tinhTrang = (bool)cbtinhtrangphucvu.SelectedValue; // Giá trị true hoặc false từ ComboBox

                // Chuyển trạng thái thành 0 hoặc 1 để lưu vào DB
                int tinhTrangValue = tinhTrang ? 1 : 0;
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("UpdateTinhTrangPhucVu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho Stored Procedure
                        cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);
                        cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
                        cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);

                        // Thực thi Stored Procedure
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật tình trạng phục vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataUpdated?.Invoke();
                        this.Close(); // Đóng form
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
