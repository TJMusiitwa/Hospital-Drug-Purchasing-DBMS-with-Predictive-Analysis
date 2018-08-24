namespace HDP_DBMSystem
{
    partial class NewOrder
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
            System.Windows.Forms.LinkLabel linkLabel1;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelMgt = new System.Windows.Forms.Label();
            this.sideMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.labelReports = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drugOrderQuantity = new System.Windows.Forms.NumericUpDown();
            this.orderTotalCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.orderDrug = new System.Windows.Forms.ComboBox();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDPurchasingDataSet = new HDP_DBMSystem.HDPurchasingDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.drugPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.orderedBy = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.orderDateTime = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.OrdersTableAdapter();
            this.drugSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drug_SuppliersTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.Drug_SuppliersTableAdapter();
            this.usersTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.UsersTableAdapter();
            this.drugTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.DrugTableAdapter();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugOrderQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugSuppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.Enabled = false;
            linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkLabel1.LinkColor = System.Drawing.Color.Black;
            linkLabel1.Location = new System.Drawing.Point(7, 50);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(366, 46);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "New Order";
            linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = global::HDP_DBMSystem.Properties.Resources.purchase_order_clipart_icon_png_43;
            pictureBox1.Location = new System.Drawing.Point(38, 30);
            pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(122, 131);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Highlight;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.labelMgt);
            this.splitContainer1.Panel1.Controls.Add(this.labelAnalytics);
            this.splitContainer1.Panel1.Controls.Add(this.labelReports);
            this.splitContainer1.Panel1.Controls.Add(this.labelDashboard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.orderedBy);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(linkLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPlaceOrder);
            this.splitContainer1.Panel2.Controls.Add(this.cancelButton);
            this.splitContainer1.Panel2.Controls.Add(this.orderDateTime);
            this.splitContainer1.Panel2.Controls.Add(this.dateLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 734);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelMgt
            // 
            this.labelMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMgt.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMgt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMgt.ImageKey = "icons8-management.png";
            this.labelMgt.ImageList = this.sideMenuIcons;
            this.labelMgt.Location = new System.Drawing.Point(3, 513);
            this.labelMgt.Name = "labelMgt";
            this.labelMgt.Size = new System.Drawing.Size(193, 72);
            this.labelMgt.TabIndex = 7;
            this.labelMgt.Text = "Management";
            this.labelMgt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.labelAnalytics.Location = new System.Drawing.Point(3, 301);
            this.labelAnalytics.Name = "labelAnalytics";
            this.labelAnalytics.Size = new System.Drawing.Size(193, 72);
            this.labelAnalytics.TabIndex = 5;
            this.labelAnalytics.Text = "Analytics";
            this.labelAnalytics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelReports
            // 
            this.labelReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReports.ForeColor = System.Drawing.SystemColors.Window;
            this.labelReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelReports.ImageIndex = 0;
            this.labelReports.ImageList = this.sideMenuIcons;
            this.labelReports.Location = new System.Drawing.Point(3, 407);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(193, 72);
            this.labelReports.TabIndex = 6;
            this.labelReports.Text = "Reports";
            this.labelReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelDashboard
            // 
            this.labelDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDashboard.ImageKey = "icons8-home.png";
            this.labelDashboard.ImageList = this.sideMenuIcons;
            this.labelDashboard.Location = new System.Drawing.Point(3, 195);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(193, 72);
            this.labelDashboard.TabIndex = 8;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drugOrderQuantity);
            this.groupBox1.Controls.Add(this.orderTotalCost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.orderDrug);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.drugPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 241);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Description";
            // 
            // drugOrderQuantity
            // 
            this.drugOrderQuantity.CausesValidation = false;
            this.drugOrderQuantity.Location = new System.Drawing.Point(436, 87);
            this.drugOrderQuantity.Name = "drugOrderQuantity";
            this.drugOrderQuantity.Size = new System.Drawing.Size(330, 23);
            this.drugOrderQuantity.TabIndex = 27;
            this.drugOrderQuantity.ThousandsSeparator = true;
            this.drugOrderQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.drugOrderQuantity.ValueChanged += new System.EventHandler(this.drugOrderQuantity_ValueChanged);
            // 
            // orderTotalCost
            // 
            this.orderTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotalCost.Location = new System.Drawing.Point(436, 171);
            this.orderTotalCost.Name = "orderTotalCost";
            this.orderTotalCost.ReadOnly = true;
            this.orderTotalCost.Size = new System.Drawing.Size(330, 23);
            this.orderTotalCost.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total Cost";
            // 
            // orderDrug
            // 
            this.orderDrug.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.orderDrug.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orderDrug.DataSource = this.drugBindingSource;
            this.orderDrug.DisplayMember = "Brand_Name";
            this.orderDrug.FormattingEnabled = true;
            this.orderDrug.Location = new System.Drawing.Point(436, 38);
            this.orderDrug.Name = "orderDrug";
            this.orderDrug.Size = new System.Drawing.Size(330, 24);
            this.orderDrug.TabIndex = 24;
            this.orderDrug.ValueMember = "Brand_Name";
            this.orderDrug.SelectedIndexChanged += new System.EventHandler(this.orderDrug_SelectedIndexChanged);
            this.orderDrug.TextChanged += new System.EventHandler(this.orderDrug_TextChanged);
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataMember = "Drug";
            this.drugBindingSource.DataSource = this.hDPurchasingDataSet;
            // 
            // hDPurchasingDataSet
            // 
            this.hDPurchasingDataSet.DataSetName = "HDPurchasingDataSet";
            this.hDPurchasingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Drug Order";
            // 
            // drugPrice
            // 
            this.drugPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugPrice.Location = new System.Drawing.Point(436, 128);
            this.drugPrice.Name = "drugPrice";
            this.drugPrice.ReadOnly = true;
            this.drugPrice.Size = new System.Drawing.Size(330, 23);
            this.drugPrice.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Drug Price";
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Quantity";
            // 
            // orderedBy
            // 
            this.orderedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.orderedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orderedBy.DataSource = this.usersBindingSource;
            this.orderedBy.DisplayMember = "Users_Fname";
            this.orderedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderedBy.FormattingEnabled = true;
            this.orderedBy.Location = new System.Drawing.Point(499, 197);
            this.orderedBy.Name = "orderedBy";
            this.orderedBy.Size = new System.Drawing.Size(370, 24);
            this.orderedBy.TabIndex = 21;
            this.orderedBy.ValueMember = "Users_Fname";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.hDPurchasingDataSet;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ordered By";
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlaceOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPlaceOrder.Location = new System.Drawing.Point(580, 574);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(147, 38);
            this.buttonPlaceOrder.TabIndex = 11;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = false;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(184, 574);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(147, 38);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // orderDateTime
            // 
            this.orderDateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderDateTime.Location = new System.Drawing.Point(499, 147);
            this.orderDateTime.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.orderDateTime.Name = "orderDateTime";
            this.orderDateTime.Size = new System.Drawing.Size(370, 23);
            this.orderDateTime.TabIndex = 3;
            this.orderDateTime.Value = new System.DateTime(2018, 7, 2, 17, 50, 15, 0);
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(67, 136);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(167, 41);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Order Date";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Orders";
            this.bindingSource1.DataSource = this.hDPurchasingDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // drugSuppliersBindingSource
            // 
            this.drugSuppliersBindingSource.DataMember = "Drug_Suppliers";
            this.drugSuppliersBindingSource.DataSource = this.hDPurchasingDataSet;
            // 
            // drug_SuppliersTableAdapter
            // 
            this.drug_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // drugTableAdapter
            // 
            this.drugTableAdapter.ClearBeforeFill = true;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 734);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugOrderQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugSuppliersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList sideMenuIcons;
        private System.Windows.Forms.Label labelMgt;
        private System.Windows.Forms.Label labelAnalytics;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.DateTimePicker orderDateTime;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private HDPurchasingDataSet hDPurchasingDataSet;
        private HDPurchasingDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource drugSuppliersBindingSource;
        private HDPurchasingDataSetTableAdapters.Drug_SuppliersTableAdapter drug_SuppliersTableAdapter;
        private System.Windows.Forms.ComboBox orderedBy;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox drugPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox orderDrug;
        private HDPurchasingDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private HDPurchasingDataSetTableAdapters.DrugTableAdapter drugTableAdapter;
        private System.Windows.Forms.TextBox orderTotalCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown drugOrderQuantity;
    }
}