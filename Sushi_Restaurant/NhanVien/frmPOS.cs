using Sushi_Restaurant.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            //AddCategory();
            //ProductPanel.Controls.Clear();
            //LoadProducts();
        }

        //private void AddCategory()
        //{
        //    string qry = "SELECT * FROM category";
        //    SqlCommand cmd = new SqlCommand(qry, MainClass.con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt= new DataTable();
        //    da.Fill(dt);

        //    CategoryPanel.Controls.Clear();
        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach(DataRow row in dt.Rows)
        //        {
        //            Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
        //            b.FillColor = Color.FromArgb(50, 55, 89);
        //            b.Size = new Size(172, 45);
        //            b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
        //            b.Text = dt.Rows["catName"].ToString();

        //              //event for click
        //            b.Click+=new EventHandler(_Click);
        //            CategoryPanel.Controls.Add(b);
        //        }
                
        //    }
        //}

        private void _Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in ProductPanel.Controls)
            {

                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());


            }
        }

        private void AddItems(string id, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(id),
            };

            ProductPanel.Controls.Add(w);

            w.onSelect += (SetStyle, ee) =>
            {
                var wdg = (ucProduct)SetStyle;
                

                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    // Check if product is already in the DataGridView
                    if (Convert.ToInt32(item.Cells["dvgid"].Value) == wdg.id)
                    {
                        item.Cells["dvgQty"].Value = int.Parse(item.Cells["dvgQty"].Value.ToString()) + 1;
                        item.Cells["dvgAmount"].Value =
                            int.Parse(item.Cells["dvgQty"].Value.ToString()) *
                            double.Parse(item.Cells["dvgPrice"].Value.ToString());
                        return;
                    }
                }
                // this line add new product
                guna2DataGridView1.Rows.Add(new object[] {0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();

            };
        }


        //Getting product from database
        //private void LoadProducts() 
        //{
        //    string qry = "SELECT * FROM product";
        //    SqlCommand cmd = new SqlCommand(qry, MainClass.con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt= new DataTable();
        //    da.Fill(dt);

        //    foreach (DataRow items in dt.Rows)
        //    {
        //        // Nguoi ta them anh tu database
        //        Byte[] imagearray = (Byte[])items["pImage"]; 
        //        Byte[] imagebytearray=imagearray;

        //        AddItems(items["pID"].ToString(), items["pName"].ToString(), items["catName"].ToString(), items["pPrice"].ToString(),Image.FromStream(new MemoryStream(imagearray)));
        //    }

        //}

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in ProductPanel.Controls)
            {
                
                var pro = (ucProduct)item;
                pro.Visible=pro.PName.ToLower().Contains(txtTimKiem.Text.Trim().ToLower());

               
            }
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // dat 1 mon nhieu lan
            int count =0;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                row.Cells[0].Value = ++count;
            }
        }

        private void GetTotal() {
            double tot = 0;
            lblTotal.Text = "";
            foreach(DataGridViewRow item in guna2DataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dvgAmount"].Value.ToString());
            }
            lblTotal.Text = tot.ToString("N2");
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            // tao phieu dat truc tiep
            PhieuDatTrucTiep pdtt = new PhieuDatTrucTiep();
            //MainClass.BlurBackground();
        }

        //private void btnBill_Click(object sender, EventArgs e)
        //{
        //    MainClass.BlurBackground(new HoaDon());
        //}
    }
}
