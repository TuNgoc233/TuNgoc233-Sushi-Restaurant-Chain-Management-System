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

namespace Sushi_Restaurant
{
    public partial class FrmDatMon : Form
    {
        public FrmDatMon()
        {
            InitializeComponent();
        }

        private void but_Nguon_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void FrmDatMon_Load(object sender, EventArgs e)
        {
            panel_dat_hang.BorderStyle = BorderStyle.FixedSingle;
        }

        private void but_giao_hang_Click(object sender, EventArgs e)
        {
            GiaoHangView frm = new GiaoHangView();
            frm.Show();
        }

        private void but_dat_ban_Click(object sender, EventArgs e)
        {
            DatBanView frm = new DatBanView();
            frm.Show();
        }
    }
}
