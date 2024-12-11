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

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();
            ProductPanel.Controls.Clear();
            LoadProducts();
        }

        private void AddCategory()
        {
            // Truy vấn dữ liệu từ bảng MUC
            string qry = "SELECT * FROM MUC";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Làm sạch các mục cũ trong CategoryPanel
            CategoryPanel.Controls.Clear();

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
            CategoryPanel.Controls.Add(btnAll);

            // Thêm nút "Best-Seller"
            Guna.UI2.WinForms.Guna2Button btnBestSeller = new Guna.UI2.WinForms.Guna2Button
            {
                FillColor = Color.FromArgb(50, 55, 89),
                Size = new Size(134, 45), // Kích thước của button
                ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton,
                Text = "Best-Seller",
                Tag = "BestSeller" // Gán Tag đặc biệt
            };
            btnBestSeller.Click += new EventHandler(_Click);
            CategoryPanel.Controls.Add(btnBestSeller);

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
                    CategoryPanel.Controls.Add(b);
                }
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

            ProductPanel.Controls.Add(w);

            w.onSelect += (SetStyle, ee) =>
            {
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

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(MainClass.con_string))
            {
                string query = "SELECT * FROM MON_AN";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                da.Fill(dt);

                ProductPanel.Controls.Clear(); // Xóa các sản phẩm cũ trong ProductPanel

                foreach (DataRow row in dt.Rows)
                {
                    string productCode = row["MaMonAn"].ToString(); // Lấy mã món ăn
                    Image productImage = LoadImageFromResources(productCode); // Tải hình ảnh từ Resources dựa trên mã món ăn

                    // Thêm sản phẩm vào panel
                    AddItems(
                        productCode,                       // Mã món ăn
                        row["TenMonAn"].ToString(),        // Tên món ăn
                        row["MaMuc"].ToString(),           // Danh mục món ăn
                        row["GiaHienTai"].ToString(),      // Giá của món ăn
                        productImage                       // Hình ảnh của món ăn
                    );
                }
            }
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
            // tao phieu dat truc tiep
            PhieuDatTrucTiep pdtt = new PhieuDatTrucTiep();
            //MainClass.BlurBackground();
        }


        //private void btnBill_Click(object sender, EventArgs e)
        //{
        //    MainClass.BlurBackground(new HoaDon());
        //}
    }
}