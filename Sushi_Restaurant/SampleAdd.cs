using System;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        public virtual void btnLuu_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     
        public virtual void btnDong_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đóng cửa sổ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

       
        public virtual void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void SampleAdd_Load(object sender, EventArgs e)
        {
            
            this.label1.Text = "Thêm dữ liệu mới";
        }

        public virtual void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
