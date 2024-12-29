using Guna.UI2.WinForms;
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
    public partial class DatBanView : Form
    {
        public DatBanView()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.DatBanView_Load);
        }
        private void DatBanView_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");


            // Hiển thị thông tin chi nhánh
            text_dia_chi.Text = GlobalVariables.tenDiaChiCN;

            // Xóa các mục cũ trong ComboBox (nếu có)
            text_NgayDen.Items.Clear();

            // Thêm ngày hôm nay và ngày mai vào ComboBox
            text_NgayDen.Items.Add("Hôm nay - " + DateTime.Now.ToString("dd/MM/yyyy"));
            text_NgayDen.Items.Add("Ngày mai - " + DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"));


            text_sl_KH.Minimum = 1; 
            text_sl_KH.Maximum = 50; 

        }



        public string TenKhachHang
        {
            get => text_KH.Text;
            set => text_KH.Text = value;
        }

        public string SoDienThoai
        {
            get => text_SDT.Text;
            set => text_SDT.Text = value;
        }

        // Phương thức để thêm món ăn vào danh sách DataGridView
        public void AddMonAn(string maMon, string tenMon, int soLuong, double donGia, double thanhTien)
        {
            panel_list_mon.Rows.Add(new object[] {
            panel_list_mon.Rows.Count + 1, // STT
            maMon,
            tenMon,
            soLuong,
            donGia.ToString("N0", GlobalVariables.AppCultureInfo),
            thanhTien.ToString("N0", GlobalVariables.AppCultureInfo)
            });
        }

        private void but_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_datBan_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem khách hàng đã nhập đủ thông tin hay chưa
                if (string.IsNullOrWhiteSpace(text_NgayDen.Text))
                {
                    MessageBox.Show("Vui lòng chọn ngày đến.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(text_GioDat.Text))
                {
                    MessageBox.Show("Vui lòng chọn giờ đến.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (text_sl_KH.Value == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng khách hàng đến.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 1. Lấy dữ liệu từ các trường trên giao diện

                // Lấy chuỗi từ ComboBox
                string selectedText = text_NgayDen.SelectedItem.ToString();

                // Tách ngày từ chuỗi: Lấy phần sau dấu '-'
                string[] parts = selectedText.Split('-');
                string datePart = parts[1].Trim(); // "17/12/2024"

                // Chuyển đổi chuỗi ngày thành kiểu DateTime
                DateTime ngayDat = DateTime.ParseExact(datePart, "dd/MM/yyyy", null);

                string maKhachHang = GlobalVariables.MaKH;
                bool soluongKH = text_sl_KH.Value.ToString() == "Thanh toán qua ngân hàng";
                DateTime thoiDiemTruyCap = GlobalVariables.ThoiDiemTruyCap;
                TimeSpan thoiGianTruyCap = DateTime.Now.TimeOfDay;
                TimeSpan gioDen = text_GioDat.Value.TimeOfDay;
                int soLuongKhach = (int)text_sl_KH.Value;
                string ghiChu = string.IsNullOrWhiteSpace(richBox_ghi_chu.Text) ? null : richBox_ghi_chu.Text.Trim();

                // Tạo DataTable cho TVP
                DataTable chiTietDatMon = new DataTable();
                chiTietDatMon.Columns.Add("MaMonAn", typeof(string));
                chiTietDatMon.Columns.Add("SoLuong", typeof(int));
                chiTietDatMon.Columns.Add("Gia", typeof(int));

                // Thêm dữ liệu từ DataGridView vào DataTable
                if (panel_list_mon.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in panel_list_mon.Rows)
                    {

                        if (row.Cells["dgvID"] != null && row.Cells["soLuong"] != null && row.Cells["donGia"] != null)
                        {

                            string maMonAn = row.Cells["dgvID"].Value.ToString();
                            int soLuong = Convert.ToInt32(row.Cells["soLuong"].Value);
                            string giaString = row.Cells["donGia"].Value?.ToString();
                            giaString = giaString.Replace(".", ""); // Loại bỏ dấu .

                            int gia = Convert.ToInt32(giaString);
                            chiTietDatMon.Rows.Add(maMonAn, soLuong, gia);
                        }
                    }
                }

                // 2. Kết nối SQL và gọi procedure

                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("NXHanh_TaoDonHangDatBan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền tham số vào stored procedure
                        cmd.Parameters.AddWithValue("@MaChiNhanh", GlobalVariables.MaChiNhanh);
                        cmd.Parameters.AddWithValue("@NgayDat", ngayDat);
                        cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        cmd.Parameters.AddWithValue("@GioDen", gioDen);
                        cmd.Parameters.AddWithValue("@SoLuongKhach", soLuongKhach);
                        cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                        cmd.Parameters.AddWithValue("@ThoiDiemTruyCap", thoiDiemTruyCap);
                        cmd.Parameters.AddWithValue("@ThoiGianTruyCap", thoiGianTruyCap);

                        SqlParameter tvpParam = cmd.Parameters.AddWithValue("@ChiTietDatMon", chiTietDatMon);
                        tvpParam.SqlDbType = SqlDbType.Structured;
                        tvpParam.TypeName = "TVP_ChiTietDatMon";


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đặt bàn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void text_GioDat_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = text_GioDat.Value;
            TimeSpan minTime = new TimeSpan(9, 0, 0);  // 09:00
            TimeSpan maxTime = new TimeSpan(20, 0, 0); // 20:00

            if (selectedTime.TimeOfDay < minTime || selectedTime.TimeOfDay > maxTime)
            {
                warning_gioDen_DBView.Show("Giờ đến phải nằm trong khoảng từ 09:00 đến 20:00.");

                // Đặt lại giá trị mặc định
                text_GioDat.ValueChanged -= text_GioDat_ValueChanged; // Hủy đăng ký sự kiện tạm thời
                text_GioDat.Value = DateTime.Today.Add(minTime);
                text_GioDat.ValueChanged += text_GioDat_ValueChanged; // Đăng ký lại sự kiện
            }
        }
    }
}
