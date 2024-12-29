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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.text_NgayDen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.text_dia_chi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_gioDen = new System.Windows.Forms.Label();
            this.label_ghiChu = new System.Windows.Forms.Label();
            this.label_listMon = new System.Windows.Forms.Label();
            this.label_slKH = new System.Windows.Forms.Label();
            this.label_ngayDen = new System.Windows.Forms.Label();
            this.label_SDT = new System.Windows.Forms.Label();
            this.label_TenKH = new System.Windows.Forms.Label();
            this.label_diaChiCN = new System.Windows.Forms.Label();
            this.panel_list_mon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richBox_ghi_chu = new System.Windows.Forms.RichTextBox();
            this.text_sl_KH = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.text_GioDat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.text_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_KH = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_Header = new Guna.UI2.WinForms.Guna2Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.but_datBan = new Guna.UI2.WinForms.Guna2Button();
            this.but_huy = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.warning_gioDen_DBView = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.warning_SLKH_DBView = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_list_mon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_sl_KH)).BeginInit();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BorderColor = System.Drawing.Color.Silver;
            this.panel_main.BorderThickness = 1;
            this.panel_main.Controls.Add(this.text_NgayDen);
            this.panel_main.Controls.Add(this.text_dia_chi);
            this.panel_main.Controls.Add(this.label_gioDen);
            this.panel_main.Controls.Add(this.label_ghiChu);
            this.panel_main.Controls.Add(this.label_listMon);
            this.panel_main.Controls.Add(this.label_slKH);
            this.panel_main.Controls.Add(this.label_ngayDen);
            this.panel_main.Controls.Add(this.label_SDT);
            this.panel_main.Controls.Add(this.label_TenKH);
            this.panel_main.Controls.Add(this.label_diaChiCN);
            this.panel_main.Controls.Add(this.panel_list_mon);
            this.panel_main.Controls.Add(this.richBox_ghi_chu);
            this.panel_main.Controls.Add(this.text_sl_KH);
            this.panel_main.Controls.Add(this.text_GioDat);
            this.panel_main.Controls.Add(this.text_SDT);
            this.panel_main.Controls.Add(this.text_KH);
            this.panel_main.Controls.Add(this.panel_Header);
            this.panel_main.Controls.Add(this.but_datBan);
            this.panel_main.Controls.Add(this.but_huy);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.FillColor = System.Drawing.Color.Silver;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(942, 757);
            this.panel_main.TabIndex = 0;
            // 
            // text_NgayDen
            // 
            this.text_NgayDen.BackColor = System.Drawing.Color.Transparent;
            this.text_NgayDen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.text_NgayDen.BorderThickness = 2;
            this.text_NgayDen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_NgayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_NgayDen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_NgayDen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_NgayDen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.text_NgayDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.text_NgayDen.ItemHeight = 30;
            this.text_NgayDen.Items.AddRange(new object[] {
            "Thanh toán trực tiếp khi nhận hàng ",
            "Thanh toán qua ngân hàng"});
            this.text_NgayDen.Location = new System.Drawing.Point(230, 236);
            this.text_NgayDen.Margin = new System.Windows.Forms.Padding(2);
            this.text_NgayDen.Name = "text_NgayDen";
            this.text_NgayDen.Size = new System.Drawing.Size(288, 36);
            this.text_NgayDen.TabIndex = 88;
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
            this.text_dia_chi.Enabled = false;
            this.text_dia_chi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_dia_chi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_dia_chi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_dia_chi.Location = new System.Drawing.Point(230, 83);
            this.text_dia_chi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_dia_chi.Name = "text_dia_chi";
            this.text_dia_chi.PasswordChar = '\0';
            this.text_dia_chi.PlaceholderText = "";
            this.text_dia_chi.ReadOnly = true;
            this.text_dia_chi.SelectedText = "";
            this.text_dia_chi.Size = new System.Drawing.Size(669, 35);
            this.text_dia_chi.TabIndex = 59;
            // 
            // label_gioDen
            // 
            this.label_gioDen.AutoSize = true;
            this.label_gioDen.BackColor = System.Drawing.Color.Transparent;
            this.label_gioDen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gioDen.Location = new System.Drawing.Point(570, 243);
            this.label_gioDen.Name = "label_gioDen";
            this.label_gioDen.Size = new System.Drawing.Size(73, 23);
            this.label_gioDen.TabIndex = 58;
            this.label_gioDen.Text = "Giờ đến";
            // 
            // label_ghiChu
            // 
            this.label_ghiChu.AutoSize = true;
            this.label_ghiChu.BackColor = System.Drawing.Color.Transparent;
            this.label_ghiChu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ghiChu.Location = new System.Drawing.Point(626, 360);
            this.label_ghiChu.Name = "label_ghiChu";
            this.label_ghiChu.Size = new System.Drawing.Size(70, 23);
            this.label_ghiChu.TabIndex = 58;
            this.label_ghiChu.Text = "Ghi chú";
            // 
            // label_listMon
            // 
            this.label_listMon.AutoSize = true;
            this.label_listMon.BackColor = System.Drawing.Color.Transparent;
            this.label_listMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listMon.Location = new System.Drawing.Point(56, 360);
            this.label_listMon.Name = "label_listMon";
            this.label_listMon.Size = new System.Drawing.Size(243, 23);
            this.label_listMon.TabIndex = 58;
            this.label_listMon.Text = "Danh sách các món đặt trước";
            // 
            // label_slKH
            // 
            this.label_slKH.AutoSize = true;
            this.label_slKH.BackColor = System.Drawing.Color.Transparent;
            this.label_slKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_slKH.Location = new System.Drawing.Point(58, 299);
            this.label_slKH.Name = "label_slKH";
            this.label_slKH.Size = new System.Drawing.Size(135, 23);
            this.label_slKH.TabIndex = 58;
            this.label_slKH.Text = "Số lượng khách";
            // 
            // label_ngayDen
            // 
            this.label_ngayDen.AutoSize = true;
            this.label_ngayDen.BackColor = System.Drawing.Color.Transparent;
            this.label_ngayDen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngayDen.Location = new System.Drawing.Point(58, 243);
            this.label_ngayDen.Name = "label_ngayDen";
            this.label_ngayDen.Size = new System.Drawing.Size(87, 23);
            this.label_ngayDen.TabIndex = 58;
            this.label_ngayDen.Text = "Ngày đến";
            // 
            // label_SDT
            // 
            this.label_SDT.AutoSize = true;
            this.label_SDT.BackColor = System.Drawing.Color.Transparent;
            this.label_SDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SDT.Location = new System.Drawing.Point(56, 190);
            this.label_SDT.Name = "label_SDT";
            this.label_SDT.Size = new System.Drawing.Size(116, 23);
            this.label_SDT.TabIndex = 58;
            this.label_SDT.Text = "Số điện thoại";
            // 
            // label_TenKH
            // 
            this.label_TenKH.AutoSize = true;
            this.label_TenKH.BackColor = System.Drawing.Color.Transparent;
            this.label_TenKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenKH.Location = new System.Drawing.Point(56, 137);
            this.label_TenKH.Name = "label_TenKH";
            this.label_TenKH.Size = new System.Drawing.Size(134, 23);
            this.label_TenKH.TabIndex = 58;
            this.label_TenKH.Text = "Tên khách hàng";
            // 
            // label_diaChiCN
            // 
            this.label_diaChiCN.AutoSize = true;
            this.label_diaChiCN.BackColor = System.Drawing.Color.Transparent;
            this.label_diaChiCN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diaChiCN.Location = new System.Drawing.Point(56, 83);
            this.label_diaChiCN.Name = "label_diaChiCN";
            this.label_diaChiCN.Size = new System.Drawing.Size(147, 23);
            this.label_diaChiCN.TabIndex = 58;
            this.label_diaChiCN.Text = "Địa chỉ chi nhánh";
            // 
            // panel_list_mon
            // 
            this.panel_list_mon.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.panel_list_mon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.panel_list_mon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_list_mon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.panel_list_mon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panel_list_mon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.panel_list_mon.ColumnHeadersHeight = 40;
            this.panel_list_mon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.panel_list_mon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.dgvId,
            this.ten_mon,
            this.soLuong,
            this.donGia,
            this.thanhTien});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panel_list_mon.DefaultCellStyle = dataGridViewCellStyle9;
            this.panel_list_mon.Enabled = false;
            this.panel_list_mon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_list_mon.Location = new System.Drawing.Point(60, 386);
            this.panel_list_mon.Name = "panel_list_mon";
            this.panel_list_mon.RowHeadersVisible = false;
            this.panel_list_mon.RowHeadersWidth = 51;
            this.panel_list_mon.RowTemplate.Height = 24;
            this.panel_list_mon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.panel_list_mon.Size = new System.Drawing.Size(548, 299);
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
            this.STT.FillWeight = 40F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 40;
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "";
            this.dgvId.MinimumWidth = 6;
            this.dgvId.Name = "dgvId";
            this.dgvId.Visible = false;
            this.dgvId.Width = 21;
            // 
            // ten_mon
            // 
            this.ten_mon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_mon.FillWeight = 350F;
            this.ten_mon.HeaderText = "Tên Món";
            this.ten_mon.MinimumWidth = 6;
            this.ten_mon.Name = "ten_mon";
            // 
            // soLuong
            // 
            this.soLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.soLuong.FillWeight = 35F;
            this.soLuong.HeaderText = "S.L";
            this.soLuong.MinimumWidth = 35;
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 35;
            // 
            // donGia
            // 
            this.donGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.donGia.FillWeight = 70F;
            this.donGia.HeaderText = "D.Gia";
            this.donGia.MinimumWidth = 70;
            this.donGia.Name = "donGia";
            this.donGia.Width = 70;
            // 
            // thanhTien
            // 
            this.thanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.thanhTien.FillWeight = 85F;
            this.thanhTien.HeaderText = "T.Tiền";
            this.thanhTien.MinimumWidth = 85;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.Width = 85;
            // 
            // richBox_ghi_chu
            // 
            this.richBox_ghi_chu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richBox_ghi_chu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richBox_ghi_chu.Location = new System.Drawing.Point(630, 385);
            this.richBox_ghi_chu.Name = "richBox_ghi_chu";
            this.richBox_ghi_chu.Size = new System.Drawing.Size(286, 301);
            this.richBox_ghi_chu.TabIndex = 56;
            this.richBox_ghi_chu.Text = "";
            // 
            // text_sl_KH
            // 
            this.text_sl_KH.BackColor = System.Drawing.Color.Transparent;
            this.text_sl_KH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sl_KH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_sl_KH.Location = new System.Drawing.Point(230, 292);
            this.text_sl_KH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_sl_KH.Name = "text_sl_KH";
            this.text_sl_KH.Size = new System.Drawing.Size(149, 35);
            this.text_sl_KH.TabIndex = 55;
            // 
            // text_GioDat
            // 
            this.text_GioDat.BackColor = System.Drawing.Color.Transparent;
            this.text_GioDat.Checked = true;
            this.text_GioDat.CustomFormat = "HH:mm";
            this.text_GioDat.FillColor = System.Drawing.Color.White;
            this.text_GioDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_GioDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.text_GioDat.Location = new System.Drawing.Point(669, 236);
            this.text_GioDat.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.text_GioDat.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.text_GioDat.Name = "text_GioDat";
            this.text_GioDat.ShowUpDown = true;
            this.text_GioDat.Size = new System.Drawing.Size(230, 36);
            this.text_GioDat.TabIndex = 53;
            this.text_GioDat.Value = new System.DateTime(2024, 12, 19, 9, 0, 0, 0);
            this.text_GioDat.ValueChanged += new System.EventHandler(this.text_GioDat_ValueChanged);
            // 
            // text_SDT
            // 
            this.text_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_SDT.DefaultText = "";
            this.text_SDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_SDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_SDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_SDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_SDT.Enabled = false;
            this.text_SDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_SDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_SDT.Location = new System.Drawing.Point(230, 184);
            this.text_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_SDT.Name = "text_SDT";
            this.text_SDT.PasswordChar = '\0';
            this.text_SDT.PlaceholderText = "";
            this.text_SDT.ReadOnly = true;
            this.text_SDT.SelectedText = "";
            this.text_SDT.Size = new System.Drawing.Size(669, 35);
            this.text_SDT.TabIndex = 50;
            // 
            // text_KH
            // 
            this.text_KH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_KH.DefaultText = "";
            this.text_KH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_KH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_KH.Enabled = false;
            this.text_KH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_KH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_KH.Location = new System.Drawing.Point(230, 133);
            this.text_KH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_KH.Name = "text_KH";
            this.text_KH.PasswordChar = '\0';
            this.text_KH.PlaceholderText = "";
            this.text_KH.ReadOnly = true;
            this.text_KH.SelectedText = "";
            this.text_KH.Size = new System.Drawing.Size(669, 35);
            this.text_KH.TabIndex = 50;
            // 
            // panel_Header
            // 
            this.panel_Header.BorderColor = System.Drawing.Color.Silver;
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
            this.but_datBan.Location = new System.Drawing.Point(611, 705);
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
            this.but_huy.Location = new System.Drawing.Point(763, 705);
            this.but_huy.Name = "but_huy";
            this.but_huy.Size = new System.Drawing.Size(136, 45);
            this.but_huy.TabIndex = 41;
            this.but_huy.Text = "Hủy";
            this.but_huy.Click += new System.EventHandler(this.but_huy_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Sushi_Restaurant.Properties.Resources.icon_xoa;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // warning_gioDen_DBView
            // 
            this.warning_gioDen_DBView.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.warning_gioDen_DBView.Caption = null;
            this.warning_gioDen_DBView.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.warning_gioDen_DBView.Parent = this;
            this.warning_gioDen_DBView.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.warning_gioDen_DBView.Text = null;
            // 
            // warning_SLKH_DBView
            // 
            this.warning_SLKH_DBView.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.warning_SLKH_DBView.Caption = null;
            this.warning_SLKH_DBView.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.warning_SLKH_DBView.Parent = this;
            this.warning_SLKH_DBView.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.warning_SLKH_DBView.Text = null;
            // 
            // DatBanView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 757);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatBanView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatBanView";
            this.Load += new System.EventHandler(this.DatBanView_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_list_mon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_sl_KH)).EndInit();
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_main;
        private Guna.UI2.WinForms.Guna2TextBox text_KH;
        private Guna.UI2.WinForms.Guna2Panel panel_Header;
        private System.Windows.Forms.Label label_title;
        private Guna.UI2.WinForms.Guna2Button but_datBan;
        private Guna.UI2.WinForms.Guna2Button but_huy;
        private Guna.UI2.WinForms.Guna2DateTimePicker text_GioDat;
        private Guna.UI2.WinForms.Guna2NumericUpDown text_sl_KH;
        private System.Windows.Forms.RichTextBox richBox_ghi_chu;
        private Guna.UI2.WinForms.Guna2DataGridView panel_list_mon;
        private System.Windows.Forms.Label label_diaChiCN;
        private System.Windows.Forms.Label label_ngayDen;
        private System.Windows.Forms.Label label_TenKH;
        private System.Windows.Forms.Label label_gioDen;
        private System.Windows.Forms.Label label_ghiChu;
        private System.Windows.Forms.Label label_listMon;
        private System.Windows.Forms.Label label_slKH;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label_SDT;
        private Guna.UI2.WinForms.Guna2TextBox text_SDT;
        private Guna.UI2.WinForms.Guna2TextBox text_dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private Guna.UI2.WinForms.Guna2ComboBox text_NgayDen;
        private Guna.UI2.WinForms.Guna2MessageDialog warning_gioDen_DBView;
        private Guna.UI2.WinForms.Guna2MessageDialog warning_SLKH_DBView;
    }
}