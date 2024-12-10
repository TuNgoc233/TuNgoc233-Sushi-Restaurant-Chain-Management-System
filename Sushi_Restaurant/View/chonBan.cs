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
    public partial class chonBan : Form
    {
        public chonBan()
        {
            InitializeComponent();
        }

        private void but_tiep_Click_1(object sender, EventArgs e)
        {
            
            DatBanView datBanView = new DatBanView();
            datBanView.Owner = this.Owner;
            this.Close();
            datBanView.Show();
            
        }

        private void but_thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
