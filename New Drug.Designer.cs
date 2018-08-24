namespace HDP_DBMSystem
{
    partial class New_Drug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Drug));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMgt = new System.Windows.Forms.Label();
            this.sideMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.labelReports = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.moaList = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.dosageInfo = new System.Windows.Forms.TextBox();
            this.genericName = new System.Windows.Forms.TextBox();
            this.brandName = new System.Windows.Forms.TextBox();
            this.drugProductID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.LinkLabel();
            this.newdrugbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDPurchasingDataSet = new HDP_DBMSystem.HDPurchasingDataSet();
            this.drugTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.DrugTableAdapter();
            this.drugPrice = new System.Windows.Forms.NumericUpDown();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdrugbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.Enabled = false;
            linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkLabel1.LinkColor = System.Drawing.Color.Black;
            linkLabel1.Location = new System.Drawing.Point(7, 66);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(366, 46);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "New Drug";
            linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
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
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.labelMgt);
            this.splitContainer1.Panel1.Controls.Add(this.labelAnalytics);
            this.splitContainer1.Panel1.Controls.Add(this.labelReports);
            this.splitContainer1.Panel1.Controls.Add(this.labelDashboard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.drugPrice);
            this.splitContainer1.Panel2.Controls.Add(this.moaList);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2.Controls.Add(this.buttonReset);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionText);
            this.splitContainer1.Panel2.Controls.Add(this.dosageInfo);
            this.splitContainer1.Panel2.Controls.Add(this.genericName);
            this.splitContainer1.Panel2.Controls.Add(this.brandName);
            this.splitContainer1.Panel2.Controls.Add(this.drugProductID);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.logoutButton);
            this.splitContainer1.Panel2.Controls.Add(linkLabel1);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 734);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HDP_DBMSystem.Properties.Resources.purchase_order_clipart_icon_png_43;
            this.pictureBox1.Location = new System.Drawing.Point(45, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // labelMgt
            // 
            this.labelMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMgt.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMgt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMgt.ImageKey = "icons8-management.png";
            this.labelMgt.ImageList = this.sideMenuIcons;
            this.labelMgt.Location = new System.Drawing.Point(16, 517);
            this.labelMgt.Name = "labelMgt";
            this.labelMgt.Size = new System.Drawing.Size(193, 72);
            this.labelMgt.TabIndex = 13;
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
            this.labelAnalytics.Location = new System.Drawing.Point(16, 293);
            this.labelAnalytics.Name = "labelAnalytics";
            this.labelAnalytics.Size = new System.Drawing.Size(193, 72);
            this.labelAnalytics.TabIndex = 11;
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
            this.labelReports.Location = new System.Drawing.Point(16, 405);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(193, 72);
            this.labelReports.TabIndex = 12;
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
            this.labelDashboard.Location = new System.Drawing.Point(16, 181);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(193, 72);
            this.labelDashboard.TabIndex = 14;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
            // 
            // moaList
            // 
            this.moaList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.moaList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.moaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moaList.FormattingEnabled = true;
            this.moaList.Items.AddRange(new object[] {
            "Injection",
            "Inhalation",
            "Oral",
            "Subcutaneous",
            "Other"});
            this.moaList.Location = new System.Drawing.Point(494, 509);
            this.moaList.Name = "moaList";
            this.moaList.Size = new System.Drawing.Size(367, 28);
            this.moaList.TabIndex = 34;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Location = new System.Drawing.Point(703, 632);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(158, 55);
            this.buttonSave.TabIndex = 33;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(353, 632);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(158, 55);
            this.buttonReset.TabIndex = 32;
            this.buttonReset.Text = "Reset Form";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(14, 632);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(147, 55);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionText.Location = new System.Drawing.Point(494, 385);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(367, 92);
            this.descriptionText.TabIndex = 28;
            // 
            // dosageInfo
            // 
            this.dosageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosageInfo.Location = new System.Drawing.Point(494, 327);
            this.dosageInfo.Name = "dosageInfo";
            this.dosageInfo.Size = new System.Drawing.Size(367, 26);
            this.dosageInfo.TabIndex = 27;
            // 
            // genericName
            // 
            this.genericName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericName.Location = new System.Drawing.Point(494, 269);
            this.genericName.Name = "genericName";
            this.genericName.Size = new System.Drawing.Size(367, 26);
            this.genericName.TabIndex = 26;
            // 
            // brandName
            // 
            this.brandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandName.Location = new System.Drawing.Point(494, 211);
            this.brandName.Name = "brandName";
            this.brandName.Size = new System.Drawing.Size(367, 26);
            this.brandName.TabIndex = 25;
            // 
            // drugProductID
            // 
            this.drugProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugProductID.Location = new System.Drawing.Point(494, 153);
            this.drugProductID.Name = "drugProductID";
            this.drugProductID.Size = new System.Drawing.Size(367, 26);
            this.drugProductID.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 570);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Drug Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Method Of Administration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dosage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Generic Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Brand Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Drug Product ID";
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.logoutButton.Location = new System.Drawing.Point(1150, 9);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(66, 20);
            this.logoutButton.TabIndex = 16;
            this.logoutButton.TabStop = true;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newdrugbindingSource
            // 
            this.newdrugbindingSource.DataMember = "Drug";
            this.newdrugbindingSource.DataSource = this.hDPurchasingDataSet;
            // 
            // hDPurchasingDataSet
            // 
            this.hDPurchasingDataSet.DataSetName = "HDPurchasingDataSet";
            this.hDPurchasingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugTableAdapter
            // 
            this.drugTableAdapter.ClearBeforeFill = true;
            // 
            // drugPrice
            // 
            this.drugPrice.DecimalPlaces = 2;
            this.drugPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugPrice.Location = new System.Drawing.Point(494, 569);
            this.drugPrice.Name = "drugPrice";
            this.drugPrice.Size = new System.Drawing.Size(367, 23);
            this.drugPrice.TabIndex = 35;
            this.drugPrice.ThousandsSeparator = true;
            // 
            // New_Drug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 734);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Drug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Drug";
            this.Load += new System.EventHandler(this.New_Drug_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdrugbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMgt;
        private System.Windows.Forms.Label labelAnalytics;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.ImageList sideMenuIcons;
        private System.Windows.Forms.LinkLabel logoutButton;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox dosageInfo;
        private System.Windows.Forms.TextBox genericName;
        private System.Windows.Forms.TextBox brandName;
        private System.Windows.Forms.TextBox drugProductID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource newdrugbindingSource;
        private HDPurchasingDataSet hDPurchasingDataSet;
        private HDPurchasingDataSetTableAdapters.DrugTableAdapter drugTableAdapter;
        private System.Windows.Forms.ComboBox moaList;
        private System.Windows.Forms.NumericUpDown drugPrice;
    }
}