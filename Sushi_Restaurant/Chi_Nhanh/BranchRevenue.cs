using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class BranchRevenue : Form
    {
        public string _branchId;  // Biến lưu trữ ID chi nhánh
        private Statistic statistic = new Statistic();
        public BranchRevenue(string branchId)
        {
            InitializeComponent();
            _branchId = branchId;

            // Kiểm tra giá trị mã chi nhánh
            if (string.IsNullOrEmpty(Branch.MaChiNhanh))
            {
                MessageBox.Show("Mã chi nhánh chưa được xác định. Vui lòng đăng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Đóng form nếu không có mã chi nhánh
            }
        }

        private void buttonXemNgay_Click(object sender, EventArgs e)
        {
            decimal doanhThu = statistic.GetDoanhThuTheoChiNhanh("NGAY", Branch.MaChiNhanh);

            labelDoanhThuNgay.Text = $"Doanh thu theo ngày: {doanhThu:N0} VND";
        }

        private void buttonXemThang_Click(object sender, EventArgs e)
        {
            decimal doanhThu = statistic.GetDoanhThuTheoChiNhanh("THANG", Branch.MaChiNhanh);

            labelDoanhThuThang.Text = $"Doanh thu theo tháng: {doanhThu:N0} VND";
        }

        private void buttonXemQuy_Click(object sender, EventArgs e)
        {
            decimal doanhThu = statistic.GetDoanhThuTheoChiNhanh("QUY", Branch.MaChiNhanh);

            labelDoanhThuQuy.Text = $"Doanh thu theo quý: {doanhThu:N0} VND";
        }

        private void buttonXemNam_Click(object sender, EventArgs e)
        {
            decimal doanhThu = statistic.GetDoanhThuTheoChiNhanh("NAM", Branch.MaChiNhanh);

            labelDoanhThuNam.Text = $"Doanh thu theo năm: {doanhThu:N0} VND";
        }

    }
}
