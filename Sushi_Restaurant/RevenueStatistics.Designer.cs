namespace Sushi_Restaurant
{
    partial class RevenueStatistics
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
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cboBranch = new System.Windows.Forms.ComboBox();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.lblBestSelling = new System.Windows.Forms.Label();
            this.txtBestSelling = new System.Windows.Forms.TextBox();
            this.lblSlowestSelling = new System.Windows.Forms.Label();
            this.txtSlowestSelling = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.dtpStartDate);
            this.groupBoxFilters.Controls.Add(this.dtpEndDate);
            this.groupBoxFilters.Controls.Add(this.cboBranch);
            this.groupBoxFilters.Controls.Add(this.cboRegion);
            this.groupBoxFilters.Controls.Add(this.btnGenerateReport);
            this.groupBoxFilters.Controls.Add(this.lblFromDate);
            this.groupBoxFilters.Controls.Add(this.lblToDate);
            this.groupBoxFilters.Controls.Add(this.lblBranch);
            this.groupBoxFilters.Controls.Add(this.lblRegion);
            this.groupBoxFilters.Location = new System.Drawing.Point(16, 15);
            this.groupBoxFilters.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFilters.Size = new System.Drawing.Size(1013, 148);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Bộ lọc dữ liệu";
            this.groupBoxFilters.Enter += new System.EventHandler(this.groupBoxFilters_Enter);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(120, 37);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(265, 22);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(573, 37);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(265, 22);
            this.dtpEndDate.TabIndex = 1;
            // 
            // cboBranch
            // 
            this.cboBranch.FormattingEnabled = true;
            this.cboBranch.Location = new System.Drawing.Point(120, 86);
            this.cboBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cboBranch.Name = "cboBranch";
            this.cboBranch.Size = new System.Drawing.Size(265, 24);
            this.cboBranch.TabIndex = 2;
            this.cboBranch.SelectedIndexChanged += new System.EventHandler(this.cboBranch_SelectedIndexChanged);
            // 
            // cboRegion
            // 
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(573, 86);
            this.cboRegion.Margin = new System.Windows.Forms.Padding(4);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(265, 24);
            this.cboRegion.TabIndex = 3;
            this.cboRegion.SelectedIndexChanged += new System.EventHandler(this.cboRegion_SelectedIndexChanged);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(867, 62);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(133, 37);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Thống kê";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(27, 37);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(59, 16);
            this.lblFromDate.TabIndex = 5;
            this.lblFromDate.Text = "Từ ngày:";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(467, 37);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(67, 16);
            this.lblToDate.TabIndex = 6;
            this.lblToDate.Text = "Đến ngày:";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(27, 86);
            this.lblBranch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(68, 16);
            this.lblBranch.TabIndex = 7;
            this.lblBranch.Text = "Chi nhánh:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(467, 86);
            this.lblRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(56, 16);
            this.lblRegion.TabIndex = 8;
            this.lblRegion.Text = "Khu vực:";
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Location = new System.Drawing.Point(16, 185);
            this.dgvRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.RowHeadersWidth = 51;
            this.dgvRevenue.Size = new System.Drawing.Size(1013, 369);
            this.dgvRevenue.TabIndex = 1;
            this.dgvRevenue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRevenue_CellContentClick);
            // 
            // lblBestSelling
            // 
            this.lblBestSelling.AutoSize = true;
            this.lblBestSelling.Location = new System.Drawing.Point(16, 578);
            this.lblBestSelling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBestSelling.Name = "lblBestSelling";
            this.lblBestSelling.Size = new System.Drawing.Size(96, 16);
            this.lblBestSelling.TabIndex = 2;
            this.lblBestSelling.Text = "Món chạy nhất:";
            // 
            // txtBestSelling
            // 
            this.txtBestSelling.Location = new System.Drawing.Point(133, 578);
            this.txtBestSelling.Margin = new System.Windows.Forms.Padding(4);
            this.txtBestSelling.Name = "txtBestSelling";
            this.txtBestSelling.Size = new System.Drawing.Size(265, 22);
            this.txtBestSelling.TabIndex = 3;
            // 
            // lblSlowestSelling
            // 
            this.lblSlowestSelling.AutoSize = true;
            this.lblSlowestSelling.Location = new System.Drawing.Point(467, 578);
            this.lblSlowestSelling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlowestSelling.Name = "lblSlowestSelling";
            this.lblSlowestSelling.Size = new System.Drawing.Size(126, 16);
            this.lblSlowestSelling.TabIndex = 4;
            this.lblSlowestSelling.Text = "Món bán chậm nhất:";
            // 
            // txtSlowestSelling
            // 
            this.txtSlowestSelling.Location = new System.Drawing.Point(613, 578);
            this.txtSlowestSelling.Margin = new System.Windows.Forms.Padding(4);
            this.txtSlowestSelling.Name = "txtSlowestSelling";
            this.txtSlowestSelling.Size = new System.Drawing.Size(265, 22);
            this.txtSlowestSelling.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(920, 640);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 37);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RevenueStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSlowestSelling);
            this.Controls.Add(this.lblSlowestSelling);
            this.Controls.Add(this.txtBestSelling);
            this.Controls.Add(this.lblBestSelling);
            this.Controls.Add(this.dgvRevenue);
            this.Controls.Add(this.groupBoxFilters);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RevenueStatistics";
            this.Text = "Thống kê doanh thu theo món";
            this.Load += new System.EventHandler(this.RevenueStatistics_Load);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.Label lblBestSelling;
        private System.Windows.Forms.TextBox txtBestSelling;
        private System.Windows.Forms.Label lblSlowestSelling;
        private System.Windows.Forms.TextBox txtSlowestSelling;
        private System.Windows.Forms.Button btnClose;
        

    }
}