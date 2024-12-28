namespace Sushi_Restaurant.Chi_Nhanh
{
    partial class viewOrderForm
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
            this.Load_Invoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gdvFormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.Load_Invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(939, 87);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnThem.Image = global::Sushi_Restaurant.Properties.Resources.icon_form;
            this.btnThem.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.btnThem.Location = new System.Drawing.Point(202, 24);
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 97);
            this.label2.Size = new System.Drawing.Size(274, 41);
            this.label2.Text = "Danh sách hóa đơn";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(282, 183);
            // 
            // Load_Invoice
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.Load_Invoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Load_Invoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Load_Invoice.ColumnHeadersHeight = 40;
            this.Load_Invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Load_Invoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gdvFormID,
            this.gdvType,
            this.dgvText,
            this.dgvDate,
            this.dgv});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Load_Invoice.DefaultCellStyle = dataGridViewCellStyle9;
            this.Load_Invoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Load_Invoice.Location = new System.Drawing.Point(202, 228);
            this.Load_Invoice.Name = "Load_Invoice";
            this.Load_Invoice.RowHeadersVisible = false;
            this.Load_Invoice.RowHeadersWidth = 51;
            this.Load_Invoice.RowTemplate.Height = 24;
            this.Load_Invoice.Size = new System.Drawing.Size(1169, 449);
            this.Load_Invoice.TabIndex = 5;
            this.Load_Invoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Load_Invoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Load_Invoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Load_Invoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Load_Invoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Load_Invoice.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Load_Invoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Load_Invoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.Load_Invoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Load_Invoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Invoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Load_Invoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Load_Invoice.ThemeStyle.HeaderStyle.Height = 40;
            this.Load_Invoice.ThemeStyle.ReadOnly = false;
            this.Load_Invoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Load_Invoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Load_Invoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Invoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Load_Invoice.ThemeStyle.RowsStyle.Height = 24;
            this.Load_Invoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Load_Invoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Load_Invoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // gdvFormID
            // 
            this.gdvFormID.HeaderText = "Mã hóa đơn";
            this.gdvFormID.MinimumWidth = 6;
            this.gdvFormID.Name = "gdvFormID";
            // 
            // gdvType
            // 
            this.gdvType.HeaderText = "Nhân viên";
            this.gdvType.MinimumWidth = 6;
            this.gdvType.Name = "gdvType";
            // 
            // dgvText
            // 
            this.dgvText.HeaderText = "Khách Hàng";
            this.dgvText.MinimumWidth = 6;
            this.dgvText.Name = "dgvText";
            // 
            // dgvDate
            // 
            this.dgvDate.HeaderText = "Thời gian lập";
            this.dgvDate.MinimumWidth = 6;
            this.dgvDate.Name = "dgvDate";
            // 
            // dgv
            // 
            this.dgv.HeaderText = "Tổng tiền";
            this.dgv.MinimumWidth = 6;
            this.dgv.Name = "dgv";
            // 
            // Date
            // 
            this.Date.Checked = true;
            this.Date.FillColor = System.Drawing.Color.White;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date.Location = new System.Drawing.Point(1035, 139);
            this.Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(336, 38);
            this.Date.TabIndex = 6;
            this.Date.Value = new System.DateTime(2024, 12, 15, 17, 25, 24, 399);
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // guna2Button5
            // 
            this.guna2Button5.AutoRoundedCorners = true;
            this.guna2Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Button5.BorderRadius = 21;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(12, 369);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(158, 45);
            this.guna2Button5.TabIndex = 12;
            this.guna2Button5.Text = "Trang chủ";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1349, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 29);
            this.Exit.TabIndex = 15;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // guna2Button6
            // 
            this.guna2Button6.AutoRoundedCorners = true;
            this.guna2Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Button6.BorderColor = System.Drawing.Color.White;
            this.guna2Button6.BorderRadius = 21;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(12, 435);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(158, 45);
            this.guna2Button6.TabIndex = 16;
            this.guna2Button6.Text = "Đăng xuất";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // viewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 689);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Load_Invoice);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.guna2Button5);
            this.Name = "viewOrderForm";
            this.Text = "viewOderForm";
            this.Load += new System.EventHandler(this.viewOrderForm_Load_1);
            this.Controls.SetChildIndex(this.guna2Button5, 0);
            this.Controls.SetChildIndex(this.Exit, 0);
            this.Controls.SetChildIndex(this.guna2Button6, 0);
            this.Controls.SetChildIndex(this.Load_Invoice, 0);
            this.Controls.SetChildIndex(this.Date, 0);
            this.Controls.SetChildIndex(this.guna2Separator1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnThem, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Load_Invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Load_Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdvFormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvText;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv;
        private Guna.UI2.WinForms.Guna2DateTimePicker Date;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
    }
}