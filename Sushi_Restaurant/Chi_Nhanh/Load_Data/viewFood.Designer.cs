namespace Sushi_Restaurant.Chi_Nhanh
{
    partial class viewFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Data_Load = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insert_Item = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.texRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.texMark = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.texName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.texID = new Guna.UI2.WinForms.Guna2TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.labRole = new System.Windows.Forms.Label();
            this.labGener = new System.Windows.Forms.Label();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Load)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnThem.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.btnThem.Location = new System.Drawing.Point(64, 33);
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 110);
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.Text = "Món ăn";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Data_Load
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Data_Load.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Load.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Data_Load.ColumnHeadersHeight = 25;
            this.Data_Load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data_Load.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv,
            this.dgv1,
            this.dgv2,
            this.dgv3,
            this.dgv4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Load.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data_Load.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_Load.Location = new System.Drawing.Point(225, 189);
            this.Data_Load.Name = "Data_Load";
            this.Data_Load.RowHeadersVisible = false;
            this.Data_Load.RowHeadersWidth = 51;
            this.Data_Load.RowTemplate.Height = 24;
            this.Data_Load.Size = new System.Drawing.Size(1146, 234);
            this.Data_Load.TabIndex = 6;
            this.Data_Load.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_Load.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Data_Load.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Data_Load.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Data_Load.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Data_Load.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Data_Load.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_Load.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Data_Load.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Data_Load.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_Load.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Data_Load.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data_Load.ThemeStyle.HeaderStyle.Height = 25;
            this.Data_Load.ThemeStyle.ReadOnly = false;
            this.Data_Load.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Data_Load.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Data_Load.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_Load.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data_Load.ThemeStyle.RowsStyle.Height = 24;
            this.Data_Load.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data_Load.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data_Load.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Load);
            // 
            // dgv
            // 
            this.dgv.HeaderText = "Mã món ăn";
            this.dgv.MinimumWidth = 6;
            this.dgv.Name = "dgv";
            // 
            // dgv1
            // 
            this.dgv1.HeaderText = "Tên món ăn";
            this.dgv1.MinimumWidth = 6;
            this.dgv1.Name = "dgv1";
            // 
            // dgv2
            // 
            this.dgv2.HeaderText = "Mã mục";
            this.dgv2.MinimumWidth = 6;
            this.dgv2.Name = "dgv2";
            // 
            // dgv3
            // 
            this.dgv3.HeaderText = "Giá hiện tại";
            this.dgv3.MinimumWidth = 6;
            this.dgv3.Name = "dgv3";
            // 
            // dgv4
            // 
            this.dgv4.HeaderText = "Tình trạng phục vụ";
            this.dgv4.MinimumWidth = 6;
            this.dgv4.Name = "dgv4";
            // 
            // Insert_Item
            // 
            this.Insert_Item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Insert_Item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Insert_Item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Insert_Item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Insert_Item.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Insert_Item.ForeColor = System.Drawing.Color.White;
            this.Insert_Item.Location = new System.Drawing.Point(1214, 143);
            this.Insert_Item.Name = "Insert_Item";
            this.Insert_Item.Size = new System.Drawing.Size(180, 45);
            this.Insert_Item.TabIndex = 7;
            this.Insert_Item.Text = "Thêm món ăn";
            this.Insert_Item.Click += new System.EventHandler(this.Insert_Item_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.texRole);
            this.guna2CustomGradientPanel1.Controls.Add(this.texMark);
            this.guna2CustomGradientPanel1.Controls.Add(this.Insert_Item);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2RadioButton2);
            this.guna2CustomGradientPanel1.Controls.Add(this.texName);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2RadioButton1);
            this.guna2CustomGradientPanel1.Controls.Add(this.labName);
            this.guna2CustomGradientPanel1.Controls.Add(this.texID);
            this.guna2CustomGradientPanel1.Controls.Add(this.labID);
            this.guna2CustomGradientPanel1.Controls.Add(this.labRole);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(182, 489);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1224, 200);
            this.guna2CustomGradientPanel1.TabIndex = 8;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint_1);
            // 
            // texRole
            // 
            this.texRole.AutoCompleteCustomSource.AddRange(new string[] {
            "TenMuc"});
            this.texRole.BackColor = System.Drawing.Color.Transparent;
            this.texRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.texRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.texRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.texRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.texRole.ItemHeight = 30;
            this.texRole.Location = new System.Drawing.Point(3, 128);
            this.texRole.Name = "texRole";
            this.texRole.Size = new System.Drawing.Size(140, 36);
            this.texRole.TabIndex = 45;
            this.texRole.SelectedIndexChanged += new System.EventHandler(this.texRole_SelectedIndexChanged);
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
            this.texMark.Location = new System.Drawing.Point(440, 43);
            this.texMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texMark.Name = "texMark";
            this.texMark.PasswordChar = '\0';
            this.texMark.PlaceholderText = "";
            this.texMark.SelectedText = "";
            this.texMark.Size = new System.Drawing.Size(297, 48);
            this.texMark.TabIndex = 44;
            this.texMark.TextChanged += new System.EventHandler(this.textMark_TextChanged);
            // 
            // guna2RadioButton2
            // 
            this.guna2RadioButton2.AutoSize = true;
            this.guna2RadioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.BorderThickness = 0;
            this.guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton2.CheckedState.InnerOffset = -4;
            this.guna2RadioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2RadioButton2.Location = new System.Drawing.Point(630, 128);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(81, 27);
            this.guna2RadioButton2.TabIndex = 42;
            this.guna2RadioButton2.Text = "Không";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UseVisualStyleBackColor = false;
            this.guna2RadioButton2.CheckedChanged += new System.EventHandler(this.guna2RadioButton2_CheckedChanged);
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
            this.texName.Location = new System.Drawing.Point(157, 122);
            this.texName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texName.Name = "texName";
            this.texName.PasswordChar = '\0';
            this.texName.PlaceholderText = "";
            this.texName.SelectedText = "";
            this.texName.Size = new System.Drawing.Size(369, 48);
            this.texName.TabIndex = 38;
            this.texName.TextChanged += new System.EventHandler(this.texName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(439, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Giá hiện tại";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.labName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labName.Location = new System.Drawing.Point(1, 6);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(74, 23);
            this.labName.TabIndex = 35;
            this.labName.Text = "Mã món";
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
            this.texID.Location = new System.Drawing.Point(7, 33);
            this.texID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texID.Name = "texID";
            this.texID.PasswordChar = '\0';
            this.texID.PlaceholderText = "";
            this.texID.SelectedText = "";
            this.texID.Size = new System.Drawing.Size(297, 48);
            this.texID.TabIndex = 39;
            this.texID.TextChanged += new System.EventHandler(this.texID_TextChanged);
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.labID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labID.Location = new System.Drawing.Point(167, 95);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(76, 23);
            this.labID.TabIndex = 36;
            this.labID.Text = "Tên món";
            // 
            // labRole
            // 
            this.labRole.AutoSize = true;
            this.labRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.labRole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labRole.Location = new System.Drawing.Point(3, 85);
            this.labRole.Name = "labRole";
            this.labRole.Size = new System.Drawing.Size(43, 23);
            this.labRole.TabIndex = 40;
            this.labRole.Text = "Mục";
            // 
            // labGener
            // 
            this.labGener.AutoSize = true;
            this.labGener.Location = new System.Drawing.Point(499, 547);
            this.labGener.Name = "labGener";
            this.labGener.Size = new System.Drawing.Size(85, 23);
            this.labGener.TabIndex = 37;
            this.labGener.Text = "Giao món";
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2RadioButton1.Location = new System.Drawing.Point(532, 128);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(52, 27);
            this.guna2RadioButton1.TabIndex = 41;
            this.guna2RadioButton1.Text = "Có";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UseVisualStyleBackColor = false;
            this.guna2RadioButton1.CheckedChanged += new System.EventHandler(this.guna2RadioButton1_CheckedChanged);
            // 
            // viewFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 689);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.labGener);
            this.Controls.Add(this.Data_Load);
            this.Name = "viewFood";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.viewAdd_Load);
            this.Controls.SetChildIndex(this.Data_Load, 0);
            this.Controls.SetChildIndex(this.labGener, 0);
            this.Controls.SetChildIndex(this.guna2CustomGradientPanel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnThem, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.guna2Separator1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Load)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Data_Load;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv4;
        private Guna.UI2.WinForms.Guna2Button Insert_Item;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        public Guna.UI2.WinForms.Guna2TextBox texName;
        private System.Windows.Forms.Label labName;
        public Guna.UI2.WinForms.Guna2TextBox texID;
        private System.Windows.Forms.Label labID;
        public System.Windows.Forms.Label labRole;
        private Guna.UI2.WinForms.Guna2ComboBox texRole;
        public Guna.UI2.WinForms.Guna2TextBox texMark;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private System.Windows.Forms.Label labGener;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
    }
}