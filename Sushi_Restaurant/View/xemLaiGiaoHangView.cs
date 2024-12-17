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
    public partial class xemLaiGiaoHangView : Form
    {
        private string maDonHang;
        public xemLaiGiaoHangView(string maDonHang, string trangThai)
        {
            InitializeComponent();
            this.maDonHang = maDonHang;

            text_tenKH.Text = GlobalVariables.HoTenKH;
            text_SDT.Text = GlobalVariables.SDTKH;
        }

        private void but_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xemLaiGiaoHangView_Load(object sender, EventArgs e)
        {
            LoadThongTinGiaoHang(maDonHang);
        }

        private void LoadThongTinGiaoHang(string maDonHang)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("NXHanh_LayThongTinGiaoHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhieu", maDonHang);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        // Gán dữ liệu vào controls
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = ds.Tables[0].Rows[0];
                            text_ngayDat.Text = Convert.ToDateTime(row["NgayDatHang"]).ToString("dd-MM-yyyy");
                            text_ngayGiao.Text = Convert.ToDateTime(row["NgayGiaoHang"]).ToString("dd-MM-yyyy");
                            text_gioGiao.Text = row["GioGiaoHang"].ToString();
                            text_diaChiGiao.Text = row["DiaChiGiao"].ToString();
                            text_thanhToan.Text = row["HinhThucThanhToan"].ToString();
                        }

                        // Hiển thị danh sách món ăn
                        if (ds.Tables.Count > 1)
                        {
                            panel_dat_hang.AutoGenerateColumns = false;
                            panel_dat_hang.DataSource = ds.Tables[1];
                        }

                      
                        value_tongTien.Text = string.Format("{0:N0} VNĐ", ds.Tables[2].Rows[0]["TongTien"]);
                     
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin giao hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_TTV_Click(object sender, EventArgs e)
        {

        }
    }
}
