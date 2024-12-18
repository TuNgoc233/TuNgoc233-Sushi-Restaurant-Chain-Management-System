using Sushi_Restaurant.Reports;
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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        public string MaHD = "";
        private void HoaDon_Load(object sender, EventArgs e)
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
                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("sp_LayDSHoaDon", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@NgayLap", MainClass.curDate);
                        cmd.Parameters.AddWithValue("@MaChiNhanh", MainClass.user.MaChiNhanh);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Gán DataTable vào DataGridView
                        guna2DataGridView1.DataSource = dt;

                        // Đặt DataPropertyName cho các cột
                        guna2DataGridView1.Columns["dgvId"].DataPropertyName = "MaHoaDon";
                        guna2DataGridView1.Columns["dgvType"].DataPropertyName = "Loai";
                        guna2DataGridView1.Columns["dgvTotal"].DataPropertyName = "TongTien";
                    }
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

            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvprint")
            {
                MaHD = guna2DataGridView1.CurrentRow.Cells["dgvId"].Value.ToString();
                try
                {
                    using (SqlConnection con = new SqlConnection(MainClass.con_string))
                    {
                        // Mở kết nối
                        con.Open();

                        // Tạo SqlCommand để gọi stored procedure
                        using (SqlCommand cmd = new SqlCommand("sp_InCTHoaDon", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Thêm tham số cho stored procedure
                            cmd.Parameters.AddWithValue("@MaHoaDon", MaHD);

                            // Thực thi và lấy dữ liệu
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // Kiểm tra nếu không có dữ liệu
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy dữ liệu cho hóa đơn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            // Hiển thị báo cáo Crystal Report
                            frmPrint frm = new frmPrint();
                            MainClass.CurMaHD = MaHD;
                            rptHoadon rpt = new rptHoadon();
                            rpt.SetDataSource(dt);

                            // Truyền tham số @MaHoaDon vào Crystal Report
                            rpt.SetParameterValue("@MaHoaDon", MaHD);

                            // Thiết lập report source và hiển thị
                            frm.crystalReportViewer1.ReportSource = rpt;
                            frm.crystalReportViewer1.Refresh();
                            frm.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
    }
}