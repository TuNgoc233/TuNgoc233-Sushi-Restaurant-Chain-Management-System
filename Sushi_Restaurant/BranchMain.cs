using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Restaurant
{
    internal class BranchMain
    {
        public static readonly string con_string = "ServerNHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True;";
        public static SqlConnection con = new SqlConnection(con_string);

        // Method to check user validation
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = @"Select * from CHI
                    where SoDienThoai = '" + user + "' and MatKhau = '" + pass + "'";

            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
            }

            return isValid;
        }
        public static DataTable Lay_Khu_Vuc_ChiNhanh_SDT()
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Lay_Khu_Vuc_ChiNhanh_SDT", con)
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


