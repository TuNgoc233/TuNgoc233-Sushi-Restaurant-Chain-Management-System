using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    
    internal class Branch
    {
        // Chuỗi kết nối với cơ sở dữ liệu
        public static readonly string con_string = "Server=LAPTOP-80T8CRON; Database=QLNH_SUSHI_2024_FINAL_DGDV; Trusted_Connection=True;";
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
    public class Employee
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string MaBoPhan { get; set; }

        // Phương thức để lấy danh sách nhân viên từ stored procedure
        public static List<Employee> LoadNhanVienFromProcedure(string branchID)
        {
            List<Employee> employees = new List<Employee>();
            string query = "LayNhanVienCuaChiNhanhTheoLichSu"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaChiNhanh", branchID);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee emp = new Employee
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            SDT = reader["SoDienThoai"].ToString(),
                            MaBoPhan = reader["MaBoPhan"].ToString()
                        };
                        employees.Add(emp);
                    }
                }
            }
            return employees;
        }
    }
}