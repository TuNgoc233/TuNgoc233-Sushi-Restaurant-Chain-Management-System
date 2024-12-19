//using Sushi_Restaurant.Reports;
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
    public partial class DsPhieuDatBan : Form
    {
        public DsPhieuDatBan()
        {
            InitializeComponent();
        }

        public string MaPhieu = "";
        DateTime date = DateTime.Now.Date;

        private void DSPhieuDatBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            guna2DataGridView1.AutoGenerateColumns = false;

            // Kết nối với cơ sở dữ liệu
            using (SqlConnection con = new SqlConnection(MainClass.con_string))
            {
                try
                {
                    // Gọi stored procedure
                    SqlCommand cmd = new SqlCommand("LayDsPhieuDatBan", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NgayLap", date);
                    cmd.Parameters.AddWithValue("@MaChiNhanh", MainClass.user.MaChiNhanh);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gán DataTable vào DataGridView
                    guna2DataGridView1.DataSource = dt;

                    // Đặt DataPropertyName cho các cột
                    guna2DataGridView1.Columns["dgvId"].DataPropertyName = "MaPhieu";
                    guna2DataGridView1.Columns["dgvCustomer"].DataPropertyName = "HoTen";
                    guna2DataGridView1.Columns["dgvNoCus"].DataPropertyName = "SoLuongKhach";
                    guna2DataGridView1.Columns["dgvStatus"].DataPropertyName = "DaLapHoaDon";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }


        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {   // Kiểm tra trạng thái "Đã lập hóa đơn"
                bool daLapHoaDon = Convert.ToBoolean(guna2DataGridView1.CurrentRow.Cells["dgvStatus"].Value);
                if (daLapHoaDon)
                {
                    MessageBox.Show("Phiếu đặt bàn này đã lập hóa đơn và không thể chỉnh sửa.");
                    return;
                }

                // Nếu chưa lập hóa đơn, cho phép chỉnh sửa
                MaPhieu = guna2DataGridView1.CurrentRow.Cells["dgvId"].Value.ToString();
                this.Close();
            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {

                // Lấy MaPhieu từ dòng hiện tại
                string maPhieu = guna2DataGridView1.CurrentRow.Cells["dgvId"].Value.ToString();

                // Hiển thị hộp thoại xác nhận xóa
                var result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa mục này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Tạo và mở kết nối SQL
                        using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                        {
                            conn.Open();

                            // Tạo SqlCommand để gọi Stored Procedure
                            using (SqlCommand cmd = new SqlCommand("sp_XoaPhieuDatMon", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                                

                                // Thực thi Stored Procedure
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Xóa dòng khỏi DataGridView sau khi xóa thành công trong database
                        guna2DataGridView1.Rows.RemoveAt(e.RowIndex);

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }

        }
    }
}
