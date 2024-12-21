using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Sushi_Restaurant
{

    internal class Branch
    {
        public static string LoggedBranchId { get; set; }
        // Chuỗi kết nối với cơ sở dữ liệu
        public static readonly string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;";

        // Thuộc tính tĩnh chung cho lớp (Mã chi nhánh)
        public static string MaChiNhanh { get; set; }

        

        // Kiểm tra đăng nhập và lấy mã chi nhánh
        public static string CheckLogin(string username, string hashedPassword)
        {
            string branchId = null;
            string query = @"
            SELECT MaChiNhanh 
            FROM TaiKhoanChiNhanh 
            WHERE TenDangNhap = @Username AND MatKhau = @Password";

            using (SqlConnection con = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        branchId = reader["MaChiNhanh"].ToString();
                        MaChiNhanh = branchId; // Lưu mã chi nhánh vào thuộc tính chung
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return branchId;
        }

        // Tìm kiếm hóa đơn theo ngày lập và mã khách hàng, sử dụng stored procedure
        public static DataTable SearchInvoices(string ngayLap, string maKhachHang)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(con_string))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_TimKiemHoaDon", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@ngayLap", string.IsNullOrEmpty(ngayLap) ? (object)DBNull.Value : ngayLap);
                    cmd.Parameters.AddWithValue("@MaKhachHang", string.IsNullOrEmpty(maKhachHang) ? (object)DBNull.Value : maKhachHang);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dataTable;
        }

        // Lấy tổng số nhân viên của chi nhánh
        public static int GetTotalEmployees(string branchId)
        {
            return ExecuteScalarCount("SELECT COUNT(MaNhanVien) FROM LICH_SU_LAM_VIEC WHERE MaChiNhanh = @BranchID", branchId);
        }

        // Lấy tổng số khách hàng của chi nhánh
        public static int GetTotalCustomers(string branchId)
        {
            return ExecuteScalarCount("SELECT COUNT(HOA_DON.MaKhachHang) " +
                                      "FROM KHACH_HANG JOIN HOA_DON ON KHACH_HANG.MaKhachHang = HOA_DON.MaKhachHang " +
                                      "JOIN CHI_NHANH ON CHI_NHANH.MaChiNhanh = HOA_DON.MaChiNhanh " +
                                      "WHERE CHI_NHANH.MaChiNhanh = @BranchID", branchId);
        }

        // Lấy tổng số hóa đơn của chi nhánh
        public static int GetTotalInvoices(string branchId)
        {
            return ExecuteScalarCount("SELECT COUNT(*) FROM HOA_DON WHERE MaChiNhanh = @BranchID", branchId);
        }

        // Lấy tổng doanh thu của chi nhánh
        public static decimal GetTotalRevenue(string branchId)
        {
            decimal total = 0;
            string query = "SELECT SUM(CAST(TongTien AS DECIMAL)) FROM HOA_DON WHERE MaChiNhanh = @BranchID";

            using (SqlConnection con = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BranchID", branchId);

                try
                {
                    con.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        total = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return total;
        }

        // Hàm chung để thực thi COUNT
        private static int ExecuteScalarCount(string query, string branchId)
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BranchID", branchId);

                try
                {
                    con.Open();
                    count = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return count;
        }

        // Hàm gọi SP thống kê doanh thu
        public static DataTable GetRevenueReport(string timeFrame, string branchId, int? month = null, int year = 0, int? quarter = null, DateTime? specificDate = null)
        {
            DataTable dt = new DataTable();
            string query = "SP_ThongKeDoanhThuTheoChiNhanh"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, con)
                {
                    CommandType = CommandType.StoredProcedure,
                    //CommandTimeout = 120
                };

                // Thêm tham số cho stored procedure
                cmd.Parameters.AddWithValue("@ThoiGian", timeFrame);
                cmd.Parameters.AddWithValue("@MaChiNhanh", branchId ?? (object)DBNull.Value);


                if (timeFrame == "NGAY" && specificDate.HasValue)
                {
                    // Lấy giá trị từ DateTimePicker

                    //DateTime selectedDate = dtpDate.Value;
                    //cmd.Parameters.AddWithValue("@NgayLap", SqlDbType.Date).Value = specificDate.Value.Date;
                    cmd.Parameters.AddWithValue("@NgayLap", specificDate ?? (object)DBNull.Value);
                }
                else if (timeFrame == "THANG")
                {
                    cmd.Parameters.AddWithValue("@Thang", month ?? 0);
                    cmd.Parameters.AddWithValue("@Nam", year);
                }
                else if (timeFrame == "QUY")
                {
                    cmd.Parameters.AddWithValue("@Quy", quarter ?? 0);
                    cmd.Parameters.AddWithValue("@Nam", year);
                }
                else if (timeFrame == "NAM")
                {
                    cmd.Parameters.AddWithValue("@Nam", year);
                }

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }


        public static List<string> GetBranchIds()
        {
            List<string> branchIds = new List<string>();
            string query = "SELECT MaChiNhanh FROM CHI_NHANH"; // Truy vấn SQL để lấy mã chi nhánh

            using (SqlConnection con = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        branchIds.Add(reader["MaChiNhanh"].ToString()); // Thêm mã chi nhánh vào danh sách
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return branchIds;
        }

        public static List<string> GetMonths()
        {
            List<string> months = new List<string>();
            string query = "SELECT DISTINCT MONTH(ThoiGianLap) AS Month FROM HOA_DON ORDER BY Month";

            using (SqlConnection con = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        months.Add($"Tháng {reader["Month"]}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return months;
        }

        // Phương thức lấy danh sách quý từ database hoặc sử dụng danh sách mặc định
        public static List<string> GetQuarters()
        {
            // Đây là cách giả lập trả về danh sách các quý. Nếu bạn muốn lấy từ CSDL, bạn cần viết một truy vấn.
            List<string> quarters = new List<string>
        {
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"
        };

            return quarters;
        }

        // Lấy doanh thu công ty theo khoảng thời gian
        public static DataTable GetRevenueReportCompany(string timeFrame, string branchId = null, DateTime? specificDate = null)
        {
            DataTable dt = new DataTable();
            string storedProcedure = "SP_CongTyThongKeDoanhThu";

            using (SqlConnection con = new SqlConnection(con_string))
            {
                SqlCommand cmd = new SqlCommand(storedProcedure, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ThoiGian", timeFrame);
                cmd.Parameters.AddWithValue("@MaChiNhanh", (object)branchId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@NgayLap", (object)specificDate ?? DBNull.Value);

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lấy doanh thu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }


    }

    // Phương thức để lấy danh sách nhân viên từ stored procedure
    public class Employee
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string NgayVaoLam { get; set; } // Ngày vào làm
        public string TenBoPhan { get; set; } // Tên bộ phận
        public int MucLuong { get; set; } // Mức lương

        // Phương thức để lấy danh sách nhân viên từ stored procedure
        public static List<Employee> LoadEmployeeFromProcedure(string branchID)
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
                            NgaySinh = Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"), // Định dạng ngày sinh
                            DiaChi = reader["DiaChi"].ToString(),
                            SDT = reader["SoDienThoai"].ToString(),
                            NgayVaoLam = Convert.ToDateTime(reader["NgayGanNhat"]).ToString("dd/MM/yyyy"), // Định dạng ngày vào làm
                            TenBoPhan = reader["TenBoPhan"].ToString(),
                            MucLuong = Convert.ToInt32(reader["MucLuong"])
                            //DiemPhucVu = Convert.ToInt32(reader["DiemPhucVu"])
                        };
                        employees.Add(emp);
                    }
                }
            }
            return employees;
        }
        // Phương thức tìm kiếm nhân viên
        public static List<Employee> SearchEmployees(string searchTerm, string branchID)
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
                        // Kiểm tra xem tên nhân viên hoặc mã nhân viên có chứa searchTerm không
                        if (reader["MaNhanVien"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            reader["HoTen"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            reader["TenBoPhan"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Employee emp = new Employee
                            {
                                MaNhanVien = reader["MaNhanVien"].ToString(),
                                HoTen = reader["HoTen"].ToString(),
                                GioiTinh = reader["GioiTinh"].ToString(),
                                NgaySinh = Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"),
                                DiaChi = reader["DiaChi"].ToString(),
                                SDT = reader["SoDienThoai"].ToString(),
                                NgayVaoLam = Convert.ToDateTime(reader["NgayGanNhat"]).ToString("dd/MM/yyyy"),
                                TenBoPhan = reader["TenBoPhan"].ToString(),
                                MucLuong = Convert.ToInt32(reader["MucLuong"])
                            };
                            employees.Add(emp);
                        }
                    }
                }
            }
            return employees;
        }

    }

    public class Invoice
    {
        public string MaHoaDon { get; set; }
        public string TenNhanVienLap { get; set; }
        public string MaKhachHang { get; set; }
        public string HoTenKhachHang { get; set; }
        public DateTime ThoiGianLap { get; set; }
        public decimal TongTien { get; set; } // Giả sử tổng tiền là kiểu decimal

        public static List<Invoice> LoadInvoicesFromProcedure(string branchID)
        {
            List<Invoice> invoices = new List<Invoice>();
            string query = "sp_LayThongTinHoaDon"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ChiNhanh", branchID);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Invoice invoice = new Invoice
                        {
                            MaHoaDon = reader["MaHoaDon"].ToString(),
                            TenNhanVienLap = reader["TenNhanVienLap"].ToString(),
                            MaKhachHang = reader["MaKhachHang"].ToString(),
                            HoTenKhachHang = reader["HoTen"].ToString(),
                            ThoiGianLap = Convert.ToDateTime(reader["NgayLapHoaDon"]), // Định dạng ngày
                            TongTien = Convert.ToDecimal(reader["TongTien"]) // Giả sử tổng tiền là kiểu decimal
                        };
                        invoices.Add(invoice);
                    }
                }
            }
            return invoices;

        }

        public static List<Invoice> SearchInvoicesItem(string searchTerm, string branchID)
        {
            List<Invoice> invoices = new List<Invoice>();
            string query = "sp_LayThongTinHoaDon"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ChiNhanh", branchID);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Kiểm tra xem tên khách hàng có chứa searchTerm không
                        if (reader["HoTen"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Invoice invoice = new Invoice
                            {
                                MaHoaDon = reader["MaHoaDon"].ToString(),
                                TenNhanVienLap = reader["TenNhanVienLap"].ToString(),
                                MaKhachHang = reader["MaKhachHang"].ToString(),
                                HoTenKhachHang = reader["HoTen"].ToString(),
                                ThoiGianLap = Convert.ToDateTime(reader["NgayLapHoaDon"]), // Định dạng ngày
                                TongTien = Convert.ToDecimal(reader["TongTien"]) // Giả sử tổng tiền là kiểu decimal
                            };
                            invoices.Add(invoice);
                        }
                    }
                }
            }
            return invoices;
        }

        public static List<Invoice> SearchInvoicesDate(DateTime searchDate, string branchID)
        {
            List<Invoice> invoices = new List<Invoice>();
            string query = "EXEC sp_LayThongTinHoaDon @ChiNhanh, @NgayLapHoaDon";

            using (SqlConnection connection = new SqlConnection(Branch.con_string))
            {
 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ChiNhanh", branchID);
                    command.Parameters.AddWithValue("@NgayLapHoaDon", searchDate);
               

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Invoice invoice = new Invoice
                            {
                                MaHoaDon = reader["MaHoaDon"].ToString(),
                                TenNhanVienLap = reader["TenNhanVienLap"].ToString(),
                                MaKhachHang = reader["MaKhachHang"].ToString(),
                                HoTenKhachHang = reader["HoTen"].ToString(),
                                ThoiGianLap = Convert.ToDateTime(reader["NgayLapHoaDon"]), // Định dạng ngày
                                TongTien = Convert.ToDecimal(reader["TongTien"]) // Giả sử tổng tiền là kiểu decimal
                            };
                            invoices.Add(invoice);
                        }
                    }
                }
            }

            return invoices;
        }
    }
    public class CustomerCard
    {
        public string MaSoThe { get; set; } // Mã số thẻ
        public string LoaiThe { get; set; } // Loại thẻ
        public int TongDiemTichLuy { get; set; } // Tổng điểm tích lũy
        public DateTime NgayLap { get; set; } // Ngày lập thẻ
        public string HoTenKhachHang { get; set; } // Họ tên khách hàng
        public string HoTenNhanVien { get; set; } // Họ tên nhân viên lập thẻ

        public static List<CustomerCard> LoadCustomerCardsFromProcedure(string branchID)
        {
            List<CustomerCard> customerCards = new List<CustomerCard>();
            string query = "sp_LayThongTinTheThanhVien"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ChiNhanh", branchID);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CustomerCard customerCard = new CustomerCard
                        {
                            MaSoThe = reader["MaSoThe"].ToString(),
                            LoaiThe = reader["LoaiThe"].ToString(),
                            TongDiemTichLuy = Convert.ToInt32(reader["TongDiemTichLuy"]), // Tổng điểm tích lũy  
                            NgayLap = Convert.ToDateTime(reader["NgayLap"]), // Ngày lập thẻ                         
                            HoTenKhachHang = reader["HoTenKhachHang"].ToString(),
                            HoTenNhanVien = reader["TenNhanVienLap"].ToString() // Họ tên nhân viên lập thẻ
                        };
                        customerCards.Add(customerCard);
                    }
                }
            }
            return customerCards;
        }

        public static List<CustomerCard> SearchCustomerCards(string searchTerm, string branchID)
        {
            List<CustomerCard> customerCards = new List<CustomerCard>();
            string query = "sp_LayThongTinTheThanhVien"; // Tên stored procedure cho tìm kiếm

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ChiNhanh", branchID);
                   

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Kiểm tra xem mã số thẻ hoặc họ tên khách hàng có chứa searchTerm không
                        if (reader["MaSoThe"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                            reader["HoTenKhachHang"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            CustomerCard customerCard = new CustomerCard
                            {
                                MaSoThe = reader["MaSoThe"].ToString(),
                                LoaiThe = reader["LoaiThe"].ToString(),
                                TongDiemTichLuy = Convert.ToInt32(reader["TongDiemTichLuy"]), // Tổng điểm tích lũy  
                                NgayLap = Convert.ToDateTime(reader["NgayLap"]), // Ngày lập thẻ                         
                                HoTenKhachHang = reader["HoTenKhachHang"].ToString(),
                                HoTenNhanVien = reader["TenNhanVienLap"].ToString() // Họ tên nhân viên lập thẻ
                            };
                            customerCards.Add(customerCard);
                        }
                    }
                }
            }
            return customerCards;
        }
    }

    public class FoodItem
    {
        public string MaMonAn { get; set; } // Mã món ăn
        public string TenMonAn { get; set; } // Tên món ăn
        public string TenMuc { get; set; } // Mã mục
        public decimal GiaHienTai { get; set; } // Giá hiện tại
        public int TinhTrangPhucVu { get; set; } // Tình trạng phục vụ

        public static List<FoodItem> LoadFoodItemsFromProcedure(string branchID)
        {
            List<FoodItem> foodItems = new List<FoodItem>();
            string query = "CheckMonAnForChiNhanhByMaChiNhanh"; // Tên stored procedure

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


    //public class Statistic
    //{

    //    public string MaChiNhanh { get; set; }
    //    public string TenChiNhanh { get; set; }
    //    public string ThoiGian { get; set; }
    //    public decimal TongDoanhThu { get; set; }

    //    private string connectionString = Branch.con_string; // Kết nối từ Branch

    //    // Phương thức thực hiện gọi stored procedure để lấy doanh thu theo thời gian và chi nhánh
    //    public List<Statistic> GetDoanhThu(string thoiGian, string branchID)
    //    {
    //        List<Statistic> doanhThus = new List<Statistic>();
    //        string query = "SP_ThongKeDoanhThuTheoChiNhanh"; // Tên stored procedure

    //        using (SqlConnection con = new SqlConnection(connectionString))
    //        {
    //            using (SqlCommand cmd = new SqlCommand(query, con))
    //            {
    //                cmd.CommandType = CommandType.StoredProcedure;

    //                // Thêm tham số cho stored procedure
    //                cmd.Parameters.AddWithValue("@ThoiGian", thoiGian); // 'NGAY', 'THANG', 'QUY', 'NAM'
    //                if (!string.IsNullOrEmpty(branchID))
    //                {
    //                    cmd.Parameters.AddWithValue("@MaChiNhanh", branchID); // Tham số cho mã chi nhánh, nếu có
    //                }
    //                else
    //                {
    //                    cmd.Parameters.AddWithValue("@MaChiNhanh", DBNull.Value); // Nếu không có mã chi nhánh, truyền NULL
    //                }

    //                con.Open();
    //                SqlDataReader reader = cmd.ExecuteReader();
    //                while (reader.Read())
    //                {
    //                    Statistic doanhThu = new Statistic
    //                    {
    //                        MaChiNhanh = reader["MaChiNhanh"].ToString(),
    //                        TenChiNhanh = reader["TenChiNhanh"].ToString(),
    //                        ThoiGian = reader["Ngay"].ToString(), // Có thể là Ngày, Tháng, Quý, Năm
    //                        TongDoanhThu = Convert.ToDecimal(reader["TongDoanhThu"])
    //                    };
    //                    doanhThus.Add(doanhThu);
    //                }
    //            }
    //        }
    //        return doanhThus;
    //    }

    //    public class StatisticBLL
    //    {
    //        private Statistic statistic;

    //        public StatisticBLL()
    //        {
    //            statistic = new Statistic(); // Khởi tạo lớp Statistic (DAL)
    //        }

    //        // Phương thức gọi Statistic để lấy doanh thu theo thời gian và chi nhánh
    //        public List<Statistic> GetDoanhThu(string thoiGian, string maChiNhanh = null)
    //        {
    //            return statistic.GetDoanhThu(thoiGian, maChiNhanh); // Gọi phương thức trong DAL
    //        }
    //    }
    //}

    // Đảm bảo đã khai báo các thư viện cần thiết ở đầu file


    public class Statistic
    {
        // Kết nối đến cơ sở dữ liệu
        private string connectionString = "Server=LAPTOP-80T8CRON; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;";

        // Hàm để gọi stored procedure và lấy doanh thu theo chi nhánh
        public decimal GetDoanhThuTheoChiNhanh(string thoiGian, string branchID)
        {
            decimal doanhThu = 0;

            // Cấu trúc câu lệnh SQL để gọi stored procedure
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_ThongKeDoanhThuTheoChiNhanh", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    command.Parameters.AddWithValue("@ThoiGian", thoiGian); // 'NGAY', 'THANG', 'QUY', hoặc 'NAM'
                    command.Parameters.AddWithValue("@MaChiNhanh", branchID ?? (object)DBNull.Value);

                    // Mở kết nối và thực thi câu lệnh
                    connection.Open();

                    // Thực hiện truy vấn và lấy kết quả trả về
                    var result = command.ExecuteScalar();
                    // Kiểm tra và chuyển đổi kết quả trả về
                    if (result != null && result != DBNull.Value)
                    {
                        if (decimal.TryParse(result.ToString(), out decimal tempDoanhThu))
                        {
                            doanhThu = tempDoanhThu;
                        }
                        else
                        {
                            doanhThu = 0; // Xử lý an toàn khi kết quả không hợp lệ
                        }
                    }
                }
            }

            return doanhThu;
        }

    }

}

