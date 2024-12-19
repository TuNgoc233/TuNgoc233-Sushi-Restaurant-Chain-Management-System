using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.Admin
{
    public partial class Tranfer : Form
    {
        public event Action TransferCompleted;

        private string _dgvID;
        // Constructor nhận hai tham số
        public Tranfer(string dgvID)
        {
            InitializeComponent();
            _dgvID = dgvID;
            LoadBranchIds(); // Gọi phương thức để tải mã chi nhánh
        }

        public void Tranfer_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadBranchIds()
        {
            List<string> branchIds = new List<string>();
            string query = "SELECT MaChiNhanh FROM Chi_Nhanh"; // Truy vấn SQL để lấy mã chi nhánh

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        branchIds.Add(reader["MaChiNhanh"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            guna2ComboBox2.Items.Clear();

            // Thêm mã chi nhánh vào ComboBox
            foreach (var branchId in branchIds)
            {
                guna2ComboBox2.Items.Add(branchId);
            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox2.SelectedItem != null)
            {
                string selectedBranchId = guna2ComboBox2.SelectedItem.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Giả sử bạn đã có mã nhân viên và mã chi nhánh hiện tại
            string employeeId = _dgvID; // Thay thế bằng mã nhân viên thực tế
            string targetBranchId = guna2ComboBox2.SelectedItem?.ToString(); // Mã chi nhánh muốn chuyển

            // Kiểm tra xem mã chi nhánh muốn chuyển có hợp lệ không
            if (string.IsNullOrEmpty(targetBranchId))
            {
                MessageBox.Show("Vui lòng chọn mã chi nhánh muốn chuyển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi stored procedure
            string query = "sp_ChuyenChiNhanh"; // Tên stored procedure

            using (SqlConnection con = new SqlConnection(Branch.con_string))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số vào command
                    cmd.Parameters.AddWithValue("@MaNhanVien", employeeId);
                    cmd.Parameters.AddWithValue("@MaChiNhanhChuyen", targetBranchId); // Mã chi nhánh muốn chuyển

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Chuyển chi nhánh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TransferCompleted?.Invoke(); // Gọi sự kiện sau khi thành công
                        this.Close(); // Đóng form
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.Hide();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
