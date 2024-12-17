namespace Sushi_Restaurant.Model
{
    partial class FrmDSDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDSDonHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Header = new Guna.UI2.WinForms.Guna2Panel();
            this.label_tieuDe = new System.Windows.Forms.Label();
            this.icon_Dat_Mon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridViewDSDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xemLai = new System.Windows.Forms.DataGridViewImageColumn();
            this.spacing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhGia = new System.Windows.Forms.DataGridViewImageColumn();
            this.spacing2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnDatBan = new System.Windows.Forms.RadioButton();
            this.rbtnGiaoHang = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.rbtnChoXuLy = new System.Windows.Forms.RadioButton();
            this.rbtnDaGiao = new System.Windows.Forms.RadioButton();
            this.rbtnDaXacNhan = new System.Windows.Forms.RadioButton();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Dat_Mon)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BorderColor = System.Drawing.Color.White;
            this.panel_Header.BorderThickness = 1;
            this.panel_Header.Controls.Add(this.label_tieuDe);
            this.panel_Header.Controls.Add(this.icon_Dat_Mon);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1341, 94);
            this.panel_Header.TabIndex = 28;
            // 
            // label_tieuDe
            // 
            this.label_tieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_tieuDe.AutoSize = true;
            this.label_tieuDe.BackColor = System.Drawing.Color.Transparent;
            this.label_tieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_tieuDe.Location = new System.Drawing.Point(78, 24);
            this.label_tieuDe.Name = "label_tieuDe";
            this.label_tieuDe.Size = new System.Drawing.Size(693, 46);
            this.label_tieuDe.TabIndex = 3;
            this.label_tieuDe.Text = "Danh sách các đơn đặt hàng của bạn ";
            // 
            // icon_Dat_Mon
            // 
            this.icon_Dat_Mon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_Dat_Mon.AutoRoundedCorners = true;
            this.icon_Dat_Mon.BackColor = System.Drawing.Color.Transparent;
            this.icon_Dat_Mon.BorderRadius = 31;
            this.icon_Dat_Mon.Image = global::Sushi_Restaurant.Properties.Resources.icon_dsDH;
            this.icon_Dat_Mon.ImageRotate = 0F;
            this.icon_Dat_Mon.Location = new System.Drawing.Point(12, 0);
            this.icon_Dat_Mon.Name = "icon_Dat_Mon";
            this.icon_Dat_Mon.Size = new System.Drawing.Size(65, 88);
            this.icon_Dat_Mon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_Dat_Mon.TabIndex = 2;
            this.icon_Dat_Mon.TabStop = false;
            this.icon_Dat_Mon.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dataGridViewDSDonHang);
            this.guna2Panel1.Controls.Add(this.rbtnDaXacNhan);
            this.guna2Panel1.Controls.Add(this.rbtnDaGiao);
            this.guna2Panel1.Controls.Add(this.rbtnChoXuLy);
            this.guna2Panel1.Controls.Add(this.rbtnDatBan);
            this.guna2Panel1.Controls.Add(this.rbtnGiaoHang);
            this.guna2Panel1.Controls.Add(this.rbtnAll);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 94);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1341, 792);
            this.guna2Panel1.TabIndex = 29;
            // 
            // dataGridViewDSDonHang
            // 
            this.dataGridViewDSDonHang.AllowUserToAddRows = false;
            this.dataGridViewDSDonHang.AllowUserToDeleteRows = false;
            this.dataGridViewDSDonHang.AllowUserToOrderColumns = true;
            this.dataGridViewDSDonHang.AllowUserToResizeColumns = false;
            this.dataGridViewDSDonHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            this.dataGridViewDSDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridViewDSDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridViewDSDonHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDSDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridViewDSDonHang.ColumnHeadersHeight = 70;
            this.dataGridViewDSDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewDSDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.loaiDH,
            this.maDH,
            this.trangThai,
            this.tongTien,
            this.ngayDat,
            this.xemLai,
            this.spacing,
            this.danhGia,
            this.spacing2});
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDSDonHang.DefaultCellStyle = dataGridViewCellStyle47;
            this.dataGridViewDSDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewDSDonHang.Location = new System.Drawing.Point(42, 131);
            this.dataGridViewDSDonHang.Name = "dataGridViewDSDonHang";
            this.dataGridViewDSDonHang.ReadOnly = true;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDSDonHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridViewDSDonHang.RowHeadersVisible = false;
            this.dataGridViewDSDonHang.RowHeadersWidth = 51;
            this.dataGridViewDSDonHang.RowTemplate.Height = 60;
            this.dataGridViewDSDonHang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDSDonHang.Size = new System.Drawing.Size(1259, 616);
            this.dataGridViewDSDonHang.TabIndex = 42;
            this.dataGridViewDSDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDSDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewDSDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewDSDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewDSDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewDSDonHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDSDonHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewDSDonHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewDSDonHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewDSDonHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDSDonHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewDSDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewDSDonHang.ThemeStyle.HeaderStyle.Height = 70;
            this.dataGridViewDSDonHang.ThemeStyle.ReadOnly = true;
            this.dataGridViewDSDonHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDSDonHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDSDonHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDSDonHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewDSDonHang.ThemeStyle.RowsStyle.Height = 60;
            this.dataGridViewDSDonHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewDSDonHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewDSDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSDonHang_CellContentClick);
            this.dataGridViewDSDonHang.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewDSDonHang_DataError);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.Black;
            this.STT.DefaultCellStyle = dataGridViewCellStyle39;
            this.STT.FillWeight = 70F;
            this.STT.Frozen = true;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 70;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 70;
            // 
            // loaiDH
            // 
            this.loaiDH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.loaiDH.DataPropertyName = "Loại đơn hàng";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black;
            this.loaiDH.DefaultCellStyle = dataGridViewCellStyle40;
            this.loaiDH.FillWeight = 220F;
            this.loaiDH.HeaderText = "Loại Đơn Hàng";
            this.loaiDH.MinimumWidth = 220;
            this.loaiDH.Name = "loaiDH";
            this.loaiDH.ReadOnly = true;
            this.loaiDH.Width = 220;
            // 
            // maDH
            // 
            this.maDH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maDH.DataPropertyName = "Mã đơn hàng";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.Black;
            this.maDH.DefaultCellStyle = dataGridViewCellStyle41;
            this.maDH.FillWeight = 220F;
            this.maDH.HeaderText = "Mã đơn hàng";
            this.maDH.MinimumWidth = 220;
            this.maDH.Name = "maDH";
            this.maDH.ReadOnly = true;
            this.maDH.Width = 220;
            // 
            // trangThai
            // 
            this.trangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.trangThai.DataPropertyName = "Trạng thái";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            this.trangThai.DefaultCellStyle = dataGridViewCellStyle42;
            this.trangThai.FillWeight = 220F;
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 220;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Width = 220;
            // 
            // tongTien
            // 
            this.tongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tongTien.DataPropertyName = "Tổng tiền";
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.Black;
            this.tongTien.DefaultCellStyle = dataGridViewCellStyle43;
            this.tongTien.FillWeight = 210F;
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.MinimumWidth = 210;
            this.tongTien.Name = "tongTien";
            this.tongTien.ReadOnly = true;
            this.tongTien.Width = 210;
            // 
            // ngayDat
            // 
            this.ngayDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngayDat.DataPropertyName = "Ngày đặt";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.Black;
            this.ngayDat.DefaultCellStyle = dataGridViewCellStyle44;
            this.ngayDat.FillWeight = 220F;
            this.ngayDat.HeaderText = "Ngày đặt";
            this.ngayDat.MinimumWidth = 220;
            this.ngayDat.Name = "ngayDat";
            this.ngayDat.ReadOnly = true;
            this.ngayDat.Width = 220;
            // 
            // xemLai
            // 
            this.xemLai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle45.NullValue")));
            this.xemLai.DefaultCellStyle = dataGridViewCellStyle45;
            this.xemLai.FillWeight = 30F;
            this.xemLai.HeaderText = "";
            this.xemLai.Image = global::Sushi_Restaurant.Properties.Resources.icon_xemLaiDH;
            this.xemLai.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.xemLai.MinimumWidth = 30;
            this.xemLai.Name = "xemLai";
            this.xemLai.ReadOnly = true;
            this.xemLai.Width = 30;
            // 
            // spacing
            // 
            this.spacing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.spacing.FillWeight = 20F;
            this.spacing.HeaderText = "";
            this.spacing.MinimumWidth = 20;
            this.spacing.Name = "spacing";
            this.spacing.ReadOnly = true;
            this.spacing.Width = 20;
            // 
            // danhGia
            // 
            this.danhGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.danhGia.DataPropertyName = "Đánh giá";
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.danhGia.DefaultCellStyle = dataGridViewCellStyle46;
            this.danhGia.FillWeight = 30F;
            this.danhGia.HeaderText = "";
            this.danhGia.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.danhGia.MinimumWidth = 30;
            this.danhGia.Name = "danhGia";
            this.danhGia.ReadOnly = true;
            this.danhGia.Width = 30;
            // 
            // spacing2
            // 
            this.spacing2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.spacing2.FillWeight = 15F;
            this.spacing2.HeaderText = "";
            this.spacing2.MinimumWidth = 15;
            this.spacing2.Name = "spacing2";
            this.spacing2.ReadOnly = true;
            this.spacing2.Width = 15;
            // 
            // rbtnDatBan
            // 
            this.rbtnDatBan.AutoSize = true;
            this.rbtnDatBan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDatBan.Location = new System.Drawing.Point(480, 83);
            this.rbtnDatBan.Name = "rbtnDatBan";
            this.rbtnDatBan.Size = new System.Drawing.Size(119, 35);
            this.rbtnDatBan.TabIndex = 37;
            this.rbtnDatBan.Text = "Đặt bàn";
            this.rbtnDatBan.UseVisualStyleBackColor = true;
            this.rbtnDatBan.CheckedChanged += new System.EventHandler(this.rbtnDatBan_CheckedChanged_1);
            // 
            // rbtnGiaoHang
            // 
            this.rbtnGiaoHang.AutoSize = true;
            this.rbtnGiaoHang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGiaoHang.Location = new System.Drawing.Point(173, 83);
            this.rbtnGiaoHang.Name = "rbtnGiaoHang";
            this.rbtnGiaoHang.Size = new System.Drawing.Size(226, 35);
            this.rbtnGiaoHang.TabIndex = 38;
            this.rbtnGiaoHang.Text = "Giao hàng tận nơi";
            this.rbtnGiaoHang.UseVisualStyleBackColor = true;
            this.rbtnGiaoHang.CheckedChanged += new System.EventHandler(this.rbtnGiaoHang_CheckedChanged_1);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAll.Location = new System.Drawing.Point(41, 83);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(65, 35);
            this.rbtnAll.TabIndex = 39;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged_1);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Sushi_Restaurant.Properties.Resources.icon_danhGia;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Sushi_Restaurant.Properties.Resources.icon_danhGia;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // rbtnChoXuLy
            // 
            this.rbtnChoXuLy.AutoSize = true;
            this.rbtnChoXuLy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChoXuLy.Location = new System.Drawing.Point(703, 83);
            this.rbtnChoXuLy.Name = "rbtnChoXuLy";
            this.rbtnChoXuLy.Size = new System.Drawing.Size(136, 35);
            this.rbtnChoXuLy.TabIndex = 37;
            this.rbtnChoXuLy.Text = "Chờ xử lý";
            this.rbtnChoXuLy.UseVisualStyleBackColor = true;
            this.rbtnChoXuLy.CheckedChanged += new System.EventHandler(this.rbtnDatBan_CheckedChanged_1);
            this.rbtnChoXuLy.Click += new System.EventHandler(this.rbtnChoXuLy_Click);
            // 
            // rbtnDaGiao
            // 
            this.rbtnDaGiao.AutoSize = true;
            this.rbtnDaGiao.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDaGiao.Location = new System.Drawing.Point(1178, 83);
            this.rbtnDaGiao.Name = "rbtnDaGiao";
            this.rbtnDaGiao.Size = new System.Drawing.Size(123, 35);
            this.rbtnDaGiao.TabIndex = 37;
            this.rbtnDaGiao.Text = "Đã giao ";
            this.rbtnDaGiao.UseVisualStyleBackColor = true;
            this.rbtnDaGiao.CheckedChanged += new System.EventHandler(this.rbtnDatBan_CheckedChanged_1);
            this.rbtnDaGiao.Click += new System.EventHandler(this.rbtnDaGiao_Click);
            // 
            // rbtnDaXacNhan
            // 
            this.rbtnDaXacNhan.AutoSize = true;
            this.rbtnDaXacNhan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDaXacNhan.Location = new System.Drawing.Point(932, 83);
            this.rbtnDaXacNhan.Name = "rbtnDaXacNhan";
            this.rbtnDaXacNhan.Size = new System.Drawing.Size(166, 35);
            this.rbtnDaXacNhan.TabIndex = 37;
            this.rbtnDaXacNhan.Text = "Đã xác nhận";
            this.rbtnDaXacNhan.UseVisualStyleBackColor = true;
            this.rbtnDaXacNhan.CheckedChanged += new System.EventHandler(this.rbtnDatBan_CheckedChanged_1);
            this.rbtnDaXacNhan.Click += new System.EventHandler(this.rbtnDaXacNhan_Click);
            // 
            // FrmDSDonHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1341, 886);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDSDonHang";
            this.Text = "FrmDSDonHang";
            this.Load += new System.EventHandler(this.FrmDSDonHang_Load_1);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Dat_Mon)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_Header;
        private Guna.UI2.WinForms.Guna2PictureBox icon_Dat_Mon;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.RadioButton rbtnDatBan;
        private System.Windows.Forms.RadioButton rbtnGiaoHang;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.Label label_tieuDe;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewDSDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDat;
        private System.Windows.Forms.DataGridViewImageColumn xemLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn spacing;
        private System.Windows.Forms.DataGridViewImageColumn danhGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn spacing2;
        private System.Windows.Forms.RadioButton rbtnDaXacNhan;
        private System.Windows.Forms.RadioButton rbtnDaGiao;
        private System.Windows.Forms.RadioButton rbtnChoXuLy;
    }
}