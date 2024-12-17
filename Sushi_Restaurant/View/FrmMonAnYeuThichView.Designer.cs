namespace Sushi_Restaurant.View
{
    partial class FrmMonAnYeuThichView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonAnYeuThichView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Header = new Guna.UI2.WinForms.Guna2Panel();
            this.label_tieuDe = new System.Windows.Forms.Label();
            this.icon_Dat_Mon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dataGridViewMonAn = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhMinhHoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.spacing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.spacing2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Dat_Mon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).BeginInit();
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
            this.panel_Header.TabIndex = 29;
            // 
            // label_tieuDe
            // 
            this.label_tieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_tieuDe.AutoSize = true;
            this.label_tieuDe.BackColor = System.Drawing.Color.Transparent;
            this.label_tieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_tieuDe.Location = new System.Drawing.Point(114, 23);
            this.label_tieuDe.Name = "label_tieuDe";
            this.label_tieuDe.Size = new System.Drawing.Size(820, 51);
            this.label_tieuDe.TabIndex = 3;
            this.label_tieuDe.Text = "Danh sách các món ăn yêu thích của bạn ";
            // 
            // icon_Dat_Mon
            // 
            this.icon_Dat_Mon.BackColor = System.Drawing.Color.Transparent;
            this.icon_Dat_Mon.Image = global::Sushi_Restaurant.Properties.Resources.icon_favouriteFood;
            this.icon_Dat_Mon.ImageRotate = 0F;
            this.icon_Dat_Mon.Location = new System.Drawing.Point(12, 7);
            this.icon_Dat_Mon.Name = "icon_Dat_Mon";
            this.icon_Dat_Mon.Size = new System.Drawing.Size(96, 61);
            this.icon_Dat_Mon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_Dat_Mon.TabIndex = 2;
            this.icon_Dat_Mon.TabStop = false;
            this.icon_Dat_Mon.UseTransparentBackground = true;
            // 
            // dataGridViewMonAn
            // 
            this.dataGridViewMonAn.AllowUserToAddRows = false;
            this.dataGridViewMonAn.AllowUserToDeleteRows = false;
            this.dataGridViewMonAn.AllowUserToOrderColumns = true;
            this.dataGridViewMonAn.AllowUserToResizeColumns = false;
            this.dataGridViewMonAn.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewMonAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMonAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMonAn.ColumnHeadersHeight = 70;
            this.dataGridViewMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maMon,
            this.tenMon,
            this.anhMinhHoa,
            this.spacing,
            this.butXoa,
            this.spacing2});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMonAn.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewMonAn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMonAn.Location = new System.Drawing.Point(109, 140);
            this.dataGridViewMonAn.Name = "dataGridViewMonAn";
            this.dataGridViewMonAn.ReadOnly = true;
            this.dataGridViewMonAn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMonAn.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewMonAn.RowHeadersVisible = false;
            this.dataGridViewMonAn.RowHeadersWidth = 51;
            this.dataGridViewMonAn.RowTemplate.Height = 80;
            this.dataGridViewMonAn.Size = new System.Drawing.Size(1121, 569);
            this.dataGridViewMonAn.TabIndex = 30;
            this.dataGridViewMonAn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMonAn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewMonAn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewMonAn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewMonAn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewMonAn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMonAn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMonAn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewMonAn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMonAn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMonAn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMonAn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewMonAn.ThemeStyle.HeaderStyle.Height = 70;
            this.dataGridViewMonAn.ThemeStyle.ReadOnly = true;
            this.dataGridViewMonAn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMonAn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMonAn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMonAn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMonAn.ThemeStyle.RowsStyle.Height = 80;
            this.dataGridViewMonAn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMonAn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonAn_CellContentClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.STT.DefaultCellStyle = dataGridViewCellStyle3;
            this.STT.FillWeight = 90F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 90;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 90;
            // 
            // maMon
            // 
            this.maMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maMon.DataPropertyName = "Mã món ăn";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.maMon.DefaultCellStyle = dataGridViewCellStyle4;
            this.maMon.FillWeight = 200F;
            this.maMon.HeaderText = "Mã món ăn";
            this.maMon.MinimumWidth = 200;
            this.maMon.Name = "maMon";
            this.maMon.ReadOnly = true;
            this.maMon.Width = 200;
            // 
            // tenMon
            // 
            this.tenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenMon.DataPropertyName = "Tên món ăn";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tenMon.DefaultCellStyle = dataGridViewCellStyle5;
            this.tenMon.HeaderText = "Tên món ăn";
            this.tenMon.MinimumWidth = 6;
            this.tenMon.Name = "tenMon";
            this.tenMon.ReadOnly = true;
            // 
            // anhMinhHoa
            // 
            this.anhMinhHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.anhMinhHoa.DataPropertyName = "Hình ảnh";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.anhMinhHoa.DefaultCellStyle = dataGridViewCellStyle6;
            this.anhMinhHoa.HeaderText = "";
            this.anhMinhHoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.anhMinhHoa.MinimumWidth = 100;
            this.anhMinhHoa.Name = "anhMinhHoa";
            this.anhMinhHoa.ReadOnly = true;
            this.anhMinhHoa.Width = 125;
            // 
            // spacing
            // 
            this.spacing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.spacing.DefaultCellStyle = dataGridViewCellStyle7;
            this.spacing.FillWeight = 70F;
            this.spacing.HeaderText = "";
            this.spacing.MinimumWidth = 70;
            this.spacing.Name = "spacing";
            this.spacing.ReadOnly = true;
            this.spacing.Width = 70;
            // 
            // butXoa
            // 
            this.butXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.butXoa.DataPropertyName = "butXoa";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.butXoa.DefaultCellStyle = dataGridViewCellStyle8;
            this.butXoa.FillWeight = 50F;
            this.butXoa.HeaderText = "";
            this.butXoa.Image = global::Sushi_Restaurant.Properties.Resources.icon_xoa;
            this.butXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.butXoa.MinimumWidth = 50;
            this.butXoa.Name = "butXoa";
            this.butXoa.ReadOnly = true;
            this.butXoa.Width = 50;
            // 
            // spacing2
            // 
            this.spacing2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.spacing2.DefaultCellStyle = dataGridViewCellStyle9;
            this.spacing2.FillWeight = 20F;
            this.spacing2.HeaderText = "";
            this.spacing2.MinimumWidth = 20;
            this.spacing2.Name = "spacing2";
            this.spacing2.ReadOnly = true;
            this.spacing2.Width = 20;
            // 
            // FrmMonAnYeuThichView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 760);
            this.Controls.Add(this.dataGridViewMonAn);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMonAnYeuThichView";
            this.Text = "FrmMonAnYeuThichView";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Dat_Mon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_Header;
        private System.Windows.Forms.Label label_tieuDe;
        private Guna.UI2.WinForms.Guna2PictureBox icon_Dat_Mon;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewImageColumn anhMinhHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn spacing;
        private System.Windows.Forms.DataGridViewImageColumn butXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn spacing2;
    }
}