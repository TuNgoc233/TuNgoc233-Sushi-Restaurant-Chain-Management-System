using Sushi_Restaurant.Chi_Nhanh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.Admin
{
    public partial class Admin_Manage : Form
    {
        public Admin_Manage()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Employee(object sender, EventArgs e)
        {
            this.Hide();
            Employee emp = new Employee();
            emp.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
