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
    public partial class CapNhatThongTinView : Form
    {
        public CapNhatThongTinView()
        {
            InitializeComponent();
            text_gioiTinh.SelectedItem = "Nam";
        }

        private void but_edit_FullName_Click(object sender, EventArgs e)
        {
            text_User.Enabled = true;
            text_User.Focus();
        }

        private void text_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_User.Enabled = false;
                e.SuppressKeyPress = true;
            }

        }

        private void but_edit_CCCD_Click(object sender, EventArgs e)
        {
            text_CCCD.Enabled = true;
            text_CCCD.Focus();
        }

        private void text_CCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_CCCD.Enabled = false;
                e.SuppressKeyPress = true;
            }
        }

        private void but_edit_Email_Click(object sender, EventArgs e)
        {
            text_email.Enabled = true;
            text_email.Focus();
        }

        private void text_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_email.Enabled = false;
                e.SuppressKeyPress = true;
            }
        }

        private void but_edit_SDT_Click(object sender, EventArgs e)
        {
            text_SDT.Enabled = true;
            text_SDT.Focus();
        }

        private void text_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_SDT.Enabled = false;
                e.SuppressKeyPress = true;
            }
        }

        private void but_pass_Click(object sender, EventArgs e)
        {
            text_pass.Enabled = true;
            text_pass.Focus();
        }

        private void text_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                text_pass.Enabled = false;
                e.SuppressKeyPress = true;
            }
        }

        private void text_gioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void but_edit_gioiTinh_Click(object sender, EventArgs e)
        {
            text_gioiTinh.Enabled = true;
        }
    }
}
