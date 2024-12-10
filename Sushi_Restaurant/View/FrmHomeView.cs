using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public partial class FrmHomeView : Form
    {
        public FrmHomeView()
        {
            InitializeComponent();
            LoadKhuVucData();
        }

        DataTable khuVucData;

        private void LoadKhuVucData()
        {
            //lay du lieu tu ban tam
            khuVucData = MainClass.Lay_Khu_Vuc_ChiNhanh_SDT();

            // loc cac khu vuc them vao combobox khu vuc
            var khuVucDistinct = khuVucData.AsEnumerable()
                .Select(row => row.Field<string>("ThanhPho"))
                .Distinct()
                .ToList();
            khuVucDistinct.Insert(0, "Chọn khu vực");
            cmb_KhuVuc.DataSource = khuVucDistinct;
            cmb_KhuVuc.SelectedIndex = 0;
        }

        private void cmb_KhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lay khu vuc da chon
            string selectedKhuVuc = cmb_KhuVuc.SelectedItem.ToString();

            // Loc chi nhanh theo khu vuc da chon
            var chiNhanhForKhuVuc = khuVucData.AsEnumerable()
                .Where(row => row.Field<string>("ThanhPho") == selectedKhuVuc)
                .Select(row => row.Field<string>("TenChiNhanh"))
                .Distinct()
                .ToList();

            chiNhanhForKhuVuc.Insert(0, "Chọn chi nhánh");
            cmb_ChiNhanh.DataSource = chiNhanhForKhuVuc;
            cmb_ChiNhanh.SelectedIndex = 0;
        }

        private void cmb_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lay chi nhanh da chon
            string selectedChiNhanh = cmb_ChiNhanh.SelectedItem.ToString();

            // Loc so dien thoai theo chi nhanh da chon
            var sdtForChiNhanh = khuVucData.AsEnumerable()
                .Where(row => row.Field<string>("TenChiNhanh") == selectedChiNhanh)
                .Select(row => row.Field<string>("SoDienThoai"))
                .ToList();

            cmb_SDT.DataSource = sdtForChiNhanh;
            cmb_SDT.SelectedIndex = 0;


            // Lọc thông tin địa chỉ chi nhánh từ DataTable
            var diaChiForChiNhanh = khuVucData.AsEnumerable()
                .Where(row => row.Field<string>("TenChiNhanh") == selectedChiNhanh)
                .Select(row => new
                {
                    Duong = row.Field<string>("Duong"),
                    Phuong = row.Field<string>("Phuong"),
                    Quan = row.Field<string>("Quan"),
                    ThanhPho = row.Field<string>("ThanhPho")
                })
                .FirstOrDefault(); // Dùng FirstOrDefault để lấy 1 giá trị duy nhất (do 1 chi nhánh có 1 địa chỉ)

            // Kiểm tra nếu có thông tin chi nhánh
            if (diaChiForChiNhanh != null)
            {
                // Tạo địa chỉ theo định dạng yêu cầu
                string diaChi = $"{diaChiForChiNhanh.Duong} - {diaChiForChiNhanh.Phuong} - {diaChiForChiNhanh.Quan} - {diaChiForChiNhanh.ThanhPho}";

                // Gán vào TextBox
                textbox_diaChi.Text = diaChi;
            }
            else
            {
                // Nếu không tìm thấy thông tin địa chỉ, xóa nội dung TextBox hoặc hiển thị thông báo
                textbox_diaChi.Clear();
            }
        }

     

        private void text_diaChi_TextChanged(object sender, EventArgs e)
        {
            // Lay chi nhanh da chon
            string selectedChiNhanh = cmb_ChiNhanh.SelectedItem.ToString();

            // Lọc thông tin địa chỉ chi nhánh từ DataTable
            var diaChiForChiNhanh = khuVucData.AsEnumerable()
                .Where(row => row.Field<string>("TenChiNhanh") == selectedChiNhanh)
                .Select(row => new
                {
                    Duong = row.Field<string>("Duong"),
                    Phuong = row.Field<string>("Phuong"),
                    Quan = row.Field<string>("Quan"),
                    ThanhPho = row.Field<string>("ThanhPho")
                })
                .FirstOrDefault(); // Dùng FirstOrDefault để lấy 1 giá trị duy nhất (do 1 chi nhánh có 1 địa chỉ)

            // Kiểm tra nếu có thông tin chi nhánh
            if (diaChiForChiNhanh != null)
            {
                // Tạo địa chỉ theo định dạng yêu cầu
                string diaChi = $"{diaChiForChiNhanh.Duong} - {diaChiForChiNhanh.Phuong} - {diaChiForChiNhanh.Quan} - {diaChiForChiNhanh.ThanhPho}";

                // Gán vào TextBox
                text_diaChi.Text = diaChi;
            }
            else
            {
                // Nếu không tìm thấy thông tin địa chỉ, xóa nội dung TextBox hoặc hiển thị thông báo
                text_diaChi.Clear();
            }
        }
    }
}
