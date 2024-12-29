namespace Sushi_Restaurant.Chi_Nhanh
{
    partial class viewFood
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
            this.Data_Load = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Load)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnThem.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.btnThem.Location = new System.Drawing.Point(225, 28);
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(219, 95);
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.Text = "Món ăn";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
            // 
            // Data_Load
            // 
            this.Data_Load.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Data_Load.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Load.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Data_Load.ColumnHeadersHeight = 40;
            this.Data_Load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data_Load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv,
            this.dgv1,
            this.dgv2,
            this.dgv3,
            this.dgv4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Load.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data_Load.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_Load.Location = new System.Drawing.Point(225, 189);
            this.Data_Load.Name = "Data_Load";
            this.Data_Load.RowHeadersVisible = false;
            this.Data_Load.RowHeadersWidth = 51;
            this.Data_Load.RowTemplate.Height = 24;
            this.Data_Load.Size = new System.Drawing.Size(1146, 467);
            this.Data_Load.TabIndex = 6;
            this.Data_Load.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_Load.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Data_Load.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Data_Load.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Data_Load.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Data_Load.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Data_Load.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_Load.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Data_Load.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Data_Load.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_Load.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Data_Load.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data_Load.ThemeStyle.HeaderStyle.Height = 40;
            this.Data_Load.ThemeStyle.ReadOnly = false;
            this.Data_Load.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_Load.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Data_Load.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_Load.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data_Load.ThemeStyle.RowsStyle.Height = 24;
            this.Data_Load.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_Load.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data_Load.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Load);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(683, 28);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(148, 111);
            this.guna2CustomGradientPanel2.TabIndex = 38;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(1445, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 29);
            this.Exit.TabIndex = 41;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
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
            this.guna2Button5.Location = new System.Drawing.Point(12, 368);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(158, 45);
            this.guna2Button5.TabIndex = 46;
            this.guna2Button5.Text = "Về trang chủ";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(12, 441);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(158, 45);
            this.guna2Button1.TabIndex = 47;
            this.guna2Button1.Text = "Đăng xuất";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1349, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 48;
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
            this.dgv.HeaderText = "Mã món";
            this.dgv.MinimumWidth = 6;
            this.dgv.Name = "dgv";
            // 
            // dgv1
            // 
            this.dgv1.HeaderText = "Tên món";
            this.dgv1.MinimumWidth = 6;
            this.dgv1.Name = "dgv1";
            // 
            // dgv2
            // 
            this.dgv2.HeaderText = "Tên mục";
            this.dgv2.MinimumWidth = 6;
            this.dgv2.Name = "dgv2";
            // 
            // dgv3
            // 
            this.dgv3.HeaderText = "Giá hiện tại";
            this.dgv3.MinimumWidth = 6;
            this.dgv3.Name = "dgv3";
            // 
            // dgv4
            // 
            this.dgv4.HeaderText = "Tình trạng phục vụ";
            this.dgv4.MinimumWidth = 6;
            this.dgv4.Name = "dgv4";
            // 
            // viewFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 689);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Data_Load);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Name = "viewFood";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.viewAdd_Load);
            this.Controls.SetChildIndex(this.guna2CustomGradientPanel2, 0);
            this.Controls.SetChildIndex(this.Data_Load, 0);
            this.Controls.SetChildIndex(this.Exit, 0);
            this.Controls.SetChildIndex(this.guna2Button5, 0);
            this.Controls.SetChildIndex(this.guna2Button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnThem, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.guna2Separator1, 0);
            this.Controls.SetChildIndex(this.guna2ControlBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Data_Load;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv4;
    }
}