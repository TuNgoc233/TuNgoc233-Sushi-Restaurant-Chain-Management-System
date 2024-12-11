namespace Sushi_Restaurant.Chi_Nhanh
{
    public partial class addStaff
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
        protected new void InitializeComponent()
        {   
            this.labName = new System.Windows.Forms.Label();
            this.labMark = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.labBirth = new System.Windows.Forms.Label();
            this.labGener = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.texName = new Guna.UI2.WinForms.Guna2TextBox();
            this.texID = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkGener = new Guna.UI2.WinForms.Guna2CheckBox();
            this.texMark = new Guna.UI2.WinForms.Guna2TextBox();
            this.texAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.texPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.labRole = new System.Windows.Forms.Label();
            this.texRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chooseBranch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labBranch = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
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
            this.labName.Location = new System.Drawing.Point(35, 162);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(62, 23);
            this.labName.TabIndex = 3;
            this.labName.Text = "Họ tên";
            this.labName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labMark
            // 
            this.labMark.AutoSize = true;
            this.labMark.Location = new System.Drawing.Point(37, 431);
            this.labMark.Name = "labMark";
            this.labMark.Size = new System.Drawing.Size(116, 23);
            this.labMark.TabIndex = 5;
            this.labMark.Text = "Điểm phục vụ";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(587, 162);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(114, 23);
            this.labID.TabIndex = 7;
            this.labID.Text = "Mã nhân viên";
            // 
            // labBirth
            // 
            this.labBirth.AutoSize = true;
            this.labBirth.Location = new System.Drawing.Point(35, 291);
            this.labBirth.Name = "labBirth";
            this.labBirth.Size = new System.Drawing.Size(86, 23);
            this.labBirth.TabIndex = 9;
            this.labBirth.Text = "Ngày sinh";
            // 
            // labGener
            // 
            this.labGener.AutoSize = true;
            this.labGener.Location = new System.Drawing.Point(587, 294);
            this.labGener.Name = "labGener";
            this.labGener.Size = new System.Drawing.Size(75, 23);
            this.labGener.TabIndex = 11;
            this.labGener.Text = "Giới tính";
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(590, 431);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(111, 23);
            this.labPhone.TabIndex = 13;
            this.labPhone.Text = "Số điện thoại";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(37, 555);
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
            this.texName.Location = new System.Drawing.Point(41, 189);
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
            this.texID.Location = new System.Drawing.Point(591, 189);
            this.texID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texID.Name = "texID";
            this.texID.PasswordChar = '\0';
            this.texID.PlaceholderText = "";
            this.texID.SelectedText = "";
            this.texID.Size = new System.Drawing.Size(229, 48);
            this.texID.TabIndex = 17;
            // 
            // checkGener
            // 
            this.checkGener.AutoSize = true;
            this.checkGener.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkGener.CheckedState.BorderRadius = 0;
            this.checkGener.CheckedState.BorderThickness = 0;
            this.checkGener.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkGener.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkGener.Location = new System.Drawing.Point(591, 320);
            this.checkGener.Name = "checkGener";
            this.checkGener.Size = new System.Drawing.Size(69, 27);
            this.checkGener.TabIndex = 18;
            this.checkGener.Text = "Nam";
            this.checkGener.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkGener.UncheckedState.BorderRadius = 0;
            this.checkGener.UncheckedState.BorderThickness = 0;
            this.checkGener.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkGener.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
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
            this.texMark.Location = new System.Drawing.Point(41, 458);
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
            this.texAddress.Location = new System.Drawing.Point(39, 582);
            this.texAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texAddress.Name = "texAddress";
            this.texAddress.PasswordChar = '\0';
            this.texAddress.PlaceholderText = "";
            this.texAddress.SelectedText = "";
            this.texAddress.Size = new System.Drawing.Size(781, 48);
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
            this.texPhone.Location = new System.Drawing.Point(591, 458);
            this.texPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texPhone.Name = "texPhone";
            this.texPhone.PasswordChar = '\0';
            this.texPhone.PlaceholderText = "";
            this.texPhone.SelectedText = "";
            this.texPhone.Size = new System.Drawing.Size(229, 48);
            this.texPhone.TabIndex = 22;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Location = new System.Drawing.Point(719, 320);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(55, 27);
            this.guna2CheckBox1.TabIndex = 23;
            this.guna2CheckBox1.Text = "Nữ";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // labRole
            // 
            this.labRole.AutoSize = true;
            this.labRole.Location = new System.Drawing.Point(239, 444);
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
            this.texRole.Items.AddRange(new object[] {
            "Bếp",
            "Lễ tân",
            "Phục vụ bàn",
            "Thu ngân",
            "Quản lý",
            "Vệ sinh",
            "Kế toán",
            "Marketing",
            "Nhân sự",
            "Quản lý kho",
            "Giám sát",
            "Giao hàng",
            "Tiếp thị",
            "Chăm sóc khách hàng",
            "Vận hành"});
            this.texRole.Location = new System.Drawing.Point(243, 470);
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
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(41, 317);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(251, 48);
            this.guna2DateTimePicker1.TabIndex = 28;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 11, 29, 8, 59, 22, 173);

            // 
            // addStaff
            // 
            this.ClientSize = new System.Drawing.Size(859, 738);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.labBranch);
            this.Controls.Add(this.chooseBranch);
            this.Controls.Add(this.texRole);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.texPhone);
            this.Controls.Add(this.texAddress);
            this.Controls.Add(this.texMark);
            this.Controls.Add(this.checkGener);
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
        public Guna.UI2.WinForms.Guna2CheckBox checkGener;
        public Guna.UI2.WinForms.Guna2TextBox texPhone;
        public Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        public Guna.UI2.WinForms.Guna2TextBox texAddress;
        public System.Windows.Forms.Label labRole;
        public Guna.UI2.WinForms.Guna2ComboBox texRole;
        private Guna.UI2.WinForms.Guna2ComboBox chooseBranch;
        private System.Windows.Forms.Label labBranch;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}