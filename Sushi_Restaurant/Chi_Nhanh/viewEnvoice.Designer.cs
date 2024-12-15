namespace Sushi_Restaurant.Chi_Nhanh
{
    partial class viewEnvoice
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
        /// 

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        public System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox texEnvID;
        public Guna.UI2.WinForms.Guna2TextBox texBranchID;
        public System.Windows.Forms.Label labBranchID;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public System.Windows.Forms.Label labCustomerID;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView3;
        public Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        public System.Windows.Forms.Label labDate;
        public System.Windows.Forms.Label labSearch;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayLap;
        public System.Windows.Forms.Label labTypePurchase;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCost;
        public Guna.UI2.WinForms.Guna2DataGridView gridEnvoice;
        public Guna.UI2.WinForms.Guna2TextBox boxTypeBuy;
        public Guna.UI2.WinForms.Guna2TextBox boxCustomName;
        public System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView5;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxTimKiemTheo;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTimKiem;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labSearch = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.texEnvID = new Guna.UI2.WinForms.Guna2TextBox();
            this.texBranchID = new Guna.UI2.WinForms.Guna2TextBox();
            this.labBranchID = new System.Windows.Forms.Label();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.labCustomerID = new System.Windows.Forms.Label();
            this.guna2DataGridView3 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labDate = new System.Windows.Forms.Label();
            this.labTypePurchase = new System.Windows.Forms.Label();
            this.guna2DataGridView4 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gridEnvoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxTypeBuy = new Guna.UI2.WinForms.Guna2TextBox();
            this.boxCustomName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2DataGridView5 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboBoxTimKiemTheo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnThem.Image = global::Sushi_Restaurant.Properties.Resources.icon_invoice;
            this.btnThem.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.btnThem.Location = new System.Drawing.Point(60, 70);
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThem.Size = new System.Drawing.Size(67, 69);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.Text = "Hoá đơn";
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(761, 45);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(100, 23);
            this.labSearch.TabIndex = 5;
            this.labSearch.Text = "Ngày tháng";
            this.labSearch.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Checked = true;
            this.dtpNgayLap.FillColor = System.Drawing.Color.White;
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayLap.Location = new System.Drawing.Point(773, 70);
            this.dtpNgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(227, 48);
            this.dtpNgayLap.TabIndex = 6;
            this.dtpNgayLap.Value = new System.DateTime(2024, 11, 29, 9, 19, 45, 271);
            // 
            // gridEnvoice
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.gridEnvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridEnvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEnvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridEnvoice.ColumnHeadersHeight = 40;
            this.gridEnvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridEnvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvFoodName,
            this.dgvAmount,
            this.dgvCost});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEnvoice.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridEnvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridEnvoice.Location = new System.Drawing.Point(49, 189);
            this.gridEnvoice.Name = "gridEnvoice";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEnvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridEnvoice.RowHeadersVisible = false;
            this.gridEnvoice.RowHeadersWidth = 51;
            this.gridEnvoice.RowTemplate.Height = 24;
            this.gridEnvoice.Size = new System.Drawing.Size(1318, 491);
            this.gridEnvoice.TabIndex = 21;
            this.gridEnvoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridEnvoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridEnvoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridEnvoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridEnvoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridEnvoice.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.gridEnvoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridEnvoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridEnvoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridEnvoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEnvoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridEnvoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridEnvoice.ThemeStyle.HeaderStyle.Height = 40;
            this.gridEnvoice.ThemeStyle.ReadOnly = false;
            this.gridEnvoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridEnvoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridEnvoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEnvoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridEnvoice.ThemeStyle.RowsStyle.Height = 24;
            this.gridEnvoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridEnvoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridEnvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView5_CellContentClick);
            // 
            // dgvSno
            // 
            this.dgvSno.HeaderText = "STT";
            this.dgvSno.MinimumWidth = 6;
            this.dgvSno.Name = "dgvSno";
            // 
            // dgvFoodName
            // 
            this.dgvFoodName.HeaderText = "Tên món";
            this.dgvFoodName.MinimumWidth = 6;
            this.dgvFoodName.Name = "dgvFoodName";
            // 
            // dgvAmount
            // 
            this.dgvAmount.HeaderText = "Số lượng";
            this.dgvAmount.MinimumWidth = 6;
            this.dgvAmount.Name = "dgvAmount";
            // 
            // dgvCost
            // 
            this.dgvCost.HeaderText = "Giá";
            this.dgvCost.MinimumWidth = 6;
            this.dgvCost.Name = "dgvCost";
            // 
            // boxTypeBuy
            // 
            this.boxTypeBuy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.boxTypeBuy.DefaultText = "";
            this.boxTypeBuy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.boxTypeBuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.boxTypeBuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.boxTypeBuy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.boxTypeBuy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxTypeBuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boxTypeBuy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxTypeBuy.Location = new System.Drawing.Point(790, 302);
            this.boxTypeBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxTypeBuy.Name = "boxTypeBuy";
            this.boxTypeBuy.PasswordChar = '\0';
            this.boxTypeBuy.PlaceholderText = "";
            this.boxTypeBuy.SelectedText = "";
            this.boxTypeBuy.Size = new System.Drawing.Size(229, 48);
            this.boxTypeBuy.TabIndex = 22;
            // 
            // boxCustomName
            // 
            this.boxCustomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.boxCustomName.DefaultText = "";
            this.boxCustomName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.boxCustomName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.boxCustomName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.boxCustomName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.boxCustomName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxCustomName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boxCustomName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxCustomName.Location = new System.Drawing.Point(421, 315);
            this.boxCustomName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxCustomName.Name = "boxCustomName";
            this.boxCustomName.PasswordChar = '\0';
            this.boxCustomName.PlaceholderText = "";
            this.boxCustomName.SelectedText = "";
            this.boxCustomName.Size = new System.Drawing.Size(229, 48);
            this.boxCustomName.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tên khách hàng";
            // 
            // guna2DataGridView5
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.guna2DataGridView5.ColumnHeadersHeight = 4;
            this.guna2DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView5.DefaultCellStyle = dataGridViewCellStyle19;
            this.guna2DataGridView5.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView5.Location = new System.Drawing.Point(417, 278);
            this.guna2DataGridView5.Name = "guna2DataGridView5";
            this.guna2DataGridView5.RowHeadersVisible = false;
            this.guna2DataGridView5.RowHeadersWidth = 51;
            this.guna2DataGridView5.RowTemplate.Height = 24;
            this.guna2DataGridView5.Size = new System.Drawing.Size(103, 51);
            this.guna2DataGridView5.TabIndex = 23;
            this.guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView5.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView5.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView5.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView5.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView5.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView5.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView5.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView5.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView5.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView5.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView5.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView5.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // comboBoxTimKiemTheo
            // 
            this.comboBoxTimKiemTheo.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxTimKiemTheo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTimKiemTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimKiemTheo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTimKiemTheo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTimKiemTheo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxTimKiemTheo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxTimKiemTheo.ItemHeight = 30;
            this.comboBoxTimKiemTheo.Items.AddRange(new object[] {
            "Ngày lập đơn",
            "Mã khách hàng"});
            this.comboBoxTimKiemTheo.Location = new System.Drawing.Point(472, 82);
            this.comboBoxTimKiemTheo.Name = "comboBoxTimKiemTheo";
            this.comboBoxTimKiemTheo.Size = new System.Drawing.Size(197, 36);
            this.comboBoxTimKiemTheo.TabIndex = 26;
            this.comboBoxTimKiemTheo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimKiemTheo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tìm kiếm theo";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(209, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 46);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // viewEnvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 783);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTimKiemTheo);
            this.Controls.Add(this.boxCustomName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2DataGridView5);
            this.Controls.Add(this.boxTypeBuy);
            this.Controls.Add(this.gridEnvoice);
            this.Controls.Add(this.labTypePurchase);
            this.Controls.Add(this.guna2DataGridView4);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.labCustomerID);
            this.Controls.Add(this.guna2DataGridView3);
            this.Controls.Add(this.texBranchID);
            this.Controls.Add(this.labBranchID);
            this.Controls.Add(this.guna2DataGridView2);
            this.Controls.Add(this.texEnvID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "viewEnvoice";
            this.Text = "viewEnvoice";
            this.Load += new System.EventHandler(this.viewEnvoice_Load);
            this.Controls.SetChildIndex(this.btnTimKiem, 0);
            this.Controls.SetChildIndex(this.guna2Separator1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnThem, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.labSearch, 0);
            this.Controls.SetChildIndex(this.dtpNgayLap, 0);
            this.Controls.SetChildIndex(this.guna2DataGridView1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.texEnvID, 0);
            this.Controls.SetChildIndex(this.guna2DataGridView2, 0);
            this.Controls.SetChildIndex(this.labBranchID, 0);
            this.Controls.SetChildIndex(this.texBranchID, 0);
            this.Controls.SetChildIndex(this.guna2DataGridView3, 0);
            this.Controls.SetChildIndex(this.labCustomerID, 0);
            this.Controls.SetChildIndex(this.guna2TextBox1, 0);
            this.Controls.SetChildIndex(this.labDate, 0);
            this.Controls.SetChildIndex(this.guna2DateTimePicker2, 0);
            this.Controls.SetChildIndex(this.guna2DataGridView4, 0);
            this.Controls.SetChildIndex(this.labTypePurchase, 0);
            this.Controls.SetChildIndex(this.gridEnvoice, 0);
            this.Controls.SetChildIndex(this.boxTypeBuy, 0);
            this.Controls.SetChildIndex(this.guna2DataGridView5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.boxCustomName, 0);
            this.Controls.SetChildIndex(this.comboBoxTimKiemTheo, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion
        
    }
}