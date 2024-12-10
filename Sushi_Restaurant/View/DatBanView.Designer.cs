namespace Sushi_Restaurant.View
{
    partial class DatBanView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.text_sl_KH = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.text_GioDat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.text_NgayDen = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.text_KH = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_dia_chi = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_NgayDatBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_Header = new Guna.UI2.WinForms.Guna2Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.but_datBan = new Guna.UI2.WinForms.Guna2Button();
            this.but_huy = new Guna.UI2.WinForms.Guna2Button();
            this.richBox_ghi_chu = new System.Windows.Forms.RichTextBox();
            this.panel_list_mon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_sl_KH)).BeginInit();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_list_mon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BorderColor = System.Drawing.Color.Black;
            this.panel_main.BorderThickness = 1;
            this.panel_main.Controls.Add(this.label5);
            this.panel_main.Controls.Add(this.label8);
            this.panel_main.Controls.Add(this.label7);
            this.panel_main.Controls.Add(this.label6);
            this.panel_main.Controls.Add(this.label4);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.panel_list_mon);
            this.panel_main.Controls.Add(this.richBox_ghi_chu);
            this.panel_main.Controls.Add(this.text_sl_KH);
            this.panel_main.Controls.Add(this.text_GioDat);
            this.panel_main.Controls.Add(this.text_NgayDen);
            this.panel_main.Controls.Add(this.text_KH);
            this.panel_main.Controls.Add(this.text_dia_chi);
            this.panel_main.Controls.Add(this.text_NgayDatBan);
            this.panel_main.Controls.Add(this.panel_Header);
            this.panel_main.Controls.Add(this.but_datBan);
            this.panel_main.Controls.Add(this.but_huy);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(942, 788);
            this.panel_main.TabIndex = 0;
            // 
            // text_sl_KH
            // 
            this.text_sl_KH.BackColor = System.Drawing.Color.Transparent;
            this.text_sl_KH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sl_KH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_sl_KH.Location = new System.Drawing.Point(230, 300);
            this.text_sl_KH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_sl_KH.Name = "text_sl_KH";
            this.text_sl_KH.Size = new System.Drawing.Size(149, 35);
            this.text_sl_KH.TabIndex = 55;
            // 
            // text_GioDat
            // 
            this.text_GioDat.BackColor = System.Drawing.Color.Transparent;
            this.text_GioDat.Checked = true;
            this.text_GioDat.CustomFormat = "";
            this.text_GioDat.FillColor = System.Drawing.Color.White;
            this.text_GioDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_GioDat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.text_GioDat.Location = new System.Drawing.Point(630, 244);
            this.text_GioDat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.text_GioDat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.text_GioDat.Name = "text_GioDat";
            this.text_GioDat.Size = new System.Drawing.Size(269, 36);
            this.text_GioDat.TabIndex = 53;
            this.text_GioDat.Value = new System.DateTime(2024, 12, 3, 11, 47, 18, 151);
            // 
            // text_NgayDen
            // 
            this.text_NgayDen.BackColor = System.Drawing.Color.Transparent;
            this.text_NgayDen.Checked = true;
            this.text_NgayDen.FillColor = System.Drawing.Color.White;
            this.text_NgayDen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_NgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.text_NgayDen.Location = new System.Drawing.Point(230, 244);
            this.text_NgayDen.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.text_NgayDen.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.text_NgayDen.Name = "text_NgayDen";
            this.text_NgayDen.Size = new System.Drawing.Size(276, 36);
            this.text_NgayDen.TabIndex = 53;
            this.text_NgayDen.Value = new System.DateTime(2024, 12, 3, 11, 47, 18, 151);
            // 
            // text_KH
            // 
            this.text_KH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_KH.DefaultText = "";
            this.text_KH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_KH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_KH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_KH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_KH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_KH.Location = new System.Drawing.Point(230, 189);
            this.text_KH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_KH.Name = "text_KH";
            this.text_KH.PasswordChar = '\0';
            this.text_KH.PlaceholderText = "";
            this.text_KH.SelectedText = "";
            this.text_KH.Size = new System.Drawing.Size(669, 35);
            this.text_KH.TabIndex = 50;
            // 
            // text_dia_chi
            // 
            this.text_dia_chi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_dia_chi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_dia_chi.DefaultText = "";
            this.text_dia_chi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_dia_chi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_dia_chi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_dia_chi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_dia_chi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_dia_chi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_dia_chi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_dia_chi.Location = new System.Drawing.Point(230, 77);
            this.text_dia_chi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_dia_chi.Name = "text_dia_chi";
            this.text_dia_chi.PasswordChar = '\0';
            this.text_dia_chi.PlaceholderText = "";
            this.text_dia_chi.SelectedText = "";
            this.text_dia_chi.Size = new System.Drawing.Size(669, 35);
            this.text_dia_chi.TabIndex = 52;
            // 
            // text_NgayDatBan
            // 
            this.text_NgayDatBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_NgayDatBan.DefaultText = "";
            this.text_NgayDatBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_NgayDatBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_NgayDatBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_NgayDatBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_NgayDatBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_NgayDatBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_NgayDatBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_NgayDatBan.Location = new System.Drawing.Point(230, 133);
            this.text_NgayDatBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_NgayDatBan.Name = "text_NgayDatBan";
            this.text_NgayDatBan.PasswordChar = '\0';
            this.text_NgayDatBan.PlaceholderText = "";
            this.text_NgayDatBan.SelectedText = "";
            this.text_NgayDatBan.Size = new System.Drawing.Size(669, 35);
            this.text_NgayDatBan.TabIndex = 52;
            // 
            // panel_Header
            // 
            this.panel_Header.BorderColor = System.Drawing.Color.White;
            this.panel_Header.BorderThickness = 1;
            this.panel_Header.Controls.Add(this.label_title);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(942, 64);
            this.panel_Header.TabIndex = 42;
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_title.Location = new System.Drawing.Point(281, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(392, 45);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Thông tin chi tiết đặt bàn";
            // 
            // but_datBan
            // 
            this.but_datBan.AutoRoundedCorners = true;
            this.but_datBan.BackColor = System.Drawing.Color.White;
            this.but_datBan.BorderRadius = 21;
            this.but_datBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_datBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_datBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_datBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_datBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.but_datBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.but_datBan.ForeColor = System.Drawing.Color.White;
            this.but_datBan.Location = new System.Drawing.Point(620, 717);
            this.but_datBan.Name = "but_datBan";
            this.but_datBan.Size = new System.Drawing.Size(136, 45);
            this.but_datBan.TabIndex = 40;
            this.but_datBan.Text = "Đặt bàn";
            this.but_datBan.Click += new System.EventHandler(this.but_datBan_Click);
            // 
            // but_huy
            // 
            this.but_huy.AutoRoundedCorners = true;
            this.but_huy.BackColor = System.Drawing.Color.White;
            this.but_huy.BorderRadius = 21;
            this.but_huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_huy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.but_huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.but_huy.ForeColor = System.Drawing.Color.White;
            this.but_huy.Location = new System.Drawing.Point(772, 717);
            this.but_huy.Name = "but_huy";
            this.but_huy.Size = new System.Drawing.Size(136, 45);
            this.but_huy.TabIndex = 41;
            this.but_huy.Text = "Hủy";
            this.but_huy.Click += new System.EventHandler(this.but_huy_Click);
            // 
            // richBox_ghi_chu
            // 
            this.richBox_ghi_chu.Location = new System.Drawing.Point(569, 386);
            this.richBox_ghi_chu.Name = "richBox_ghi_chu";
            this.richBox_ghi_chu.Size = new System.Drawing.Size(330, 301);
            this.richBox_ghi_chu.TabIndex = 56;
            this.richBox_ghi_chu.Text = "";
            // 
            // panel_list_mon
            // 
            this.panel_list_mon.AllowUserToAddRows = false;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.White;
            this.panel_list_mon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle52;
            this.panel_list_mon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_list_mon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.panel_list_mon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panel_list_mon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle53;
            this.panel_list_mon.ColumnHeadersHeight = 40;
            this.panel_list_mon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.panel_list_mon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ten_mon,
            this.so_luong,
            this.but_Xoa});
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.panel_list_mon.DefaultCellStyle = dataGridViewCellStyle54;
            this.panel_list_mon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_list_mon.Location = new System.Drawing.Point(51, 386);
            this.panel_list_mon.Name = "panel_list_mon";
            this.panel_list_mon.RowHeadersVisible = false;
            this.panel_list_mon.RowHeadersWidth = 51;
            this.panel_list_mon.RowTemplate.Height = 24;
            this.panel_list_mon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.panel_list_mon.Size = new System.Drawing.Size(495, 301);
            this.panel_list_mon.TabIndex = 57;
            this.panel_list_mon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.panel_list_mon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.panel_list_mon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.panel_list_mon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.panel_list_mon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.panel_list_mon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.panel_list_mon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_list_mon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.panel_list_mon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.panel_list_mon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_list_mon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.panel_list_mon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.panel_list_mon.ThemeStyle.HeaderStyle.Height = 40;
            this.panel_list_mon.ThemeStyle.ReadOnly = false;
            this.panel_list_mon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.panel_list_mon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.panel_list_mon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_list_mon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.panel_list_mon.ThemeStyle.RowsStyle.Height = 24;
            this.panel_list_mon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_list_mon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.ten_mon.FillWeight = 350F;
            this.ten_mon.HeaderText = "Tên Món";
            this.ten_mon.MinimumWidth = 6;
            this.ten_mon.Name = "ten_mon";
            this.ten_mon.Width = 350;
            // 
            // so_luong
            // 
            this.so_luong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.so_luong.FillWeight = 30F;
            this.so_luong.HeaderText = "S.L";
            this.so_luong.MinimumWidth = 30;
            this.so_luong.Name = "so_luong";
            this.so_luong.Width = 30;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "Địa chỉ giao hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Ngày đặt bàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Ngày đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "Giờ đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 58;
            this.label6.Text = "Số lượng khách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 23);
            this.label7.TabIndex = 58;
            this.label7.Text = "Danh sách các món đặt trước";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(565, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 58;
            this.label8.Text = "Ghi chú";
            // 
            // DatBanView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 788);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatBanView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatBanView";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_sl_KH)).EndInit();
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_list_mon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_main;
        private Guna.UI2.WinForms.Guna2DateTimePicker text_NgayDen;
        private Guna.UI2.WinForms.Guna2TextBox text_KH;
        private Guna.UI2.WinForms.Guna2TextBox text_NgayDatBan;
        private Guna.UI2.WinForms.Guna2Panel panel_Header;
        private System.Windows.Forms.Label label_title;
        private Guna.UI2.WinForms.Guna2Button but_datBan;
        private Guna.UI2.WinForms.Guna2Button but_huy;
        private Guna.UI2.WinForms.Guna2DateTimePicker text_GioDat;
        private Guna.UI2.WinForms.Guna2NumericUpDown text_sl_KH;
        private Guna.UI2.WinForms.Guna2TextBox text_dia_chi;
        private System.Windows.Forms.RichTextBox richBox_ghi_chu;
        private Guna.UI2.WinForms.Guna2DataGridView panel_list_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewImageColumn but_Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}