using System.Windows.Forms;

namespace Sushi_Restaurant
{
    partial class FrmSignUp
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.but_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_HoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.text_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_GioiTinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_CCCD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.text_CCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Email = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.text_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.lablel_SDT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.text_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.but_DK = new Guna.UI2.WinForms.Guna2Button();
            this.radioButNam = new System.Windows.Forms.RadioButton();
            this.radioButNu = new System.Windows.Forms.RadioButton();
            this.SignUp_sucess = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.error_noFullInfor_SignUp = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.but_Exit);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(464, 147);
            this.guna2Panel1.TabIndex = 0;
            // 
            // but_Exit
            // 
            this.but_Exit.AutoRoundedCorners = true;
            this.but_Exit.BackColor = System.Drawing.Color.Transparent;
            this.but_Exit.BorderRadius = 16;
            this.but_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.but_Exit.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.but_Exit.ForeColor = System.Drawing.Color.Red;
            this.but_Exit.Location = new System.Drawing.Point(427, 0);
            this.but_Exit.Name = "but_Exit";
            this.but_Exit.Size = new System.Drawing.Size(34, 35);
            this.but_Exit.TabIndex = 2;
            this.but_Exit.Text = "X";
            this.but_Exit.UseTransparentBackground = true;
            this.but_Exit.Click += new System.EventHandler(this.but_Exit_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Sushi_Restaurant.Properties.Resources.icon_signup1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(137, 114);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(157, 53);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel7.TabIndex = 0;
            this.guna2HtmlLabel7.Text = null;
            this.guna2HtmlLabel7.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(146, 75);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(265, 30);
            this.guna2HtmlLabel8.TabIndex = 0;
            this.guna2HtmlLabel8.Text = "thông tin bên dưới để đăng kí  ";
            this.guna2HtmlLabel8.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(166, 39);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(223, 30);
            this.guna2HtmlLabel6.TabIndex = 0;
            this.guna2HtmlLabel6.Text = "Vui lòng nhập đầy đủ các";
            this.guna2HtmlLabel6.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // label_HoTen
            // 
            this.label_HoTen.BackColor = System.Drawing.Color.Transparent;
            this.label_HoTen.Location = new System.Drawing.Point(60, 154);
            this.label_HoTen.Name = "label_HoTen";
            this.label_HoTen.Size = new System.Drawing.Size(60, 18);
            this.label_HoTen.TabIndex = 0;
            this.label_HoTen.Text = "Họ và tên";
            this.label_HoTen.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // text_HoTen
            // 
            this.text_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_HoTen.DefaultText = "";
            this.text_HoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_HoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_HoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_HoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_HoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_HoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_HoTen.Location = new System.Drawing.Point(60, 179);
            this.text_HoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_HoTen.Name = "text_HoTen";
            this.text_HoTen.PasswordChar = '\0';
            this.text_HoTen.PlaceholderText = "";
            this.text_HoTen.SelectedText = "";
            this.text_HoTen.Size = new System.Drawing.Size(364, 48);
            this.text_HoTen.TabIndex = 1;
            // 
            // label_GioiTinh
            // 
            this.label_GioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.label_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GioiTinh.Location = new System.Drawing.Point(61, 498);
            this.label_GioiTinh.Name = "label_GioiTinh";
            this.label_GioiTinh.Size = new System.Drawing.Size(78, 30);
            this.label_GioiTinh.TabIndex = 0;
            this.label_GioiTinh.Text = "Giới tính";
            this.label_GioiTinh.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // label_CCCD
            // 
            this.label_CCCD.BackColor = System.Drawing.Color.Transparent;
            this.label_CCCD.Location = new System.Drawing.Point(59, 238);
            this.label_CCCD.Name = "label_CCCD";
            this.label_CCCD.Size = new System.Drawing.Size(60, 18);
            this.label_CCCD.TabIndex = 0;
            this.label_CCCD.Text = "Số CCCD";
            this.label_CCCD.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // text_CCCD
            // 
            this.text_CCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_CCCD.DefaultText = "";
            this.text_CCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_CCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_CCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_CCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_CCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_CCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_CCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_CCCD.Location = new System.Drawing.Point(59, 263);
            this.text_CCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_CCCD.Name = "text_CCCD";
            this.text_CCCD.PasswordChar = '\0';
            this.text_CCCD.PlaceholderText = "";
            this.text_CCCD.SelectedText = "";
            this.text_CCCD.Size = new System.Drawing.Size(364, 48);
            this.text_CCCD.TabIndex = 1;
            this.text_CCCD.TextChanged += new System.EventHandler(this.text_CCCD_TextChanged);
            this.text_CCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_SDT_KeyPress);
            // 
            // label_Email
            // 
            this.label_Email.BackColor = System.Drawing.Color.Transparent;
            this.label_Email.Location = new System.Drawing.Point(60, 324);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(37, 18);
            this.label_Email.TabIndex = 0;
            this.label_Email.Text = "Email";
            this.label_Email.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // text_Email
            // 
            this.text_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_Email.DefaultText = "";
            this.text_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_Email.Location = new System.Drawing.Point(59, 349);
            this.text_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_Email.Name = "text_Email";
            this.text_Email.PasswordChar = '\0';
            this.text_Email.PlaceholderText = "";
            this.text_Email.SelectedText = "";
            this.text_Email.Size = new System.Drawing.Size(364, 48);
            this.text_Email.TabIndex = 1;
            this.text_Email.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // lablel_SDT
            // 
            this.lablel_SDT.BackColor = System.Drawing.Color.Transparent;
            this.lablel_SDT.Location = new System.Drawing.Point(59, 410);
            this.lablel_SDT.Name = "lablel_SDT";
            this.lablel_SDT.Size = new System.Drawing.Size(81, 18);
            this.lablel_SDT.TabIndex = 0;
            this.lablel_SDT.Text = "Số điện thoại";
            this.lablel_SDT.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // text_SDT
            // 
            this.text_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_SDT.DefaultText = "";
            this.text_SDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_SDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_SDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_SDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_SDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_SDT.Location = new System.Drawing.Point(59, 435);
            this.text_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_SDT.Name = "text_SDT";
            this.text_SDT.PasswordChar = '\0';
            this.text_SDT.PlaceholderText = "";
            this.text_SDT.SelectedText = "";
            this.text_SDT.Size = new System.Drawing.Size(364, 48);
            this.text_SDT.TabIndex = 1;
            this.text_SDT.TextChanged += new System.EventHandler(this.text_SDT_TextChanged);
            // 
            // but_DK
            // 
            this.but_DK.AutoRoundedCorners = true;
            this.but_DK.BorderRadius = 21;
            this.but_DK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.but_DK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.but_DK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.but_DK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.but_DK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.but_DK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.but_DK.ForeColor = System.Drawing.Color.White;
            this.but_DK.Location = new System.Drawing.Point(157, 583);
            this.but_DK.Name = "but_DK";
            this.but_DK.Size = new System.Drawing.Size(136, 45);
            this.but_DK.TabIndex = 2;
            this.but_DK.Text = "Đăng kí";
            this.but_DK.Click += new System.EventHandler(this.but_DK_Click);
            // 
            // radioButNam
            // 
            this.radioButNam.AutoSize = true;
            this.radioButNam.Location = new System.Drawing.Point(187, 501);
            this.radioButNam.Name = "radioButNam";
            this.radioButNam.Size = new System.Drawing.Size(68, 27);
            this.radioButNam.TabIndex = 3;
            this.radioButNam.TabStop = true;
            this.radioButNam.Text = "Nam";
            this.radioButNam.UseVisualStyleBackColor = true;
            this.radioButNam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButNu
            // 
            this.radioButNu.AutoSize = true;
            this.radioButNu.Location = new System.Drawing.Point(304, 501);
            this.radioButNu.Name = "radioButNu";
            this.radioButNu.Size = new System.Drawing.Size(54, 27);
            this.radioButNu.TabIndex = 3;
            this.radioButNu.TabStop = true;
            this.radioButNu.Text = "Nữ";
            this.radioButNu.UseVisualStyleBackColor = true;
            this.radioButNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SignUp_sucess
            // 
            this.SignUp_sucess.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.SignUp_sucess.Caption = null;
            this.SignUp_sucess.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.SignUp_sucess.Parent = this;
            this.SignUp_sucess.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.SignUp_sucess.Text = null;
            // 
            // error_noFullInfor_SignUp
            // 
            this.error_noFullInfor_SignUp.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.error_noFullInfor_SignUp.Caption = null;
            this.error_noFullInfor_SignUp.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.error_noFullInfor_SignUp.Parent = this;
            this.error_noFullInfor_SignUp.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.error_noFullInfor_SignUp.Text = null;
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 650);
            this.Controls.Add(this.radioButNu);
            this.Controls.Add(this.radioButNam);
            this.Controls.Add(this.but_DK);
            this.Controls.Add(this.text_SDT);
            this.Controls.Add(this.lablel_SDT);
            this.Controls.Add(this.text_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.text_CCCD);
            this.Controls.Add(this.label_CCCD);
            this.Controls.Add(this.label_GioiTinh);
            this.Controls.Add(this.text_HoTen);
            this.Controls.Add(this.label_HoTen);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSignUp";
            this.Load += new System.EventHandler(this.FrmSignUp_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_HoTen;
        private Guna.UI2.WinForms.Guna2TextBox text_HoTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_GioiTinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_CCCD;
        private Guna.UI2.WinForms.Guna2TextBox text_CCCD;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_Email;
        private Guna.UI2.WinForms.Guna2TextBox text_Email;
        private Guna.UI2.WinForms.Guna2HtmlLabel lablel_SDT;
        private Guna.UI2.WinForms.Guna2TextBox text_SDT;
        private Guna.UI2.WinForms.Guna2Button but_DK;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private System.Windows.Forms.RadioButton radioButNam;
        private System.Windows.Forms.RadioButton radioButNu;
        private Guna.UI2.WinForms.Guna2Button but_Exit;
        private Guna.UI2.WinForms.Guna2MessageDialog SignUp_sucess;
        private Guna.UI2.WinForms.Guna2MessageDialog error_noFullInfor_SignUp;
    }
}