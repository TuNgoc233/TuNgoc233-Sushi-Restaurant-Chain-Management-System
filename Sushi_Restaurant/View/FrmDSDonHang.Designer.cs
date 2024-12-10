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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle89 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle90 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle98 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle99 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle91 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle92 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle93 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle94 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle95 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle96 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle97 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDSDonHang));
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_soDong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rbtnDatBan = new System.Windows.Forms.RadioButton();
            this.rbtnGiaoHang = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.cmb_soDong);
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
            dataGridViewCellStyle89.BackColor = System.Drawing.Color.White;
            this.dataGridViewDSDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle89;
            this.dataGridViewDSDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridViewDSDonHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle90.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle90.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle90.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle90.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle90.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle90.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle90.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDSDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle90;
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
            this.danhGia});
            dataGridViewCellStyle98.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle98.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle98.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle98.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle98.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle98.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle98.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDSDonHang.DefaultCellStyle = dataGridViewCellStyle98;
            this.dataGridViewDSDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewDSDonHang.Location = new System.Drawing.Point(42, 131);
            this.dataGridViewDSDonHang.Name = "dataGridViewDSDonHang";
            this.dataGridViewDSDonHang.ReadOnly = true;
            dataGridViewCellStyle99.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle99.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle99.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle99.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle99.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle99.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle99.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDSDonHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle99;
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
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle91.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle91.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle91.ForeColor = System.Drawing.Color.Black;
            this.STT.DefaultCellStyle = dataGridViewCellStyle91;
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
            this.loaiDH.DataPropertyName = "Loại đơn hàng";
            dataGridViewCellStyle92.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle92.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle92.ForeColor = System.Drawing.Color.Black;
            this.loaiDH.DefaultCellStyle = dataGridViewCellStyle92;
            this.loaiDH.FillWeight = 225F;
            this.loaiDH.Frozen = true;
            this.loaiDH.HeaderText = "Loại Đơn Hàng";
            this.loaiDH.MinimumWidth = 225;
            this.loaiDH.Name = "loaiDH";
            this.loaiDH.ReadOnly = true;
            this.loaiDH.Width = 225;
            // 
            // maDH
            // 
            this.maDH.DataPropertyName = "Mã đơn hàng";
            dataGridViewCellStyle93.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle93.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle93.ForeColor = System.Drawing.Color.Black;
            this.maDH.DefaultCellStyle = dataGridViewCellStyle93;
            this.maDH.FillWeight = 225F;
            this.maDH.Frozen = true;
            this.maDH.HeaderText = "Mã đơn hàng";
            this.maDH.MinimumWidth = 225;
            this.maDH.Name = "maDH";
            this.maDH.ReadOnly = true;
            this.maDH.Width = 225;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "Trạng thái";
            dataGridViewCellStyle94.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle94.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle94.ForeColor = System.Drawing.Color.Black;
            this.trangThai.DefaultCellStyle = dataGridViewCellStyle94;
            this.trangThai.FillWeight = 225F;
            this.trangThai.Frozen = true;
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 225;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Width = 225;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "Tổng tiền";
            dataGridViewCellStyle95.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle95.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle95.ForeColor = System.Drawing.Color.Black;
            this.tongTien.DefaultCellStyle = dataGridViewCellStyle95;
            this.tongTien.FillWeight = 225F;
            this.tongTien.Frozen = true;
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.MinimumWidth = 225;
            this.tongTien.Name = "tongTien";
            this.tongTien.ReadOnly = true;
            this.tongTien.Width = 225;
            // 
            // ngayDat
            // 
            this.ngayDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngayDat.DataPropertyName = "Ngày đặt";
            dataGridViewCellStyle96.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle96.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle96.ForeColor = System.Drawing.Color.Black;
            this.ngayDat.DefaultCellStyle = dataGridViewCellStyle96;
            this.ngayDat.FillWeight = 205F;
            this.ngayDat.Frozen = true;
            this.ngayDat.HeaderText = "Ngày đặt";
            this.ngayDat.MinimumWidth = 205;
            this.ngayDat.Name = "ngayDat";
            this.ngayDat.ReadOnly = true;
            this.ngayDat.Width = 205;
            // 
            // xemLai
            // 
            this.xemLai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle97.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle97.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle97.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle97.NullValue")));
            this.xemLai.DefaultCellStyle = dataGridViewCellStyle97;
            this.xemLai.FillWeight = 30F;
            this.xemLai.Frozen = true;
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
            this.danhGia.FillWeight = 30F;
            this.danhGia.HeaderText = "";
            this.danhGia.Image = global::Sushi_Restaurant.Properties.Resources.icon_danhGia;
            this.danhGia.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.danhGia.MinimumWidth = 30;
            this.danhGia.Name = "danhGia";
            this.danhGia.ReadOnly = true;
            this.danhGia.Width = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1099, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Số dòng";
            // 
            // cmb_soDong
            // 
            this.cmb_soDong.BackColor = System.Drawing.Color.Transparent;
            this.cmb_soDong.BorderColor = System.Drawing.Color.Black;
            this.cmb_soDong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_soDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_soDong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_soDong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_soDong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_soDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_soDong.ItemHeight = 30;
            this.cmb_soDong.Items.AddRange(new object[] {
            "Tất cả",
            "1",
            "2",
            "3",
            "4"});
            this.cmb_soDong.Location = new System.Drawing.Point(1202, 82);
            this.cmb_soDong.Name = "cmb_soDong";
            this.cmb_soDong.Size = new System.Drawing.Size(98, 36);
            this.cmb_soDong.TabIndex = 40;
            this.cmb_soDong.SelectedIndexChanged += new System.EventHandler(this.cmb_soDong_SelectedIndexChanged);
            // 
            // rbtnDatBan
            // 
            this.rbtnDatBan.AutoSize = true;
            this.rbtnDatBan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDatBan.Location = new System.Drawing.Point(442, 83);
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
            this.rbtnGiaoHang.Location = new System.Drawing.Point(161, 83);
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
            // FrmDSDonHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1341, 886);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDSDonHang";
            this.Text = "FrmDSDonHang";
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
        private Guna.UI2.WinForms.Guna2ComboBox cmb_soDong;
        private System.Windows.Forms.RadioButton rbtnDatBan;
        private System.Windows.Forms.RadioButton rbtnGiaoHang;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewDSDonHang;
        private System.Windows.Forms.Label label_tieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDat;
        private System.Windows.Forms.DataGridViewImageColumn xemLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn spacing;
        private System.Windows.Forms.DataGridViewImageColumn danhGia;
    }
}