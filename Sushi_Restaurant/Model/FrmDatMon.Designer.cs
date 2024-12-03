namespace Sushi_Restaurant
{
    partial class FrmDatMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatMon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Header = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Dat_Mon = new System.Windows.Forms.Label();
            this.but_Nguon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.icon_Dat_Mon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_Border = new Guna.UI2.WinForms.Guna2Panel();
            this.but_giao_hang = new Guna.UI2.WinForms.Guna2TileButton();
            this.but_dat_ban = new Guna.UI2.WinForms.Guna2TileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_dat_hang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.don_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanh_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_Product = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Category = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.but_Nguon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Dat_Mon)).BeginInit();
            this.panel_Border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_dat_hang)).BeginInit();
            this.panel_Category.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.Controls.Add(this.guna2TextBox1);
            this.panel_Header.Controls.Add(this.label_Dat_Mon);
            this.panel_Header.Controls.Add(this.but_Nguon);
            this.panel_Header.Controls.Add(this.icon_Dat_Mon);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1472, 95);
            this.panel_Header.TabIndex = 0;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox1.AutoSize = true;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.Location = new System.Drawing.Point(341, 38);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "tìm kiếm món ăn ở đây";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(613, 36);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // label_Dat_Mon
            // 
            this.label_Dat_Mon.AutoSize = true;
            this.label_Dat_Mon.BackColor = System.Drawing.Color.Transparent;
            this.label_Dat_Mon.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dat_Mon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_Dat_Mon.Location = new System.Drawing.Point(128, 29);
            this.label_Dat_Mon.Name = "label_Dat_Mon";
            this.label_Dat_Mon.Size = new System.Drawing.Size(170, 45);
            this.label_Dat_Mon.TabIndex = 1;
            this.label_Dat_Mon.Text = "ĐẶT MÓN";
            // 
            // but_Nguon
            // 
            this.but_Nguon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_Nguon.BackColor = System.Drawing.Color.Transparent;
            this.but_Nguon.Image = global::Sushi_Restaurant.Properties.Resources.icon_nut_nguon;
            this.but_Nguon.ImageRotate = 0F;
            this.but_Nguon.Location = new System.Drawing.Point(1380, 12);
            this.but_Nguon.Name = "but_Nguon";
            this.but_Nguon.Size = new System.Drawing.Size(80, 62);
            this.but_Nguon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.but_Nguon.TabIndex = 0;
            this.but_Nguon.TabStop = false;
            this.but_Nguon.UseTransparentBackground = true;
            this.but_Nguon.Click += new System.EventHandler(this.but_Nguon_Click);
            // 
            // icon_Dat_Mon
            // 
            this.icon_Dat_Mon.BackColor = System.Drawing.Color.Transparent;
            this.icon_Dat_Mon.Image = global::Sushi_Restaurant.Properties.Resources.dat_mon;
            this.icon_Dat_Mon.ImageRotate = 0F;
            this.icon_Dat_Mon.Location = new System.Drawing.Point(0, 3);
            this.icon_Dat_Mon.Name = "icon_Dat_Mon";
            this.icon_Dat_Mon.Size = new System.Drawing.Size(113, 92);
            this.icon_Dat_Mon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_Dat_Mon.TabIndex = 0;
            this.icon_Dat_Mon.TabStop = false;
            this.icon_Dat_Mon.UseTransparentBackground = true;
            // 
            // panel_Border
            // 
            this.panel_Border.Controls.Add(this.but_giao_hang);
            this.panel_Border.Controls.Add(this.but_dat_ban);
            this.panel_Border.Controls.Add(this.label2);
            this.panel_Border.Controls.Add(this.label1);
            this.panel_Border.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Border.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel_Border.Location = new System.Drawing.Point(0, 731);
            this.panel_Border.Name = "panel_Border";
            this.panel_Border.Size = new System.Drawing.Size(1472, 95);
            this.panel_Border.TabIndex = 1;
            // 
            // but_giao_hang
            // 
            this.but_giao_hang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_giao_hang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.but_giao_hang.BorderRadius = 10;
            this.but_giao_hang.BorderThickness = 1;
            this.but_giao_hang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_giao_hang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_giao_hang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_giao_hang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_giao_hang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.but_giao_hang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_giao_hang.ForeColor = System.Drawing.Color.White;
            this.but_giao_hang.Image = global::Sushi_Restaurant.Properties.Resources.icon_delivery;
            this.but_giao_hang.ImageSize = new System.Drawing.Size(45, 32);
            this.but_giao_hang.Location = new System.Drawing.Point(1092, 9);
            this.but_giao_hang.Name = "but_giao_hang";
            this.but_giao_hang.Size = new System.Drawing.Size(116, 74);
            this.but_giao_hang.TabIndex = 4;
            this.but_giao_hang.Text = "Giao hàng";
            this.but_giao_hang.Click += new System.EventHandler(this.but_giao_hang_Click);
            // 
            // but_dat_ban
            // 
            this.but_dat_ban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_dat_ban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.but_dat_ban.BorderRadius = 10;
            this.but_dat_ban.BorderThickness = 1;
            this.but_dat_ban.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_dat_ban.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_dat_ban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_dat_ban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_dat_ban.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.but_dat_ban.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dat_ban.ForeColor = System.Drawing.Color.White;
            this.but_dat_ban.Image = global::Sushi_Restaurant.Properties.Resources.icon_check_dat_ban;
            this.but_dat_ban.ImageSize = new System.Drawing.Size(40, 30);
            this.but_dat_ban.Location = new System.Drawing.Point(960, 9);
            this.but_dat_ban.Name = "but_dat_ban";
            this.but_dat_ban.Size = new System.Drawing.Size(126, 74);
            this.but_dat_ban.TabIndex = 4;
            this.but_dat_ban.Text = "Đặt bàn";
            this.but_dat_ban.Click += new System.EventHandler(this.but_dat_ban_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1314, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 77);
            this.label2.TabIndex = 2;
            this.label2.Text = "10.000.000 VND";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1214, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng Tiền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_dat_hang
            // 
            this.panel_dat_hang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.panel_dat_hang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.panel_dat_hang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dat_hang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panel_dat_hang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.panel_dat_hang.ColumnHeadersHeight = 40;
            this.panel_dat_hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.panel_dat_hang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ten_mon,
            this.so_luong,
            this.don_gia,
            this.thanh_tien,
            this.but_Xoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.panel_dat_hang.DefaultCellStyle = dataGridViewCellStyle3;
            this.panel_dat_hang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_dat_hang.Location = new System.Drawing.Point(960, 101);
            this.panel_dat_hang.Name = "panel_dat_hang";
            this.panel_dat_hang.RowHeadersVisible = false;
            this.panel_dat_hang.RowHeadersWidth = 51;
            this.panel_dat_hang.RowTemplate.Height = 24;
            this.panel_dat_hang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.panel_dat_hang.Size = new System.Drawing.Size(509, 624);
            this.panel_dat_hang.TabIndex = 3;
            this.panel_dat_hang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.panel_dat_hang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.panel_dat_hang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.panel_dat_hang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.panel_dat_hang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.panel_dat_hang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.panel_dat_hang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_dat_hang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.panel_dat_hang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.panel_dat_hang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_dat_hang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.panel_dat_hang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.panel_dat_hang.ThemeStyle.HeaderStyle.Height = 40;
            this.panel_dat_hang.ThemeStyle.ReadOnly = false;
            this.panel_dat_hang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.panel_dat_hang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.panel_dat_hang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_dat_hang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.panel_dat_hang.ThemeStyle.RowsStyle.Height = 24;
            this.panel_dat_hang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_dat_hang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.FillWeight = 70F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 70;
            this.STT.Name = "STT";
            this.STT.Width = 70;
            // 
            // ten_mon
            // 
            this.ten_mon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ten_mon.HeaderText = "Tên Món";
            this.ten_mon.MinimumWidth = 6;
            this.ten_mon.Name = "ten_mon";
            this.ten_mon.Width = 197;
            // 
            // so_luong
            // 
            this.so_luong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.so_luong.FillWeight = 50F;
            this.so_luong.HeaderText = "S.L";
            this.so_luong.MinimumWidth = 50;
            this.so_luong.Name = "so_luong";
            this.so_luong.Width = 50;
            // 
            // don_gia
            // 
            this.don_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.don_gia.FillWeight = 70F;
            this.don_gia.HeaderText = "Đ.Giá";
            this.don_gia.MinimumWidth = 70;
            this.don_gia.Name = "don_gia";
            this.don_gia.Width = 70;
            // 
            // thanh_tien
            // 
            this.thanh_tien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.thanh_tien.FillWeight = 70F;
            this.thanh_tien.HeaderText = "T.tiền";
            this.thanh_tien.MinimumWidth = 70;
            this.thanh_tien.Name = "thanh_tien";
            this.thanh_tien.Width = 70;
            // 
            // but_Xoa
            // 
            this.but_Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.but_Xoa.FillWeight = 50F;
            this.but_Xoa.HeaderText = "";
            this.but_Xoa.Image = global::Sushi_Restaurant.Properties.Resources.icon_xoa;
            this.but_Xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.but_Xoa.MinimumWidth = 50;
            this.but_Xoa.Name = "but_Xoa";
            this.but_Xoa.Width = 50;
            // 
            // panel_Product
            // 
            this.panel_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Product.Location = new System.Drawing.Point(157, 101);
            this.panel_Product.Name = "panel_Product";
            this.panel_Product.Size = new System.Drawing.Size(797, 624);
            this.panel_Product.TabIndex = 4;
            // 
            // panel_Category
            // 
            this.panel_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Category.Controls.Add(this.guna2Button1);
            this.panel_Category.Location = new System.Drawing.Point(7, 101);
            this.panel_Category.Name = "panel_Category";
            this.panel_Category.Size = new System.Drawing.Size(144, 624);
            this.panel_Category.TabIndex = 5;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(133, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Sushi_Restaurant.Properties.Resources.icon_sua;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Sushi_Restaurant.Properties.Resources.icon_xoa;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // FrmDatMon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1472, 826);
            this.Controls.Add(this.panel_Product);
            this.Controls.Add(this.panel_Category);
            this.Controls.Add(this.panel_dat_hang);
            this.Controls.Add(this.panel_Border);
            this.Controls.Add(this.panel_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDatMon";
            this.Text = "FormDatMon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDatMon_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.but_Nguon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Dat_Mon)).EndInit();
            this.panel_Border.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_dat_hang)).EndInit();
            this.panel_Category.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_Header;
        private Guna.UI2.WinForms.Guna2Panel panel_Border;
        private Guna.UI2.WinForms.Guna2PictureBox icon_Dat_Mon;
        private System.Windows.Forms.Label label_Dat_Mon;
        private Guna.UI2.WinForms.Guna2PictureBox but_Nguon;
        private Guna.UI2.WinForms.Guna2DataGridView panel_dat_hang;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn don_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanh_tien;
        private System.Windows.Forms.DataGridViewImageColumn but_Xoa;
        private System.Windows.Forms.FlowLayoutPanel panel_Product;
        private System.Windows.Forms.FlowLayoutPanel panel_Category;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TileButton but_dat_ban;
        private Guna.UI2.WinForms.Guna2TileButton but_giao_hang;
    }
}