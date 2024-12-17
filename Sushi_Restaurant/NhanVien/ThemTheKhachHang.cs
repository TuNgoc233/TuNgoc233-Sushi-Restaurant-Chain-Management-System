using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant.NhanVien
{
    public partial class ThemTheKhachHang : SampleAdd
    {
        public ThemTheKhachHang()
        {
            InitializeComponent();
        }

        DateTime date = DateTime.Now;
        public string MaThe = "";
        public override void btnLuu_Click(object sender, EventArgs e)
        {
            // Thực hiện các hành động khi nhấn nút "LƯU"
            MessageBox.Show("Lưu thành công!");
        }

        private string LayMaTheTiepTheo()
        {
            string nextId = "";

            try
            {
                using (SqlConnection con = new SqlConnection(MainClass.con_string))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.LayMaTheTiepTheo()", con))
                    {
                        nextId = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã hóa đơn: " + ex.Message);
            }
            MaThe = nextId;

            return nextId;
        }

        private void ThemTheKhachHang_Load(object sender, EventArgs e)
        {
            txtMaThe.Text = LayMaTheTiepTheo();
            guna2DateTimePicker1.Value = date;

        }


    }
}
