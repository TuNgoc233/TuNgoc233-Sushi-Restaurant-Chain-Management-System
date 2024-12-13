namespace Sushi_Restaurant.Chi_Nhanh
{
    partial class viewStaff
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
            this.GridViewStaff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ControlMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlMini = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_Insert = new Guna.UI2.WinForms.Guna2Button();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStaff)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(937, 86);
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnThem.Image = global::Sushi_Restaurant.Properties.Resources.icon_person;
            this.btnThem.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.btnThem.Location = new System.Drawing.Point(12, 86);
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(92, 96);
            this.label2.Size = new System.Drawing.Size(238, 32);
            this.label2.Text = "Danh sách nhân viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(29, 160);
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
            // 
            // GridViewStaff
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GridViewStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewStaff.ColumnHeadersHeight = 40;
            this.GridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridViewStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvName,
            this.dgvMark,
            this.dgvBirth,
            this.dgvSex,
            this.dgvSalary,
            this.dgvAddress,
            this.dgvPhone,
            this.dgvDel,
            this.dgvEdit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.GridViewStaff.Location = new System.Drawing.Point(67, 189);
            this.GridViewStaff.Name = "GridViewStaff";
            this.GridViewStaff.RowHeadersVisible = false;
            this.GridViewStaff.RowHeadersWidth = 51;
            this.GridViewStaff.RowTemplate.Height = 24;
            this.GridViewStaff.Size = new System.Drawing.Size(1244, 196);
            this.GridViewStaff.TabIndex = 5;
            this.GridViewStaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridViewStaff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridViewStaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridViewStaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridViewStaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridViewStaff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridViewStaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.GridViewStaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GridViewStaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridViewStaff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridViewStaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridViewStaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridViewStaff.ThemeStyle.HeaderStyle.Height = 40;
            this.GridViewStaff.ThemeStyle.ReadOnly = false;
            this.GridViewStaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridViewStaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridViewStaff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridViewStaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridViewStaff.ThemeStyle.RowsStyle.Height = 24;
            this.GridViewStaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridViewStaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridViewStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.ControlMax);
            this.guna2CustomGradientPanel1.Controls.Add(this.ControlMini);
            this.guna2CustomGradientPanel1.Controls.Add(this.Exit);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Button2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Button3);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Button1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1463, 60);
            this.guna2CustomGradientPanel1.TabIndex = 6;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // ControlMax
            // 
            this.ControlMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlMax.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlMax.IconColor = System.Drawing.Color.White;
            this.ControlMax.Location = new System.Drawing.Point(1304, 12);
            this.ControlMax.Name = "ControlMax";
            this.ControlMax.Size = new System.Drawing.Size(45, 29);
            this.ControlMax.TabIndex = 3;
            // 
            // ControlMini
            // 
            this.ControlMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlMini.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ControlMini.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ControlMini.IconColor = System.Drawing.Color.White;
            this.ControlMini.Location = new System.Drawing.Point(1355, 12);
            this.ControlMini.Name = "ControlMini";
            this.ControlMini.Size = new System.Drawing.Size(45, 29);
            this.ControlMini.TabIndex = 3;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1406, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 29);
            this.Exit.TabIndex = 3;
            this.Exit.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(384, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Khách hàng";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(198, 3);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 1;
            this.guna2Button3.Text = "Hóa đơn";
            this.guna2Button3.Click += new System.EventHandler(this.Btn_Invoice);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(12, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Nhân viên";
            this.guna2Button1.Click += new System.EventHandler(this.Btn_Staff);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.btn_Insert);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 482);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1463, 166);
            this.guna2CustomGradientPanel2.TabIndex = 8;
            // 
            // btn_Insert
            // 
            this.btn_Insert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Insert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Insert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Insert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Insert.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.btn_Insert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.Location = new System.Drawing.Point(1181, 25);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(180, 45);
            this.btn_Insert.TabIndex = 9;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "STT";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.Width = 70;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "Mã nhân viên";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Họ tên";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            // 
            // dgvMark
            // 
            this.dgvMark.HeaderText = "Điểm phục vụ";
            this.dgvMark.MinimumWidth = 6;
            this.dgvMark.Name = "dgvMark";
            // 
            // dgvBirth
            // 
            this.dgvBirth.HeaderText = "Ngày sinh";
            this.dgvBirth.MinimumWidth = 6;
            this.dgvBirth.Name = "dgvBirth";
            // 
            // dgvSex
            // 
            this.dgvSex.HeaderText = "Giới tính";
            this.dgvSex.MinimumWidth = 6;
            this.dgvSex.Name = "dgvSex";
            this.dgvSex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvSalary
            // 
            this.dgvSalary.HeaderText = "Lương";
            this.dgvSalary.MinimumWidth = 6;
            this.dgvSalary.Name = "dgvSalary";
            // 
            // dgvAddress
            // 
            this.dgvAddress.HeaderText = "Địa chỉ";
            this.dgvAddress.MinimumWidth = 6;
            this.dgvAddress.Name = "dgvAddress";
            // 
            // dgvPhone
            // 
            this.dgvPhone.HeaderText = "Số điện thoại ";
            this.dgvPhone.MinimumWidth = 6;
            this.dgvPhone.Name = "dgvPhone";
            // 
            // dgvDel
            // 
            this.dgvDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDel.FillWeight = 50F;
            this.dgvDel.HeaderText = "";
            this.dgvDel.Image = global::Sushi_Restaurant.Properties.Resources.icon_xoa;
            this.dgvDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDel.MinimumWidth = 50;
            this.dgvDel.Name = "dgvDel";
            this.dgvDel.Width = 50;
            // 
            // dgvEdit
            // 
            this.dgvEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvEdit.FillWeight = 50F;
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.Image = global::Sushi_Restaurant.Properties.Resources.icon_sua;
            this.dgvEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvEdit.MinimumWidth = 50;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.Width = 50;
            // 
            // viewStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1463, 648);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.GridViewStaff);
            this.Name = "viewStaff";
            this.Text = "viewStaff";
            this.Load += new System.EventHandler(this.viewStaff_Load);
            this.Controls.SetChildIndex(this.GridViewStaff, 0);
            this.Controls.SetChildIndex(this.guna2CustomGradientPanel1, 0);
            this.Controls.SetChildIndex(this.guna2CustomGradientPanel2, 0);
            this.Controls.SetChildIndex(this.guna2Separator1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnThem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStaff)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView GridViewStaff;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ControlBox ControlMax;
        private Guna.UI2.WinForms.Guna2ControlBox ControlMini;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btn_Insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhone;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
    }
}