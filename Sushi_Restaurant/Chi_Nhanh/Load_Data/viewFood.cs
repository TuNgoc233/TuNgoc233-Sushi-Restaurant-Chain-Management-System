using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class viewFood : SampleView
    {
        public viewFood()
        {
            InitializeComponent();
            this.Load += new EventHandler(viewAdd_Load); // Đăng ký sự kiện Load
            //texRole.SelectedIndexChanged += textRole_SelectedIndexChanged;

        }

        public override void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text.Trim(); // Lấy chuỗi tìm kiếm từ TextBox
            string branchID = Branch.MaChiNhanh; // Lấy mã chi nhánh từ lớp Branch

            // Gọi phương thức tìm kiếm món ăn
            List<FoodItem> foodItems = FoodItem.SearchFoodItems(searchTerm, branchID);

            // Xóa các dòng hiện có trong DataGridView
            Data_Load.Rows.Clear();

            // Hiển thị kết quả tìm kiếm
            foreach (var item in foodItems)
            {
                // Định dạng giá theo định dạng 000.000 VND
                string formattedPrice = item.GiaHienTai.ToString("N0", CultureInfo.InvariantCulture) + " VND";

                // Chuyển đổi tình trạng phục vụ từ BIT sang "Có" hoặc "Không"
                string serviceStatus = item.TinhTrangPhucVu == 1 ? "Có" : "Không";

                // Thêm dữ liệu vào DataGridView
                Data_Load.Rows.Add(
                    item.MaMonAn,
                    item.TenMonAn,
                    item.TenMuc,
                    formattedPrice,
                    serviceStatus // Sử dụng biến serviceStatus
                );
            }
        }

        private void viewAdd_Load(object sender, EventArgs e)
        {
            // Lấy chuỗi tìm kiếm từ TextBox
            string searchTerm = txtTimKiem.Text.Trim();
            // Lấy mã chi nhánh từ lớp Branch
            string branchID = Branch.MaChiNhanh;

            // Gọi phương thức tìm kiếm món ăn
            List<FoodItem> foodItems = FoodItem.LoadFoodItemsFromProcedure(branchID);

            // Xóa các dòng hiện có trong DataGridView
            Data_Load.Rows.Clear();

            // Hiển thị kết quả tìm kiếm
            foreach (var item in foodItems)
            {
                // Chuyển đổi tình trạng phục vụ từ BIT sang "Có" hoặc "Không"
                string serviceStatus = item.TinhTrangPhucVu == 1 ? "Có" : "Không";
                string formattedPrice = item.GiaHienTai.ToString("N0") + " VND";

                Data_Load.Rows.Add(
                    item.MaMonAn,
                    item.TenMonAn,
                    item.TenMuc,
                    formattedPrice,
                    serviceStatus
                );
            }
        }

        public void label2_Click_1(object sender, EventArgs e)
        {

        }

        public void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void data_Load(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void Insert_Item_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường dữ liệu có rỗng không
            if (string.IsNullOrWhiteSpace(texName.Text) ||
                string.IsNullOrWhiteSpace(texID.Text) ||
                string.IsNullOrWhiteSpace(texMark.Text) ||
                texRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra giá trị có hợp lệ không
            if (!decimal.TryParse(texMark.Text, out decimal gia))
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy giá trị từ các trường nhập liệu
            string maMonAn = texID.Text.Trim();
            string tenMonAn = texName.Text.Trim();
            string muc = texRole.SelectedItem.ToString();
            // Chuyển đổi tình trạng phục vụ từ "Có"/"Không" thành 1/0
            int giaoMon = guna2RadioButton1.Checked ? 1 : 0;

            // Chuỗi kết nối với cơ sở dữ liệu
            string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;";

            // Tên thủ tục lưu trữ
            string storedProcedure = "sp_ThemMonAn";
            // Giá trị tham số
            string branchID = Branch.MaChiNhanh; // Lấy mã chi nhánh từ lớp Branch

            try
            {
                using (SqlConnection conn = new SqlConnection(con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                    {
                        // Chỉ định rằng đây là một thủ tục lưu trữ
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho thủ tục
                        cmd.Parameters.AddWithValue("@MaChiNhanh", branchID);
                        cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
                        cmd.Parameters.AddWithValue("@TenMonAn", tenMonAn);
                        cmd.Parameters.AddWithValue("@GiaHienTai", gia);
                        cmd.Parameters.AddWithValue("@TenMuc", muc);
                        cmd.Parameters.AddWithValue("@GiaoMon", giaoMon); // Gửi 1 hoặc 0

                        // Thực thi lệnh SQL
                        cmd.ExecuteNonQuery();
                    }
                }

                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Thêm dữ liệu vào DataGridView
                string formattedPrice = gia.ToString("N0", CultureInfo.InvariantCulture) + " VND";
                Data_Load.Rows.Add(maMonAn, tenMonAn, muc, formattedPrice, giaoMon == 1 ? "Có" : "Không");

                // Làm mới các trường nhập liệu
                texName.Text = "";
                texID.Text = "";
                texMark.Text = "";
                texRole.SelectedIndex = -1;
                guna2RadioButton1.Checked = false;
                //guna2RadioButton2.Checked = false; // Nếu cần, có thể bỏ comment dòng này
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void texRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddRoles()
        {
            // Chuỗi kết nối với cơ sở dữ liệu
            string con_string = "Server=NHU\\SQLEXPRESS; Database=QLNH_SUSHI_2024_FINAL; Trusted_Connection=True; Connection Timeout=120;";

            // Truy vấn SQL
            string query = @"
                    SELECT 
                        M.TenMuc
                    FROM 
                        CHI_NHANH CN
                    JOIN 
                        THUC_DON_MUC TDM ON CN.MaThucDon = TDM.MaThucDon AND CN.ThanhPho = TDM.KhuVuc
                    JOIN 
                        MUC M ON TDM.MaMuc = M.MaMuc
                    WHERE 
                        CN.MaChiNhanh = @MaChiNhanh";

            // Giá trị tham số
            string branchID = Branch.MaChiNhanh; // Lấy mã chi nhánh từ lớp Branch

            try
            {
                using (SqlConnection conn = new SqlConnection(con_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số cho truy vấn
                        cmd.Parameters.AddWithValue("@MaChiNhanh", branchID);

                        // Đọc dữ liệu
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Xóa dữ liệu cũ trong ComboBox (nếu có)
                            texRole.Items.Clear();

                            // Đổ dữ liệu vào ComboBox
                            while (reader.Read())
                            {
                                texRole.Items.Add(reader["TenMuc"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void texName_TextChanged(object sender, EventArgs e)
        {

        }

        private void texID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            AddRoles();
        }
    }
}
