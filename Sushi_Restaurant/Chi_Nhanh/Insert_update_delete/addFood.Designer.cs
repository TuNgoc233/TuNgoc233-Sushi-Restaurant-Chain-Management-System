using System.Windows.Forms;
using System;

namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class addFood
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
            this.labID = new System.Windows.Forms.Label();
            this.labGener = new System.Windows.Forms.Label();
            this.texName = new Guna.UI2.WinForms.Guna2TextBox();
            this.texID = new Guna.UI2.WinForms.Guna2TextBox();
            this.labRole = new System.Windows.Forms.Label();
            this.chooseBranch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labBranch = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.Text = "Thêm món";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(37, 125);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(74, 23);
            this.labName.TabIndex = 3;
            this.labName.Text = "Mã món";
            this.labName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(35, 228);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(76, 23);
            this.labID.TabIndex = 7;
            this.labID.Text = "Tên món";
            // 
            // labGener
            // 
            this.labGener.AutoSize = true;
            this.labGener.Location = new System.Drawing.Point(488, 334);
            this.labGener.Name = "labGener";
            this.labGener.Size = new System.Drawing.Size(85, 23);
            this.labGener.TabIndex = 11;
            this.labGener.Text = "Giao món";
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
            this.texName.TextChanged += new System.EventHandler(this.texName_TextChanged);
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
            this.texID.Location = new System.Drawing.Point(39, 255);
            this.texID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texID.Name = "texID";
            this.texID.PasswordChar = '\0';
            this.texID.PlaceholderText = "";
            this.texID.SelectedText = "";
            this.texID.Size = new System.Drawing.Size(297, 48);
            this.texID.TabIndex = 17;
            this.texID.TextChanged += new System.EventHandler(this.texID_TextChanged);
            // 
            // labRole
            // 
            this.labRole.AutoSize = true;
            this.labRole.Location = new System.Drawing.Point(37, 346);
            this.labRole.Name = "labRole";
            this.labRole.Size = new System.Drawing.Size(43, 23);
            this.labRole.TabIndex = 24;
            this.labRole.Text = "Mục";
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
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Location = new System.Drawing.Point(492, 381);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(52, 27);
            this.guna2RadioButton1.TabIndex = 29;
            this.guna2RadioButton1.Text = "Có";
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
            this.guna2RadioButton2.Location = new System.Drawing.Point(623, 381);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(81, 27);
            this.guna2RadioButton2.TabIndex = 30;
            this.guna2RadioButton2.Text = "Không";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.CheckedChanged += new System.EventHandler(this.guna2RadioButton2_CheckedChanged);
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
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(492, 253);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(297, 48);
            this.guna2TextBox1.TabIndex = 33;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Giá hiện tại";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textRole
            // 
            this.textRole.BackColor = System.Drawing.Color.Transparent;
            this.textRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.textRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.textRole.ItemHeight = 30;
            this.textRole.Items.AddRange(new object[] {
            "TenMuc"});
            this.textRole.Location = new System.Drawing.Point(41, 383);
            this.textRole.Name = "textRole";
            this.textRole.Size = new System.Drawing.Size(140, 36);
            this.textRole.TabIndex = 34;
            this.textRole.SelectedIndexChanged += new System.EventHandler(this.RoleBox_SelectedIndexChanged);
            // 
            // addFood
            // 
            this.ClientSize = new System.Drawing.Size(853, 685);
            this.Controls.Add(this.textRole);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2RadioButton2);
            this.Controls.Add(this.guna2RadioButton1);
            this.Controls.Add(this.labBranch);
            this.Controls.Add(this.chooseBranch);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.texID);
            this.Controls.Add(this.texName);
            this.Controls.Add(this.labGener);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.labName);
            this.Name = "addFood";
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
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labGener;
        public Guna.UI2.WinForms.Guna2TextBox texName;
        public Guna.UI2.WinForms.Guna2TextBox texID;
        public System.Windows.Forms.Label labRole;
        private Guna.UI2.WinForms.Guna2ComboBox chooseBranch;
        private System.Windows.Forms.Label labBranch;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox textRole;
    }
}