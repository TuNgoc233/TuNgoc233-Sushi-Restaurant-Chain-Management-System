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
    public partial class xemLaiDatBanView : Form
    {
        private string maDonHang;
        private string maChiNhanh;

        public xemLaiDatBanView(string maDonHang, string trangThai)
        {
            InitializeComponent();

            this.maDonHang = maDonHang;

        }

        private void but_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xemLaiDatBanView_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");

            text_KH.Text = GlobalVariables.HoTenKH;
            text_SDT.Text = GlobalVariables.SDTKH;

            LoadThongTinDatBan(maDonHang);

            // Hiển thị thông tin chi nhánh
            DataTable ChiNhanhData;
            //lay du lieu tu ban tam
            ChiNhanhData = MainClass.Lay_Khu_Vuc_ChiNhanh_SDT();

            // Lay chi nhanh da chon
            string selectedChiNhanh = maChiNhanh;

            // Lọc thông tin địa chỉ chi nhánh từ DataTable
            var diaChiForChiNhanh = ChiNhanhData.AsEnumerable()
                .Where(row => row.Field<string>("MaChiNhanh") == selectedChiNhanh)
                .Select(row => new
                {
                    Duong = row.Field<string>("Duong"),
                    Phuong = row.Field<string>("Phuong"),
                    Quan = row.Field<string>("Quan"),
                    ThanhPho = row.Field<string>("ThanhPho")
                })
                .FirstOrDefault(); // Dùng FirstOrDefault để lấy 1 giá trị duy nhất (do 1 chi nhánh có 1 địa chỉ)

            // Kiểm tra nếu có thông tin chi nhánh
            if (diaChiForChiNhanh != null)
            {

                string tenDiaChiCN = $"{selectedChiNhanh} - {diaChiForChiNhanh.Duong} - {diaChiForChiNhanh.Phuong} - {diaChiForChiNhanh.Quan} - {diaChiForChiNhanh.ThanhPho}";
                text_dia_chi.Text = tenDiaChiCN;
            }
            else
            {
                // Nếu không tìm thấy thông tin địa chỉ, xóa nội dung TextBox hoặc hiển thị thông báo
               MessageBox.Show("Không tìm thấy thông tin chi nhánh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadThongTinDatBan(string maDonHang)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("NXHanh_LayThongTinDatBan", conn))
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
                            maChiNhanh = row["MaChiNhanh"].ToString();
                            text_ngayDen.Text = Convert.ToDateTime(row["NgayDen"]).ToString("dd-MM-yyyy");
                            text_GioDen.Text = row["GioDen"].ToString();
                            text_sl_KH.Text = row["SoLuongKhach"].ToString();
                            richBox_ghi_chu.Text = row["GhiChu"].ToString();
                            text_ngayDat.Text = Convert.ToDateTime(row["NgayDat"]).ToString("dd-MM-yyyy");
                        }

                        panel_list_mon.AutoGenerateColumns = false;
                        // Hiển thị danh sách món ăn
                        if (ds.Tables.Count > 1)
                        {
                            panel_list_mon.DataSource = ds.Tables[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin đặt bàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlBoxThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
