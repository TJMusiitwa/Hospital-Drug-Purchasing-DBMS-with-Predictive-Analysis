namespace HDP_DBMSystem
{
    partial class ViewDrugs
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDrugs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sideMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelMgt = new System.Windows.Forms.Label();
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.labelReports = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.drugIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genericNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodofAdministrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDPurchasingDataSet = new HDP_DBMSystem.HDPurchasingDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hDPurchasingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.DrugTableAdapter();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSetBindingSource)).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(153, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(195, 17);
            label2.TabIndex = 8;
            label2.Text = "Search by drug generic name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 39);
            label1.TabIndex = 11;
            label1.Text = "View Drugs";
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
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSearch);
            this.splitContainer1.Panel2.Controls.Add(label2);
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
            this.labelMgt.Location = new System.Drawing.Point(10, 517);
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
            this.labelAnalytics.Location = new System.Drawing.Point(10, 307);
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
            this.labelReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelReports.ImageIndex = 0;
            this.labelReports.ImageList = this.sideMenuIcons;
            this.labelReports.Location = new System.Drawing.Point(10, 412);
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
            this.labelDashboard.Location = new System.Drawing.Point(10, 202);
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
            this.buttonReturn.Location = new System.Drawing.Point(664, 85);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(183, 32);
            this.buttonReturn.TabIndex = 10;
            this.buttonReturn.Text = "Return to Management";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(348, 90);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(183, 23);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drugIDDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.genericNameDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.methodofAdministrationDataGridViewTextBoxColumn,
            this.drugCostDataGridViewTextBoxColumn,
            this.drugDescriptionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.drugBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(0, 135);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Size = new System.Drawing.Size(895, 599);
            this.dataGridView2.TabIndex = 1;
            // 
            // drugIDDataGridViewTextBoxColumn
            // 
            this.drugIDDataGridViewTextBoxColumn.DataPropertyName = "Drug_ID";
            this.drugIDDataGridViewTextBoxColumn.HeaderText = "Drug_ID";
            this.drugIDDataGridViewTextBoxColumn.Name = "drugIDDataGridViewTextBoxColumn";
            this.drugIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "Brand_Name";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "Brand_Name";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genericNameDataGridViewTextBoxColumn
            // 
            this.genericNameDataGridViewTextBoxColumn.DataPropertyName = "Generic_Name";
            this.genericNameDataGridViewTextBoxColumn.HeaderText = "Generic_Name";
            this.genericNameDataGridViewTextBoxColumn.Name = "genericNameDataGridViewTextBoxColumn";
            this.genericNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dosageDataGridViewTextBoxColumn
            // 
            this.dosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage";
            this.dosageDataGridViewTextBoxColumn.HeaderText = "Dosage";
            this.dosageDataGridViewTextBoxColumn.Name = "dosageDataGridViewTextBoxColumn";
            this.dosageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // methodofAdministrationDataGridViewTextBoxColumn
            // 
            this.methodofAdministrationDataGridViewTextBoxColumn.DataPropertyName = "Method_of_Administration";
            this.methodofAdministrationDataGridViewTextBoxColumn.HeaderText = "Method_of_Administration";
            this.methodofAdministrationDataGridViewTextBoxColumn.Name = "methodofAdministrationDataGridViewTextBoxColumn";
            this.methodofAdministrationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drugCostDataGridViewTextBoxColumn
            // 
            this.drugCostDataGridViewTextBoxColumn.DataPropertyName = "Drug_Cost_$";
            this.drugCostDataGridViewTextBoxColumn.HeaderText = "Drug_Cost_$";
            this.drugCostDataGridViewTextBoxColumn.Name = "drugCostDataGridViewTextBoxColumn";
            this.drugCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drugDescriptionDataGridViewTextBoxColumn
            // 
            this.drugDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Drug_Description";
            this.drugDescriptionDataGridViewTextBoxColumn.HeaderText = "Drug_Description";
            this.drugDescriptionDataGridViewTextBoxColumn.Name = "drugDescriptionDataGridViewTextBoxColumn";
            this.drugDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(895, 734);
            this.dataGridView1.TabIndex = 0;
            // 
            // hDPurchasingDataSetBindingSource
            // 
            this.hDPurchasingDataSetBindingSource.DataSource = this.hDPurchasingDataSet;
            this.hDPurchasingDataSetBindingSource.Position = 0;
            // 
            // drugTableAdapter
            // 
            this.drugTableAdapter.ClearBeforeFill = true;
            // 
            // ViewDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 734);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewDrugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Drugs";
            this.Load += new System.EventHandler(this.ViewDrugs_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList sideMenuIcons;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelAnalytics;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource hDPurchasingDataSetBindingSource;
        private HDPurchasingDataSet hDPurchasingDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private HDPurchasingDataSetTableAdapters.DrugTableAdapter drugTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genericNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodofAdministrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelMgt;
    }
}