using System.Windows.Forms;

namespace Sushi_Restaurant
{
    partial class branch_revenue
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTimeSelection = new System.Windows.Forms.Label();
            this.cboTimeSelection = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboQuarter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labQuater = new System.Windows.Forms.Label();
            this.labMonth = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Xem doanh thu chi nhánh";
            // 
            // lblTimeSelection
            // 
            this.lblTimeSelection.AutoSize = true;
            this.lblTimeSelection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSelection.Location = new System.Drawing.Point(15, 130);
            this.lblTimeSelection.Name = "lblTimeSelection";
            this.lblTimeSelection.Size = new System.Drawing.Size(44, 20);
            this.lblTimeSelection.TabIndex = 1;
            this.lblTimeSelection.Text = "Ngày";
            // 
            // cboTimeSelection
            // 
            this.cboTimeSelection.FormattingEnabled = true;
            this.cboTimeSelection.Location = new System.Drawing.Point(13, 91);
            this.cboTimeSelection.Name = "cboTimeSelection";
            this.cboTimeSelection.Size = new System.Drawing.Size(121, 24);
            this.cboTimeSelection.TabIndex = 2;
            this.cboTimeSelection.SelectedIndexChanged += new System.EventHandler(this.cboTimeSelection_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(18, 152);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtRevenue
            // 
            this.txtRevenue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRevenue.Location = new System.Drawing.Point(175, 93);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.Size = new System.Drawing.Size(350, 22);
            this.txtRevenue.TabIndex = 4;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRevenue.Location = new System.Drawing.Point(171, 71);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(96, 23);
            this.lblRevenue.TabIndex = 5;
            this.lblRevenue.Text = "Doanh thu:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(551, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(374, 150);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(120, 24);
            this.cboMonth.TabIndex = 2;
            this.cboMonth.Visible = false;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // cboQuarter
            // 
            this.cboQuarter.FormattingEnabled = true;
            this.cboQuarter.Location = new System.Drawing.Point(236, 150);
            this.cboQuarter.Name = "cboQuarter";
            this.cboQuarter.Size = new System.Drawing.Size(120, 24);
            this.cboQuarter.TabIndex = 3;
            this.cboQuarter.Visible = false;
            this.cboQuarter.SelectedIndexChanged += new System.EventHandler(this.cboQuarter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thống kê theo:";
            // 
            // labQuater
            // 
            this.labQuater.AutoSize = true;
            this.labQuater.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuater.Location = new System.Drawing.Point(232, 130);
            this.labQuater.Name = "labQuater";
            this.labQuater.Size = new System.Drawing.Size(35, 20);
            this.labQuater.TabIndex = 9;
            this.labQuater.Text = "Quý";
            // 
            // labMonth
            // 
            this.labMonth.AutoSize = true;
            this.labMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonth.Location = new System.Drawing.Point(371, 130);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(50, 20);
            this.labMonth.TabIndex = 10;
            this.labMonth.Text = "Tháng";
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
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(696, 55);
            this.guna2CustomGradientPanel1.TabIndex = 11;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(515, 130);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 16);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Năm";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(518, 150);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 24);
            this.cboYear.TabIndex = 13;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // branch_revenue
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(696, 271);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.labMonth);
            this.Controls.Add(this.labQuater);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboTimeSelection);
            this.Controls.Add(this.lblTimeSelection);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboQuarter);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "branch_revenue";
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.branch_revenue_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimeSelection;
        private System.Windows.Forms.ComboBox cboTimeSelection;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Label lblRevenue;
        //private System.Windows.Forms.Button btnViewRevenue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboQuarter;
        //private System.Windows.Forms.ComboBox cboBranchId;
        private Label label1;
        private Label labQuater;
        private Label labMonth;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        //private Label labBranch;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblYear;

    }
}