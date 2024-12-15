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
    public partial class viewEnvoice : SampleView
    {
        public viewEnvoice()
        {
            InitializeComponent();
        }

        public override void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        public override void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void viewEnvoice_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       private void comboBoxTimKiemTheo_SelectedIndexChanged(object sender, EventArgs e)
       {
            if (comboBoxTimKiemTheo.SelectedItem.ToString() == "Ngày lập đơn") {
                txtTimKiem.Visible = false; // Ẩn TextBox Mã Khách Hàng
                label1.Visible = false;
                dtpNgayLap.Visible = true;      // Hiển thị DateTimePicker Ngày Lập
                labSearch.Visible = true;
            }
            else if (comboBoxTimKiemTheo.SelectedItem.ToString() == "Mã khách hàng") {
                dtpNgayLap.Visible = false;     // Ẩn DateTimePicker Ngày Lập
                labSearch.Visible = false;
                txtTimKiem.Visible = true; // Hiển thị TextBox Mã Khách Hàng
                label1.Visible = true;
            }
       }



        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    // Lấy giá trị từ giao diện người dùng
        //    string ngayLap = null;
        //    string maKhachHang = null;

        //    // Kiểm tra điều kiện ComboBox và lấy giá trị phù hợp
        //    if (comboBoxTimKiemTheo.SelectedItem?.ToString() == "Ngày lập đơn")
        //    {
        //        ngayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd"); // Lấy giá trị từ DateTimePicker
        //    }
        //    else if (comboBoxTimKiemTheo.SelectedItem?.ToString() == "Mã khách hàng")
        //    {
        //        maKhachHang = txtTimKiem.Text.Trim(); // Lấy giá trị từ TextBox
        //    }

        //    // Gọi hàm TimKiemHoaDon từ lớp Branch
        //    DataTable result = Branch.TimKiemHoaDon(ngayLap, maKhachHang);

        //    // Hiển thị kết quả lên DataGridView
        //    if (result != null && result.Rows.Count > 0)
        //    {
        //        gridEnvoice.AutoGenerateColumns = true;
        //        gridEnvoice.DataSource = result;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        gridEnvoice.DataSource = null;
        //    }
        //}

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ngayLap = null;
            string maKhachHang = null;

            if (comboBoxTimKiemTheo.SelectedItem?.ToString() == "Tìm kiếm theo ngày lập")
            {
                ngayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");
            }
            else if (comboBoxTimKiemTheo.SelectedItem?.ToString() == "Tìm kiếm theo mã khách hàng")
            {
                maKhachHang = txtTimKiem.Text.Trim();
            }

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                SqlCommand cmd = new SqlCommand("SP_TimKiemHoaDon", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@NgayLap", string.IsNullOrEmpty(ngayLap) ? (object)DBNull.Value : ngayLap);
                cmd.Parameters.AddWithValue("@MaKhachHang", string.IsNullOrEmpty(maKhachHang) ? (object)DBNull.Value : maKhachHang);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Phần 1: Đọc dữ liệu hóa đơn chính
                    if (reader.Read())
                    {
                        texEnvID.Text = reader["Mã hoá đơn"].ToString();
                        texBranchID.Text = reader["Tên nhân viên lập"].ToString();
                        guna2TextBox1.Text = reader["Mã khách hàng"].ToString();
                        boxCustomName.Text = reader["Tên khách hàng"].ToString();
                        dtpNgayLap.Value = Convert.ToDateTime(reader["Ngày lập"]);
                        boxTypeBuy.Text = reader["Hình thức mua hàng"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        return;
                    }

                    // Phần 2: Đọc dữ liệu chi tiết món ăn
                    if (reader.NextResult()) // Chuyển sang tập kết quả thứ hai
                    {
                        DataTable chiTietMon = new DataTable();
                        chiTietMon.Load(reader);
                        gridEnvoice.DataSource = chiTietMon;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        // Hàm xóa sạch giao diện
        private void ClearFields()
        {
            texEnvID.Clear();
            texBranchID.Clear();
            guna2TextBox1.Clear();
            boxCustomName.Clear();
            boxTypeBuy.Clear();
            dtpNgayLap.Value = DateTime.Now;
            gridEnvoice.DataSource = null;
        }


    }
}
