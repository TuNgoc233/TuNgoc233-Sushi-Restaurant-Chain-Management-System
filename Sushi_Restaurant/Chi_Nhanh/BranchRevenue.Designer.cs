namespace Sushi_Restaurant.Chi_Nhanh
{
    partial class BranchRevenue
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

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageNgay = new System.Windows.Forms.TabPage();
            this.dateTimePickerNgay = new System.Windows.Forms.DateTimePicker();
            this.buttonXemNgay = new System.Windows.Forms.Button();
            this.labelDoanhThuNgay = new System.Windows.Forms.Label();
            this.tabPageThang = new System.Windows.Forms.TabPage();
            this.comboBoxThang = new System.Windows.Forms.ComboBox();
            this.comboBoxNamThang = new System.Windows.Forms.ComboBox();
            this.buttonXemThang = new System.Windows.Forms.Button();
            this.labelDoanhThuThang = new System.Windows.Forms.Label();
            this.tabPageQuy = new System.Windows.Forms.TabPage();
            this.comboBoxQuy = new System.Windows.Forms.ComboBox();
            this.comboBoxNamQuy = new System.Windows.Forms.ComboBox();
            this.buttonXemQuy = new System.Windows.Forms.Button();
            this.labelDoanhThuQuy = new System.Windows.Forms.Label();
            this.tabPageNam = new System.Windows.Forms.TabPage();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.buttonXemNam = new System.Windows.Forms.Button();
            this.labelDoanhThuNam = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageNgay.SuspendLayout();
            this.tabPageThang.SuspendLayout();
            this.tabPageQuy.SuspendLayout();
            this.tabPageNam.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageNgay);
            this.tabControl.Controls.Add(this.tabPageThang);
            this.tabControl.Controls.Add(this.tabPageQuy);
            this.tabControl.Controls.Add(this.tabPageNam);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(500, 300);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageNgay
            // 
            this.tabPageNgay.Controls.Add(this.dateTimePickerNgay);
            this.tabPageNgay.Controls.Add(this.buttonXemNgay);
            this.tabPageNgay.Controls.Add(this.labelDoanhThuNgay);
            this.tabPageNgay.Location = new System.Drawing.Point(4, 22);
            this.tabPageNgay.Name = "tabPageNgay";
            this.tabPageNgay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNgay.Size = new System.Drawing.Size(492, 274);
            this.tabPageNgay.TabIndex = 0;
            this.tabPageNgay.Text = "Doanh thu theo Ngày";
            this.tabPageNgay.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgay
            // 
            this.dateTimePickerNgay.Location = new System.Drawing.Point(130, 30);
            this.dateTimePickerNgay.Name = "dateTimePickerNgay";
            this.dateTimePickerNgay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgay.TabIndex = 0;
            // 
            // buttonXemNgay
            // 
            this.buttonXemNgay.Location = new System.Drawing.Point(180, 70);
            this.buttonXemNgay.Name = "buttonXemNgay";
            this.buttonXemNgay.Size = new System.Drawing.Size(75, 23);
            this.buttonXemNgay.TabIndex = 1;
            this.buttonXemNgay.Text = "Xem Doanh thu";
            this.buttonXemNgay.UseVisualStyleBackColor = true;
            this.buttonXemNgay.Click += new System.EventHandler(this.buttonXemNgay_Click);
            // 
            // labelDoanhThuNgay
            // 
            this.labelDoanhThuNgay.AutoSize = true;
            this.labelDoanhThuNgay.Location = new System.Drawing.Point(127, 120);
            this.labelDoanhThuNgay.Name = "labelDoanhThuNgay";
            this.labelDoanhThuNgay.Size = new System.Drawing.Size(95, 13);
            this.labelDoanhThuNgay.TabIndex = 2;
            this.labelDoanhThuNgay.Text = "Doanh thu: 0 VND";
            // 
            // tabPageThang
            // 
            this.tabPageThang.Controls.Add(this.comboBoxThang);
            this.tabPageThang.Controls.Add(this.comboBoxNamThang);
            this.tabPageThang.Controls.Add(this.buttonXemThang);
            this.tabPageThang.Controls.Add(this.labelDoanhThuThang);
            this.tabPageThang.Location = new System.Drawing.Point(4, 22);
            this.tabPageThang.Name = "tabPageThang";
            this.tabPageThang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThang.Size = new System.Drawing.Size(492, 274);
            this.tabPageThang.TabIndex = 1;
            this.tabPageThang.Text = "Doanh thu theo Tháng";
            this.tabPageThang.UseVisualStyleBackColor = true;
            // 
            // comboBoxThang
            // 
            this.comboBoxThang.FormattingEnabled = true;
            this.comboBoxThang.Items.AddRange(new object[] {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"});
            this.comboBoxThang.Location = new System.Drawing.Point(130, 30);
            this.comboBoxThang.Name = "comboBoxThang";
            this.comboBoxThang.Size = new System.Drawing.Size(121, 21);
            this.comboBoxThang.TabIndex = 0;
            // 
            // comboBoxNamThang
            // 
            this.comboBoxNamThang.FormattingEnabled = true;
            this.comboBoxNamThang.Items.AddRange(new object[] {
            "2023", "2024", "2025"});
            this.comboBoxNamThang.Location = new System.Drawing.Point(130, 70);
            this.comboBoxNamThang.Name = "comboBoxNamThang";
            this.comboBoxNamThang.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNamThang.TabIndex = 1;
            // 
            // buttonXemThang
            // 
            this.buttonXemThang.Location = new System.Drawing.Point(180, 110);
            this.buttonXemThang.Name = "buttonXemThang";
            this.buttonXemThang.Size = new System.Drawing.Size(75, 23);
            this.buttonXemThang.TabIndex = 2;
            this.buttonXemThang.Text = "Xem Doanh thu";
            this.buttonXemThang.UseVisualStyleBackColor = true;
            this.buttonXemThang.Click += new System.EventHandler(this.buttonXemThang_Click);
            // 
            // labelDoanhThuThang
            // 
            this.labelDoanhThuThang.AutoSize = true;
            this.labelDoanhThuThang.Location = new System.Drawing.Point(127, 150);
            this.labelDoanhThuThang.Name = "labelDoanhThuThang";
            this.labelDoanhThuThang.Size = new System.Drawing.Size(95, 13);
            this.labelDoanhThuThang.TabIndex = 3;
            this.labelDoanhThuThang.Text = "Doanh thu: 0 VND";
            // 
            // tabPageQuy
            // 
            this.tabPageQuy.Controls.Add(this.comboBoxQuy);
            this.tabPageQuy.Controls.Add(this.comboBoxNamQuy);
            this.tabPageQuy.Controls.Add(this.buttonXemQuy);
            this.tabPageQuy.Controls.Add(this.labelDoanhThuQuy);
            this.tabPageQuy.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuy.Name = "tabPageQuy";
            this.tabPageQuy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuy.Size = new System.Drawing.Size(492, 274);
            this.tabPageQuy.TabIndex = 2;
            this.tabPageQuy.Text = "Doanh thu theo Quý";
            this.tabPageQuy.UseVisualStyleBackColor = true;
            // 
            // comboBoxQuy
            // 
            this.comboBoxQuy.FormattingEnabled = true;
            this.comboBoxQuy.Items.AddRange(new object[] {
            "Quý 1", "Quý 2", "Quý 3", "Quý 4"});
            this.comboBoxQuy.Location = new System.Drawing.Point(130, 30);
            this.comboBoxQuy.Name = "comboBoxQuy";
            this.comboBoxQuy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuy.TabIndex = 0;
            // 
            // comboBoxNamQuy
            // 
            this.comboBoxNamQuy.FormattingEnabled = true;
            this.comboBoxNamQuy.Items.AddRange(new object[] {
            "2023", "2024", "2025"});
            this.comboBoxNamQuy.Location = new System.Drawing.Point(130, 70);
            this.comboBoxNamQuy.Name = "comboBoxNamQuy";
            this.comboBoxNamQuy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNamQuy.TabIndex = 1;
            // 
            // buttonXemQuy
            // 
            this.buttonXemQuy.Location = new System.Drawing.Point(180, 110);
            this.buttonXemQuy.Name = "buttonXemQuy";
            this.buttonXemQuy.Size = new System.Drawing.Size(75, 23);
            this.buttonXemQuy.TabIndex = 2;
            this.buttonXemQuy.Text = "Xem Doanh thu";
            this.buttonXemQuy.UseVisualStyleBackColor = true;
            this.buttonXemQuy.Click += new System.EventHandler(this.buttonXemQuy_Click);
            // 
            // labelDoanhThuQuy
            // 
            this.labelDoanhThuQuy.AutoSize = true;
            this.labelDoanhThuQuy.Location = new System.Drawing.Point(127, 150);
            this.labelDoanhThuQuy.Name = "labelDoanhThuQuy";
            this.labelDoanhThuQuy.Size = new System.Drawing.Size(95, 13);
            this.labelDoanhThuQuy.TabIndex = 3;
            this.labelDoanhThuQuy.Text = "Doanh thu: 0 VND";
            // 
            // tabPageNam
            // 
            this.tabPageNam.Controls.Add(this.comboBoxNam);
            this.tabPageNam.Controls.Add(this.buttonXemNam);
            this.tabPageNam.Controls.Add(this.labelDoanhThuNam);
            this.tabPageNam.Location = new System.Drawing.Point(4, 22);
            this.tabPageNam.Name = "tabPageNam";
            this.tabPageNam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNam.Size = new System.Drawing.Size(492, 274);
            this.tabPageNam.TabIndex = 3;
            this.tabPageNam.Text = "Doanh thu theo Năm";
            this.tabPageNam.UseVisualStyleBackColor = true;
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Items.AddRange(new object[] {
            "2023", "2024", "2025"});
            this.comboBoxNam.Location = new System.Drawing.Point(130, 30);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNam.TabIndex = 0;
            // 
            // buttonXemNam
            // 
            this.buttonXemNam.Location = new System.Drawing.Point(180, 70);
            this.buttonXemNam.Name = "buttonXemNam";
            this.buttonXemNam.Size = new System.Drawing.Size(75, 23);
            this.buttonXemNam.TabIndex = 1;
            this.buttonXemNam.Text = "Xem Doanh thu";
            this.buttonXemNam.UseVisualStyleBackColor = true;
            this.buttonXemNam.Click += new System.EventHandler(this.buttonXemNam_Click);
            // 
            // labelDoanhThuNam
            // 
            this.labelDoanhThuNam.AutoSize = true;
            this.labelDoanhThuNam.Location = new System.Drawing.Point(127, 120);
            this.labelDoanhThuNam.Name = "labelDoanhThuNam";
            this.labelDoanhThuNam.Size = new System.Drawing.Size(95, 13);
            this.labelDoanhThuNam.TabIndex = 2;
            this.labelDoanhThuNam.Text = "Doanh thu: 0 VND";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(524, 321);
            this.Controls.Add(this.tabControl);
            this.Name = "BranchRevenue";
            this.Text = "Doanh Thu Chi Nhánh";
            this.tabControl.ResumeLayout(false);
            this.tabPageNgay.ResumeLayout(false);
            this.tabPageNgay.PerformLayout();
            this.tabPageThang.ResumeLayout(false);
            this.tabPageThang.PerformLayout();
            this.tabPageQuy.ResumeLayout(false);
            this.tabPageQuy.PerformLayout();
            this.tabPageNam.ResumeLayout(false);
            this.tabPageNam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgay;
        private System.Windows.Forms.Button buttonXemNgay;
        private System.Windows.Forms.Label labelDoanhThuNgay;
        private System.Windows.Forms.TabPage tabPageThang;
        private System.Windows.Forms.ComboBox comboBoxThang;
        private System.Windows.Forms.ComboBox comboBoxNamThang;
        private System.Windows.Forms.Button buttonXemThang;
        private System.Windows.Forms.Label labelDoanhThuThang;
        private System.Windows.Forms.TabPage tabPageQuy;
        private System.Windows.Forms.ComboBox comboBoxQuy;
        private System.Windows.Forms.ComboBox comboBoxNamQuy;
        private System.Windows.Forms.Button buttonXemQuy;
        private System.Windows.Forms.Label labelDoanhThuQuy;
        private System.Windows.Forms.TabPage tabPageNam;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Button buttonXemNam;
        private System.Windows.Forms.Label labelDoanhThuNam;
    }
}
