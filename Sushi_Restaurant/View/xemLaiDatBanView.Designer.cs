namespace Sushi_Restaurant.View
{
    partial class xemLaiDatBanView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Header = new Guna.UI2.WinForms.Guna2Panel();
            this.ControlBoxThoat = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_dsMon = new System.Windows.Forms.Label();
            this.panel_list_mon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_gioDen = new System.Windows.Forms.Label();
            this.label_ghiChu = new System.Windows.Forms.Label();
            this.label_sgKH = new System.Windows.Forms.Label();
            this.label_ngayDen = new System.Windows.Forms.Label();
            this.label_SDT = new System.Windows.Forms.Label();
            this.label_TenKH = new System.Windows.Forms.Label();
            this.label_DiaChiCn = new System.Windows.Forms.Label();
            this.richBox_ghi_chu = new System.Windows.Forms.RichTextBox();
            this.text_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_KH = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_dia_chi = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_ngayDen = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_GioDen = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_sl_KH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_ngayDat = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_list_mon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BorderColor = System.Drawing.Color.White;
            this.panel_Header.BorderThickness = 1;
            this.panel_Header.Controls.Add(this.ControlBoxThoat);
            this.panel_Header.Controls.Add(this.label_title);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(924, 64);
            this.panel_Header.TabIndex = 59;
            // 
            // ControlBoxThoat
            // 
            this.ControlBoxThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxThoat.CustomClick = true;
            this.ControlBoxThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlBoxThoat.IconColor = System.Drawing.Color.White;
            this.ControlBoxThoat.Location = new System.Drawing.Point(888, 2);
            this.ControlBoxThoat.Margin = new System.Windows.Forms.Padding(2);
            this.ControlBoxThoat.Name = "ControlBoxThoat";
            this.ControlBoxThoat.Size = new System.Drawing.Size(34, 29);
            this.ControlBoxThoat.TabIndex = 96;
            this.ControlBoxThoat.Click += new System.EventHandler(this.ControlBoxThoat_Click);
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_title.Location = new System.Drawing.Point(231, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(459, 45);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Thông tin chi tiết đơn đặt bàn";
            // 
            // label_dsMon
            // 
            this.label_dsMon.AutoSize = true;
            this.label_dsMon.BackColor = System.Drawing.Color.Transparent;
            this.label_dsMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dsMon.Location = new System.Drawing.Point(41, 355);
            this.label_dsMon.Name = "label_dsMon";
            this.label_dsMon.Size = new System.Drawing.Size(243, 23);
            this.label_dsMon.TabIndex = 95;
            this.label_dsMon.Text = "Danh sách các món đặt trước";
            // 
            // panel_list_mon
            // 
            this.panel_list_mon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.panel_list_mon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.panel_list_mon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_list_mon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.panel_list_mon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panel_list_mon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.panel_list_mon.ColumnHeadersHeight = 40;
            this.panel_list_mon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.panel_list_mon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenMon,
            this.SL});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.panel_list_mon.DefaultCellStyle = dataGridViewCellStyle3;
            this.panel_list_mon.Enabled = false;
            this.panel_list_mon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_list_mon.Location = new System.Drawing.Point(42, 384);
            this.panel_list_mon.Name = "panel_list_mon";
            this.panel_list_mon.ReadOnly = true;
            this.panel_list_mon.RowHeadersVisible = false;
            this.panel_list_mon.RowHeadersWidth = 51;
            this.panel_list_mon.RowTemplate.Height = 24;
            this.panel_list_mon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.panel_list_mon.Size = new System.Drawing.Size(498, 341);
            this.panel_list_mon.TabIndex = 94;
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
            this.panel_list_mon.ThemeStyle.ReadOnly = true;
            this.panel_list_mon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.panel_list_mon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.panel_list_mon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_list_mon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.panel_list_mon.ThemeStyle.RowsStyle.Height = 24;
            this.panel_list_mon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_list_mon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.panel_list_mon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.panel_list_mon_CellContentClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 50;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.FillWeight = 350F;
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SL.DataPropertyName = "SL";
            this.SL.FillWeight = 50F;
            this.SL.HeaderText = "S.L";
            this.SL.MinimumWidth = 50;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Width = 50;
            // 
            // label_gioDen
            // 
            this.label_gioDen.AutoSize = true;
            this.label_gioDen.BackColor = System.Drawing.Color.Transparent;
            this.label_gioDen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gioDen.Location = new System.Drawing.Point(437, 237);
            this.label_gioDen.Name = "label_gioDen";
            this.label_gioDen.Size = new System.Drawing.Size(73, 23);
            this.label_gioDen.TabIndex = 93;
            this.label_gioDen.Text = "Giờ đến";
            // 
            // label_ghiChu
            // 
            this.label_ghiChu.AutoSize = true;
            this.label_ghiChu.BackColor = System.Drawing.Color.Transparent;
            this.label_ghiChu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ghiChu.Location = new System.Drawing.Point(550, 355);
            this.label_ghiChu.Name = "label_ghiChu";
            this.label_ghiChu.Size = new System.Drawing.Size(70, 23);
            this.label_ghiChu.TabIndex = 91;
            this.label_ghiChu.Text = "Ghi chú";
            // 
            // label_sgKH
            // 
            this.label_sgKH.AutoSize = true;
            this.label_sgKH.BackColor = System.Drawing.Color.Transparent;
            this.label_sgKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sgKH.Location = new System.Drawing.Point(648, 237);
            this.label_sgKH.Name = "label_sgKH";
            this.label_sgKH.Size = new System.Drawing.Size(135, 23);
            this.label_sgKH.TabIndex = 90;
            this.label_sgKH.Text = "Số lượng khách";
            // 
            // label_ngayDen
            // 
            this.label_ngayDen.AutoSize = true;
            this.label_ngayDen.BackColor = System.Drawing.Color.Transparent;
            this.label_ngayDen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngayDen.Location = new System.Drawing.Point(41, 242);
            this.label_ngayDen.Name = "label_ngayDen";
            this.label_ngayDen.Size = new System.Drawing.Size(87, 23);
            this.label_ngayDen.TabIndex = 89;
            this.label_ngayDen.Text = "Ngày đến";
            // 
            // label_SDT
            // 
            this.label_SDT.AutoSize = true;
            this.label_SDT.BackColor = System.Drawing.Color.Transparent;
            this.label_SDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SDT.Location = new System.Drawing.Point(39, 187);
            this.label_SDT.Name = "label_SDT";
            this.label_SDT.Size = new System.Drawing.Size(121, 23);
            this.label_SDT.TabIndex = 88;
            this.label_SDT.Text = "Số điện thoại ";
            // 
            // label_TenKH
            // 
            this.label_TenKH.AutoSize = true;
            this.label_TenKH.BackColor = System.Drawing.Color.Transparent;
            this.label_TenKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenKH.Location = new System.Drawing.Point(39, 142);
            this.label_TenKH.Name = "label_TenKH";
            this.label_TenKH.Size = new System.Drawing.Size(134, 23);
            this.label_TenKH.TabIndex = 87;
            this.label_TenKH.Text = "Tên khách hàng";
            // 
            // label_DiaChiCn
            // 
            this.label_DiaChiCn.AutoSize = true;
            this.label_DiaChiCn.BackColor = System.Drawing.Color.Transparent;
            this.label_DiaChiCn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiaChiCn.Location = new System.Drawing.Point(40, 90);
            this.label_DiaChiCn.Name = "label_DiaChiCn";
            this.label_DiaChiCn.Size = new System.Drawing.Size(147, 23);
            this.label_DiaChiCn.TabIndex = 92;
            this.label_DiaChiCn.Text = "Địa chỉ chi nhánh";
            // 
            // richBox_ghi_chu
            // 
            this.richBox_ghi_chu.Enabled = false;
            this.richBox_ghi_chu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richBox_ghi_chu.Location = new System.Drawing.Point(554, 382);
            this.richBox_ghi_chu.Name = "richBox_ghi_chu";
            this.richBox_ghi_chu.ReadOnly = true;
            this.richBox_ghi_chu.Size = new System.Drawing.Size(330, 343);
            this.richBox_ghi_chu.TabIndex = 86;
            this.richBox_ghi_chu.Text = "";
            // 
            // text_SDT
            // 
            this.text_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_SDT.DefaultText = "";
            this.text_SDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_SDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_SDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_SDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_SDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_SDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_SDT.Location = new System.Drawing.Point(213, 181);
            this.text_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_SDT.Name = "text_SDT";
            this.text_SDT.PasswordChar = '\0';
            this.text_SDT.PlaceholderText = "";
            this.text_SDT.ReadOnly = true;
            this.text_SDT.SelectedText = "";
            this.text_SDT.Size = new System.Drawing.Size(669, 35);
            this.text_SDT.TabIndex = 80;
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
            this.text_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_KH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_KH.Location = new System.Drawing.Point(213, 133);
            this.text_KH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_KH.Name = "text_KH";
            this.text_KH.PasswordChar = '\0';
            this.text_KH.PlaceholderText = "";
            this.text_KH.ReadOnly = true;
            this.text_KH.SelectedText = "";
            this.text_KH.Size = new System.Drawing.Size(669, 35);
            this.text_KH.TabIndex = 81;
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
            this.text_dia_chi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_dia_chi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_dia_chi.Location = new System.Drawing.Point(214, 85);
            this.text_dia_chi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_dia_chi.Name = "text_dia_chi";
            this.text_dia_chi.PasswordChar = '\0';
            this.text_dia_chi.PlaceholderText = "";
            this.text_dia_chi.ReadOnly = true;
            this.text_dia_chi.SelectedText = "";
            this.text_dia_chi.Size = new System.Drawing.Size(669, 35);
            this.text_dia_chi.TabIndex = 82;
            // 
            // text_ngayDen
            // 
            this.text_ngayDen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_ngayDen.DefaultText = "";
            this.text_ngayDen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_ngayDen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_ngayDen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_ngayDen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_ngayDen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_ngayDen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ngayDen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_ngayDen.Location = new System.Drawing.Point(214, 231);
            this.text_ngayDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_ngayDen.Name = "text_ngayDen";
            this.text_ngayDen.PasswordChar = '\0';
            this.text_ngayDen.PlaceholderText = "";
            this.text_ngayDen.ReadOnly = true;
            this.text_ngayDen.SelectedText = "";
            this.text_ngayDen.Size = new System.Drawing.Size(212, 35);
            this.text_ngayDen.TabIndex = 80;
            // 
            // text_GioDen
            // 
            this.text_GioDen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_GioDen.DefaultText = "";
            this.text_GioDen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_GioDen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_GioDen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_GioDen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_GioDen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_GioDen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_GioDen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_GioDen.Location = new System.Drawing.Point(522, 230);
            this.text_GioDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_GioDen.Name = "text_GioDen";
            this.text_GioDen.PasswordChar = '\0';
            this.text_GioDen.PlaceholderText = "";
            this.text_GioDen.ReadOnly = true;
            this.text_GioDen.SelectedText = "";
            this.text_GioDen.Size = new System.Drawing.Size(120, 35);
            this.text_GioDen.TabIndex = 80;
            // 
            // text_sl_KH
            // 
            this.text_sl_KH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sl_KH.DefaultText = "";
            this.text_sl_KH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_sl_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_sl_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_sl_KH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_sl_KH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_sl_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_sl_KH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_sl_KH.Location = new System.Drawing.Point(806, 225);
            this.text_sl_KH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_sl_KH.Name = "text_sl_KH";
            this.text_sl_KH.PasswordChar = '\0';
            this.text_sl_KH.PlaceholderText = "";
            this.text_sl_KH.ReadOnly = true;
            this.text_sl_KH.SelectedText = "";
            this.text_sl_KH.Size = new System.Drawing.Size(76, 35);
            this.text_sl_KH.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 89;
            this.label1.Text = "Ngày đặt";
            // 
            // text_ngayDat
            // 
            this.text_ngayDat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_ngayDat.DefaultText = "";
            this.text_ngayDat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_ngayDat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_ngayDat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_ngayDat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_ngayDat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_ngayDat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ngayDat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_ngayDat.Location = new System.Drawing.Point(213, 282);
            this.text_ngayDat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_ngayDat.Name = "text_ngayDat";
            this.text_ngayDat.PasswordChar = '\0';
            this.text_ngayDat.PlaceholderText = "";
            this.text_ngayDat.ReadOnly = true;
            this.text_ngayDat.SelectedText = "";
            this.text_ngayDat.Size = new System.Drawing.Size(213, 35);
            this.text_ngayDat.TabIndex = 80;
            // 
            // xemLaiDatBanView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 757);
            this.Controls.Add(this.label_dsMon);
            this.Controls.Add(this.panel_list_mon);
            this.Controls.Add(this.label_gioDen);
            this.Controls.Add(this.label_ghiChu);
            this.Controls.Add(this.label_sgKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ngayDen);
            this.Controls.Add(this.label_SDT);
            this.Controls.Add(this.label_TenKH);
            this.Controls.Add(this.label_DiaChiCn);
            this.Controls.Add(this.richBox_ghi_chu);
            this.Controls.Add(this.text_GioDen);
            this.Controls.Add(this.text_sl_KH);
            this.Controls.Add(this.text_ngayDen);
            this.Controls.Add(this.text_ngayDat);
            this.Controls.Add(this.text_SDT);
            this.Controls.Add(this.text_KH);
            this.Controls.Add(this.text_dia_chi);
            this.Controls.Add(this.panel_Header);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "xemLaiDatBanView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xemLaiDatBanView";
            this.Load += new System.EventHandler(this.xemLaiDatBanView_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_list_mon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panel_Header;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_dsMon;
        private Guna.UI2.WinForms.Guna2DataGridView panel_list_mon;
        private System.Windows.Forms.Label label_gioDen;
        private System.Windows.Forms.Label label_ghiChu;
        private System.Windows.Forms.Label label_sgKH;
        private System.Windows.Forms.Label label_ngayDen;
        private System.Windows.Forms.Label label_SDT;
        private System.Windows.Forms.Label label_TenKH;
        private System.Windows.Forms.Label label_DiaChiCn;
        private System.Windows.Forms.RichTextBox richBox_ghi_chu;
        private Guna.UI2.WinForms.Guna2TextBox text_SDT;
        private Guna.UI2.WinForms.Guna2TextBox text_KH;
        private Guna.UI2.WinForms.Guna2TextBox text_dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private Guna.UI2.WinForms.Guna2TextBox text_ngayDen;
        private Guna.UI2.WinForms.Guna2TextBox text_GioDen;
        private Guna.UI2.WinForms.Guna2TextBox text_sl_KH;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox text_ngayDat;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxThoat;
    }
}