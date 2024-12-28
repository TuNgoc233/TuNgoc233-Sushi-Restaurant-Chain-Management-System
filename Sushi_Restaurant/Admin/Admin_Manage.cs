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
            this.StartPosition = FormStartPosition.CenterScreen;

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
            Load_Employee emp = new Load_Employee();
            emp.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //viewFood viewFood = new viewFood();
            //viewFood.Show();
            //addFood food = new addFood();
            //food.Show();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            UpdateSalary_Employeee updateSalary = new UpdateSalary_Employeee();
            this.Enabled = false;
            updateSalary.ShowDialog();
            this.Enabled = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ControlMini_Click(object sender, EventArgs e)
        {

        }

        private void ControlMax_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Logout(); // Call the logout method
            }
        }

        private void Logout()
        {
            Branch.MaChiNhanh = null; // Xóa dữ liệu phiên
            Sushi_Restaurant.Chi_Nhanh.Login loginForm = new Sushi_Restaurant.Chi_Nhanh.Login(); // Sử dụng không gian tên đầy đủ
            loginForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Logout();
            }
            else
            {
                e.Cancel = true; // Prevent closing
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            company_revenue company_Revenue = new company_revenue();
            company_Revenue.Show();
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RevenueStatistics revenueStatistics = new RevenueStatistics();
            revenueStatistics.Show();
        }
    }
}
