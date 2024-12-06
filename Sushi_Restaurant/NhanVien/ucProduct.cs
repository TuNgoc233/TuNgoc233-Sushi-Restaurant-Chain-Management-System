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
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }
        public event EventHandler onSelect = null;

        public int id { get; set; }
        public string PPrice { set; get; }
        public string PCategory { set; get; }
        public string PName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public Image PImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }


        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

    }
}
