using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public class Employee
    {
        // Chuỗi kết nối với cơ sở dữ liệu
        public static readonly string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True;";
        public static SqlConnection con = new SqlConnection(con_string);
        public int MaNhanVien { get; set; }
        public string TenNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string MaBoPhan { get; set; }

        public Employee(int maNhanVien, string tenNV, string hoTen, string gioiTinh, string diaChi, string sdt, string maBoPhan)
        {
            MaNhanVien = maNhanVien;
            TenNV = tenNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SDT = sdt;
            MaBoPhan = maBoPhan;
        }

        // Hàm tạo danh sách nhân viên từ dữ liệu trong cơ sở dữ liệu
        public static List<Employee> LoadNhanVienFromProcedure(string maChiNhanh)
        {
            List<Employee> nhanViens = new List<Employee>();

            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("LayLichSuGanNhatNhanVien", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee nv = new Employee(
                            reader.GetInt32(reader.GetOrdinal("MaNhanVien")),
                            reader.GetString(reader.GetOrdinal("TenNV")),
                            reader.GetString(reader.GetOrdinal("HoTen")),
                            reader.GetString(reader.GetOrdinal("GioiTinh")),
                            reader.GetString(reader.GetOrdinal("DiaChi")),
                            reader.GetString(reader.GetOrdinal("SDT")),
                            reader.GetString(reader.GetOrdinal("MaBoPhan"))
                        );
                        nhanViens.Add(nv);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nhân viên: " + ex.Message);
            }

            return nhanViens;
        }
    }
    internal class Branch
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