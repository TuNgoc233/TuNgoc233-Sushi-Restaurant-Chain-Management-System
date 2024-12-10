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

            sdtForChiNhanh.Insert(0, "Chọn số điện thoại");
            cmb_SDT.DataSource = sdtForChiNhanh;
            cmb_SDT.SelectedIndex = 0;

        }
    }
}
