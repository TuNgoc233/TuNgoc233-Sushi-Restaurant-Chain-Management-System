using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Sushi_Restaurant.NhanVien;


namespace Sushi_Restaurant
    {
        public static class MainClass
        {
        // Chuỗi kết nối đến cơ sở dữ liệu
        public static string con_string = @"Server=sql1001.site4now.net;Database=db_ab108c_sushisystem;User Id=db_ab108c_sushisystem_admin;Password=Hanhspring123;";
        //public static string con_string = @"Server=LTCUATUNGOC;Database=QLNH_SUSHI_2024_FINAL;Trusted_Connection=True;";
        //public static string con_string = @"Server=DESKTOP-B1OU3RF;Database=QLNH_SUSHI_2;Trusted_Connection=True;";

        // Kết nối SQL
        public static SqlConnection con = new SqlConnection(con_string);

        // Biến chung để lưu mã phiếu đặt hiện tại
        public static string CurMaPhieuDat { get; set; }
        public static string CurMaHD { get; set; }
        public static DateTime curDate = DateTime.Now.Date;
        public static string LoaiPhieu= ""; 


        /// <summary>
        /// Hàm kiểm tra kết nối đến cơ sở dữ liệu
        /// </summary>
        /// <returns>True nếu kết nối thành công, ngược lại False</returns>
        /// 

        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = frmMain.Instance.Size;
                Background.Location = frmMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog();
                Background.Dispose();
            }
        }

        public static user user = new user();

    }
    public class user
    {
        public string MaNhanVien { get; set; }
        public string MaChiNhanh { get; set; }
        public string TenNhanVien { get; set; }
        public string TenChiNhanh { get; set; }
    }
}
