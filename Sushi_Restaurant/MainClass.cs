using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Restaurant
{
    internal class MainClass
    {
        //public static readonly string con_string = "Server=DESKTOP-TJGBBGQ\\HANHSPRING; Database=QLNH_SUSHI_1; Trusted_Connection=True;";
        public static readonly string con_string = "Server=sql1001.site4now.net; Database=db_ab108c_sushisystem; User Id=db_ab108c_sushisystem_admin; Password=Hanhspring123; TrustServerCertificate=True;";


        public static SqlConnection con = new SqlConnection(con_string);

        // Method to check user validation
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = @"Select * from KHACH_HANG where SoDienThoai = '" + user + "' and MatKhau = '" + pass + "'";

            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;

                // Lấy thông tin khách hàng và lưu vào GlobalVariables
                GlobalVariables.MaKH = dt.Rows[0]["MaKhachHang"].ToString();
                GlobalVariables.HoTenKH = dt.Rows[0]["HoTen"].ToString();
                GlobalVariables.EmailKH = dt.Rows[0]["Email"].ToString();
                GlobalVariables.SDTKH = dt.Rows[0]["SoDienThoai"].ToString();
                GlobalVariables.GioiTinhKH = dt.Rows[0]["GioiTinh"].ToString();
                GlobalVariables.CCCDKH = dt.Rows[0]["CCCD"].ToString();
            }

            return isValid;
        }
        public static DataTable Lay_Khu_Vuc_ChiNhanh_SDT()
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("NXHanh_LayThongTinVaSDTChiNhanh", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
    }


}


