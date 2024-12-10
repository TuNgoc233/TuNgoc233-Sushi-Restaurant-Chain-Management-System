namespace Sushi_Restaurant.Model
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_main = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.duong_ke = new Guna.UI2.WinForms.Guna2Separator();
            this.panel_ten_sp = new System.Windows.Forms.Panel();
            this.gia = new System.Windows.Forms.Label();
            this.pic_mon_an = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_ten_sp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mon_an)).BeginInit();
            this.label_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.Controls.Add(this.label_header);
            this.panel_main.Controls.Add(this.duong_ke);
            this.panel_main.Controls.Add(this.panel_ten_sp);
            this.panel_main.Controls.Add(this.pic_mon_an);
            this.panel_main.FillColor = System.Drawing.Color.White;
            this.panel_main.Location = new System.Drawing.Point(3, 3);
            this.panel_main.Name = "panel_main";
            this.panel_main.ShadowColor = System.Drawing.Color.Black;
            this.panel_main.Size = new System.Drawing.Size(220, 229);
            this.panel_main.TabIndex = 0;
            // 
            // duong_ke
            // 
            this.duong_ke.Location = new System.Drawing.Point(10, 174);
            this.duong_ke.Name = "duong_ke";
            this.duong_ke.Size = new System.Drawing.Size(210, 10);
            this.duong_ke.TabIndex = 3;
            // 
            // panel_ten_sp
            // 
            this.panel_ten_sp.Controls.Add(this.gia);
            this.panel_ten_sp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ten_sp.Location = new System.Drawing.Point(0, 180);
            this.panel_ten_sp.Name = "panel_ten_sp";
            this.panel_ten_sp.Size = new System.Drawing.Size(220, 49);
            this.panel_ten_sp.TabIndex = 2;
            // 
            // gia
            // 
            this.gia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gia.Location = new System.Drawing.Point(3, 4);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(213, 37);
            this.gia.TabIndex = 0;
            this.gia.Text = "Giá";
            this.gia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_mon_an
            // 
            this.pic_mon_an.Image = global::Sushi_Restaurant.Properties.Resources.sushi_logo1;
            this.pic_mon_an.ImageRotate = 0F;
            this.pic_mon_an.Location = new System.Drawing.Point(47, 69);
            this.pic_mon_an.Name = "pic_mon_an";
            this.pic_mon_an.Size = new System.Drawing.Size(119, 99);
            this.pic_mon_an.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_mon_an.TabIndex = 1;
            this.pic_mon_an.TabStop = false;
            // 
            // label_header
            // 
            this.label_header.Controls.Add(this.label1);
            this.label_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_header.Location = new System.Drawing.Point(0, 0);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(220, 54);
            this.label_header.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sashimi lườn cá hồi nướng (2 miếng)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel_main);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(226, 235);
            this.panel_main.ResumeLayout(false);
            this.panel_ten_sp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_mon_an)).EndInit();
            this.label_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel panel_main;
        private Guna.UI2.WinForms.Guna2PictureBox pic_mon_an;
        private System.Windows.Forms.Panel panel_ten_sp;
        private Guna.UI2.WinForms.Guna2Separator duong_ke;
        private System.Windows.Forms.Panel label_header;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label gia;
    }
}
