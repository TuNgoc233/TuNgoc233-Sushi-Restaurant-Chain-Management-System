using System.Windows.Forms;
using System;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class updateIDCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        public override void Dispose(bool disposing)
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
        protected new void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labName = new System.Windows.Forms.Label();
            this.labMark = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.labBirth = new System.Windows.Forms.Label();
            this.labGener = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.texName = new Guna.UI2.WinForms.Guna2TextBox();
            this.texID = new Guna.UI2.WinForms.Guna2TextBox();
            this.texMark = new Guna.UI2.WinForms.Guna2TextBox();
            this.texAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.texPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.labRole = new System.Windows.Forms.Label();
            this.texRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chooseBranch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labBranch = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.Text = "Thông tin nhân viên";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(37, 125);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(62, 23);
            this.labName.TabIndex = 3;
            this.labName.Text = "Họ tên";
            this.labName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labMark
            // 
            this.labMark.AutoSize = true;
            this.labMark.Location = new System.Drawing.Point(35, 346);
            this.labMark.Name = "labMark";
            this.labMark.Size = new System.Drawing.Size(116, 23);
            this.labMark.TabIndex = 5;
            this.labMark.Text = "Điểm phục vụ";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(527, 125);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(114, 23);
            this.labID.TabIndex = 7;
            this.labID.Text = "Mã nhân viên";
            // 
            // labBirth
            // 
            this.labBirth.AutoSize = true;
            this.labBirth.Location = new System.Drawing.Point(35, 228);
            this.labBirth.Name = "labBirth";
            this.labBirth.Size = new System.Drawing.Size(86, 23);
            this.labBirth.TabIndex = 9;
            this.labBirth.Text = "Ngày sinh";
            // 
            // labGener
            // 
            this.labGener.AutoSize = true;
            this.labGener.Location = new System.Drawing.Point(527, 228);
            this.labGener.Name = "labGener";
            this.labGener.Size = new System.Drawing.Size(75, 23);
            this.labGener.TabIndex = 11;
            this.labGener.Text = "Giới tính";
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(530, 346);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(111, 23);
            this.labPhone.TabIndex = 13;
            this.labPhone.Text = "Số điện thoại";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(37, 476);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(62, 23);
            this.labAddress.TabIndex = 15;
            this.labAddress.Text = "Địa chỉ";
            // 
            // texName
            // 
            this.texName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texName.DefaultText = "";
            this.texName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.texName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.texName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.texName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texName.Location = new System.Drawing.Point(39, 152);
            this.texName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texName.Name = "texName";
            this.texName.PasswordChar = '\0';
            this.texName.PlaceholderText = "";
            this.texName.SelectedText = "";
            this.texName.Size = new System.Drawing.Size(369, 48);
            this.texName.TabIndex = 16;
            // 
            // texID
            // 
            this.texID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texID.DefaultText = "";
            this.texID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.texID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.texID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.texID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texID.Location = new System.Drawing.Point(531, 152);
            this.texID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texID.Name = "texID";
            this.texID.PasswordChar = '\0';
            this.texID.PlaceholderText = "";
            this.texID.SelectedText = "";
            this.texID.Size = new System.Drawing.Size(297, 48);
            this.texID.TabIndex = 17;
            // 
            // texMark
            // 
            this.texMark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texMark.DefaultText = "";
            this.texMark.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.texMark.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.texMark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texMark.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texMark.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texMark.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.texMark.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texMark.Location = new System.Drawing.Point(41, 383);
            this.texMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texMark.Name = "texMark";
            this.texMark.PasswordChar = '\0';
            this.texMark.PlaceholderText = "";
            this.texMark.SelectedText = "";
            this.texMark.Size = new System.Drawing.Size(58, 48);
            this.texMark.TabIndex = 19;
            // 
            // texAddress
            // 
            this.texAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texAddress.DefaultText = "";
            this.texAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.texAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.texAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.texAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texAddress.Location = new System.Drawing.Point(39, 503);
            this.texAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texAddress.Name = "texAddress";
            this.texAddress.PasswordChar = '\0';
            this.texAddress.PlaceholderText = "";
            this.texAddress.SelectedText = "";
            this.texAddress.Size = new System.Drawing.Size(789, 48);
            this.texAddress.TabIndex = 21;
            // 
            // texPhone
            // 
            this.texPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texPhone.DefaultText = "";
            this.texPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.texPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.texPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.texPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texPhone.Location = new System.Drawing.Point(531, 383);
            this.texPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texPhone.Name = "texPhone";
            this.texPhone.PasswordChar = '\0';
            this.texPhone.PlaceholderText = "";
            this.texPhone.SelectedText = "";
            this.texPhone.Size = new System.Drawing.Size(297, 48);
            this.texPhone.TabIndex = 22;
            // 
            // labRole
            // 
            this.labRole.AutoSize = true;
            this.labRole.Location = new System.Drawing.Point(267, 346);
            this.labRole.Name = "labRole";
            this.labRole.Size = new System.Drawing.Size(74, 23);
            this.labRole.TabIndex = 24;
            this.labRole.Text = "Bộ phận";
            // 
            // texRole
            // 
            this.texRole.BackColor = System.Drawing.Color.Transparent;
            this.texRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.texRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.texRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texRole.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.texRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.texRole.ItemHeight = 30;
            this.texRole.Location = new System.Drawing.Point(271, 395);
            this.texRole.Name = "texRole";
            this.texRole.Size = new System.Drawing.Size(140, 36);
            this.texRole.TabIndex = 25;
            // 
            // chooseBranch
            // 
            this.chooseBranch.BackColor = System.Drawing.Color.Transparent;
            this.chooseBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chooseBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseBranch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chooseBranch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chooseBranch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chooseBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.chooseBranch.ItemHeight = 30;
            this.chooseBranch.Location = new System.Drawing.Point(591, 46);
            this.chooseBranch.Name = "chooseBranch";
            this.chooseBranch.Size = new System.Drawing.Size(161, 36);
            this.chooseBranch.TabIndex = 26;
            // 
            // labBranch
            // 
            this.labBranch.AutoSize = true;
            this.labBranch.Location = new System.Drawing.Point(587, 20);
            this.labBranch.Name = "labBranch";
            this.labBranch.Size = new System.Drawing.Size(89, 23);
            this.labBranch.TabIndex = 27;
            this.labBranch.Text = "Chi nhánh";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(39, 254);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(251, 48);
            this.guna2DateTimePicker1.TabIndex = 28;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 11, 29, 8, 59, 22, 173);
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Location = new System.Drawing.Point(531, 275);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(68, 27);
            this.guna2RadioButton1.TabIndex = 29;
            this.guna2RadioButton1.Text = "Nam";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.CheckedChanged += new System.EventHandler(this.guna2RadioButton1_CheckedChanged);
            // 
            // guna2RadioButton2
            // 
            this.guna2RadioButton2.AutoSize = true;
            this.guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.BorderThickness = 0;
            this.guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton2.CheckedState.InnerOffset = -4;
            this.guna2RadioButton2.Location = new System.Drawing.Point(662, 275);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(54, 27);
            this.guna2RadioButton2.TabIndex = 30;
            this.guna2RadioButton2.Text = "Nữ";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(783, 20);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 31;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // addStaff
            // 
            this.ClientSize = new System.Drawing.Size(853, 685);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2RadioButton2);
            this.Controls.Add(this.guna2RadioButton1);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.labBranch);
            this.Controls.Add(this.chooseBranch);
            this.Controls.Add(this.texRole);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.texPhone);
            this.Controls.Add(this.texAddress);
            this.Controls.Add(this.texMark);
            this.Controls.Add(this.texID);
            this.Controls.Add(this.texName);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.labGener);
            this.Controls.Add(this.labBirth);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.labMark);
            this.Controls.Add(this.labName);
            this.Name = "addStaff";
            this.Load += new System.EventHandler(this.addStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeCustomButtons()
        {
            // Nút Đóng (X)
            Button closeButton = new Button();
            closeButton.Text = "X";
            closeButton.Size = new System.Drawing.Size(30, 30);
            closeButton.Location = new System.Drawing.Point(this.Width - 90, 10);  // Đặt ở góc trên bên phải
            closeButton.Click += CloseButton_Click;
            this.Controls.Add(closeButton);

            // Nút Phóng to/Khôi phục (⊞)
            Button maximizeButton = new Button();
            maximizeButton.Text = "☐";
            maximizeButton.Size = new System.Drawing.Size(30, 30);
            maximizeButton.Location = new System.Drawing.Point(this.Width - 60, 10);  // Đặt bên cạnh nút đóng
            maximizeButton.Click += MaximizeButton_Click;
            this.Controls.Add(maximizeButton);

            // Nút Thu nhỏ (-)
            Button minimizeButton = new Button();
            minimizeButton.Text = "-";
            minimizeButton.Size = new System.Drawing.Size(30, 30);
            minimizeButton.Location = new System.Drawing.Point(this.Width - 30, 10);  // Đặt bên cạnh nút phóng to
            minimizeButton.Click += MinimizeButton_Click;
            this.Controls.Add(minimizeButton);
        }

        // Sự kiện cho nút Đóng
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng cửa sổ
        }

        // Sự kiện cho nút Phóng to/Khôi phục
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;  // Phóng to cửa sổ
            }
            else
            {
                this.WindowState = FormWindowState.Normal;  // Khôi phục lại kích thước ban đầu
            }
        }

        // Sự kiện cho nút Thu nhỏ
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  // Thu nhỏ cửa sổ
        }

        // Đảm bảo các nút di chuyển theo kích thước cửa sổ khi thay đổi
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Di chuyển lại các nút khi kích thước form thay đổi
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Left = this.Width - 90 + this.Controls.IndexOf(control) * 30;
                }
            }
        }

        #endregion
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labMark;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labBirth;
        private System.Windows.Forms.Label labGener;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labAddress;
        public Guna.UI2.WinForms.Guna2TextBox texMark;
        public Guna.UI2.WinForms.Guna2TextBox texName;
        public Guna.UI2.WinForms.Guna2TextBox texID;
        public Guna.UI2.WinForms.Guna2TextBox texPhone;
        public Guna.UI2.WinForms.Guna2TextBox texAddress;
        public System.Windows.Forms.Label labRole;
        public Guna.UI2.WinForms.Guna2ComboBox texRole;
        private Guna.UI2.WinForms.Guna2ComboBox chooseBranch;
        private System.Windows.Forms.Label labBranch;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}