using Guna.UI2.WinForms;
using Sushi_Restaurant.Reports;
using System;
using System.Collections;
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

    public partial class frmThanhtoan : Form
    {
        public frmThanhtoan()
        {
            InitializeComponent();
        }
  

        public string MaKH = "";
        public string TheTV = "";

        public string MaHD = "";
        DateTime dateTime = DateTime.Now;
        public string sdt = "";
        public string MaPhieuCanTT = "";
        public string MaKM = "";
        public int TongTruocGiam = 0;
        public int TongSauGiam = 0;
        public int TienGiam = 0;
        public int PhanTramKM = 0;

        public virtual void btnLuu_Click(object sender, EventArgs e)
        {
            // Tạo hóa đơn cho phiếu đặt trực tiếp
            using (SqlConnection con = new SqlConnection(MainClass.con_string))
            {
                try
                {
                    // Mở kết nối
                    con.Open();

                    // Tạo SqlCommand để gọi stored procedure tạo hóa đơn
                    using (SqlCommand cmd = new SqlCommand("sp_TaoHoaDon", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaHoaDon", MaHD);
                        cmd.Parameters.AddWithValue("@NgayLap", dateTime);
                        cmd.Parameters.AddWithValue("@MaChiNhanh", MainClass.user.MaChiNhanh);
                        cmd.Parameters.AddWithValue("@MaNV", MainClass.user.MaNhanVien);
                        cmd.Parameters.AddWithValue("@MaPhieu", MaPhieuCanTT);
                        cmd.Parameters.AddWithValue("@MaKM", string.IsNullOrEmpty(MaKM) ? (object)DBNull.Value : MaKM);
                        cmd.Parameters.AddWithValue("@TongTien", TongSauGiam);
                        cmd.Parameters.AddWithValue("@SoTienDuocGiam", TienGiam);
                        cmd.Parameters.AddWithValue("@SDT", string.IsNullOrEmpty(txtSDT.Text) || txtSDT.Text == "0" ? (object)DBNull.Value : txtSDT.Text.Trim());

                        cmd.ExecuteNonQuery();

                        // Lưu hóa đơn thành công
                        MessageBox.Show("Lưu hóa đơn thành công!");
                        MainClass.CurMaHD = MaHD;

                        // Gọi hàm hiển thị hóa đơn
                        InHoaDon(MaHD);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tạo hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InHoaDon(string maHoaDon)
        {
            // Hiển thị hóa đơn sau khi lưu thành công
            using (SqlConnection con = new SqlConnection(MainClass.con_string))
            {
                try
                {
                    // Mở kết nối
                    con.Open();

                    // Tạo SqlCommand để gọi stored procedure lấy chi tiết hóa đơn
                    using (SqlCommand cmd = new SqlCommand("sp_InCTHoaDon", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

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
                        rptHoadon rpt = new rptHoadon();
                        rpt.SetDataSource(dt);

                        // Truyền tham số @MaHoaDon vào Crystal Report (nếu cần)
                        rpt.SetParameterValue("@MaHoaDon", maHoaDon);

                        // Thiết lập report source và hiển thị
                        frm.crystalReportViewer1.ReportSource = rpt;
                        frm.crystalReportViewer1.Refresh();
                        frm.Show();
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void XemThongTinHoaDon_TrucTuyen(string maPhieu, string maChiNhanh, DateTime ngayLap)
        {
            using (SqlConnection con = new SqlConnection(MainClass.con_string))
            {
                try
                {

                    con.Open();

                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("sp_XemThongTinHoaDon_TrucTuyen", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số đầu vào
                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                        cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);
                        cmd.Parameters.AddWithValue("@NgayLap", ngayLap);

                        // Thêm các tham số đầu ra
                        cmd.Parameters.Add(new SqlParameter("@SDT", SqlDbType.Char, 10) { Direction = ParameterDirection.Output });
                        cmd.Parameters.Add(new SqlParameter("@MaKhuyenMai", SqlDbType.Char, 5) { Direction = ParameterDirection.Output });
                        cmd.Parameters.Add(new SqlParameter("@MaSoThe", SqlDbType.Char, 8) { Direction = ParameterDirection.Output });
                        cmd.Parameters.Add(new SqlParameter("@TongTien", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        cmd.Parameters.Add(new SqlParameter("@SoTienDuocGiam", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        cmd.Parameters.Add(new SqlParameter("@TienPhaiTra", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        cmd.Parameters.Add(new SqlParameter("@MaHoaDon", SqlDbType.Char, 8) { Direction = ParameterDirection.Output });

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        // Gán kết quả từ các tham số OUTPUT vào các biến tương ứng
                        sdt = cmd.Parameters["@SDT"].Value.ToString().Trim();
                        MaKM = cmd.Parameters["@MaKhuyenMai"].Value.ToString().Trim();
                        TheTV = cmd.Parameters["@MaSoThe"].Value.ToString().Trim();
                        MaHD = cmd.Parameters["@MaHoaDon"].Value.ToString().Trim();
                        TongTruocGiam = Convert.ToInt32(cmd.Parameters["@TongTien"].Value);
                        TienGiam = Convert.ToInt32(cmd.Parameters["@SoTienDuocGiam"].Value);
                        TongSauGiam = Convert.ToInt32(cmd.Parameters["@TienPhaiTra"].Value);

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Thông tin hóa đơn đã được lấy thành công!");
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void LayMaHDTiepTheo()
        {
            string nextId = "";

            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.f_LayMaHDTiepTheo()", con))
                    {
                        nextId = cmd.ExecuteScalar().ToString();
                        MaHD = nextId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã hóa đơn tiếp theo: " + ex.Message);
            }


        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số hoặc phím điều khiển (như Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ

                // Hiển thị thông báo cho người dùng
                MessageBox.Show("Vui lòng chỉ nhập số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void TimKhuyenMai()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_TimKhuyenMai", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số đầu vào
                        cmd.Parameters.AddWithValue("@MaChiNhanh", MainClass.user.MaChiNhanh);
                        cmd.Parameters.AddWithValue("@NgayLap", dateTime);

                        // Thêm tham số đầu ra
                        SqlParameter maKMParam = new SqlParameter("@MaKM", SqlDbType.Char, 5)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(maKMParam);

                        SqlParameter phanTramKMParam = new SqlParameter("@PhanTramKM", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(phanTramKMParam);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        // Lấy giá trị từ tham số đầu ra
                        MaKM = maKMParam.Value.ToString();
                        PhanTramKM = Convert.ToInt32(phanTramKMParam.Value);
                        txtKhuyenMai.Text = MaKM;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm mã khuyến mãi: " + ex.Message);
            }

        }


        private void TinhTongTienTruocGiam()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.f_TinhTongCTPhieuDat_HoaDon(@MaPhieu)", con))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieu", MaPhieuCanTT);
                        var result = cmd.ExecuteScalar();
                        // Ép kiểu và xử lý null
                        TongTruocGiam = result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng tiền trước giảm: " + ex.Message);
            }
        }

        private void TimTheThanhVien()
        {
            sdt = txtSDT.Text;
            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.f_TimKiemKhachHangCoThe(@SoDienThoai)", con))
                    {

                        cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                        var result = cmd.ExecuteScalar();

                        // Ép kiểu và xử lý null
                        TheTV = result != null ? result.ToString() : null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng tiền trước giảm: " + ex.Message);
            }

        }

        private void TinhTienDuocGiam()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.f_TinhSoTienDuocGiam_HoaDon(@TongTien, @PhanTramKhuyenMai, @TheTV)", con))
                    {
                        cmd.Parameters.AddWithValue("@TongTien", TongTruocGiam);
                        cmd.Parameters.AddWithValue("@PhanTramKhuyenMai", PhanTramKM);
                        cmd.Parameters.AddWithValue("@TheTV", TheTV);
                        var result = cmd.ExecuteScalar();
                        // Ép kiểu và xử lý null
                        TienGiam = result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng tiền trước giảm: " + ex.Message);
            }

        }


        private void frmThanhtoan_Load(object sender, EventArgs e)
        {
            if (MainClass.LoaiPhieu != "TT")
            {
                XemThongTinHoaDon_TrucTuyen(MaPhieuCanTT, MainClass.user.MaChiNhanh, MainClass.curDate);
                txtSDT.Text = sdt;
                txtSDT.Enabled = false;
                btnTimTheTV.Visible = false;
                txtTheTV.Text = TheTV;
                txtKhuyenMai.Text = MaKM;
                txtTongTien.Text = TongTruocGiam.ToString();
                txtTienGiam.Text = TienGiam.ToString();
                txtTongSauGiam.Text = TongSauGiam.ToString();
            }
            else
            {
                TinhTongTienTruocGiam();
                txtTongTien.Text = TongTruocGiam.ToString();
                LayMaHDTiepTheo();
                TimKhuyenMai();
            }

        }

        // Phương thức xử lý sự kiện khi nhấn nút "ĐÓNG"
        public virtual void btnDong_Click(object sender, EventArgs e)
        {
            // Đóng cửa sổ hiện tại
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTimTheTV_Click(object sender, EventArgs e)
        {
            TimTheThanhVien();
            txtTheTV.Text = TheTV;
            txtTongTien.Text = TongTruocGiam.ToString();
            txtKhuyenMai.Text = MaKM;
            TinhTienDuocGiam();
            txtTienGiam.Text = TienGiam.ToString();
            TongSauGiam = TongTruocGiam - TienGiam;
            txtTongSauGiam.Text = TongSauGiam.ToString();

        }


    }
}
