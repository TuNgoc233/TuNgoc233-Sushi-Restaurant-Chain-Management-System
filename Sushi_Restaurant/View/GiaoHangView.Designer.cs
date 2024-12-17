namespace Sushi_Restaurant.View
{
    partial class GiaoHangView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new Guna.UI2.WinForms.Guna2Panel();
            this.text_NgayDen = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmb_thanhToan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.text_diaChiGiao = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_thanhToan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_diaChGiao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.text_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_SDT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.text_tenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_TenKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_ngayDat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_Header = new Guna.UI2.WinForms.Guna2Panel();
            this.label_Dat_Mon = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.value_giamGiaTTV = new System.Windows.Forms.Label();
            this.value_giamGia = new System.Windows.Forms.Label();
            this.value_thanhTien = new System.Windows.Forms.Label();
            this.value_tongTien = new System.Windows.Forms.Label();
            this.label_lisMon = new System.Windows.Forms.Label();
            this.label_thanhTien = new System.Windows.Forms.Label();
            this.value_TTV = new System.Windows.Forms.Label();
            this.label_TTV = new System.Windows.Forms.Label();
            this.label_giamGia = new System.Windows.Forms.Label();
            this.label_tongTien = new System.Windows.Forms.Label();
            this.panel_dat_hang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.but_huy = new Guna.UI2.WinForms.Guna2Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel_main.SuspendLayout();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_dat_hang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.BorderColor = System.Drawing.Color.Silver;
            this.panel_main.BorderThickness = 2;
            this.panel_main.Controls.Add(this.value_giamGiaTTV);
            this.panel_main.Controls.Add(this.value_giamGia);
            this.panel_main.Controls.Add(this.value_thanhTien);
            this.panel_main.Controls.Add(this.value_tongTien);
            this.panel_main.Controls.Add(this.label_lisMon);
            this.panel_main.Controls.Add(this.label_thanhTien);
            this.panel_main.Controls.Add(this.value_TTV);
            this.panel_main.Controls.Add(this.label_TTV);
            this.panel_main.Controls.Add(this.label_giamGia);
            this.panel_main.Controls.Add(this.label_tongTien);
            this.panel_main.Controls.Add(this.panel_dat_hang);
            this.panel_main.Controls.Add(this.guna2Button1);
            this.panel_main.Controls.Add(this.but_huy);
            this.panel_main.Controls.Add(this.text_NgayDen);
            this.panel_main.Controls.Add(this.cmb_thanhToan);
            this.panel_main.Controls.Add(this.text_diaChiGiao);
            this.panel_main.Controls.Add(this.label_thanhToan);
            this.panel_main.Controls.Add(this.label_diaChGiao);
            this.panel_main.Controls.Add(this.text_SDT);
            this.panel_main.Controls.Add(this.label_SDT);
            this.panel_main.Controls.Add(this.text_tenKH);
            this.panel_main.Controls.Add(this.label_TenKH);
            this.panel_main.Controls.Add(this.label_ngayDat);
            this.panel_main.Controls.Add(this.panel_Header);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.FillColor = System.Drawing.Color.White;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(920, 756);
            this.panel_main.TabIndex = 0;
            // 
            // text_NgayDen
            // 
            this.text_NgayDen.BackColor = System.Drawing.Color.Transparent;
            this.text_NgayDen.Checked = true;
            this.text_NgayDen.CustomFormat = "dddd, dd/MM/yyyy";
            this.text_NgayDen.FillColor = System.Drawing.Color.White;
            this.text_NgayDen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_NgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.text_NgayDen.Location = new System.Drawing.Point(239, 102);
            this.text_NgayDen.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.text_NgayDen.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.text_NgayDen.Name = "text_NgayDen";
            this.text_NgayDen.Size = new System.Drawing.Size(634, 43);
            this.text_NgayDen.TabIndex = 71;
            this.text_NgayDen.Value = new System.DateTime(2024, 12, 3, 0, 0, 0, 0);
            // 
            // cmb_thanhToan
            // 
            this.cmb_thanhToan.BackColor = System.Drawing.Color.Transparent;
            this.cmb_thanhToan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmb_thanhToan.BorderThickness = 2;
            this.cmb_thanhToan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_thanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_thanhToan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_thanhToan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_thanhToan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_thanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_thanhToan.ItemHeight = 30;
            this.cmb_thanhToan.Items.AddRange(new object[] {
            "Thanh toán trực tiếp khi nhận hàng ",
            "Thanh toán qua ngân hàng"});
            this.cmb_thanhToan.Location = new System.Drawing.Point(239, 344);
            this.cmb_thanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_thanhToan.Name = "cmb_thanhToan";
            this.cmb_thanhToan.Size = new System.Drawing.Size(356, 36);
            this.cmb_thanhToan.TabIndex = 39;
            this.cmb_thanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_diaChiGiao
            // 
            this.text_diaChiGiao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_diaChiGiao.DefaultText = "";
            this.text_diaChiGiao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_diaChiGiao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_diaChiGiao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_diaChiGiao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_diaChiGiao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_diaChiGiao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_diaChiGiao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_diaChiGiao.Location = new System.Drawing.Point(239, 275);
            this.text_diaChiGiao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_diaChiGiao.Name = "text_diaChiGiao";
            this.text_diaChiGiao.PasswordChar = '\0';
            this.text_diaChiGiao.PlaceholderText = "";
            this.text_diaChiGiao.SelectedText = "";
            this.text_diaChiGiao.Size = new System.Drawing.Size(634, 48);
            this.text_diaChiGiao.TabIndex = 34;
            // 
            // label_thanhToan
            // 
            this.label_thanhToan.AutoSize = false;
            this.label_thanhToan.BackColor = System.Drawing.Color.Transparent;
            this.label_thanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thanhToan.Location = new System.Drawing.Point(51, 340);
            this.label_thanhToan.Name = "label_thanhToan";
            this.label_thanhToan.Size = new System.Drawing.Size(106, 46);
            this.label_thanhToan.TabIndex = 28;
            this.label_thanhToan.Text = "Hình thức thanh toán";
            // 
            // label_diaChGiao
            // 
            this.label_diaChGiao.AutoSize = false;
            this.label_diaChGiao.BackColor = System.Drawing.Color.Transparent;
            this.label_diaChGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diaChGiao.Location = new System.Drawing.Point(51, 287);
            this.label_diaChGiao.Name = "label_diaChGiao";
            this.label_diaChGiao.Size = new System.Drawing.Size(141, 24);
            this.label_diaChGiao.TabIndex = 29;
            this.label_diaChGiao.Text = "Địa chỉ giao";
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
            this.text_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_SDT.Location = new System.Drawing.Point(239, 211);
            this.text_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_SDT.Name = "text_SDT";
            this.text_SDT.PasswordChar = '\0';
            this.text_SDT.PlaceholderText = "";
            this.text_SDT.SelectedText = "";
            this.text_SDT.Size = new System.Drawing.Size(634, 48);
            this.text_SDT.TabIndex = 35;
            // 
            // label_SDT
            // 
            this.label_SDT.AutoSize = false;
            this.label_SDT.BackColor = System.Drawing.Color.Transparent;
            this.label_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SDT.Location = new System.Drawing.Point(51, 222);
            this.label_SDT.Name = "label_SDT";
            this.label_SDT.Size = new System.Drawing.Size(164, 24);
            this.label_SDT.TabIndex = 30;
            this.label_SDT.Text = "Số điện thoại";
            // 
            // text_tenKH
            // 
            this.text_tenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_tenKH.DefaultText = "";
            this.text_tenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_tenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_tenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_tenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_tenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_tenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_tenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_tenKH.Location = new System.Drawing.Point(239, 155);
            this.text_tenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_tenKH.Name = "text_tenKH";
            this.text_tenKH.PasswordChar = '\0';
            this.text_tenKH.PlaceholderText = "";
            this.text_tenKH.SelectedText = "";
            this.text_tenKH.Size = new System.Drawing.Size(634, 48);
            this.text_tenKH.TabIndex = 35;
            // 
            // label_TenKH
            // 
            this.label_TenKH.AutoSize = false;
            this.label_TenKH.BackColor = System.Drawing.Color.Transparent;
            this.label_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenKH.Location = new System.Drawing.Point(51, 166);
            this.label_TenKH.Name = "label_TenKH";
            this.label_TenKH.Size = new System.Drawing.Size(164, 24);
            this.label_TenKH.TabIndex = 30;
            this.label_TenKH.Text = "Tên khách hàng";
            // 
            // label_ngayDat
            // 
            this.label_ngayDat.AutoSize = false;
            this.label_ngayDat.BackColor = System.Drawing.Color.Transparent;
            this.label_ngayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngayDat.Location = new System.Drawing.Point(51, 111);
            this.label_ngayDat.Name = "label_ngayDat";
            this.label_ngayDat.Size = new System.Drawing.Size(150, 24);
            this.label_ngayDat.TabIndex = 33;
            this.label_ngayDat.Text = "Ngày đặt hàng";
            // 
            // panel_Header
            // 
            this.panel_Header.BorderColor = System.Drawing.Color.Silver;
            this.panel_Header.BorderThickness = 1;
            this.panel_Header.Controls.Add(this.label_Dat_Mon);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(920, 64);
            this.panel_Header.TabIndex = 27;
            // 
            // label_Dat_Mon
            // 
            this.label_Dat_Mon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Dat_Mon.AutoSize = true;
            this.label_Dat_Mon.BackColor = System.Drawing.Color.Transparent;
            this.label_Dat_Mon.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dat_Mon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_Dat_Mon.Location = new System.Drawing.Point(231, 9);
            this.label_Dat_Mon.Name = "label_Dat_Mon";
            this.label_Dat_Mon.Size = new System.Drawing.Size(430, 45);
            this.label_Dat_Mon.TabIndex = 1;
            this.label_Dat_Mon.Text = "Thông tin chi tiết đơn hàng ";
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
            // value_giamGiaTTV
            // 
            this.value_giamGiaTTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_giamGiaTTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.value_giamGiaTTV.Location = new System.Drawing.Point(751, 552);
            this.value_giamGiaTTV.Name = "value_giamGiaTTV";
            this.value_giamGiaTTV.Size = new System.Drawing.Size(152, 25);
            this.value_giamGiaTTV.TabIndex = 81;
            this.value_giamGiaTTV.Text = "-20.000";
            this.value_giamGiaTTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // value_giamGia
            // 
            this.value_giamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_giamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.value_giamGia.Location = new System.Drawing.Point(755, 483);
            this.value_giamGia.Name = "value_giamGia";
            this.value_giamGia.Size = new System.Drawing.Size(148, 25);
            this.value_giamGia.TabIndex = 82;
            this.value_giamGia.Text = "-20.000";
            this.value_giamGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // value_thanhTien
            // 
            this.value_thanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_thanhTien.ForeColor = System.Drawing.Color.Black;
            this.value_thanhTien.Location = new System.Drawing.Point(747, 605);
            this.value_thanhTien.Name = "value_thanhTien";
            this.value_thanhTien.Size = new System.Drawing.Size(163, 38);
            this.value_thanhTien.TabIndex = 83;
            this.value_thanhTien.Text = "1.000.000 VNĐ";
            this.value_thanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // value_tongTien
            // 
            this.value_tongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_tongTien.ForeColor = System.Drawing.Color.Gray;
            this.value_tongTien.Location = new System.Drawing.Point(751, 452);
            this.value_tongTien.Name = "value_tongTien";
            this.value_tongTien.Size = new System.Drawing.Size(152, 23);
            this.value_tongTien.TabIndex = 84;
            this.value_tongTien.Text = "1.000.000";
            this.value_tongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_lisMon
            // 
            this.label_lisMon.AutoSize = true;
            this.label_lisMon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lisMon.Location = new System.Drawing.Point(43, 413);
            this.label_lisMon.Name = "label_lisMon";
            this.label_lisMon.Size = new System.Drawing.Size(176, 25);
            this.label_lisMon.TabIndex = 75;
            this.label_lisMon.Text = "Danh sách các món";
            // 
            // label_thanhTien
            // 
            this.label_thanhTien.AutoSize = true;
            this.label_thanhTien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thanhTien.Location = new System.Drawing.Point(637, 613);
            this.label_thanhTien.Name = "label_thanhTien";
            this.label_thanhTien.Size = new System.Drawing.Size(104, 25);
            this.label_thanhTien.TabIndex = 76;
            this.label_thanhTien.Text = "Thành tiền";
            // 
            // value_TTV
            // 
            this.value_TTV.Font = new System.Drawing.Font("Script MT Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_TTV.Location = new System.Drawing.Point(751, 519);
            this.value_TTV.Name = "value_TTV";
            this.value_TTV.Size = new System.Drawing.Size(152, 28);
            this.value_TTV.TabIndex = 77;
            this.value_TTV.Text = "Membership";
            this.value_TTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_TTV
            // 
            this.label_TTV.AutoSize = true;
            this.label_TTV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TTV.Location = new System.Drawing.Point(637, 521);
            this.label_TTV.Name = "label_TTV";
            this.label_TTV.Size = new System.Drawing.Size(65, 23);
            this.label_TTV.TabIndex = 78;
            this.label_TTV.Text = "Thẻ TV";
            // 
            // label_giamGia
            // 
            this.label_giamGia.AutoSize = true;
            this.label_giamGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_giamGia.Location = new System.Drawing.Point(638, 485);
            this.label_giamGia.Name = "label_giamGia";
            this.label_giamGia.Size = new System.Drawing.Size(87, 23);
            this.label_giamGia.TabIndex = 79;
            this.label_giamGia.Text = "Giảm giá ";
            // 
            // label_tongTien
            // 
            this.label_tongTien.AutoSize = true;
            this.label_tongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tongTien.Location = new System.Drawing.Point(637, 452);
            this.label_tongTien.Name = "label_tongTien";
            this.label_tongTien.Size = new System.Drawing.Size(87, 23);
            this.label_tongTien.TabIndex = 80;
            this.label_tongTien.Text = "Tổng tiền";
            // 
            // panel_dat_hang
            // 
            this.panel_dat_hang.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.panel_dat_hang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.panel_dat_hang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dat_hang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.panel_dat_hang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panel_dat_hang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.panel_dat_hang.ColumnHeadersHeight = 40;
            this.panel_dat_hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.panel_dat_hang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.dgvID,
            this.tenMon,
            this.soLuong,
            this.DonGia,
            this.thanhTien});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.panel_dat_hang.DefaultCellStyle = dataGridViewCellStyle11;
            this.panel_dat_hang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_dat_hang.Location = new System.Drawing.Point(25, 441);
            this.panel_dat_hang.Name = "panel_dat_hang";
            this.panel_dat_hang.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panel_dat_hang.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.panel_dat_hang.RowHeadersVisible = false;
            this.panel_dat_hang.RowHeadersWidth = 51;
            this.panel_dat_hang.RowTemplate.Height = 24;
            this.panel_dat_hang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.panel_dat_hang.Size = new System.Drawing.Size(606, 294);
            this.panel_dat_hang.TabIndex = 74;
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
            this.panel_dat_hang.ThemeStyle.ReadOnly = true;
            this.panel_dat_hang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.panel_dat_hang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.panel_dat_hang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_dat_hang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.panel_dat_hang.ThemeStyle.RowsStyle.Height = 24;
            this.panel_dat_hang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel_dat_hang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // but_huy
            // 
            this.but_huy.AutoRoundedCorners = true;
            this.but_huy.BorderRadius = 21;
            this.but_huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_huy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.but_huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.but_huy.ForeColor = System.Drawing.Color.White;
            this.but_huy.Location = new System.Drawing.Point(642, 690);
            this.but_huy.Name = "but_huy";
            this.but_huy.Size = new System.Drawing.Size(121, 45);
            this.but_huy.TabIndex = 73;
            this.but_huy.Text = "Thoát";
            this.but_huy.Click += new System.EventHandler(this.but_huy_Click);
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
            // dgvID
            // 
            this.dgvID.HeaderText = "";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Visible = false;
            this.dgvID.Width = 125;
            // 
            // tenMon
            // 
            this.tenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenMon.DataPropertyName = "TenMon";
            this.tenMon.HeaderText = "Tên Món";
            this.tenMon.MinimumWidth = 6;
            this.tenMon.Name = "tenMon";
            this.tenMon.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.soLuong.DataPropertyName = "SL";
            this.soLuong.FillWeight = 50F;
            this.soLuong.HeaderText = "S.L";
            this.soLuong.MinimumWidth = 50;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 50;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.FillWeight = 85F;
            this.DonGia.HeaderText = "Đ.Giá";
            this.DonGia.MinimumWidth = 85;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 85;
            // 
            // thanhTien
            // 
            this.thanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.thanhTien.DataPropertyName = "ThanhTien";
            this.thanhTien.FillWeight = 85F;
            this.thanhTien.HeaderText = "T.tiền";
            this.thanhTien.MinimumWidth = 85;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            this.thanhTien.Width = 85;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(789, 690);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(121, 45);
            this.guna2Button1.TabIndex = 73;
            this.guna2Button1.Text = "Đặt hàng";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // GiaoHangView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 756);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiaoHangView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatHangView";
            this.Load += new System.EventHandler(this.GiaoHangView_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_dat_hang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panel_main;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_thanhToan;
        private Guna.UI2.WinForms.Guna2TextBox text_diaChiGiao;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_thanhToan;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_diaChGiao;
        private Guna.UI2.WinForms.Guna2TextBox text_tenKH;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_TenKH;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_ngayDat;
        private Guna.UI2.WinForms.Guna2Panel panel_Header;
        private System.Windows.Forms.Label label_Dat_Mon;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2TextBox text_SDT;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_SDT;
        private Guna.UI2.WinForms.Guna2DateTimePicker text_NgayDen;
        private System.Windows.Forms.Label value_giamGiaTTV;
        private System.Windows.Forms.Label value_giamGia;
        private System.Windows.Forms.Label value_thanhTien;
        private System.Windows.Forms.Label value_tongTien;
        private System.Windows.Forms.Label label_lisMon;
        private System.Windows.Forms.Label label_thanhTien;
        private System.Windows.Forms.Label value_TTV;
        private System.Windows.Forms.Label label_TTV;
        private System.Windows.Forms.Label label_giamGia;
        private System.Windows.Forms.Label label_tongTien;
        private Guna.UI2.WinForms.Guna2DataGridView panel_dat_hang;
        private Guna.UI2.WinForms.Guna2Button but_huy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}