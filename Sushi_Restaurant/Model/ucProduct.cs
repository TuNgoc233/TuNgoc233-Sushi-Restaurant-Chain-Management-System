using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.Model
{
    public partial class ucProduct : UserControl
    {
        public event EventHandler onSelect = null;
        public ucProduct()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public int PPrice { get; set; }

        public string PCategory { get; set; }

        public string PName
        {
            get { return gia.Text; }
            set { gia.Text = value; }
        }

        public string PImage
        {
            get { return pic_mon_an.Image.ToString(); }
            set { pic_mon_an.Image = Image.FromFile(value); }
        }

        private void txt_mon_an_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

    }
}
