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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Load_Invoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gdvFormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Load_Invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(913, 12);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnThem.Image = global::Sushi_Restaurant.Properties.Resources.icon_form;
            this.btnThem.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(143, 97);
            this.label2.Size = new System.Drawing.Size(221, 32);
            this.label2.Text = "Danh sách hóa đơn";
            // 
            // Load_Invoice
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Load_Invoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Load_Invoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Load_Invoice.ColumnHeadersHeight = 40;
            this.Load_Invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Load_Invoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gdvFormID,
            this.gdvType,
            this.dgvText,
            this.dgvDate,
            this.dgv});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Load_Invoice.DefaultCellStyle = dataGridViewCellStyle6;
            this.Load_Invoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Load_Invoice.Location = new System.Drawing.Point(49, 180);
            this.Load_Invoice.Name = "Load_Invoice";
            this.Load_Invoice.RowHeadersVisible = false;
            this.Load_Invoice.RowHeadersWidth = 51;
            this.Load_Invoice.RowTemplate.Height = 24;
            this.Load_Invoice.Size = new System.Drawing.Size(1322, 449);
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
            this.Date.Location = new System.Drawing.Point(1035, 12);
            this.Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(336, 38);
            this.Date.TabIndex = 6;
            this.Date.Value = new System.DateTime(2024, 12, 15, 17, 25, 24, 399);
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // viewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 689);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Load_Invoice);
            this.Name = "viewOrderForm";
            this.Text = "viewOderForm";
            this.Load += new System.EventHandler(this.viewOrderForm_Load_1);
            this.Controls.SetChildIndex(this.guna2Separator1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnThem, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Load_Invoice, 0);
            this.Controls.SetChildIndex(this.Date, 0);
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
    }
}