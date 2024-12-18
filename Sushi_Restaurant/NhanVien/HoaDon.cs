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
       
        DateTime date = new DateTime(2024, 7, 30);

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            guna2DataGridView1.AutoGenerateColumns = false;

            using (SqlConnection con = new SqlConnection(MainClass.con_string))
            {
                try
                {
                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("sp_LayDSHoaDon", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@NgayLap", date);
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
                string qry = @"SELECT * 
                FROM HOA_DON HD 
                JOIN PHIEU_DAT_MON PD ON PD.MaPhieu = HD.MaPhieuDatMon
                JOIN CHI_TIET_DAT_MON CT ON CT.MaPhieu=PD.MaPhieu
                JOIN MON_AN MA ON MA.MaMonAn=CT.MaMonAn
                WHERE HD.MaHoaDon = @MaHoaDon"; // Sử dụng parameter";

                SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
                MainClass.con.Open();
                cmd2.Parameters.AddWithValue("@MaHoaDon", MaHD);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(dt);
                MainClass.con.Close();


                //frmPrint frm = new frmPrint();
                //MainClass.CurMaHD = MaHD;
                //rptHoadon rpt = new rptHoadon();
                //rpt.SetDataSource(dt); // Không cần gọi rpt.SetDatabaseLogon cho Windows Authentication
                //frm.crystalReportViewer1.ReportSource = rpt;
                //frm.crystalReportViewer1.Refresh();
                //frm.Show();

            }
        }
    }
}