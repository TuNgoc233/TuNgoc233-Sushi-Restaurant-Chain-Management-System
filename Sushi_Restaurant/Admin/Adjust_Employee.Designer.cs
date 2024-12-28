using System.Windows.Forms;
using System;

namespace Sushi_Restaurant.Admin
{
    public partial class Adjust_Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //public override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        protected new void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labName = new System.Windows.Forms.Label();
            this.labBirth = new System.Windows.Forms.Label();
            this.labGener = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.texName = new Guna.UI2.WinForms.Guna2TextBox();
            this.texAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.texPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.labRole = new System.Windows.Forms.Label();
            this.texRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.labAddStaff = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(22, 88);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(46, 16);
            this.labName.TabIndex = 3;
            this.labName.Text = "Họ tên";
            // 
            // labBirth
            // 
            this.labBirth.AutoSize = true;
            this.labBirth.Location = new System.Drawing.Point(23, 289);
            this.labBirth.Name = "labBirth";
            this.labBirth.Size = new System.Drawing.Size(67, 16);
            this.labBirth.TabIndex = 9;
            this.labBirth.Text = "Ngày sinh";
            this.labBirth.Click += new System.EventHandler(this.labBirth_Click);
            // 
            // labGener
            // 
            this.labGener.AutoSize = true;
            this.labGener.Location = new System.Drawing.Point(349, 289);
            this.labGener.Name = "labGener";
            this.labGener.Size = new System.Drawing.Size(54, 16);
            this.labGener.TabIndex = 11;
            this.labGener.Text = "Giới tính";
            this.labGener.Click += new System.EventHandler(this.labGener_Click);
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(23, 213);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(85, 16);
            this.labPhone.TabIndex = 13;
            this.labPhone.Text = "Số điện thoại";
            this.labPhone.Click += new System.EventHandler(this.labPhone_Click);
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(21, 357);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(47, 16);
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
            this.texName.Location = new System.Drawing.Point(24, 108);
            this.texName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texName.Name = "texName";
            this.texName.PasswordChar = '\0';
            this.texName.PlaceholderText = "";
            this.texName.SelectedText = "";
            this.texName.Size = new System.Drawing.Size(461, 33);
            this.texName.TabIndex = 16;
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
            this.texAddress.Location = new System.Drawing.Point(24, 377);
            this.texAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texAddress.Name = "texAddress";
            this.texAddress.PasswordChar = '\0';
            this.texAddress.PlaceholderText = "";
            this.texAddress.SelectedText = "";
            this.texAddress.Size = new System.Drawing.Size(563, 33);
            this.texAddress.TabIndex = 21;
            this.texAddress.TextChanged += new System.EventHandler(this.texAddress_TextChanged);
            // 
            // texPhone
            // 
            this.texPhone.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.texPhone.DefaultText = "";
            this.texPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.texPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.texPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.texPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texPhone.Location = new System.Drawing.Point(25, 233);
            this.texPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texPhone.Name = "texPhone";
            this.texPhone.PasswordChar = '\0';
            this.texPhone.PlaceholderText = "";
            this.texPhone.SelectedText = "";
            this.texPhone.Size = new System.Drawing.Size(321, 33);
            this.texPhone.TabIndex = 22;
            this.texPhone.UseWaitCursor = true;
            this.texPhone.TextChanged += new System.EventHandler(this.texPhone_TextChanged);
            // 
            // labRole
            // 
            this.labRole.AutoSize = true;
            this.labRole.Location = new System.Drawing.Point(22, 145);
            this.labRole.Name = "labRole";
            this.labRole.Size = new System.Drawing.Size(57, 16);
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
            this.texRole.Location = new System.Drawing.Point(24, 164);
            this.texRole.Name = "texRole";
            this.texRole.Size = new System.Drawing.Size(234, 36);
            this.texRole.TabIndex = 25;
            this.texRole.SelectedIndexChanged += new System.EventHandler(this.texRole_SelectedIndexChanged);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(25, 308);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(251, 33);
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
            this.guna2RadioButton1.Location = new System.Drawing.Point(352, 308);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(57, 20);
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
            this.guna2RadioButton2.Location = new System.Drawing.Point(483, 308);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(45, 20);
            this.guna2RadioButton2.TabIndex = 30;
            this.guna2RadioButton2.Text = "Nữ";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.CheckedChanged += new System.EventHandler(this.guna2RadioButton2_CheckedChanged);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.labAddStaff);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(621, 67);
            this.guna2CustomGradientPanel1.TabIndex = 51;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // labAddStaff
            // 
            this.labAddStaff.AutoSize = true;
            this.labAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.labAddStaff.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labAddStaff.Location = new System.Drawing.Point(12, 21);
            this.labAddStaff.Name = "labAddStaff";
            this.labAddStaff.Size = new System.Drawing.Size(260, 38);
            this.labAddStaff.TabIndex = 47;
            this.labAddStaff.Text = "Chỉnh sửa thông tin";
            this.labAddStaff.Click += new System.EventHandler(this.labAddStaff_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoRoundedCorners = true;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BorderRadius = 23;
            this.btnLuu.CustomizableEdges.TopRight = false;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(84, 436);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 49);
            this.btnLuu.TabIndex = 49;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.AutoRoundedCorners = true;
            this.btnDong.BackColor = System.Drawing.Color.Transparent;
            this.btnDong.BorderRadius = 23;
            this.btnDong.CustomizableEdges.TopRight = false;
            this.btnDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(394, 436);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(134, 49);
            this.btnDong.TabIndex = 48;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Adjust_Employee
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(621, 521);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.guna2RadioButton2);
            this.Controls.Add(this.guna2RadioButton1);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.texRole);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.texPhone);
            this.Controls.Add(this.texAddress);
            this.Controls.Add(this.texName);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.labGener);
            this.Controls.Add(this.labBirth);
            this.Controls.Add(this.labName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adjust_Employee";
            this.Load += new System.EventHandler(this.Adjust_Employee_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
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
        private System.Windows.Forms.Label labBirth;
        private System.Windows.Forms.Label labGener;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labAddress;
        public Guna.UI2.WinForms.Guna2TextBox texName;
        public Guna.UI2.WinForms.Guna2TextBox texPhone;
        public Guna.UI2.WinForms.Guna2TextBox texAddress;
        public System.Windows.Forms.Label labRole;
        public Guna.UI2.WinForms.Guna2ComboBox texRole;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Label labAddStaff;
        public Guna.UI2.WinForms.Guna2Button btnLuu;
        public Guna.UI2.WinForms.Guna2Button btnDong;
    }
}