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
        private string trangThai;
        public xemLaiGiaoHangView(string maDonHang, string trangThai)
        {
            InitializeComponent();
            this.maDonHang = maDonHang;
            this.trangThai = trangThai;

            text_tenKH.Text = GlobalVariables.HoTenKH;
            text_SDT.Text = GlobalVariables.SDTKH;
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

                    using (SqlCommand cmd = new SqlCommand("sp_LayThongTinGiaoHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPhieu", maDonHang);

                        // Thêm tham số output
                        SqlParameter tongTienParam = new SqlParameter("@TongTien", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(tongTienParam);

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
                        // Kiểm tra trạng thái và hiển thị tổng tiền
                        if (this.trangThai == "Chờ xử lý")
                        {
                            label_thanhTien.Visible = false;
                            value_thanhTien.Visible = false;
                        }
                        else if (this.trangThai == "Đã xác nhận" || this.trangThai == "Đã giao")
                        {
                            int tongTien = Convert.ToInt32(tongTienParam.Value);

                            value_thanhTien.Text = tongTien.ToString("N0", GlobalVariables.AppCultureInfo) + " VND";
                            label_thanhTien.Visible = true;
                            value_thanhTien.Visible = true;
                        }
                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin giao hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ControlBoxThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_dat_hang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
