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
    public partial class PhieuDatTrucTiep : Form
    {
        public PhieuDatTrucTiep()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DateTime date = DateTime.Now;
        public string MainID = "";
        private void btnLuu_Click(object sender, EventArgs e)
        {

            
            using (SqlConnection con = new SqlConnection(MainClass.con_string))
            {
                try
                {
                    // Mở kết nối
                    con.Open();

                    // Tạo SqlCommand và chỉ định Stored Procedure
                    using (SqlCommand cmd = new SqlCommand("sp_ThemPhieuDatTrucTiep", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho procedure
                        cmd.Parameters.AddWithValue("@MaPhieu", txtMaphieu.Text);
                        cmd.Parameters.AddWithValue("@SoBan", int.Parse(txtSoBan.Text));
                        cmd.Parameters.AddWithValue("@NgayLap", guna2DateTimePicker1.Value.Date);
                        //cmd.Parameters.AddWithValue("@NhanVienLap", txtNhanvien.Text);

                        // Thực thi lệnh
                        cmd.ExecuteNonQuery();

                        // Thông báo lưu thành công
                        MessageBox.Show("Lưu thành công!");
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi nếu có
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private string LayMaPDTiepTheo()
        {
            string nextId = "";

            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.LayMaPDTiepTheo()", con))
                    {
                        nextId = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã hóa đơn: " + ex.Message);
            }
            MainID = nextId;

            return nextId;
        }

        private void txtSoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép số và phím xóa (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSoBan_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoBan.Text, out int soBan))
            {
                if (soBan < 1 || soBan > 100)
                {
                    MessageBox.Show("Số bàn phải từ 1 đến 100!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoBan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoBan.Focus();
            }
        }



        private void PhieuDatTrucTiep_Load(object sender, EventArgs e)
        {
            txtMaphieu.Text = LayMaPDTiepTheo();
            guna2DateTimePicker1.Value = date;

        }

    }
}
