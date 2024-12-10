using Sushi_Restaurant.Model;
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

namespace Sushi_Restaurant
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            foreach (Control control in panel_center.Controls.OfType<Control>().ToList())
            {
                if (control != ControlBoxThoat && control != controlBoxAn && control != ControlBoxThuNho)
                {
                    panel_center.Controls.Remove(control);
                }
            }
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panel_center.Controls.Add(f);
            f.Show();
        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            // Bat luon nut home khi load form
            but_Home.PerformClick();
        }

        //Thoat
        private void ControlBoxThoat_Click(object sender, EventArgs e)
        {

        }

        private void ControlBoxThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_Home_Click(object sender, EventArgs e)
        {
            AddControls(new FrmHomeView());
        }

        private void but_dat_mon_Click(object sender, EventArgs e)
        {
            FrmDatMon frm = new FrmDatMon();
            frm.Show();
            but_dat_mon.Checked = false;
            AddControls(new FrmHomeView());
            but_Home.Checked = true;
         
        }


        private void but_DSDH_Click(object sender, EventArgs e)
        {
            AddControls(new FrmDSDonHang());
        }

        private void but_mon_yeu_thich_Click(object sender, EventArgs e)
        {
            AddControls(new FrmMonAnYeuThichView());
        }

        private void but_cap_nhat_info_Click(object sender, EventArgs e)
        {
            AddControls(new CapNhatThongTinView());
        }
    }
    
}
