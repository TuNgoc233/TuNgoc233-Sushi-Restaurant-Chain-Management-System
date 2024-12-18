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
        public string TheTV="";

        public string MaHD = "";
        DateTime date = DateTime.Now;
        public string MaChiNhanh = MainClass.user.MaChiNhanh;
        public string sdt = "";
        public string MaNV = MainClass.user.MaNhanVien;
        public string MaPhieuCanTT = "";
        public string MaKM = "";
        public int TongTruocGiam = 0;
        public int TongSauGiam = 0;
        public int TienGiam = 0;
        public int PhanTramKM = 0;

        public virtual void btnLuu_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(MainClass.con_string))
            {
                try
                {
                    // Mở kết nối
                    con.Open();

                    // Tạo SqlCommand để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("sp_TaoHoaDon", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaHoaDon", MaHD);
                        cmd.Parameters.AddWithValue("@NgayLap", date);
                        cmd.Parameters.AddWithValue("@MaChiNhanh", MainClass.user.MaChiNhanh);
                        //cmd.Parameters.AddWithValue("@MaKH", MaKH);
                        cmd.Parameters.AddWithValue("@MaNV", MaNV);
                        cmd.Parameters.AddWithValue("@MaPhieu", MaPhieuCanTT);
                        cmd.Parameters.AddWithValue("@MaKM", MaKM);
                        cmd.Parameters.AddWithValue("@TongTien", TongSauGiam);
                        cmd.Parameters.AddWithValue("@SoTienDuocGiam", TienGiam);
                        cmd.Parameters.AddWithValue("@TheTV", TheTV);

                        cmd.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Lưu hóa đơn thành công!");
                        MainClass.CurMaHD = MaHD;
                    }

                    // Tạo lệnh SQL để lấy dữ liệu cho báo cáo
                    string qry = @"SELECT * 
                       FROM HOA_DON HD 
                       JOIN PHIEU_DAT_MON PD ON PD.MaPhieu = HD.MaPhieuDatMon
                       JOIN CHI_TIET_DAT_MON CT ON CT.MaPhieu = PD.MaPhieu
                       JOIN MON_AN MA ON MA.MaMonAn = CT.MaMonAn
                       WHERE HD.MaHoaDon = @MaHoaDon";

                    using (SqlCommand cmd2 = new SqlCommand(qry, con))
                    {
                        cmd2.Parameters.AddWithValue("@MaHoaDon", MaHD);

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        da.Fill(dt);

                        // Hiển thị báo cáo
                        frmPrint frm = new frmPrint();
                        rptHoadon rpt = new rptHoadon();
                        rpt.SetDataSource(dt); // Không cần gọi rpt.SetDatabaseLogon cho Windows Authentication
                        frm.crystalReportViewer1.ReportSource = rpt;
                        frm.crystalReportViewer1.Refresh();
                        frm.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tạo hóa đơn: " + ex.Message);
                }
                finally
                {
                    // Đảm bảo kết nối được đóng
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
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
                MessageBox.Show("Lỗi khi lấy mã phiếu tiếp theo: " + ex.Message);
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
                        cmd.Parameters.AddWithValue("@NgayLap", date);

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
            TinhTongTienTruocGiam();
            txtTongTien.Text = TongTruocGiam.ToString();
            LayMaHDTiepTheo();
            TimKhuyenMai(); 
        }

        // Phương thức xử lý sự kiện khi nhấn nút "ĐÓNG"
        public virtual void btnDong_Click(object sender, EventArgs e)
        {
            // Đóng cửa sổ hiện tại
            this.Close();
        }

        private void btnTimTheTV_Click(object sender, EventArgs e)
        {
            TimTheThanhVien();
            txtTheTV.Text= TheTV;
            txtTongTien.Text = TongTruocGiam.ToString();
            txtKhuyenMai.Text = MaKM;
            TinhTienDuocGiam();
            txtTienGiam.Text = TienGiam.ToString();
            TongSauGiam = TongTruocGiam - TienGiam;
            txtTongSauGiam.Text = TongSauGiam.ToString();

        }

        
    }
}
