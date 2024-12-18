namespace Sushi_Restaurant.Admin
{
    partial class Employee
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Dataview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1281, 101);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // Dataview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Dataview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dataview.ColumnHeadersHeight = 25;
            this.Dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv,
            this.dgv1,
            this.dgv3,
            this.dgv10,
            this.dgv11,
            this.dgv100,
            this.dgv8,
            this.dgv111,
            this.dgvUpdate,
            this.dgvDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dataview.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dataview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dataview.Location = new System.Drawing.Point(12, 129);
            this.Dataview.Name = "Dataview";
            this.Dataview.RowHeadersVisible = false;
            this.Dataview.RowHeadersWidth = 51;
            this.Dataview.RowTemplate.Height = 24;
            this.Dataview.Size = new System.Drawing.Size(1240, 327);
            this.Dataview.TabIndex = 10;
            this.Dataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Dataview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Dataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Dataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Dataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Dataview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Dataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Dataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dataview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dataview.ThemeStyle.HeaderStyle.Height = 25;
            this.Dataview.ThemeStyle.ReadOnly = false;
            this.Dataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dataview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dataview.ThemeStyle.RowsStyle.Height = 24;
            this.Dataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dataview_CellContentClick);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgv
            // 
            this.dgv.HeaderText = "Mã nhân viên";
            this.dgv.MinimumWidth = 6;
            this.dgv.Name = "dgv";
            // 
            // dgv1
            // 
            this.dgv1.HeaderText = "Họ tên";
            this.dgv1.MinimumWidth = 6;
            this.dgv1.Name = "dgv1";
            // 
            // dgv3
            // 
            this.dgv3.HeaderText = "Ngày sinh";
            this.dgv3.MinimumWidth = 6;
            this.dgv3.Name = "dgv3";
            // 
            // dgv10
            // 
            this.dgv10.HeaderText = "Bộ phận";
            this.dgv10.MinimumWidth = 6;
            this.dgv10.Name = "dgv10";
            // 
            // dgv11
            // 
            this.dgv11.HeaderText = "Lương";
            this.dgv11.MinimumWidth = 6;
            this.dgv11.Name = "dgv11";
            // 
            // dgv100
            // 
            this.dgv100.HeaderText = "Chi nhánh";
            this.dgv100.MinimumWidth = 6;
            this.dgv100.Name = "dgv100";
            // 
            // dgv8
            // 
            this.dgv8.HeaderText = "Ngày vào làm";
            this.dgv8.MinimumWidth = 6;
            this.dgv8.Name = "dgv8";
            // 
            // dgv111
            // 
            this.dgv111.HeaderText = "Ngày kết thúc";
            this.dgv111.MinimumWidth = 6;
            this.dgv111.Name = "dgv111";
            // 
            // dgvUpdate
            // 
            this.dgvUpdate.HeaderText = "Chuyển";
            this.dgvUpdate.MinimumWidth = 6;
            this.dgvUpdate.Name = "dgvUpdate";
            this.dgvUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvDelete
            // 
            this.dgvDelete.HeaderText = "Xóa nhân viên";
            this.dgvDelete.MinimumWidth = 6;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1281, 581);
            this.Controls.Add(this.Dataview);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dataview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView Dataview;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv100;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv111;
        private System.Windows.Forms.DataGridViewImageColumn dgvUpdate;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}