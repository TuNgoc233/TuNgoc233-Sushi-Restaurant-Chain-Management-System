using System.Windows.Forms;

namespace Sushi_Restaurant
{
    partial class company_revenue
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTimeSelection = new System.Windows.Forms.Label();
            this.cboTimeSelection = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnViewRevenue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboQuarter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labQuater = new System.Windows.Forms.Label();
            this.labMonth = new System.Windows.Forms.Label();
            this.cboBranch = new System.Windows.Forms.ComboBox();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.labBranch = new System.Windows.Forms.Label();
            this.labRevenue = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimeSelection
            // 
            this.lblTimeSelection.AutoSize = true;
            this.lblTimeSelection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSelection.Location = new System.Drawing.Point(150, 56);
            this.lblTimeSelection.Name = "lblTimeSelection";
            this.lblTimeSelection.Size = new System.Drawing.Size(109, 20);
            this.lblTimeSelection.TabIndex = 1;
            this.lblTimeSelection.Text = "Chọn thời gian:";
            // 
            // cboTimeSelection
            // 
            this.cboTimeSelection.FormattingEnabled = true;
            this.cboTimeSelection.Location = new System.Drawing.Point(12, 134);
            this.cboTimeSelection.Name = "cboTimeSelection";
            this.cboTimeSelection.Size = new System.Drawing.Size(121, 24);
            this.cboTimeSelection.TabIndex = 2;
            this.cboTimeSelection.SelectedIndexChanged += new System.EventHandler(this.cboTimeSelection_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(153, 76);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // btnViewRevenue
            // 
            this.btnViewRevenue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRevenue.Location = new System.Drawing.Point(12, 487);
            this.btnViewRevenue.Name = "btnViewRevenue";
            this.btnViewRevenue.Size = new System.Drawing.Size(149, 30);
            this.btnViewRevenue.TabIndex = 6;
            this.btnViewRevenue.Text = "Xem Doanh Thu";
            this.btnViewRevenue.UseVisualStyleBackColor = true;
            this.btnViewRevenue.Click += new System.EventHandler(this.btnViewRevenue_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(578, 487);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Location = new System.Drawing.Point(13, 188);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.RowHeadersWidth = 51;
            this.dgvRevenue.Size = new System.Drawing.Size(693, 293);
            this.dgvRevenue.TabIndex = 1;
            this.dgvRevenue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRevenue_CellContentClick);
            // 
            // cboMonth
            // 
            this.cboMonth.Location = new System.Drawing.Point(577, 78);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(121, 24);
            this.cboMonth.TabIndex = 12;
            // 
            // cboQuarter
            // 
            this.cboQuarter.Location = new System.Drawing.Point(401, 78);
            this.cboQuarter.Name = "cboQuarter";
            this.cboQuarter.Size = new System.Drawing.Size(121, 24);
            this.cboQuarter.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thống kê theo:";
            // 
            // labQuater
            // 
            this.labQuater.AutoSize = true;
            this.labQuater.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuater.Location = new System.Drawing.Point(398, 58);
            this.labQuater.Name = "labQuater";
            this.labQuater.Size = new System.Drawing.Size(35, 20);
            this.labQuater.TabIndex = 9;
            this.labQuater.Text = "Quý";
            // 
            // labMonth
            // 
            this.labMonth.AutoSize = true;
            this.labMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonth.Location = new System.Drawing.Point(575, 58);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(50, 20);
            this.labMonth.TabIndex = 10;
            this.labMonth.Text = "Tháng";
            // 
            // cboBranch
            // 
            this.cboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBranch.FormattingEnabled = true;
            this.cboBranch.Location = new System.Drawing.Point(153, 134);
            this.cboBranch.Name = "cboBranch";
            this.cboBranch.Size = new System.Drawing.Size(150, 24);
            this.cboBranch.TabIndex = 0;
            this.cboBranch.SelectedIndexChanged += new System.EventHandler(this.cboBranch_SelectedIndexChanged);
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(498, 136);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.Size = new System.Drawing.Size(200, 22);
            this.txtRevenue.TabIndex = 1;
            // 
            // labBranch
            // 
            this.labBranch.AutoSize = true;
            this.labBranch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBranch.Location = new System.Drawing.Point(150, 114);
            this.labBranch.Name = "labBranch";
            this.labBranch.Size = new System.Drawing.Size(74, 20);
            this.labBranch.TabIndex = 13;
            this.labBranch.Text = "Chi nhánh";
            // 
            // labRevenue
            // 
            this.labRevenue.AutoSize = true;
            this.labRevenue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRevenue.Location = new System.Drawing.Point(397, 136);
            this.labRevenue.Name = "labRevenue";
            this.labRevenue.Size = new System.Drawing.Size(92, 23);
            this.labRevenue.TabIndex = 14;
            this.labRevenue.Text = "Doanh thu";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTitle);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(710, 53);
            this.guna2CustomGradientPanel1.TabIndex = 16;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(16, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 41);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Xem doanh thu chi nhánh";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(763, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // company_revenue
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(710, 532);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labRevenue);
            this.Controls.Add(this.labBranch);
            this.Controls.Add(this.cboBranch);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.labMonth);
            this.Controls.Add(this.labQuater);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboQuarter);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.dgvRevenue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewRevenue);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboTimeSelection);
            this.Controls.Add(this.lblTimeSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "company_revenue";
            this.Text = "Doanh Thu Công Ty";
            this.Load += new System.EventHandler(this.company_revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblTimeSelection;
        private System.Windows.Forms.ComboBox cboTimeSelection;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnViewRevenue;
        private System.Windows.Forms.Button btnClose;
        private DataGridView dgvRevenue;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboQuarter;
        private Label label1;
        private Label labQuater;
        private Label labMonth;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.TextBox txtRevenue;
        private Label labBranch;
        private Label labRevenue;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Label lblTitle;
        private Button button1;
    }
}
