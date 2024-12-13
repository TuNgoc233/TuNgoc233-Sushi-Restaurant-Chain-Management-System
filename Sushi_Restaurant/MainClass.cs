using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Restaurant
    {
        public static class MainClass
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            public static string con_string = @"Server=LTCUATUNGOC;Database=QLNH_SUSHI_2024_FINAL;Trusted_Connection=True;";

            // Kết nối SQL
            public static SqlConnection con = new SqlConnection(con_string);

            public static user user = new user();


        /// <summary>
        /// Hàm kiểm tra kết nối đến cơ sở dữ liệu
        /// </summary>
        /// <returns>True nếu kết nối thành công, ngược lại False</returns>

    }

    public class user
    {
        public string MaNhanVien { get; set; }
        public string MaChiNhanh { get; set; }
    }
}
