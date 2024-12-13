using System.Data.SqlClient;
using System.Data;
using System;

namespace Sushi_Restaurant
{
    internal class BranchMain
    {
        // Chuỗi kết nối với cơ sở dữ liệu
        public static readonly string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True;";
        public static SqlConnection con = new SqlConnection(con_string);

        // Thuộc tính tĩnh chung cho lớp (Mã chi nhánh)
        public static string MaChiNhanh { get; set; }

        // Kiểm tra đăng nhập và lấy mã chi nhánh
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
                    MaChiNhanh = branchId; // Lưu mã chi nhánh vào thuộc tính chung
                }
                con.Close();
            }
            return branchId;
        }

        // Method to fetch region data
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
