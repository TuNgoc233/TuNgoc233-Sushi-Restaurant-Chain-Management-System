using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.View
{
    public partial class DatBanView : Form
    {
        public DatBanView()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.DatBanView_Load);
        }

        private void but_datBan_Click(object sender, EventArgs e)
        {

        }

        private void but_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatBanView_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
        }



    }
}
