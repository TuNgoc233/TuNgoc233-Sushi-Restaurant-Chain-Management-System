using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Sushi_Restaurant.NhanVien;


namespace Sushi_Restaurant
{
    public static class MainClass
    {
        // Chuỗi kết nối đến cơ sở dữ liệu
        public static string con_string = @"Server=LTCUATUNGOC;Database=TEST;Trusted_Connection=True;";
        //public static string con_string = @"Server=DESKTOP-B1OU3RF;Database=Test;Trusted_Connection=True;";



        // Kết nối SQL
        public static SqlConnection con = new SqlConnection(con_string);

        /// <summary>
        /// Hàm kiểm tra kết nối đến cơ sở dữ liệu
        /// </summary>
        /// <returns>True nếu kết nối thành công, ngược lại False</returns>
        /// 
        //method for curd operation
        public static int SQl(string qry, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
                con.Close();
            }
            return res;

        }

        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
               Background.StartPosition = FormStartPosition.Manual;
               Background.FormBorderStyle = FormBorderStyle.None;
               Background.Opacity = 0.5d;
               Background.BackColor = Color.Black;
               Background.Size = frmMain.Instance.Size;
               Background.Location = frmMain.Instance.Location;
               Background.ShowInTaskbar = false;
               Background.Show();
               Model.Owner = Background;
               Model.ShowDialog();
               Background.Dispose();
            }
        }


    }
}
