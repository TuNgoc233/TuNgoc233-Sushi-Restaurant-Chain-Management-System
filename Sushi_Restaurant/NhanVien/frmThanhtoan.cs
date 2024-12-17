using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.NhanVien
{
    public partial class frmThanhtoan : Form
    {
        public frmThanhtoan()
        {
            InitializeComponent();
        }

        public double amt;
        public string MainID = "";  


        //public virtual void btnLuu_Click(object sender, EventArgs e)
        //{
        //    string qry = @"UPDATE HOA_DON SET TongTien = @tongtien WHERE MaHoaDon = @mahoadon";
        //    Hashtable ht = new Hashtable();

        //    ht.Add("@tongtien", txtTongTien.Text);
        //    ht.Add("@tienphaitra", txtTienphaitra.Text);

        //    if(MainClass.SQl(qry, ht)>0)
        //    {
        //        Guna2MessageDialog dialog = new Guna2MessageDialog();
        //        dialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
        //        dialog.Show("Thanh toán thành công!");
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thanh toán thất bại!");
        //    }

        //    // Thực hiện các hành động khi nhấn nút "LƯU"
        //    MessageBox.Show("Lưu thành công!");
        //}

        // Phương thức xử lý sự kiện khi nhấn nút "ĐÓNG"
        public virtual void btnDong_Click(object sender, EventArgs e)
        {
            // Đóng cửa sổ hiện tại
            this.Close();
        }

        private void frmThanhtoan_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = amt.ToString();
        }

        

    }
}
