using Guna.UI2.WinForms;
using Sushi_Restaurant.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sushi_Restaurant.Model
{
    public partial class FrmDSDonHang : Form
    {
        private DataTable allOrders = new DataTable();
        private DataTable datBanOrders = new DataTable();
        private DataTable giaoHangOrders = new DataTable();
        public FrmDSDonHang()
        {
            InitializeComponent();
            cmb_soDong.SelectedItem = "Tất cả";
            dataGridViewDSDonHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default; // Tắt theme
            dataGridViewDSDonHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 55, 89);
            dataGridViewDSDonHang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold); // Chỉnh font
            KhoiTaoDuLieu();
            dataGridViewDSDonHang.DataSource = allOrders;
        }

        private void KhoiTaoDuLieu()
        {

            // Tạo cột
            allOrders.Columns.Add("STT", typeof(int));
            allOrders.Columns.Add("Loại Đơn Hàng", typeof(string));
            allOrders.Columns.Add("Mã Đơn Hàng", typeof(string));
            allOrders.Columns.Add("Trạng Thái", typeof(string));
            allOrders.Columns.Add("Tổng Tiền", typeof(decimal));
            allOrders.Columns.Add("Ngày Đặt", typeof(DateTime)); // Thêm cột Ngày Đặt

            // Thêm dữ liệu mẫu
            allOrders.Rows.Add(1, "Giao hàng tận nơi", "DH001", "Đã giao", 150000, new DateTime(2023, 12, 1));
            allOrders.Rows.Add(2, "Đặt bàn", "DB002", "Chờ xác nhận", 500000, new DateTime(2023, 12, 2));
            allOrders.Rows.Add(3, "Giao hàng tận nơi", "DH003", "Đang giao", 200000, new DateTime(2023, 12, 3));
            allOrders.Rows.Add(4, "Đặt bàn", "DB004", "Hoàn thành", 300000, new DateTime(2023, 12, 4));

            // Phân loại dữ liệu
            var datBanRows = allOrders.Select("[Loại Đơn Hàng] = 'Đặt bàn'");
            if (datBanRows.Length > 0)
                datBanOrders = datBanRows.CopyToDataTable();

            var giaoHangRows = allOrders.Select("[Loại Đơn Hàng] = 'Giao hàng tận nơi'");
            if (giaoHangRows.Length > 0)
                giaoHangOrders = giaoHangRows.CopyToDataTable();
        }
        // Ham danh so thu tu lai cho ca dong
        private void ReindexRows()
        {
            for (int i = 0; i < dataGridViewDSDonHang.Rows.Count; i++)
            {
                dataGridViewDSDonHang.Rows[i].Cells["STT"].Value = i + 1;
            }
        }

        private void rbtnAll_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnAll.Checked)
            {
                dataGridViewDSDonHang.DataSource = allOrders; // Hien thi tat ca don hang
            }
        }
        private void rbtnGiaoHang_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnGiaoHang.Checked)
            {
                dataGridViewDSDonHang.DataSource = giaoHangOrders; // Hien thi giao hang tan noi
                ReindexRows(); // Đánh số thứ tự lại
            }
        }

        private void rbtnDatBan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnDatBan.Checked)
            {
                dataGridViewDSDonHang.DataSource = datBanOrders; // Hien thi dat ban
                ReindexRows(); // Đánh số thứ tự lại
            }
        }

        private void cmb_soDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmb_soDong.SelectedItem.ToString();
            DataTable tempListOder = new DataTable();

            // kiem tra xem dang chon loai don hang nao
            if (rbtnAll.Checked)
            {
                tempListOder = allOrders;
            }
            if (rbtnGiaoHang.Checked)
            {
                tempListOder = giaoHangOrders;
            }
            if (rbtnDatBan.Checked)
            {
                tempListOder = datBanOrders;
            }

            // Hien thi dong theo ý muốn của người dùng
            if (selectedValue == "Tất cả")
            {
                // Hiển thị tất cả các dòng
                dataGridViewDSDonHang.DataSource = allOrders;
            }
            else
            {
                // Hiển thị số dòng được chọn
                int rowsToShow = int.Parse(selectedValue);

                // Lọc dữ liệu và tạo bảng tạm để hiển thị
                DataTable tempTable = tempListOder.AsEnumerable()
                                                  .Take(rowsToShow)
                                                  .CopyToDataTable();

                dataGridViewDSDonHang.DataSource = tempTable;
            }
        }

        private void dataGridViewDSDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào cột hình ảnh không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridViewDSDonHang.Columns[e.ColumnIndex].Name;

                // Nếu nhấn vào cột "ChiTiet"
                if (columnName == "xemLai")
                {
                    // Lấy mã đơn hàng từ dòng được chọn
                    string maDonHang = dataGridViewDSDonHang.Rows[e.RowIndex].Cells["maDH"].Value.ToString();

                    // Lấy loại Đơn Hàng từ dòng được chọn
                    string loaiDonHang = dataGridViewDSDonHang.Rows[e.RowIndex].Cells["loaiDH"].Value.ToString();

                    if (loaiDonHang == "Giao hàng tận nơi")
                    {
                        xemLaiGiaoHangView frm = new xemLaiGiaoHangView();
                        frm.Show();
                    } 
                    else
                    {
                        xemLaiDatBanView frm = new xemLaiDatBanView();
                        frm.Show();
                    }    
                        
                }

                //// Nếu nhấn vào cột "DanhGia"
                //else if (columnName == "danhGia")
                //{
                //    // Lấy mã đơn hàng từ dòng được chọn
                //    string maDonHang = dataGridViewDSDonHang.Rows[e.RowIndex].Cells["maDH"].Value.ToString();

                //    danhGiaDView frm = new danhGiaDHView(maDonHang);
                //    frm.Show();
                //}
            }
        }
    }
}
