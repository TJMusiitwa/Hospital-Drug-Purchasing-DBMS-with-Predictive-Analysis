namespace HDP_DBMSystem
{
    partial class Reports
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelMgt = new System.Windows.Forms.Label();
            this.sideMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.labelReports = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.logoutButton = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hDPurchasingDataSet = new HDP_DBMSystem.HDPurchasingDataSet();
            this.drugPricingCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugPricingCostTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.DrugPricingCostTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.OrdersTableAdapter();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugPricingCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = global::HDP_DBMSystem.Properties.Resources.purchase_order_clipart_icon_png_43;
            pictureBox1.Location = new System.Drawing.Point(52, 9);
            pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(122, 131);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(301, 40);
            label1.TabIndex = 0;
            label1.Text = "Reports";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.splitContainer1.Panel1.Controls.Add(pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.labelMgt);
            this.splitContainer1.Panel1.Controls.Add(this.labelAnalytics);
            this.splitContainer1.Panel1.Controls.Add(this.labelReports);
            this.splitContainer1.Panel1.Controls.Add(this.labelDashboard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 734);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelMgt
            // 
            this.labelMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMgt.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMgt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMgt.ImageKey = "icons8-management.png";
            this.labelMgt.ImageList = this.sideMenuIcons;
            this.labelMgt.Location = new System.Drawing.Point(9, 464);
            this.labelMgt.Name = "labelMgt";
            this.labelMgt.Size = new System.Drawing.Size(193, 72);
            this.labelMgt.TabIndex = 7;
            this.labelMgt.Text = "Management";
            this.labelMgt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelMgt.Click += new System.EventHandler(this.labelMgt_Click);
            // 
            // sideMenuIcons
            // 
            this.sideMenuIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sideMenuIcons.ImageStream")));
            this.sideMenuIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.sideMenuIcons.Images.SetKeyName(0, "icons8-bar-chart-and-polyline.png");
            this.sideMenuIcons.Images.SetKeyName(1, "icons8-analyze-32.png");
            this.sideMenuIcons.Images.SetKeyName(2, "icons8-home.png");
            this.sideMenuIcons.Images.SetKeyName(3, "icons8-management.png");
            this.sideMenuIcons.Images.SetKeyName(4, "icons8-settings.png");
            // 
            // labelAnalytics
            // 
            this.labelAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnalytics.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAnalytics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelAnalytics.ImageKey = "icons8-analyze-32.png";
            this.labelAnalytics.ImageList = this.sideMenuIcons;
            this.labelAnalytics.Location = new System.Drawing.Point(9, 266);
            this.labelAnalytics.Name = "labelAnalytics";
            this.labelAnalytics.Size = new System.Drawing.Size(193, 72);
            this.labelAnalytics.TabIndex = 5;
            this.labelAnalytics.Text = "Analytics";
            this.labelAnalytics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelAnalytics.Click += new System.EventHandler(this.labelAnalytics_Click);
            // 
            // labelReports
            // 
            this.labelReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReports.ForeColor = System.Drawing.SystemColors.Window;
            this.labelReports.Image = global::HDP_DBMSystem.Properties.Resources.icons8_bar_chart_and_polyline;
            this.labelReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelReports.Location = new System.Drawing.Point(9, 365);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(193, 72);
            this.labelReports.TabIndex = 6;
            this.labelReports.Text = "Reports";
            this.labelReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelReports.Click += new System.EventHandler(this.labelReports_Click);
            // 
            // labelDashboard
            // 
            this.labelDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDashboard.ImageKey = "icons8-home.png";
            this.labelDashboard.ImageList = this.sideMenuIcons;
            this.labelDashboard.Location = new System.Drawing.Point(9, 167);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(193, 72);
            this.labelDashboard.TabIndex = 8;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HDP_DBMSystem.Order Purchase Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(53, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(805, 418);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(819, 11);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(66, 20);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.TabStop = true;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.logoutButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutButton_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 76);
            this.panel1.TabIndex = 3;
            // 
            // hDPurchasingDataSet
            // 
            this.hDPurchasingDataSet.DataSetName = "HDPurchasingDataSet";
            this.hDPurchasingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugPricingCostBindingSource
            // 
            this.drugPricingCostBindingSource.DataMember = "DrugPricingCost";
            this.drugPricingCostBindingSource.DataSource = this.hDPurchasingDataSet;
            // 
            // drugPricingCostTableAdapter
            // 
            this.drugPricingCostTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.hDPurchasingDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 734);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugPricingCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelMgt;
        private System.Windows.Forms.Label labelAnalytics;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.ImageList sideMenuIcons;
        private System.Windows.Forms.LinkLabel logoutButton;
        private System.Windows.Forms.Panel panel1;
        private HDPurchasingDataSet hDPurchasingDataSet;
        private System.Windows.Forms.BindingSource drugPricingCostBindingSource;
        private HDPurchasingDataSetTableAdapters.DrugPricingCostTableAdapter drugPricingCostTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private HDPurchasingDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    }
}