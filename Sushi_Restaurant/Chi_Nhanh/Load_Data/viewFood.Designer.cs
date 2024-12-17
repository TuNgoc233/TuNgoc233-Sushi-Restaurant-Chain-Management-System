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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Data_Load = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insert_Item = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Load)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnThem.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.btnThem.Location = new System.Drawing.Point(64, 33);
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 110);
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.Text = "Món ăn";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Data_Load
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Data_Load.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Load.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Data_Load.ColumnHeadersHeight = 25;
            this.Data_Load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data_Load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv,
            this.dgv1,
            this.dgv2,
            this.dgv3,
            this.dgv4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Load.DefaultCellStyle = dataGridViewCellStyle3;
            this.Data_Load.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_Load.Location = new System.Drawing.Point(225, 189);
            this.Data_Load.Name = "Data_Load";
            this.Data_Load.RowHeadersVisible = false;
            this.Data_Load.RowHeadersWidth = 51;
            this.Data_Load.RowTemplate.Height = 24;
            this.Data_Load.Size = new System.Drawing.Size(1146, 433);
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
            this.Data_Load.ThemeStyle.HeaderStyle.Height = 25;
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
            // dgv
            // 
            this.dgv.HeaderText = "Mã món ăn";
            this.dgv.MinimumWidth = 6;
            this.dgv.Name = "dgv";
            // 
            // dgv1
            // 
            this.dgv1.HeaderText = "Tên món ăn";
            this.dgv1.MinimumWidth = 6;
            this.dgv1.Name = "dgv1";
            // 
            // dgv2
            // 
            this.dgv2.HeaderText = "Mã mục";
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
            // Insert_Item
            // 
            this.Insert_Item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Insert_Item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Insert_Item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Insert_Item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Insert_Item.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Insert_Item.ForeColor = System.Drawing.Color.White;
            this.Insert_Item.Location = new System.Drawing.Point(1191, 628);
            this.Insert_Item.Name = "Insert_Item";
            this.Insert_Item.Size = new System.Drawing.Size(180, 45);
            this.Insert_Item.TabIndex = 7;
            this.Insert_Item.Text = "Thêm món ăn";
            this.Insert_Item.Click += new System.EventHandler(this.Insert_Item_Click);
            // 
            // viewFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 689);
            this.Controls.Add(this.Insert_Item);
            this.Controls.Add(this.Data_Load);
            this.Name = "viewFood";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.viewAdd_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnThem, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.guna2Separator1, 0);
            this.Controls.SetChildIndex(this.Data_Load, 0);
            this.Controls.SetChildIndex(this.Insert_Item, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Data_Load;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv4;
        private Guna.UI2.WinForms.Guna2Button Insert_Item;
    }
}