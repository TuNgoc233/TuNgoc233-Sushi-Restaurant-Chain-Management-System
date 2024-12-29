using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Sushi_Restaurant.Admin
{
    public class Employee_
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string TenBoPhan { get; set; } // Tên bộ phận
        public int MucLuong { get; set; } // Mức lương
        public string MaChiNhanh { get; set; } // Mã chi nhánh
        public string NgayBatDau { get; set; } // Ngày bắt đầu làm việc
        public string NgayKetThuc { get; set; } // Ngày kết thúc làm việc

        // Phương thức để lấy danh sách nhân viên từ stored procedure
        public static List<Employee_> LoadEmployeeFromProcedure()
        {
            List<Employee_> employees = new List<Employee_>();
            string query = "LayNhanVien"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee_ emp = new Employee_
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            NgaySinh = Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"), // Định dạng ngày sinh
                            TenBoPhan = reader["TenBoPhan"].ToString(),
                            MucLuong = Convert.ToInt32(reader["MucLuong"]),
                            MaChiNhanh = reader["MaChiNhanh"].ToString(),
                            NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]).ToString("dd/MM/yyyy"),
                            NgayKetThuc = reader["NgayKetThuc"] == DBNull.Value
                                ? "Chưa xác định"
                                : Convert.ToDateTime(reader["NgayKetThuc"]).ToString("dd/MM/yyyy")
                        };
                        employees.Add(emp);
                    }
                }
            }
            return employees;
        }

        // Phương thức tìm kiếm nhân viên
        public static List<Employee_> SearchEmployees(string searchTerm)
        {
            List<Employee_> employees = new List<Employee_>();
            string query = "LayNhanVien"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Kiểm tra xem tên nhân viên, mã nhân viên, hoặc tên bộ phận có chứa searchTerm không
                        if (reader["MaNhanVien"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            reader["HoTen"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            reader["TenBoPhan"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Employee_ emp = new Employee_
                            {
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                HoTen = reader["HoTen"].ToString(),
                                NgaySinh = Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"),
                                TenBoPhan = reader["TenBoPhan"].ToString(),
                                MucLuong = Convert.ToInt32(reader["MucLuong"]),
                                MaChiNhanh = reader["MaChiNhanh"].ToString(),
                                NgayBatDau = Convert.ToDateTime(reader["NgayBatDau"]).ToString("dd/MM/yyyy"),
                                NgayKetThuc = reader["NgayKetThuc"] == DBNull.Value
                                    ? "Chưa xác định"
                                    : Convert.ToDateTime(reader["NgayKetThuc"]).ToString("dd/MM/yyyy")
                            };
                            employees.Add(emp);
                        }
                    }
                }
            }
            return employees;
        }

    }

    public class FoodItem
    {
        public string MaMonAn { get; set; } 
        public string TenMonAn { get; set; } 
        public string TenMuc { get; set; }
        public decimal GiaHienTai { get; set; } 
        public int TinhTrangPhucVu { get; set; } 
        public static List<FoodItem> LoadFoodItemsFromProcedure(string branchID)
        {
            List<FoodItem> foodItems = new List<FoodItem>();
            string query = "CheckMonAnForChiNhanhByMaChiNhanh"; 

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
                        FoodItem foodItem = new FoodItem
                        {
                            MaMonAn = reader["MaMonAn"].ToString(),
                            TenMonAn = reader["TenMonAn"].ToString(),
                            TenMuc = reader["TenMuc"] != DBNull.Value ? reader["TenMuc"].ToString() : string.Empty,
                            GiaHienTai = reader["GiaHienTai"] != DBNull.Value ? Convert.ToDecimal(reader["GiaHienTai"]) : 0m,
                            TinhTrangPhucVu = reader["TinhTrangPhucVu"] != DBNull.Value ? Convert.ToInt32(reader["TinhTrangPhucVu"]) : 0
                        };
                        foodItems.Add(foodItem);
                    }
                }
            }
            return foodItems;
        }

        public static List<FoodItem> SearchFoodItems(string searchTerm, string branchID)
        {
            List<FoodItem> foodItems = new List<FoodItem>();
            string query = "CheckMonAnForChiNhanhByMaChiNhanh"; // Tên stored procedure cho tìm kiếm món ăn

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
                        // Kiểm tra xem mã món ăn hoặc tên món ăn có chứa searchTerm không
                        if (reader["MaMonAn"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            reader["TenMonAn"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            FoodItem foodItem = new FoodItem
                            {
                                MaMonAn = reader["MaMonAn"].ToString(),
                                TenMonAn = reader["TenMonAn"].ToString(),
                                TenMuc = reader["MaMuc"].ToString(), // Mã mục
                                GiaHienTai = Convert.ToDecimal(reader["GiaHienTai"]), // Giá hiện tại
                                TinhTrangPhucVu = Convert.ToInt32(reader["TinhTrangPhucVu"]) // Tình trạng phục vụ
                            };
                            foodItems.Add(foodItem);
                        }
                    }
                }
            }
            return foodItems;
        }
    }


}
