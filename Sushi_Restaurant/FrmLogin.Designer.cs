namespace Sushi_Restaurant
{
    partial class FrmLogin
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.text_User = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_dn = new Guna.UI2.WinForms.Guna2Button();
            this.err_noFullInfor_Login = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.cnname = new System.Windows.Forms.Label();
            this.chinhanhname = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 2;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(439, 178);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Red;
            this.guna2Button1.Location = new System.Drawing.Point(400, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(36, 37);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "X";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Sushi_Restaurant.Properties.Resources.icon_login;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(140, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(163, 132);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vui lòng nhập thông tin tài khoản";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(58, 293);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(120, 23);
            this.UserName.TabIndex = 5;
            this.UserName.Text = "Mã Nhân Viên";
            // 
            // text_User
            // 
            this.text_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_User.DefaultText = "";
            this.text_User.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_User.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_User.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_User.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_User.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_User.Location = new System.Drawing.Point(62, 320);
            this.text_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_User.Name = "text_User";
            this.text_User.PasswordChar = '\0';
            this.text_User.PlaceholderText = "";
            this.text_User.SelectedText = "";
            this.text_User.Size = new System.Drawing.Size(321, 48);
            this.text_User.TabIndex = 0;
            // 
            // bt_dn
            // 
            this.bt_dn.AutoRoundedCorners = true;
            this.bt_dn.BorderRadius = 21;
            this.bt_dn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_dn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_dn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_dn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_dn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.bt_dn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dn.ForeColor = System.Drawing.Color.White;
            this.bt_dn.Location = new System.Drawing.Point(150, 432);
            this.bt_dn.Name = "bt_dn";
            this.bt_dn.Size = new System.Drawing.Size(140, 45);
            this.bt_dn.TabIndex = 2;
            this.bt_dn.Text = "Đăng nhập ";
            this.bt_dn.Click += new System.EventHandler(this.bt_dn_Click);
            // 
            // err_noFullInfor_Login
            // 
            this.err_noFullInfor_Login.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.err_noFullInfor_Login.Caption = null;
            this.err_noFullInfor_Login.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.err_noFullInfor_Login.Parent = this;
            this.err_noFullInfor_Login.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.err_noFullInfor_Login.Text = null;
            // 
            // cnname
            // 
            this.cnname.AutoSize = true;
            this.cnname.Location = new System.Drawing.Point(58, 185);
            this.cnname.Name = "cnname";
            this.cnname.Size = new System.Drawing.Size(92, 23);
            this.cnname.TabIndex = 7;
            this.cnname.Text = "Chi Nhánh";
            // 
            // chinhanhname
            // 
            this.chinhanhname.BackColor = System.Drawing.Color.Transparent;
            this.chinhanhname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chinhanhname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chinhanhname.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chinhanhname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chinhanhname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chinhanhname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.chinhanhname.ItemHeight = 30;
            this.chinhanhname.Location = new System.Drawing.Point(58, 212);
            this.chinhanhname.Name = "chinhanhname";
            this.chinhanhname.Size = new System.Drawing.Size(321, 36);
            this.chinhanhname.TabIndex = 8;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 520);
            this.Controls.Add(this.chinhanhname);
            this.Controls.Add(this.cnname);
            this.Controls.Add(this.bt_dn);
            this.Controls.Add(this.text_User);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label UserName;
        private Guna.UI2.WinForms.Guna2TextBox text_User;
        private Guna.UI2.WinForms.Guna2Button bt_dn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2MessageDialog err_noFullInfor_Login;
        private Guna.UI2.WinForms.Guna2ComboBox chinhanhname;
        private System.Windows.Forms.Label cnname;
    }
}

