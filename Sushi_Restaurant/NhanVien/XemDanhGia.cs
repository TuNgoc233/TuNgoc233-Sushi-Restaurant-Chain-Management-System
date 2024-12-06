using System;
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
    public partial class XemDanhGia : SampleView
    {
        public XemDanhGia()
        {
            InitializeComponent();
        }

        public override void btnThem_Click(object sender, EventArgs e)
        {
            ThemDanhGia themDanhGia = new ThemDanhGia();
            themDanhGia.ShowDialog();
        }
    }
}
