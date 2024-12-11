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
            public static string con_string = @"Server=LTCUATUNGOC;Database=TEST;Trusted_Connection=True;";

            // Kết nối SQL
            public static SqlConnection con = new SqlConnection(con_string);

            /// <summary>
            /// Hàm kiểm tra kết nối đến cơ sở dữ liệu
            /// </summary>
            /// <returns>True nếu kết nối thành công, ngược lại False</returns>

        }
    }
