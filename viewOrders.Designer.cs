namespace HDP_DBMSystem
{
    partial class viewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewOrders));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelMgt = new System.Windows.Forms.Label();
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.labelReports = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugsOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDPurchasingDataSet = new HDP_DBMSystem.HDPurchasingDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sideMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.ordersTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.OrdersTableAdapter();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = global::HDP_DBMSystem.Properties.Resources.purchase_order_clipart_icon_png_43;
            pictureBox1.Location = new System.Drawing.Point(58, 39);
            pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(122, 131);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(204, 39);
            label1.TabIndex = 13;
            label1.Text = "View Orders";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.splitContainer1.Panel1.Controls.Add(this.labelMgt);
            this.splitContainer1.Panel1.Controls.Add(this.labelAnalytics);
            this.splitContainer1.Panel1.Controls.Add(this.labelReports);
            this.splitContainer1.Panel1.Controls.Add(this.labelDashboard);
            this.splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(label1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonReturn);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 734);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 1;
            // 
            // labelMgt
            // 
            this.labelMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMgt.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMgt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMgt.ImageKey = "icons8-management.png";
            this.labelMgt.ImageList = this.sideMenuIcons;
            this.labelMgt.Location = new System.Drawing.Point(11, 517);
            this.labelMgt.Name = "labelMgt";
            this.labelMgt.Size = new System.Drawing.Size(193, 72);
            this.labelMgt.TabIndex = 8;
            this.labelMgt.Text = "Management";
            this.labelMgt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelMgt.Click += new System.EventHandler(this.labelMgt_Click);
            // 
            // labelAnalytics
            // 
            this.labelAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnalytics.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAnalytics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelAnalytics.ImageKey = "icons8-analyze-32.png";
            this.labelAnalytics.ImageList = this.sideMenuIcons;
            this.labelAnalytics.Location = new System.Drawing.Point(11, 307);
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
            this.labelReports.Location = new System.Drawing.Point(11, 412);
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
            this.labelDashboard.Location = new System.Drawing.Point(11, 202);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(193, 72);
            this.labelDashboard.TabIndex = 9;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(664, 74);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(183, 32);
            this.buttonReturn.TabIndex = 12;
            this.buttonReturn.Text = "Return to Management";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.orderedByDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.drugsOrderedDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalcostDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ordersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 109);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(895, 625);
            this.dataGridView2.TabIndex = 1;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "Order_Number";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Order_Number";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderedByDataGridViewTextBoxColumn
            // 
            this.orderedByDataGridViewTextBoxColumn.DataPropertyName = "Ordered_By";
            this.orderedByDataGridViewTextBoxColumn.HeaderText = "Ordered_By";
            this.orderedByDataGridViewTextBoxColumn.Name = "orderedByDataGridViewTextBoxColumn";
            this.orderedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "Order_Date";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order_Date";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drugsOrderedDataGridViewTextBoxColumn
            // 
            this.drugsOrderedDataGridViewTextBoxColumn.DataPropertyName = "Drugs_Ordered";
            this.drugsOrderedDataGridViewTextBoxColumn.HeaderText = "Drugs_Ordered";
            this.drugsOrderedDataGridViewTextBoxColumn.Name = "drugsOrderedDataGridViewTextBoxColumn";
            this.drugsOrderedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalcostDataGridViewTextBoxColumn
            // 
            this.totalcostDataGridViewTextBoxColumn.DataPropertyName = "Total_cost";
            this.totalcostDataGridViewTextBoxColumn.HeaderText = "Total_cost";
            this.totalcostDataGridViewTextBoxColumn.Name = "totalcostDataGridViewTextBoxColumn";
            this.totalcostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.hDPurchasingDataSet;
            // 
            // hDPurchasingDataSet
            // 
            this.hDPurchasingDataSet.DataSetName = "HDPurchasingDataSet";
            this.hDPurchasingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(895, 734);
            this.dataGridView1.TabIndex = 0;
            // 
            // sideMenuIcons
            // 
            this.sideMenuIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sideMenuIcons.ImageStream")));
            this.sideMenuIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.sideMenuIcons.Images.SetKeyName(0, "icons8-bar-chart-and-polyline.png");
            this.sideMenuIcons.Images.SetKeyName(1, "icons8-analyze-32.png");
            this.sideMenuIcons.Images.SetKeyName(2, "icons8-home.png");
            this.sideMenuIcons.Images.SetKeyName(3, "icons8-management.png");
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // viewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 734);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Orders";
            this.Load += new System.EventHandler(this.viewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelMgt;
        private System.Windows.Forms.Label labelAnalytics;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ImageList sideMenuIcons;
        private HDPurchasingDataSet hDPurchasingDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private HDPurchasingDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugsOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonReturn;
    }
}