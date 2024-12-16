using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public static class GlobalVariables
    {
        private static string _maChiNhanh;

        public static string MaChiNhanh { get; set; }

        public static string tenDiaChiCN { get; set; }
        public static string MaKH { get; set; }
        public static string HoTenKH { get; set; }
        public static string EmailKH { get; set; }
        public static string SDTKH { get; set; }
        public static string GioiTinhKH { get; set; }
        public static string CCCDKH { get; set; }
        public static DateTime ThoiDiemTruyCap { get; set; }

        // Định nghĩa dấu phân cách hàng nghìn và dấu thập phân cho tiền tệ
        public static CultureInfo AppCultureInfo { get; } = CreateCustomCulture();

        private static CultureInfo CreateCustomCulture()
        {
            var cultureInfo = new CultureInfo("vi-VN");
            cultureInfo.NumberFormat.CurrencyGroupSeparator = "."; // Dấu phân cách hàng nghìn là dấu chấm
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ","; // Dấu thập phân là dấu phẩy
            return cultureInfo;
        }
    }
}
