using Guna.UI2.WinForms;
using Sushi_Restaurant.Model;
using Sushi_Restaurant.NhanVien;
using Sushi_Restaurant.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Sushi_Restaurant
{
    public partial class FrmDatMon : Form
    {
        public FrmDatMon()
        {
            InitializeComponent();


        }

        private void FrmDatMon_Load(object sender, EventArgs e)
        {
            AddCategory();
            panel_Product.Controls.Clear();
            LoadProducts();

        }

        private void _Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            string selectedCategory = b.Tag.ToString();
            Debug.WriteLine($"Selected Category: {selectedCategory}");

            foreach (var item in panel_Product.Controls)
            {
                if (item is ucProduct pro)
                {
                    Debug.WriteLine($"Product Category: {pro.PCategory}"); // Debug
                    if (selectedCategory == "All")
                    {
                        // Hiển thị tất cả các sản phẩm
                        pro.Visible = true;
                    }
                    //else if (selectedCategory == "BestSeller")
                    //{
                    //    // Hiển thị sản phẩm Best-Seller (tùy logic của bạn, ví dụ dựa trên thuộc tính BestSeller của ucProduct)
                    //    //pro.Visible = pro.IsBestSeller; // Giả sử ucProduct có thuộc tính IsBestSeller
                    //}
                    else
                    {
                        // Hiển thị sản phẩm nếu danh mục khớp, ẩn nếu không khớp
                        pro.Visible = pro.PCategory.Trim() == selectedCategory;
                    }
                }
            }

        }
        private void AddCategory()
        {

            using (SqlConnection con = new SqlConnection(MainClass.con_string))
            {

                con.Open(); // Mở kết nối

                // Khai báo lệnh SQL gọi stored procedure
                SqlCommand cmd = new SqlCommand("NXHanh_LayDanhMucMonAnCuaChiNhanh", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số cho stored procedure
                cmd.Parameters.AddWithValue("@MaChiNhanh", GlobalVariables.MaChiNhanh);

                // Sử dụng SqlDataAdapter để lấy dữ liệu
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                // Thực thi stored procedure và điền dữ liệu vào DataTable
                da.Fill(dt);

                // Làm sạch các mục cũ trong CategoryPanel
                panel_Category.Controls.Clear();

                // Thêm nút "Tất cả"
                Guna.UI2.WinForms.Guna2Button btnAll = new Guna.UI2.WinForms.Guna2Button
                {
                    FillColor = Color.FromArgb(50, 55, 89),
                    Size = new Size(134, 45), // Kích thước của button
                    ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton,
                    Text = "Tất cả",
                    Tag = "All" // Gán Tag đặc biệt
                };
                btnAll.Click += new EventHandler(_Click);
                panel_Category.Controls.Add(btnAll);

                // Kiểm tra nếu có dữ liệu từ bảng MUC
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        // Tạo button cho mỗi danh mục
                        Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                        b.FillColor = Color.FromArgb(50, 55, 89);
                        b.Size = new Size(134, 45); // Kích thước của button
                        b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                        b.Text = row["TenMuc"].ToString();
                        b.Tag = row["MaMuc"]; // Gán mã danh mục vào Tag

                        // Thêm event click cho button
                        b.Click += new EventHandler(_Click);

                        // Thêm button vào CategoryPanel (FlowLayoutPanel)
                        panel_Category.Controls.Add(b);
                    }
                }
            }
        }

        private void AddItems(string id, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = id
            };

            // Gắn event "onAddFavorite" một lần duy nhất
            //w.onAddFavorite -= AddFavoriteHandler; // Xóa handler cũ nếu có
            w.onAddFavorite += (SetStyle, ee)=>
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                    {
                        conn.Open();

                        // Kiểm tra xem món ăn đã tồn tại trong danh sách yêu thích chưa
                        using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM DANH_SACH_MON_AN_YEU_THICH WHERE MaKhachHang = @MaKhachHang AND MaMon = @MaMon", conn))
                        {
                            checkCmd.Parameters.AddWithValue("@MaKhachHang", GlobalVariables.MaKH);
                            checkCmd.Parameters.AddWithValue("@MaMon", id);

                            int count = (int)checkCmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("Món ăn này đã nằm trong danh sách yêu thích!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; // Dừng lại nếu món ăn đã tồn tại
                            }
                        }

                        // Thêm món ăn vào danh sách yêu thích
                        using (SqlCommand cmd = new SqlCommand("NXHanh_ThemMonAnYeuThich", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaKhachHang", GlobalVariables.MaKH);
                            cmd.Parameters.AddWithValue("@MaMon", id);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            MessageBox.Show("Đã thêm món ăn vào danh sách yêu thích!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm vào danh sách yêu thích: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };


            panel_Product.Controls.Add(w);

            w.onSelect += (SetStyle, ee) =>
            {
                var wdg = (ucProduct)SetStyle;
                Debug.WriteLine($"Selected: {wdg.PName}");

                // Logic xử lý khi món ăn được chọn
                foreach (DataGridViewRow item in panel_dat_hang.Rows)
                {
                    if (item.Cells["dgvId"].Value != null && item.Cells["dgvId"].Value.ToString() == wdg.id)
                    {
                        if (int.TryParse(item.Cells["so_luong"].Value.ToString(), out int currentQty) &&
                            double.TryParse(item.Cells["don_gia"].Value.ToString().Replace(".", ""), out double itemPrice))
                        {
                            int newQty = currentQty + 1;
                            item.Cells["so_luong"].Value = newQty;
                            item.Cells["thanh_tien"].Value = (newQty * itemPrice).ToString("N0", GlobalVariables.AppCultureInfo);

                            GetTotal(); // Cập nhật tổng giá trị sau khi thay đổi
                        }
                        return;
                    }
                }

               



                // Nếu sản phẩm chưa tồn tại, thêm dòng mới
                panel_dat_hang.Rows.Add(new object[] {
                            panel_dat_hang.Rows.Count + 1, // Số thứ tự (dgvSTT)
                            wdg.id,
                            wdg.PName,
                            "-",
                            1,
                            "+",
                            "",
                            wdg.PPrice,
                            wdg.PPrice
                });

                    // Cập nhật tổng giá trị toàn bộ   
                    GetTotal();
            };
        }

        // Hàm tải ảnh từ đường dẫn
        private Image LoadImageFromResources(string productCode)
        {
            try
            {
                // Truy xuất hình ảnh từ Resources bằng mã món ăn (key)
                var image = (Image)Properties.Resources.ResourceManager.GetObject(productCode);
                if (image != null)
                {
                    Debug.WriteLine($"Image found in Resources: {productCode}");
                    return image;
                }
                else
                {
                    Debug.WriteLine($"Image not found in Resources: {productCode}");
                    return Properties.Resources.icon_login; // Hình ảnh mặc định nếu không tìm thấy
                  
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading image from Resources: {ex.Message}");
                return Properties.Resources.icon_login; // Hình ảnh mặc định nếu có lỗi
            }
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(MainClass.con_string))
            {
                string query = @"
                    SELECT MA.*
                    FROM MON_AN MA
                    JOIN CHI_NHANH_MON_AN CNMA ON MA.MaMonAn = CNMA.MaMonAn
                    WHERE CNMA.MaChiNhanh = @MaChiNhanh AND MA.GiaoMon = 1";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaChiNhanh", GlobalVariables.MaChiNhanh); // Truyền tham số mã chi nhánh
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);

                panel_Product.Controls.Clear(); // Xóa các sản phẩm cũ trong ProductPanel

                foreach (DataRow row in dt.Rows)
                {
                    string productCode = row["MaMonAn"].ToString(); // Lấy mã món ăn
                    Image productImage = LoadImageFromResources(productCode); // Tải hình ảnh từ Resources dựa trên mã món ăn

                    // Lấy và định dạng giá hiện tại
                    string formattedPrice = "0"; // Giá mặc định nếu không hợp lệ
                    if (double.TryParse(row["GiaHienTai"].ToString(), out double price))
                    {
                        formattedPrice = price.ToString("N0", GlobalVariables.AppCultureInfo); // Định dạng giá với dấu phân cách
                    }

                    // Thêm sản phẩm vào panel
                    AddItems(
                        productCode,                       // Mã món ăn
                        row["TenMonAn"].ToString(),        // Tên món ăn
                        row["MaMuc"].ToString(),           // Danh mục món ăn
                        formattedPrice,         // Giá của món ăn
                        productImage                       // Hình ảnh của món ăn
                    );
                }
            }
        }

        private void but_Nguon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_giao_hang_Click(object sender, EventArgs e)
        {
            if (panel_dat_hang.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món trước khi giao hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GiaoHangView frm = new GiaoHangView();

            foreach (DataGridViewRow row in panel_dat_hang.Rows)
            {
                if (row.Cells["ten_mon"] != null && row.Cells["ten_mon"].Value != null)
                {

                    // Lấy dữ liệu từ từng dòng
                    string maMon = row.Cells["dgvId"].Value.ToString();
                    string tenMon = row.Cells["ten_mon"].Value.ToString();
                    int soLuong = int.Parse(row.Cells["so_luong"].Value.ToString());
                    double donGia = double.Parse(row.Cells["don_gia"].Value.ToString().Replace(".",""));
                    double thanhTien = double.Parse(row.Cells["thanh_tien"].Value.ToString().Replace(".",""));

                    // Thêm dữ liệu vào danh sách món ăn trong form giao hàng
                    frm.AddMonAn(maMon, tenMon, soLuong, donGia, thanhTien);
                }
            }

            // Lấy thông tin khách hàng từ hệ thống (giả sử thông tin có trong GlobalVariables hoặc cơ sở dữ liệu)
            frm.TenKhachHang = GlobalVariables.HoTenKH; // Ví dụ: Lấy từ biến toàn cục
            frm.SoDienThoai = GlobalVariables.SDTKH;

            // Hiển thị form giao hàng
            frm.Show();
            frm.Owner = this;
        }

        private void but_dat_ban_Click(object sender, EventArgs e)
        { 

            DatBanView frm = new DatBanView();

            foreach (DataGridViewRow row in panel_dat_hang.Rows)
            {
                if (row.Cells["ten_mon"] != null && row.Cells["ten_mon"].Value != null)
                {
                    // Lấy dữ liệu từ từng dòng
                    string maMon = row.Cells["dgvId"].Value.ToString();
                    string tenMon = row.Cells["ten_mon"].Value.ToString();
                    int soLuong = int.Parse(row.Cells["so_luong"].Value.ToString());
                    double donGia = double.Parse(row.Cells["don_gia"].Value.ToString().Replace(".", ""));
                    double thanhTien = double.Parse(row.Cells["thanh_tien"].Value.ToString().Replace(".", ""));

                    // Thêm dữ liệu vào danh sách món ăn trong form dat ban
                    frm.AddMonAn(maMon, tenMon, soLuong, donGia, thanhTien);
                }
            }

            // Lấy thông tin khách hàng từ hệ thống (giả sử thông tin có trong   GlobalVariables hoặc cơ sở dữ liệu)
            frm.TenKhachHang = GlobalVariables.HoTenKH; // Ví dụ: Lấy từ biến toàn cục
            frm.SoDienThoai = GlobalVariables.SDTKH;

            // Hiển thị form dat ban
            frm.Show();
            frm.Owner = this;
        }
        

        private void GetTotal()
        {
            double tot = 0;
            labelTotal.Text = "";
            foreach (DataGridViewRow item in panel_dat_hang.Rows)
            {
                var cellValue = item.Cells["thanh_tien"].Value;
                if (cellValue != null && double.TryParse(cellValue.ToString().Replace(".", ""), out double cellAmount))
                {
                    tot += cellAmount;
                }
            }
            labelTotal.Text = tot.ToString("N0", GlobalVariables.AppCultureInfo) + " VND";
        }

        private void panel_dat_hang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (panel_dat_hang.Columns[e.ColumnIndex].Name == "but_giam") // Nút giảm
                {
                    var qtyCell = panel_dat_hang.Rows[e.RowIndex].Cells["so_luong"];
                    var priceCell = panel_dat_hang.Rows[e.RowIndex].Cells["don_gia"];
                    var amountCell = panel_dat_hang.Rows[e.RowIndex].Cells["thanh_tien"];

                    if (int.TryParse(qtyCell.Value.ToString(), out int qty) && qty > 1 &&
                        double.TryParse(priceCell.Value.ToString().Replace(".",""), out double price))
                    {
                        qtyCell.Value = --qty; // Giảm số lượng
                        amountCell.Value = (qty * price).ToString("N0", GlobalVariables.AppCultureInfo); // Cập nhật tổng giá trị
                        GetTotal();
                    }
                }
                else if (panel_dat_hang.Columns[e.ColumnIndex].Name == "but_tang") // Nút tăng
                {
                    var qtyCell = panel_dat_hang.Rows[e.RowIndex].Cells["so_luong"];
                    var priceCell = panel_dat_hang.Rows[e.RowIndex].Cells["don_gia"];
                    var amountCell = panel_dat_hang.Rows[e.RowIndex].Cells["thanh_tien"];

                    if (int.TryParse(qtyCell.Value.ToString(), out int qty) &&
                        double.TryParse(priceCell.Value.ToString().Replace(".", ""), out double price))
                    {
                        qtyCell.Value = ++qty; // Tăng số lượng
                        amountCell.Value = (qty * price).ToString("N0", GlobalVariables.AppCultureInfo); // Cập nhật tổng giá trị
                        GetTotal();
                    }
                }
                else if (panel_dat_hang.Columns[e.ColumnIndex].Name == "but_Xoa") // Nút xóa
                {
                    // Hiển thị hộp thoại xác nhận
                    var result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa mục này?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Nếu người dùng chọn Yes, xóa dòng
                    if (result == DialogResult.Yes)
                    {
                        panel_dat_hang.Rows.RemoveAt(e.RowIndex);

                        UpdateRowNumbers(); // Cập nhật lại số thứ tự

                        // Cập nhật tổng giá trị sau khi xóa
                        GetTotal();
                    }
                }
            }
        }


        private void UpdateRowNumbers()
        {
            for (int i = 0; i < panel_dat_hang.Rows.Count; i++)
            {
                panel_dat_hang.Rows[i].Cells["STT"].Value = (i + 1).ToString(); // Cột STT là cột đầu tiên
            }
        }


        private void SearchProducts(string searchTerm)
        {
            using (SqlConnection conn = new SqlConnection(MainClass.con_string))
            {
                string query = @"
                SELECT MA.*
                FROM MON_AN MA
                JOIN CHI_NHANH_MON_AN CNMA ON MA.MaMonAn = CNMA.MaMonAn
                WHERE CNMA.MaChiNhanh = @MaChiNhanh 
                AND MA.GiaoMon = 1
                AND (MA.TenMonAn LIKE @SearchTerm OR MA.MaMonAn LIKE @SearchTerm)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaChiNhanh", GlobalVariables.MaChiNhanh);
                cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%"); // Tìm kiếm mờ với LIKE

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);

                panel_Product.Controls.Clear(); // Xóa kết quả cũ

                foreach (DataRow row in dt.Rows)
                {
                    string productCode = row["MaMonAn"].ToString();
                    Image productImage = LoadImageFromResources(productCode);
                    string formattedPrice = double.TryParse(row["GiaHienTai"].ToString(), out double price)
                                            ? price.ToString("N0", GlobalVariables.AppCultureInfo) : "0";

                    AddItems(
                        productCode,
                        row["TenMonAn"].ToString(),
                        row["MaMuc"].ToString(),
                        formattedPrice,
                        productImage
                    );
                }
            }
        }   
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

            string searchTerm = guna2TextBox1.Text.Trim(); // Lấy từ khóa tìm kiếm
            SearchProducts(searchTerm); // Gọi hàm tìm kiếm
        }
       
    }
}
