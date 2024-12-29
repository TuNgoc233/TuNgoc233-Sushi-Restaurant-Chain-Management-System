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
    public partial class GiaoHangView : Form
    {

        public GiaoHangView()
        {
            InitializeComponent();
        }

        //Thêm tự động ngày đặt hàng
        private void GiaoHangView_Load(object sender, EventArgs e)
        {

            //Tính tồng tiền hóa đơn
            CapNhatTongTien();

            // Áp dụng khuyến mãi tốt nhất
            LayKhuyenMaiTotNhat();

            // Xóa các mục cũ trong ComboBox (nếu có)
            cmb_ngayGiao.Items.Clear();

            // Thêm ngày hôm nay và ngày mai vào ComboBox
            cmb_ngayGiao.Items.Add("Hôm nay - " + DateTime.Now.ToString("dd/MM/yyyy"));
            cmb_ngayGiao.Items.Add("Ngày mai - " + DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"));

        
        }

        // Thêm tên số điện thoại khách hàng vào phiếu giao hàng
        public string TenKhachHang
        {
            get => text_tenKH.Text;
            set => text_tenKH.Text = value;
        }

        public string SoDienThoai
        {
            get => text_SDT.Text;
            set => text_SDT.Text = value;
        }

        // Phương thức để thêm món ăn vào danh sách DataGridView
        public void AddMonAn(string maMon, string tenMon, int soLuong, double DonGia, double thanhTien)
        {
            panel_dat_hang.Rows.Add(new object[] {
            panel_dat_hang.Rows.Count + 1, // STT
            maMon,
            tenMon,
            soLuong,
            DonGia.ToString("N0", GlobalVariables.AppCultureInfo),
            thanhTien.ToString("N0", GlobalVariables.AppCultureInfo)
            });
        }

        private double TinhTongTien()
        {
            double tongTien = 0;

            foreach (DataGridViewRow row in panel_dat_hang.Rows)
            {
                if (row.Cells["thanhTien"] != null && row.Cells["thanhTien"].Value != null)
                {
                    // Cộng dồn giá trị trong cột "T.Tiền" (thanh_tien)
                    if (double.TryParse(row.Cells["thanhTien"].Value.ToString().Replace(".", ""), out double tien))
                    {
                        tongTien += tien;
                    }
                }
            }

            return tongTien;
        }

        private void CapNhatTongTien()
        {
            // Gọi hàm tính tổng tiền
            double tongTien = TinhTongTien();

            // Hiển thị tổng tiền vào Label
            value_tongTien.Text = tongTien.ToString("N0", GlobalVariables.AppCultureInfo) + " VND";
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Kiểm tra xem khách hàng đã nhập đủ thông tin hay chưa
                if (string.IsNullOrWhiteSpace(text_diaChiGiao.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ giao hàng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmb_thanhToan.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn hình thức thanh toán.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 1. Lấy dữ liệu từ các trường trên giao diện
                // Lấy chuỗi từ ComboBox
                string selectedText = cmb_ngayGiao.SelectedItem.ToString();

                // Tách ngày từ chuỗi: Lấy phần sau dấu '-'
                string[] parts = selectedText.Split('-');
                string datePart = parts[1].Trim(); // "17/12/2024"

                // Chuyển đổi chuỗi ngày thành kiểu DateTime
                DateTime ngayDat = DateTime.ParseExact(datePart, "dd/MM/yyyy", null);

                TimeSpan gioDat = text_GioDat.Value.TimeOfDay;
                string maKhachHang = GlobalVariables.MaKH;
                string diaChiGiaoHang = text_diaChiGiao.Text.Trim(); // Địa chỉ giao hàng
                bool hinhThucThanhToan = cmb_thanhToan.SelectedItem.ToString() == "Thanh toán qua ngân hàng";
                DateTime thoiDiemTruyCap = GlobalVariables.ThoiDiemTruyCap;
                TimeSpan thoiGianTruyCap = DateTime.Now.TimeOfDay;


                // Tạo DataTable cho TVP
                DataTable chiTietDatMon = new DataTable();
                chiTietDatMon.Columns.Add("MaMonAn", typeof(string));
                chiTietDatMon.Columns.Add("SoLuong", typeof(int));
                chiTietDatMon.Columns.Add("Gia", typeof(int));

                // Thêm dữ liệu từ DataGridView vào DataTable
                foreach (DataGridViewRow row in panel_dat_hang.Rows)
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

                // 2. Kết nối SQL và gọi procedure
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("NXHanh_TaoDonHangGiaoHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền tham số vào stored procedure
                        cmd.Parameters.AddWithValue("@MaChiNhanh", GlobalVariables.MaChiNhanh);
                        cmd.Parameters.AddWithValue("@NgayDat", ngayDat);
                        cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        cmd.Parameters.AddWithValue("@DiaChiGiaoHang", diaChiGiaoHang);
                        cmd.Parameters.AddWithValue("@ThoiGianNhanHang", gioDat);
                        cmd.Parameters.AddWithValue("@HinhThucThanhToan", hinhThucThanhToan);
                        cmd.Parameters.AddWithValue("@ThoiDiemTruyCap", thoiDiemTruyCap);
                        cmd.Parameters.AddWithValue("@ThoiGianTruyCap", thoiGianTruyCap);

                        SqlParameter tvpParam = cmd.Parameters.AddWithValue("@ChiTietDatMon", chiTietDatMon);
                        tvpParam.SqlDbType = SqlDbType.Structured;
                        tvpParam.TypeName = "TVP_ChiTietDatMon";

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đặt hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void LayKhuyenMaiTotNhat()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("NXHanh_LayKhuyenMaiTotNhat", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số đầu vào
                        cmd.Parameters.AddWithValue("@MaKhachHang", GlobalVariables.MaKH);
                        cmd.Parameters.AddWithValue("@MaChiNhanh", GlobalVariables.MaChiNhanh);
                        cmd.Parameters.AddWithValue("@TongTien", TinhTongTien());

                        // Thêm các tham số đầu ra
                        SqlParameter soTienGiamKM = new SqlParameter("@SoTienGiamKM", SqlDbType.Float) { Direction = ParameterDirection.Output };
                        SqlParameter soTienGiamTTV = new SqlParameter("@SoTienGiamTTV", SqlDbType.Float) { Direction = ParameterDirection.Output };
                        SqlParameter loaiThe = new SqlParameter("@LoaiThe", SqlDbType.NVarChar, 10) { Direction = ParameterDirection.Output };

                        cmd.Parameters.Add(soTienGiamKM);
                        cmd.Parameters.Add(soTienGiamTTV);
                        cmd.Parameters.Add(loaiThe);

                        // Thực thi procedure
                        cmd.ExecuteNonQuery();

                        // Lấy giá trị tham số trả về
                        double giamKM = Convert.ToDouble(soTienGiamKM.Value);
                        double giamTTV = Convert.ToDouble(soTienGiamTTV.Value);
                        string loaiTheTV = loaiThe.Value.ToString();

                        // Hiển thị lên giao diện
                        value_giamGia.Text = " - "+ giamKM.ToString("N0", GlobalVariables.AppCultureInfo);
                        value_TTV.Text = loaiTheTV;
                        value_giamGiaTTV.Text = " - " + giamTTV.ToString("N0", GlobalVariables.AppCultureInfo);
                        value_thanhTien.Text = (TinhTongTien() - giamKM - giamTTV).ToString("N0", GlobalVariables.AppCultureInfo) + " VND";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy khuyến mãi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetGioDatToDefault()
        {
            text_GioDat.ValueChanged -= text_GioDat_ValueChanged; // Hủy đăng ký sự kiện tạm thời
            text_GioDat.Value = DateTime.Today.Add(new TimeSpan(9, 0, 0)); // Đặt mặc định 09:00
            text_GioDat.ValueChanged += text_GioDat_ValueChanged; // Đăng ký lại sự kiện
        }

        private void text_GioDat_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = text_GioDat.Value;
            TimeSpan minTime = new TimeSpan(9, 0, 0);  // 09:00
            TimeSpan maxTime = new TimeSpan(20, 0, 0); // 20:00

            // Lấy giờ hiện tại theo giờ Việt Nam (UTC+7)
            DateTime now = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "SE Asia Standard Time");
            TimeSpan currentTimePlusTwoHours = now.TimeOfDay.Add(new TimeSpan(2, 0, 0)); // Giờ hiện tại + 2 tiếng

            // Kiểm tra xem người dùng đã chọn ngày đặt chưa
            if (string.IsNullOrWhiteSpace(cmb_ngayGiao.Text))
            {
                warning_gioGH_GHView.Show("Vui lòng chọn ngày đặt trước khi chọn giờ đặt.");

                // Đặt lại giá trị giờ đặt về mặc định
                ResetGioDatToDefault();
                return; // Dừng lại nếu ngày đặt chưa được chọn
            }

            // Kiểm tra ngày đến
            bool isToday = cmb_ngayGiao.Text.Contains("Hôm nay");

            // Điều kiện kiểm tra
            if (selectedTime.TimeOfDay < minTime || selectedTime.TimeOfDay > maxTime ||
                (isToday && selectedTime.TimeOfDay < currentTimePlusTwoHours))
            {
                string warningMessage = "Giờ đến phải nằm trong khoảng từ 09:00 đến 20:00.";
                if (isToday && selectedTime.TimeOfDay < currentTimePlusTwoHours)
                {
                    warningMessage = $"Nếu ngày đến là hôm nay, giờ đặt phải lớn hơn giờ hiện tại 2 tiếng ({currentTimePlusTwoHours.ToString(@"hh\:mm")}).";
                }

                // Hiển thị cảnh báo
                warning_gioGH_GHView.Show(warningMessage);

                // Đặt lại giá trị mặc định
                text_GioDat.ValueChanged -= text_GioDat_ValueChanged; // Hủy đăng ký sự kiện tạm thời
                text_GioDat.Value = DateTime.Today.Add(isToday && currentTimePlusTwoHours > minTime ? currentTimePlusTwoHours : minTime);
                text_GioDat.ValueChanged += text_GioDat_ValueChanged; // Đăng ký lại sự kiện
            }
        }

        private void cmb_ngayGiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi người dùng chọn lại ngày đến, reset giờ đặt thành giờ hiện tại + 2 tiếng
            ResetGioDatAfterNow();
        }

        private void ResetGioDatAfterNow()
        {
            // Lấy giờ hiện tại theo múi giờ Việt Nam (UTC+7)
            DateTime now = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "SE Asia Standard Time");
            DateTime newTime = now.AddHours(2); // Cộng thêm 2 tiếng

            // Giới hạn thời gian trong khoảng từ 09:00 đến 21:00
            TimeSpan minTime = new TimeSpan(9, 0, 0);  // 09:00
            TimeSpan maxTime = new TimeSpan(21, 0, 0); // 21:00

            // Nếu giờ hiện tại + 2 tiếng nhỏ hơn 09:00, đặt lại thành 09:00
            if (newTime.TimeOfDay < minTime)
            {
                newTime = now.Date.Add(minTime); // Đặt thành 09:00
            }
            // Nếu giờ hiện tại + 2 tiếng lớn hơn 21:00, đặt lại thành 21:00
            else if (newTime.TimeOfDay > maxTime)
            {
                newTime = now.Date.Add(maxTime); // Đặt thành 21:00
            }

            // Cập nhật giá trị text_GioDat
            text_GioDat.ValueChanged -= text_GioDat_ValueChanged; // Hủy đăng ký sự kiện tạm thời
            text_GioDat.Value = newTime; // Đặt giá trị mới
            text_GioDat.ValueChanged += text_GioDat_ValueChanged; // Đăng ký lại sự kiện
        }
    }
}
