using Guna.UI2.WinForms;

namespace Sushi_Restaurant
{
    partial class FrmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.but_cap_nhat_info = new Guna.UI2.WinForms.Guna2Button();
            this.but_mon_yeu_thich = new Guna.UI2.WinForms.Guna2Button();
            this.but_DSDH = new Guna.UI2.WinForms.Guna2Button();
            this.but_dat_mon = new Guna.UI2.WinForms.Guna2Button();
            this.but_Home = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_center = new Guna.UI2.WinForms.Guna2Panel();
            this.ControlBoxThuNho = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlBoxAn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlBoxThoat = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel_center.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.but_cap_nhat_info);
            this.guna2Panel1.Controls.Add(this.but_mon_yeu_thich);
            this.guna2Panel1.Controls.Add(this.but_DSDH);
            this.guna2Panel1.Controls.Add(this.but_dat_mon);
            this.guna2Panel1.Controls.Add(this.but_Home);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(254, 779);
            this.guna2Panel1.TabIndex = 0;
            // 
            // but_cap_nhat_info
            // 
            this.but_cap_nhat_info.AutoRoundedCorners = true;
            this.but_cap_nhat_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.but_cap_nhat_info.BorderRadius = 34;
            this.but_cap_nhat_info.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.but_cap_nhat_info.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.but_cap_nhat_info.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.but_cap_nhat_info.CustomizableEdges.BottomRight = false;
            this.but_cap_nhat_info.CustomizableEdges.TopRight = false;
            this.but_cap_nhat_info.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_cap_nhat_info.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_cap_nhat_info.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_cap_nhat_info.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_cap_nhat_info.FillColor = System.Drawing.Color.Transparent;
            this.but_cap_nhat_info.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_cap_nhat_info.ForeColor = System.Drawing.Color.White;
            this.but_cap_nhat_info.Image = ((System.Drawing.Image)(resources.GetObject("but_cap_nhat_info.Image")));
            this.but_cap_nhat_info.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.but_cap_nhat_info.ImageOffset = new System.Drawing.Point(4, 0);
            this.but_cap_nhat_info.ImageSize = new System.Drawing.Size(45, 45);
            this.but_cap_nhat_info.Location = new System.Drawing.Point(-6, 491);
            this.but_cap_nhat_info.Name = "but_cap_nhat_info";
            this.but_cap_nhat_info.Size = new System.Drawing.Size(260, 70);
            this.but_cap_nhat_info.TabIndex = 2;
            this.but_cap_nhat_info.Text = "Cập nhật thông tin";
            this.but_cap_nhat_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.but_cap_nhat_info.TextOffset = new System.Drawing.Point(5, 0);
            this.but_cap_nhat_info.Click += new System.EventHandler(this.but_cap_nhat_info_Click);
            // 
            // but_mon_yeu_thich
            // 
            this.but_mon_yeu_thich.AutoRoundedCorners = true;
            this.but_mon_yeu_thich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.but_mon_yeu_thich.BorderRadius = 34;
            this.but_mon_yeu_thich.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.but_mon_yeu_thich.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.but_mon_yeu_thich.CheckedState.Image = global::Sushi_Restaurant.Properties.Resources.icon_check_mon_an_yeu_thich1;
            this.but_mon_yeu_thich.CustomizableEdges.BottomRight = false;
            this.but_mon_yeu_thich.CustomizableEdges.TopRight = false;
            this.but_mon_yeu_thich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_mon_yeu_thich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_mon_yeu_thich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_mon_yeu_thich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_mon_yeu_thich.FillColor = System.Drawing.Color.Transparent;
            this.but_mon_yeu_thich.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_mon_yeu_thich.ForeColor = System.Drawing.Color.White;
            this.but_mon_yeu_thich.Image = ((System.Drawing.Image)(resources.GetObject("but_mon_yeu_thich.Image")));
            this.but_mon_yeu_thich.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.but_mon_yeu_thich.ImageOffset = new System.Drawing.Point(-14, 0);
            this.but_mon_yeu_thich.ImageSize = new System.Drawing.Size(80, 80);
            this.but_mon_yeu_thich.Location = new System.Drawing.Point(-5, 415);
            this.but_mon_yeu_thich.Name = "but_mon_yeu_thich";
            this.but_mon_yeu_thich.Size = new System.Drawing.Size(259, 70);
            this.but_mon_yeu_thich.TabIndex = 2;
            this.but_mon_yeu_thich.Text = "Món ăn yêu thích";
            this.but_mon_yeu_thich.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.but_mon_yeu_thich.TextOffset = new System.Drawing.Point(-29, -5);
            this.but_mon_yeu_thich.Click += new System.EventHandler(this.but_mon_yeu_thich_Click);
            // 
            // but_DSDH
            // 
            this.but_DSDH.AutoRoundedCorners = true;
            this.but_DSDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.but_DSDH.BorderRadius = 34;
            this.but_DSDH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.but_DSDH.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.but_DSDH.CheckedState.Image = global::Sushi_Restaurant.Properties.Resources.icon_checkDSDH;
            this.but_DSDH.CustomizableEdges.BottomRight = false;
            this.but_DSDH.CustomizableEdges.TopRight = false;
            this.but_DSDH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_DSDH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_DSDH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_DSDH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_DSDH.FillColor = System.Drawing.Color.Transparent;
            this.but_DSDH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_DSDH.ForeColor = System.Drawing.Color.White;
            this.but_DSDH.Image = global::Sushi_Restaurant.Properties.Resources.icon_dsDH;
            this.but_DSDH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.but_DSDH.ImageOffset = new System.Drawing.Point(10, 0);
            this.but_DSDH.ImageSize = new System.Drawing.Size(35, 35);
            this.but_DSDH.Location = new System.Drawing.Point(-7, 327);
            this.but_DSDH.Name = "but_DSDH";
            this.but_DSDH.Size = new System.Drawing.Size(261, 70);
            this.but_DSDH.TabIndex = 2;
            this.but_DSDH.Text = "Danh sách đơn hàng";
            this.but_DSDH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.but_DSDH.TextOffset = new System.Drawing.Point(20, 0);
            this.but_DSDH.Click += new System.EventHandler(this.but_DSDH_Click);
            // 
            // but_dat_mon
            // 
            this.but_dat_mon.AutoRoundedCorners = true;
            this.but_dat_mon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.but_dat_mon.BorderRadius = 34;
            this.but_dat_mon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.but_dat_mon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.but_dat_mon.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.but_dat_mon.CustomizableEdges.BottomRight = false;
            this.but_dat_mon.CustomizableEdges.TopRight = false;
            this.but_dat_mon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_dat_mon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_dat_mon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_dat_mon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_dat_mon.FillColor = System.Drawing.Color.Transparent;
            this.but_dat_mon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dat_mon.ForeColor = System.Drawing.Color.White;
            this.but_dat_mon.Image = ((System.Drawing.Image)(resources.GetObject("but_dat_mon.Image")));
            this.but_dat_mon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.but_dat_mon.ImageOffset = new System.Drawing.Point(2, 0);
            this.but_dat_mon.ImageSize = new System.Drawing.Size(45, 45);
            this.but_dat_mon.Location = new System.Drawing.Point(-6, 251);
            this.but_dat_mon.Name = "but_dat_mon";
            this.but_dat_mon.Size = new System.Drawing.Size(260, 70);
            this.but_dat_mon.TabIndex = 2;
            this.but_dat_mon.Text = "Đặt món";
            this.but_dat_mon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.but_dat_mon.TextOffset = new System.Drawing.Point(6, 0);
            this.but_dat_mon.Click += new System.EventHandler(this.but_dat_mon_Click);
            // 
            // but_Home
            // 
            this.but_Home.AutoRoundedCorners = true;
            this.but_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.but_Home.BorderRadius = 34;
            this.but_Home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.but_Home.Checked = true;
            this.but_Home.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.but_Home.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.but_Home.CustomizableEdges.BottomRight = false;
            this.but_Home.CustomizableEdges.TopRight = false;
            this.but_Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_Home.FillColor = System.Drawing.Color.Transparent;
            this.but_Home.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.but_Home.ForeColor = System.Drawing.Color.White;
            this.but_Home.Image = ((System.Drawing.Image)(resources.GetObject("but_Home.Image")));
            this.but_Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.but_Home.ImageOffset = new System.Drawing.Point(10, 0);
            this.but_Home.ImageSize = new System.Drawing.Size(30, 30);
            this.but_Home.Location = new System.Drawing.Point(0, 175);
            this.but_Home.Name = "but_Home";
            this.but_Home.Size = new System.Drawing.Size(254, 70);
            this.but_Home.TabIndex = 2;
            this.but_Home.Text = "Trang chủ";
            this.but_Home.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.but_Home.TextOffset = new System.Drawing.Point(15, 0);
            this.but_Home.Click += new System.EventHandler(this.but_Home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUSHI X";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Sushi_Restaurant.Properties.Resources.sushi_logo1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(30, -10);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(152, 112);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.ControlBoxThuNho);
            this.panel_center.Controls.Add(this.controlBoxAn);
            this.panel_center.Controls.Add(this.ControlBoxThoat);
            this.panel_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_center.Location = new System.Drawing.Point(254, 0);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(874, 779);
            this.panel_center.TabIndex = 1;
            // 
            // ControlBoxThuNho
            // 
            this.ControlBoxThuNho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxThuNho.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ControlBoxThuNho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlBoxThuNho.IconColor = System.Drawing.Color.White;
            this.ControlBoxThuNho.Location = new System.Drawing.Point(792, 2);
            this.ControlBoxThuNho.Margin = new System.Windows.Forms.Padding(2);
            this.ControlBoxThuNho.Name = "ControlBoxThuNho";
            this.ControlBoxThuNho.Size = new System.Drawing.Size(38, 29);
            this.ControlBoxThuNho.TabIndex = 1;
            // 
            // controlBoxAn
            // 
            this.controlBoxAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBoxAn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlBoxAn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.controlBoxAn.IconColor = System.Drawing.Color.White;
            this.controlBoxAn.Location = new System.Drawing.Point(750, 2);
            this.controlBoxAn.Margin = new System.Windows.Forms.Padding(2);
            this.controlBoxAn.Name = "controlBoxAn";
            this.controlBoxAn.Size = new System.Drawing.Size(36, 29);
            this.controlBoxAn.TabIndex = 2;
            // 
            // ControlBoxThoat
            // 
            this.ControlBoxThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxThoat.CustomClick = true;
            this.ControlBoxThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlBoxThoat.IconColor = System.Drawing.Color.White;
            this.ControlBoxThoat.Location = new System.Drawing.Point(836, 2);
            this.ControlBoxThoat.Margin = new System.Windows.Forms.Padding(2);
            this.ControlBoxThoat.Name = "ControlBoxThoat";
            this.ControlBoxThoat.Size = new System.Drawing.Size(34, 29);
            this.ControlBoxThoat.TabIndex = 3;
            this.ControlBoxThoat.Click += new System.EventHandler(this.ControlBoxThoat_Click_1);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 779);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel_center.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button but_Home;
        private Guna.UI2.WinForms.Guna2Button but_cap_nhat_info;
        private Guna.UI2.WinForms.Guna2Button but_mon_yeu_thich;
        private Guna.UI2.WinForms.Guna2Button but_DSDH;
        private Guna.UI2.WinForms.Guna2Button but_dat_mon;
        private Guna2Panel panel_center;
        private Guna2ControlBox ControlBoxThuNho;
        private Guna2ControlBox controlBoxAn;
        private Guna2ControlBox ControlBoxThoat;
    }
}