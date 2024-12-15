using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class viewIDCard : SampleView
    {
        public viewIDCard()
        {
            InitializeComponent();
            this.Load += new EventHandler(viewStaff_Load); // Đăng ký sự kiện Load
        }

        public override void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
          
        }

      

        private void viewIDCard_Load(object sender, EventArgs e)
        {
          
        }
        
        //List
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            addStaff addStaff = new addStaff();
            addStaff.Show();
        }

        //Text
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Back(object sender, EventArgs e)
        {
            this.Close(); // Đóng form viewIDCard
            if (Owner != null) // Kiểm tra nếu Owner tồn tại
            {
                Owner.Show(); // Hiển thị lại form Brand
            }
        }


        //AVT
        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Staff(object sender, EventArgs e)
        {

        }

        private void Btn_Invoice(object sender, EventArgs e)
        {

        }

        //Btn_CardID
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Insert
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStaff addStaff = new addStaff();
            addStaff.Show();
        }

        //text
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void viewStaff_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
