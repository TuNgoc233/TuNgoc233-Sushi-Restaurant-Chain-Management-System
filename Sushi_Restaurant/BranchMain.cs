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
        public static readonly string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True;";
        public static SqlConnection con = new SqlConnection(con_string);
        public static string CheckLogin(string username, string hashedPassword)
        {
            string branchId = null;
            {
                string query = @"
            SELECT MaChiNhanh 
            FROM TaiKhoanChiNhanh 
            WHERE TenDangNhap = @Username AND MatKhau = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    branchId = reader["MaChiNhanh"].ToString();
                }
                con.Close();
            }
            return branchId;
        }
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


