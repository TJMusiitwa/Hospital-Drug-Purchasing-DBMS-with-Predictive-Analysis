namespace HDP_DBMSystem
{
    partial class ModifyDrug
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyDrug));
            this.deleteUser = new System.Windows.Forms.Button();
            this.labelReports = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.sideMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.dosageTextBox = new System.Windows.Forms.TextBox();
            this.genericName = new System.Windows.Forms.TextBox();
            this.brandName = new System.Windows.Forms.TextBox();
            this.labelMgt = new System.Windows.Forms.Label();
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.updateDrug = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBoxSearchDrug = new System.Windows.Forms.ComboBox();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDPurchasingDataSet = new HDP_DBMSystem.HDPurchasingDataSet();
            this.drugDescription = new System.Windows.Forms.TextBox();
            this.drugCost = new System.Windows.Forms.TextBox();
            this.drugTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.DrugTableAdapter();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(32, 225);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(149, 23);
            label3.TabIndex = 24;
            label3.Text = "Brand Name";
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(32, 359);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(159, 41);
            label5.TabIndex = 22;
            label5.Text = "Dosage";
            // 
            // dateLabel
            // 
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(32, 292);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(159, 23);
            dateLabel.TabIndex = 21;
            dateLabel.Text = "Generic Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(31, 105);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(338, 17);
            label2.TabIndex = 3;
            label2.Text = "Enter the brand name of the drug you wish to modify";
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = global::HDP_DBMSystem.Properties.Resources.purchase_order_clipart_icon_png_43;
            pictureBox1.Location = new System.Drawing.Point(54, 10);
            pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(122, 131);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(24, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(200, 39);
            label1.TabIndex = 0;
            label1.Text = "Modify Drug";
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(32, 507);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(159, 31);
            label6.TabIndex = 33;
            label6.Text = "Drug Description";
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(32, 433);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(159, 30);
            label7.TabIndex = 32;
            label7.Text = "Drug Cost";
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.Color.Red;
            this.deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUser.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteUser.Location = new System.Drawing.Point(340, 662);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(147, 38);
            this.deleteUser.TabIndex = 31;
            this.deleteUser.Text = "Delete Drug";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // labelReports
            // 
            this.labelReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReports.ForeColor = System.Drawing.SystemColors.Window;
            this.labelReports.Image = global::HDP_DBMSystem.Properties.Resources.icons8_bar_chart_and_polyline;
            this.labelReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelReports.Location = new System.Drawing.Point(21, 391);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(193, 72);
            this.labelReports.TabIndex = 18;
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
            this.labelDashboard.Location = new System.Drawing.Point(21, 181);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(193, 72);
            this.labelDashboard.TabIndex = 20;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
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
            // dosageTextBox
            // 
            this.dosageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosageTextBox.Location = new System.Drawing.Point(505, 359);
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(310, 26);
            this.dosageTextBox.TabIndex = 27;
            // 
            // genericName
            // 
            this.genericName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericName.Location = new System.Drawing.Point(505, 291);
            this.genericName.MaxLength = 128;
            this.genericName.Name = "genericName";
            this.genericName.Size = new System.Drawing.Size(310, 26);
            this.genericName.TabIndex = 26;
            // 
            // brandName
            // 
            this.brandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandName.Location = new System.Drawing.Point(505, 223);
            this.brandName.Name = "brandName";
            this.brandName.Size = new System.Drawing.Size(310, 26);
            this.brandName.TabIndex = 25;
            // 
            // labelMgt
            // 
            this.labelMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMgt.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMgt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMgt.ImageKey = "icons8-management.png";
            this.labelMgt.ImageList = this.sideMenuIcons;
            this.labelMgt.Location = new System.Drawing.Point(21, 496);
            this.labelMgt.Name = "labelMgt";
            this.labelMgt.Size = new System.Drawing.Size(193, 72);
            this.labelMgt.TabIndex = 19;
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
            this.labelAnalytics.Location = new System.Drawing.Point(21, 286);
            this.labelAnalytics.Name = "labelAnalytics";
            this.labelAnalytics.Size = new System.Drawing.Size(193, 72);
            this.labelAnalytics.TabIndex = 17;
            this.labelAnalytics.Text = "Analytics";
            this.labelAnalytics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelAnalytics.Click += new System.EventHandler(this.labelAnalytics_Click);
            // 
            // updateDrug
            // 
            this.updateDrug.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDrug.ForeColor = System.Drawing.SystemColors.Control;
            this.updateDrug.Location = new System.Drawing.Point(668, 662);
            this.updateDrug.Name = "updateDrug";
            this.updateDrug.Size = new System.Drawing.Size(147, 38);
            this.updateDrug.TabIndex = 30;
            this.updateDrug.Text = "Update";
            this.updateDrug.UseVisualStyleBackColor = false;
            this.updateDrug.Click += new System.EventHandler(this.updateDrug_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(32, 662);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(147, 38);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Image = global::HDP_DBMSystem.Properties.Resources.icons8_search_32;
            this.searchButton.Location = new System.Drawing.Point(499, 128);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(38, 39);
            this.searchButton.TabIndex = 2;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSearchDrug);
            this.splitContainer1.Panel2.Controls.Add(this.drugDescription);
            this.splitContainer1.Panel2.Controls.Add(this.drugCost);
            this.splitContainer1.Panel2.Controls.Add(label6);
            this.splitContainer1.Panel2.Controls.Add(label7);
            this.splitContainer1.Panel2.Controls.Add(this.deleteUser);
            this.splitContainer1.Panel2.Controls.Add(this.updateDrug);
            this.splitContainer1.Panel2.Controls.Add(this.cancelButton);
            this.splitContainer1.Panel2.Controls.Add(this.dosageTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.genericName);
            this.splitContainer1.Panel2.Controls.Add(this.brandName);
            this.splitContainer1.Panel2.Controls.Add(label3);
            this.splitContainer1.Panel2.Controls.Add(label5);
            this.splitContainer1.Panel2.Controls.Add(dateLabel);
            this.splitContainer1.Panel2.Controls.Add(label2);
            this.splitContainer1.Panel2.Controls.Add(this.searchButton);
            this.splitContainer1.Panel2.Controls.Add(label1);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 734);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 2;
            // 
            // comboBoxSearchDrug
            // 
            this.comboBoxSearchDrug.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSearchDrug.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSearchDrug.DataSource = this.drugBindingSource;
            this.comboBoxSearchDrug.DisplayMember = "Brand_Name";
            this.comboBoxSearchDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchDrug.FormattingEnabled = true;
            this.comboBoxSearchDrug.Location = new System.Drawing.Point(34, 133);
            this.comboBoxSearchDrug.Name = "comboBoxSearchDrug";
            this.comboBoxSearchDrug.Size = new System.Drawing.Size(442, 28);
            this.comboBoxSearchDrug.TabIndex = 36;
            this.comboBoxSearchDrug.ValueMember = "Brand_Name";
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
            // drugDescription
            // 
            this.drugDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugDescription.Location = new System.Drawing.Point(505, 503);
            this.drugDescription.Multiline = true;
            this.drugDescription.Name = "drugDescription";
            this.drugDescription.Size = new System.Drawing.Size(310, 104);
            this.drugDescription.TabIndex = 35;
            // 
            // drugCost
            // 
            this.drugCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugCost.Location = new System.Drawing.Point(505, 435);
            this.drugCost.Name = "drugCost";
            this.drugCost.Size = new System.Drawing.Size(310, 26);
            this.drugCost.TabIndex = 34;
            // 
            // drugTableAdapter
            // 
            this.drugTableAdapter.ClearBeforeFill = true;
            // 
            // ModifyDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 734);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModifyDrug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyDrug";
            this.Load += new System.EventHandler(this.ModifyDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.ImageList sideMenuIcons;
        private System.Windows.Forms.TextBox dosageTextBox;
        private System.Windows.Forms.TextBox genericName;
        private System.Windows.Forms.TextBox brandName;
        private System.Windows.Forms.Label labelMgt;
        private System.Windows.Forms.Label labelAnalytics;
        private System.Windows.Forms.Button updateDrug;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private HDPurchasingDataSet hDPurchasingDataSet;
        private System.Windows.Forms.TextBox drugDescription;
        private System.Windows.Forms.TextBox drugCost;
        private System.Windows.Forms.ComboBox comboBoxSearchDrug;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private HDPurchasingDataSetTableAdapters.DrugTableAdapter drugTableAdapter;
    }
}