using Guna.UI2.WinForms;
using Sushi_Restaurant.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12);
            this.guna2DataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11);

            // Thiết lập màu nền và màu chữ cho Header
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 55, 89);
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false; // Bắt buộc phải tắt thuộc tính này để màu tùy chỉnh có hiệu lực

            // Tăng chiều cao Header
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.RowTemplate.Height = 25; // Tăng chiều cao lên 50 (hoặc giá trị bạn muốn)

        }
        private void frmPOS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            string maChiNhanh = MainClass.user.MaChiNhanh;
            AddCategory(maChiNhanh);
            ProductPanel.Controls.Clear();
            LoadProducts(maChiNhanh, "All");
        }

        private void AddCategory(string maChiNhanh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    // Gọi procedure
                    string procedureName = "GetMucByKhuVucAndThucDon";

                    using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        conn.Open();
                        da.Fill(dt);

                        // Làm sạch các mục cũ trong CategoryPanel
                        CategoryPanel.Controls.Clear();

                        // Thêm nút "Tất cả"
                        Guna.UI2.WinForms.Guna2Button btnAll = new Guna.UI2.WinForms.Guna2Button
                        {
                            FillColor = Color.FromArgb(50, 55, 89),
                            Size = new Size(134, 45),
                            ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton,
                            Text = "Tất cả",
                            Tag = "All"
                        };
                        btnAll.Click += new EventHandler(_Click);
                        CategoryPanel.Controls.Add(btnAll);

                        // Thêm nút "Best-Seller"
                        Guna.UI2.WinForms.Guna2Button btnBestSeller = new Guna.UI2.WinForms.Guna2Button
                        {
                            FillColor = Color.FromArgb(50, 55, 89),
                            Size = new Size(134, 45),
                            ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton,
                            Text = "Best-Seller",
                            Tag = "BestSeller"
                        };
                        btnBestSeller.Click += new EventHandler(_Click);
                        CategoryPanel.Controls.Add(btnBestSeller);

                        // Kiểm tra nếu có dữ liệu từ procedure
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                // Tạo button cho mỗi danh mục
                                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button
                                {
                                    FillColor = Color.FromArgb(50, 55, 89),
                                    Size = new Size(134, 45),
                                    ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton,
                                    Text = row["TenMuc"].ToString(),
                                    Tag = row["MaMuc"] // Gán mã danh mục vào Tag
                                };

                                // Thêm event click cho button
                                b.Click += new EventHandler(_Click);

                                // Thêm button vào CategoryPanel (FlowLayoutPanel)
                                CategoryPanel.Controls.Add(b);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message);
            }
        }


        private void LoadProducts(string maChiNhanh, string maMuc = "All")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainClass.con_string))
                {
                    // Gọi procedure
                    string procedureName = "CheckMonAnForChiNhanhByMaChiNhanh";

                    using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaChiNhanh", maChiNhanh);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        conn.Open();
                        da.Fill(dt);

                        ProductPanel.Controls.Clear(); // Xóa các sản phẩm cũ trong ProductPanel

                        foreach (DataRow row in dt.Rows)
                        {
                            // Lọc sản phẩm theo danh mục nếu cần
                            if (maMuc != "All" && row["MaMuc"].ToString() != maMuc)
                                continue;

                            string productCode = row["MaMonAn"].ToString(); // Lấy mã món ăn
                            Image productImage = LoadImageFromResources(productCode); // Tải hình ảnh từ Resources dựa trên mã món ăn

                            // Kiểm tra tình trạng phục vụ
                            bool isAvailable = Convert.ToBoolean(row["TinhTrangPhucVu"]);

                            // Thêm sản phẩm vào panel
                            AddItems(
                                productCode,                       // Mã món ăn
                                row["TenMonAn"].ToString(),        // Tên món ăn
                                row["MaMuc"].ToString(),           // Danh mục món ăn
                                row["GiaHienTai"].ToString(),      // Giá của món ăn
                                productImage,                      // Hình ảnh của món ăn
                                isAvailable                        // Tình trạng phục vụ
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải sản phẩm: " + ex.Message);
            }
        }



        private void _Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            string selectedCategory = b.Tag.ToString(); // Lấy giá trị Tag của button

            foreach (var item in ProductPanel.Controls)
            {
                if (item is ucProduct pro)
                {
                    if (selectedCategory == "All")
                    {
                        // Hiển thị tất cả các sản phẩm
                        pro.Visible = true;
                    }
                    else if (selectedCategory == "BestSeller")
                    {
                        // Hiển thị sản phẩm Best-Seller (tùy logic của bạn, ví dụ dựa trên thuộc tính BestSeller của ucProduct)
                        //pro.Visible = pro.IsBestSeller; // Giả sử ucProduct có thuộc tính IsBestSeller
                    }
                    else
                    {
                        // Hiển thị sản phẩm nếu danh mục khớp, ẩn nếu không khớp
                        pro.Visible = pro.PCategory.Trim() == selectedCategory;
                    }
                }
            }

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (guna2DataGridView1.Columns[e.ColumnIndex].Name == "dgvTru") // Nút giảm
                {
                    var qtyCell = guna2DataGridView1.Rows[e.RowIndex].Cells["dgvQty"];
                    var priceCell = guna2DataGridView1.Rows[e.RowIndex].Cells["dgvPrice"];
                    var amountCell = guna2DataGridView1.Rows[e.RowIndex].Cells["dgvAmount"];

                    if (int.TryParse(qtyCell.Value.ToString(), out int qty) && qty > 1 &&
                        double.TryParse(priceCell.Value.ToString(), out double price))
                    {
                        qtyCell.Value = --qty; // Giảm số lượng
                        amountCell.Value = qty * price; // Cập nhật tổng giá trị
                        GetTotal();
                    }
                }
                else if (guna2DataGridView1.Columns[e.ColumnIndex].Name == "dgvCong") // Nút tăng
                {
                    var qtyCell = guna2DataGridView1.Rows[e.RowIndex].Cells["dgvQty"];
                    var priceCell = guna2DataGridView1.Rows[e.RowIndex].Cells["dgvPrice"];
                    var amountCell = guna2DataGridView1.Rows[e.RowIndex].Cells["dgvAmount"];

                    if (int.TryParse(qtyCell.Value.ToString(), out int qty) &&
                        double.TryParse(priceCell.Value.ToString(), out double price))
                    {
                        qtyCell.Value = ++qty; // Tăng số lượng
                        amountCell.Value = qty * price; // Cập nhật tổng giá trị
                        GetTotal();
                    }
                }
                else if (guna2DataGridView1.Columns[e.ColumnIndex].Name == "dgvDel") // Nút xóa
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
                        guna2DataGridView1.Rows.RemoveAt(e.RowIndex);

                        // Cập nhật tổng giá trị sau khi xóa
                        GetTotal();
                    }
                }
            }
        }


        private void AddItems(string id, string name, string cat, string price, Image pimage, bool isAvailable)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = id,
                IsAvailable = isAvailable // Gán trạng thái phục vụ
            };

            // Kiểm tra trạng thái phục vụ
            if (!isAvailable)
            {
                w.Enabled = false; // Vô hiệu hóa toàn bộ `ucProduct` nếu không khả dụng
                w.BackColor = Color.LightGray; // Tô mờ nền để phân biệt
            }

            ProductPanel.Controls.Add(w);

            w.onSelect += (SetStyle, ee) =>
            {
                if (!isAvailable) return; // Không xử lý nếu món ăn không khả dụng

                var wdg = (ucProduct)SetStyle;
                Debug.WriteLine($"Selected: {wdg.PName}");

                // Logic xử lý khi món ăn được chọn
                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    if (item.Cells["dgvId"].Value != null && item.Cells["dgvId"].Value.ToString() == wdg.id)
                    {
                        if (int.TryParse(item.Cells["dgvQty"].Value.ToString(), out int currentQty) &&
                            double.TryParse(item.Cells["dgvPrice"].Value.ToString(), out double itemPrice))
                        {
                            int newQty = currentQty + 1;
                            item.Cells["dgvQty"].Value = newQty;
                            item.Cells["dgvAmount"].Value = newQty * itemPrice;

                            GetTotal(); // Cập nhật tổng giá trị sau khi thay đổi
                        }
                        return;
                    }
                }

                // Nếu sản phẩm chưa tồn tại, thêm dòng mới
                guna2DataGridView1.Rows.Add(new object[] {
            guna2DataGridView1.Rows.Count + 1, // Số thứ tự (dgvSTT)
            wdg.id,                            // Mã sản phẩm
            wdg.PName,                         // Tên sản phẩm
            "-",                               // Button giảm số lượng (dgvTru)
            1,                                 // Số lượng ban đầu (dgvQty)
            "+",                               // Button tăng số lượng (dgvCong)
            wdg.PPrice,                        // Giá đơn vị (dgvPrice)
            double.Parse(wdg.PPrice),          // Tổng giá trị (dgvAmount)
        });

                // Cập nhật tổng giá trị toàn bộ
                GetTotal();
            };
        }

        //private void LoadProducts()
        //{
        //    using (SqlConnection conn = new SqlConnection(MainClass.con_string))
        //    {
        //        string query = "SELECT * FROM MON_AN";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();

        //        conn.Open();
        //        da.Fill(dt);

        //        ProductPanel.Controls.Clear(); // Xóa các sản phẩm cũ trong ProductPanel

        //        foreach (DataRow row in dt.Rows)
        //        {
        //            string productCode = row["MaMonAn"].ToString(); // Lấy mã món ăn
        //            Image productImage = LoadImageFromResources(productCode); // Tải hình ảnh từ Resources dựa trên mã món ăn

        //            // Thêm sản phẩm vào panel
        //            AddItems(
        //                productCode,                       // Mã món ăn
        //                row["TenMonAn"].ToString(),        // Tên món ăn
        //                row["MaMuc"].ToString(),           // Danh mục món ăn
        //                row["GiaHienTai"].ToString(),      // Giá của món ăn
        //                productImage                       // Hình ảnh của món ăn
        //            );
        //        }
        //    }
        //}


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
                    return Properties.Resources.bill; // Hình ảnh mặc định nếu không tìm thấy
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading image from Resources: {ex.Message}");
                return Properties.Resources.bill; // Hình ảnh mặc định nếu có lỗi
            }
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {

                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtTimKiem.Text.Trim().ToLower());


            }
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // dat 1 mon nhieu lan
            int count = 0;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                row.Cells[0].Value = ++count;
            }
        }

        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                var cellValue = item.Cells["dgvAmount"].Value;
                if (cellValue != null && double.TryParse(cellValue.ToString(), out double cellAmount))
                {
                    tot += cellAmount;
                }
            }
            lblTotal.Text = tot.ToString("N2");
        }

        private void btnDin_Click(object sender, EventArgs e)
        {

            DSPhieuDatTrucTiep frm = new DSPhieuDatTrucTiep();
            MainClass.BlurBackground(frm);
            if (frm.MainId != "")
            {
                id = frm.MainId;
                LoadEntries_PDTT();
            }
        }

        private void LoadEntries_PDTT()
        {
            string qry = @"SELECT MA.TenMonAn, CT.SoLuong, MA.GiaHienTai, CT.SoLuong * MA.GiaHienTai AS ThanhTien, MA.MaMonAn
                   FROM PHIEU_DAT_TRUC_TIEP PD
                   JOIN CHI_TIET_DAT_MON CT ON CT.MaPhieu = PD.MaPhieu
                   JOIN MON_AN MA ON MA.MaMonAn = CT.MaMonAn
                   WHERE PD.MaPhieu = @MaPhieu"; // Sử dụng parameter

            using (SqlCommand cmd2 = new SqlCommand(qry, MainClass.con))
            {
                // Thêm tham số để tránh SQL Injection
                cmd2.Parameters.AddWithValue("@MaPhieu", id);

                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                try
                {
                    da2.Fill(dt2);

                    guna2DataGridView1.Rows.Clear();

                    foreach (DataRow item in dt2.Rows)
                    {
                        // Thêm một hàng mới và lấy chỉ số của hàng đó
                        int rowIndex = guna2DataGridView1.Rows.Add();

                        // Gán giá trị cho từng ô cụ thể theo tên cột
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvId"].Value = item["MaMonAn"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvName"].Value = item["TenMonAn"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvQty"].Value = item["SoLuong"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvPrice"].Value = item["GiaHienTai"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvAmount"].Value = item["ThanhTien"].ToString();
                    }
                    GetTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        public string id = "";

        private void btnBill_Click(object sender, EventArgs e)
        {
            HoaDon frm = new HoaDon();
            MainClass.BlurBackground(frm);
            if (frm.MainId != "")
            {
                id = frm.MainId;
                
                LoadEntries_HD();

            }
        }

        private void LoadEntries_HD()
        {
            string qry = @"SELECT MA.TenMonAn, CT.SoLuong, MA.GiaHienTai, CT.SoLuong * MA.GiaHienTai AS ThanhTien, MA.MaMonAn
                   FROM HOA_DON HD
                   JOIN PHIEU_DAT_MON PD ON PD.MaPhieu = HD.MaPhieuDatMon
                   JOIN CHI_TIET_DAT_MON CT ON CT.MaPhieu = PD.MaPhieu
                   JOIN MON_AN MA ON MA.MaMonAn = CT.MaMonAn
                   WHERE HD.MaHoaDon = @MaHoaDon"; // Sử dụng parameter

            using (SqlCommand cmd2 = new SqlCommand(qry, MainClass.con))
            {
                // Thêm tham số để tránh SQL Injection
                cmd2.Parameters.AddWithValue("@MaHoaDon", id);

                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                try
                {
                    da2.Fill(dt2);
                    

                    guna2DataGridView1.Rows.Clear();

                    foreach (DataRow item in dt2.Rows)
                    {
                        // Thêm một hàng mới và lấy chỉ số của hàng đó
                        int rowIndex = guna2DataGridView1.Rows.Add();

                        // Gán giá trị cho từng ô cụ thể theo tên cột
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvId"].Value = item["MaMonAn"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvName"].Value = item["TenMonAn"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvQty"].Value = item["SoLuong"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvPrice"].Value = item["GiaHienTai"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvAmount"].Value = item["ThanhTien"].ToString();
                    }
                    GetTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new PhieuDatTrucTiep());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            frmThanhtoan frm=new frmThanhtoan();
            frm.MainID = id;
            frm.amt=Convert.ToDouble(lblTotal.Text);
            MainClass.BlurBackground(frm);

            guna2DataGridView1.Rows.Clear();
            lblTotal.Text = "0";    

        }

        

        private void btnReservation_Click(object sender, EventArgs e)
        {
            DsPhieuDatBan frm = new DsPhieuDatBan();
            MainClass.BlurBackground(frm);
            if (frm.MainId != "")
            {
                id = frm.MainId;
                LoadEntries_PDB();  

            }
        }

        private void LoadEntries_PDB()
        {
            string qry = @"SELECT MA.TenMonAn, CT.SoLuong, MA.GiaHienTai, CT.SoLuong * MA.GiaHienTai AS ThanhTien, MA.MaMonAn
                   FROM PHIEU_DAT_BAN PD
                   JOIN CHI_TIET_DAT_MON CT ON CT.MaPhieu = PD.MaPhieu
                   JOIN MON_AN MA ON MA.MaMonAn = CT.MaMonAn
                   WHERE PD.MaPhieu = @MaPhieu"; // Sử dụng parameter

            using (SqlCommand cmd2 = new SqlCommand(qry, MainClass.con))
            {
                // Thêm tham số để tránh SQL Injection
                cmd2.Parameters.AddWithValue("@MaPhieu", id);

                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                try
                {
                    da2.Fill(dt2);


                    guna2DataGridView1.Rows.Clear();

                    foreach (DataRow item in dt2.Rows)
                    {
                        // Thêm một hàng mới và lấy chỉ số của hàng đó
                        int rowIndex = guna2DataGridView1.Rows.Add();

                        // Gán giá trị cho từng ô cụ thể theo tên cột
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvId"].Value = item["MaMonAn"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvName"].Value = item["TenMonAn"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvQty"].Value = item["SoLuong"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvPrice"].Value = item["GiaHienTai"].ToString();
                        guna2DataGridView1.Rows[rowIndex].Cells["dgvAmount"].Value = item["ThanhTien"].ToString();
                    }
                    GetTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }
    }
}