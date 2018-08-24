namespace HDP_DBMSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelMgt = new System.Windows.Forms.Label();
            this.sideMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.labelReports = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sumAndAverageCostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDPurchasingDataSet = new HDP_DBMSystem.HDPurchasingDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugsOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quickactionPlaceOrder = new System.Windows.Forms.LinkLabel();
            this.quickactionViewDrugs = new System.Windows.Forms.LinkLabel();
            this.quickActionNewDrug = new System.Windows.Forms.LinkLabel();
            this.logoutButton = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.drugStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugStockTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.DrugStockTableAdapter();
            this.ordersTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.OrdersTableAdapter();
            this.drugPricingCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugPricingCostTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.DrugPricingCostTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sum_And_Average_CostsTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.Sum_And_Average_CostsTableAdapter();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumAndAverageCostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugPricingCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = global::HDP_DBMSystem.Properties.Resources.purchase_order_clipart_icon_png_43;
            pictureBox1.Location = new System.Drawing.Point(38, 9);
            pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(122, 131);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(301, 40);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(2, 3);
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.logoutButton);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1118, 727);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 1;
            // 
            // labelMgt
            // 
            this.labelMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMgt.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMgt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMgt.ImageKey = "icons8-management.png";
            this.labelMgt.ImageList = this.sideMenuIcons;
            this.labelMgt.Location = new System.Drawing.Point(3, 488);
            this.labelMgt.Name = "labelMgt";
            this.labelMgt.Size = new System.Drawing.Size(193, 72);
            this.labelMgt.TabIndex = 3;
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
            this.labelAnalytics.Location = new System.Drawing.Point(3, 278);
            this.labelAnalytics.Name = "labelAnalytics";
            this.labelAnalytics.Size = new System.Drawing.Size(193, 72);
            this.labelAnalytics.TabIndex = 1;
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
            this.labelReports.Location = new System.Drawing.Point(3, 383);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(193, 72);
            this.labelReports.TabIndex = 2;
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
            this.labelDashboard.Location = new System.Drawing.Point(3, 173);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(193, 72);
            this.labelDashboard.TabIndex = 3;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chart2);
            this.groupBox3.Location = new System.Drawing.Point(439, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 266);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.DataSource = this.sumAndAverageCostsBindingSource;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(6, 13);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sum12";
            series1.YValueMembers = "Total_Sum_2012";
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sum13";
            series2.YValueMembers = "Total_Sum_2013";
            series2.YValuesPerPoint = 2;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Sum14";
            series3.YValueMembers = "Total_Sum_2014";
            series3.YValuesPerPoint = 2;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Sum15";
            series4.YValueMembers = "Total_Sum_2015";
            series4.YValuesPerPoint = 2;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Sum16";
            series5.YValueMembers = "Total_Sum_2016";
            series5.YValuesPerPoint = 2;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart2.Series.Add(series1);
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(466, 247);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title1.Name = "Title1";
            title1.Text = "Chart Showing Total Sum of Average Sales Pricing";
            this.chart2.Titles.Add(title1);
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // sumAndAverageCostsBindingSource
            // 
            this.sumAndAverageCostsBindingSource.DataMember = "Sum_And_Average_Costs";
            this.sumAndAverageCostsBindingSource.DataSource = this.hDPurchasingDataSet;
            // 
            // hDPurchasingDataSet
            // 
            this.hDPurchasingDataSet.DataSetName = "HDPurchasingDataSet";
            this.hDPurchasingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 277);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Latest Orders";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderedByDataGridViewTextBoxColumn,
            this.drugsOrderedDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalcostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(410, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderedByDataGridViewTextBoxColumn
            // 
            this.orderedByDataGridViewTextBoxColumn.DataPropertyName = "Ordered_By";
            this.orderedByDataGridViewTextBoxColumn.HeaderText = "Ordered_By";
            this.orderedByDataGridViewTextBoxColumn.Name = "orderedByDataGridViewTextBoxColumn";
            this.orderedByDataGridViewTextBoxColumn.ReadOnly = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quickactionPlaceOrder);
            this.groupBox1.Controls.Add(this.quickactionViewDrugs);
            this.groupBox1.Controls.Add(this.quickActionNewDrug);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Actions";
            // 
            // quickactionPlaceOrder
            // 
            this.quickactionPlaceOrder.AutoSize = true;
            this.quickactionPlaceOrder.Location = new System.Drawing.Point(254, 23);
            this.quickactionPlaceOrder.Name = "quickactionPlaceOrder";
            this.quickactionPlaceOrder.Size = new System.Drawing.Size(150, 17);
            this.quickactionPlaceOrder.TabIndex = 2;
            this.quickactionPlaceOrder.TabStop = true;
            this.quickactionPlaceOrder.Text = "Place New Drug Order";
            this.quickactionPlaceOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quickactionPlaceOrder_LinkClicked);
            // 
            // quickactionViewDrugs
            // 
            this.quickactionViewDrugs.AutoSize = true;
            this.quickactionViewDrugs.Location = new System.Drawing.Point(135, 23);
            this.quickactionViewDrugs.Name = "quickactionViewDrugs";
            this.quickactionViewDrugs.Size = new System.Drawing.Size(105, 17);
            this.quickactionViewDrugs.TabIndex = 1;
            this.quickactionViewDrugs.TabStop = true;
            this.quickactionViewDrugs.Text = "View Drugs List";
            this.quickactionViewDrugs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quickactionViewDrugs_LinkClicked);
            // 
            // quickActionNewDrug
            // 
            this.quickActionNewDrug.AutoSize = true;
            this.quickActionNewDrug.Location = new System.Drawing.Point(22, 23);
            this.quickActionNewDrug.Name = "quickActionNewDrug";
            this.quickActionNewDrug.Size = new System.Drawing.Size(97, 17);
            this.quickActionNewDrug.TabIndex = 0;
            this.quickActionNewDrug.TabStop = true;
            this.quickActionNewDrug.Text = "Add new Drug";
            this.quickActionNewDrug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quickActionNewDrug_LinkClicked);
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(843, 9);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(66, 20);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.TabStop = true;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.logoutButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutButton_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(label1);
            this.panel3.Location = new System.Drawing.Point(4, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(921, 69);
            this.panel3.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Location = new System.Drawing.Point(20, 420);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(860, 292);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.drugStockBindingSource;
            legend2.Name = "Stock Count";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(10, 13);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Legend = "Stock Count";
            series6.Name = "Stock Count";
            series6.XValueMember = "Last_PurchaseDate";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.YValueMembers = "Stock_Count";
            series6.YValuesPerPoint = 4;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(844, 273);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            title2.Name = "Title1";
            title2.Text = "A Chart of Stock Count Against Time";
            this.chart1.Titles.Add(title2);
            // 
            // drugStockBindingSource
            // 
            this.drugStockBindingSource.DataMember = "DrugStock";
            this.drugStockBindingSource.DataSource = this.hDPurchasingDataSet;
            // 
            // drugStockTableAdapter
            // 
            this.drugStockTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
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
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Sum_And_Average_Costs";
            this.bindingSource1.DataSource = this.hDPurchasingDataSet;
            // 
            // sum_And_Average_CostsTableAdapter
            // 
            this.sum_And_Average_CostsTableAdapter.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1121, 734);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumAndAverageCostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugPricingCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel logoutButton;
        private System.Windows.Forms.ImageList sideMenuIcons;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Label labelMgt;
        private System.Windows.Forms.Label labelAnalytics;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel quickactionPlaceOrder;
        private System.Windows.Forms.LinkLabel quickactionViewDrugs;
        private System.Windows.Forms.LinkLabel quickActionNewDrug;
        private HDPurchasingDataSet hDPurchasingDataSet;
        private System.Windows.Forms.BindingSource drugStockBindingSource;
        private HDPurchasingDataSetTableAdapters.DrugStockTableAdapter drugStockTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private HDPurchasingDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugsOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource drugPricingCostBindingSource;
        private HDPurchasingDataSetTableAdapters.DrugPricingCostTableAdapter drugPricingCostTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private HDPurchasingDataSetTableAdapters.Sum_And_Average_CostsTableAdapter sum_And_Average_CostsTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource sumAndAverageCostsBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}