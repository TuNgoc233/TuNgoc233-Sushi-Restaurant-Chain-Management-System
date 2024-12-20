using System;

namespace Sushi_Restaurant.Chi_Nhanh
{
    partial class viewID_Card
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
            this.DataLoad = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnThem.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.Text = "Thẻ thành viên";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // DataLoad
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataLoad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataLoad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataLoad.ColumnHeadersHeight = 40;
            this.DataLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv,
            this.dgv2,
            this.dgv3,
            this.dgv4,
            this.dgv1,
            this.dgv5,
            this.dgvImage});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataLoad.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataLoad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataLoad.Location = new System.Drawing.Point(198, 199);
            this.DataLoad.Name = "DataLoad";
            this.DataLoad.RowHeadersVisible = false;
            this.DataLoad.RowHeadersWidth = 51;
            this.DataLoad.RowTemplate.Height = 24;
            this.DataLoad.Size = new System.Drawing.Size(1196, 414);
            this.DataLoad.TabIndex = 5;
            this.DataLoad.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataLoad.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataLoad.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataLoad.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataLoad.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataLoad.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataLoad.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataLoad.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataLoad.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataLoad.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLoad.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataLoad.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataLoad.ThemeStyle.HeaderStyle.Height = 40;
            this.DataLoad.ThemeStyle.ReadOnly = false;
            this.DataLoad.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataLoad.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataLoad.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLoad.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataLoad.ThemeStyle.RowsStyle.Height = 24;
            this.DataLoad.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataLoad.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataLoad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.icon_Delete_click);
            // 
            // dgv
            // 
            this.dgv.HeaderText = "Mã số thẻ";
            this.dgv.MinimumWidth = 6;
            this.dgv.Name = "dgv";
            // 
            // dgv2
            // 
            this.dgv2.HeaderText = "Loại thẻ";
            this.dgv2.MinimumWidth = 6;
            this.dgv2.Name = "dgv2";
            // 
            // dgv3
            // 
            this.dgv3.HeaderText = "Tổng điểm tích lũy";
            this.dgv3.MinimumWidth = 6;
            this.dgv3.Name = "dgv3";
            // 
            // dgv4
            // 
            this.dgv4.HeaderText = "Ngày lập";
            this.dgv4.MinimumWidth = 6;
            this.dgv4.Name = "dgv4";
            // 
            // dgv1
            // 
            this.dgv1.HeaderText = "Họ tên khách hàng";
            this.dgv1.MinimumWidth = 6;
            this.dgv1.Name = "dgv1";
            // 
            // dgv5
            // 
            this.dgv5.HeaderText = "Họ tên nhân viên";
            this.dgv5.MinimumWidth = 6;
            this.dgv5.Name = "dgv5";
            // 
            // dgvImage
            // 
            this.dgvImage.HeaderText = "Xóa";
            this.dgvImage.Image = global::Sushi_Restaurant.Properties.Resources.icon_xoa;
            this.dgvImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvImage.MinimumWidth = 6;
            this.dgvImage.Name = "dgvImage";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1214, 632);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Cập nhật loại thẻ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Sushi_Restaurant.Properties.Resources.nha_hang;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(181, 690);
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // viewID_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1406, 689);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DataLoad);
            this.Name = "viewID_Card";
            this.Text = "viewID_Card";
            this.Load += new System.EventHandler(this.viewID_Card_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnThem, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.guna2Separator1, 0);
            this.Controls.SetChildIndex(this.DataLoad, 0);
            this.Controls.SetChildIndex(this.guna2Button1, 0);
            this.Controls.SetChildIndex(this.guna2PictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DataLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv5;
        private System.Windows.Forms.DataGridViewImageColumn dgvImage;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}