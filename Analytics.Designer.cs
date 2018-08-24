namespace HDP_DBMSystem
{
    partial class Analytics
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytics));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelMgt = new System.Windows.Forms.Label();
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.labelReports = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPredict = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSQ = new System.Windows.Forms.TabPage();
            this.predictedValue = new System.Windows.Forms.TextBox();
            this.dependentVariable = new System.Windows.Forms.TextBox();
            this.algorithmGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonClustering = new System.Windows.Forms.RadioButton();
            this.radioButtonLR = new System.Windows.Forms.RadioButton();
            this.radioButtonANN = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.LinkLabel();
            this.pricingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pricingDataSet = new HDP_DBMSystem.PricingDataSet();
            this.tabPageAQ = new System.Windows.Forms.TabPage();
            this.algorithmGridView = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSQ.SuspendLayout();
            this.algorithmGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricingDataSet)).BeginInit();
            this.tabPageAQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.algorithmGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(22, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(301, 40);
            label1.TabIndex = 0;
            label1.Text = "Drug Purchasing Analytics";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(10, 90);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(121, 20);
            label3.TabIndex = 34;
            label3.Text = "Predicted Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(10, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(216, 20);
            label2.TabIndex = 31;
            label2.Text = "Please provide a pricing value";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = global::HDP_DBMSystem.Properties.Resources.purchase_order_clipart_icon_png_43;
            pictureBox1.Location = new System.Drawing.Point(54, 45);
            pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(122, 131);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-analyze-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-bar-chart-and-polyline.png");
            this.imageList1.Images.SetKeyName(2, "icons8-home.png");
            this.imageList1.Images.SetKeyName(3, "icons8-increasing-graph.png");
            this.imageList1.Images.SetKeyName(4, "icons8-management.png");
            this.imageList1.Images.SetKeyName(5, "icons8-settings.png");
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
            this.splitContainer1.Panel1.Controls.Add(pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.labelMgt);
            this.splitContainer1.Panel1.Controls.Add(this.labelAnalytics);
            this.splitContainer1.Panel1.Controls.Add(this.labelReports);
            this.splitContainer1.Panel1.Controls.Add(this.labelDashboard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.algorithmGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 734);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelMgt
            // 
            this.labelMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMgt.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMgt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMgt.ImageKey = "icons8-management.png";
            this.labelMgt.ImageList = this.imageList1;
            this.labelMgt.Location = new System.Drawing.Point(19, 488);
            this.labelMgt.Name = "labelMgt";
            this.labelMgt.Size = new System.Drawing.Size(193, 72);
            this.labelMgt.TabIndex = 18;
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
            this.labelAnalytics.ImageList = this.imageList1;
            this.labelAnalytics.Location = new System.Drawing.Point(19, 296);
            this.labelAnalytics.Name = "labelAnalytics";
            this.labelAnalytics.Size = new System.Drawing.Size(193, 72);
            this.labelAnalytics.TabIndex = 16;
            this.labelAnalytics.Text = "Analytics";
            this.labelAnalytics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelReports
            // 
            this.labelReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReports.ForeColor = System.Drawing.SystemColors.Window;
            this.labelReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelReports.ImageKey = "icons8-bar-chart-and-polyline.png";
            this.labelReports.ImageList = this.imageList1;
            this.labelReports.Location = new System.Drawing.Point(19, 392);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(193, 72);
            this.labelReports.TabIndex = 17;
            this.labelReports.Text = "Reports";
            this.labelReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelDashboard
            // 
            this.labelDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.SystemColors.Window;
            this.labelDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDashboard.ImageKey = "icons8-home.png";
            this.labelDashboard.ImageList = this.imageList1;
            this.labelDashboard.Location = new System.Drawing.Point(19, 200);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(193, 72);
            this.labelDashboard.TabIndex = 19;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.buttonPredict);
            this.panel2.Location = new System.Drawing.Point(43, 669);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 53);
            this.panel2.TabIndex = 29;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(22, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(131, 44);
            this.buttonClear.TabIndex = 36;
            this.buttonClear.Text = "Clear ";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPredict
            // 
            this.buttonPredict.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPredict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPredict.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPredict.Location = new System.Drawing.Point(255, 3);
            this.buttonPredict.Name = "buttonPredict";
            this.buttonPredict.Size = new System.Drawing.Size(131, 44);
            this.buttonPredict.TabIndex = 35;
            this.buttonPredict.Text = "Predict";
            this.buttonPredict.UseVisualStyleBackColor = false;
            this.buttonPredict.Click += new System.EventHandler(this.buttonPredict_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSQ);
            this.tabControl1.Controls.Add(this.tabPageAQ);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(31, 192);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 471);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPageSQ
            // 
            this.tabPageSQ.Controls.Add(this.predictedValue);
            this.tabPageSQ.Controls.Add(label2);
            this.tabPageSQ.Controls.Add(label3);
            this.tabPageSQ.Controls.Add(this.dependentVariable);
            this.tabPageSQ.Location = new System.Drawing.Point(4, 25);
            this.tabPageSQ.Name = "tabPageSQ";
            this.tabPageSQ.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQ.Size = new System.Drawing.Size(664, 442);
            this.tabPageSQ.TabIndex = 0;
            this.tabPageSQ.Text = "Singleton Query Result";
            this.tabPageSQ.UseVisualStyleBackColor = true;
            // 
            // predictedValue
            // 
            this.predictedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictedValue.Location = new System.Drawing.Point(288, 90);
            this.predictedValue.Multiline = true;
            this.predictedValue.Name = "predictedValue";
            this.predictedValue.ReadOnly = true;
            this.predictedValue.Size = new System.Drawing.Size(367, 79);
            this.predictedValue.TabIndex = 33;
            // 
            // dependentVariable
            // 
            this.dependentVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dependentVariable.Location = new System.Drawing.Point(288, 14);
            this.dependentVariable.Name = "dependentVariable";
            this.dependentVariable.Size = new System.Drawing.Size(367, 26);
            this.dependentVariable.TabIndex = 32;
            // 
            // algorithmGroupBox
            // 
            this.algorithmGroupBox.Controls.Add(this.radioButtonClustering);
            this.algorithmGroupBox.Controls.Add(this.radioButtonLR);
            this.algorithmGroupBox.Controls.Add(this.radioButtonANN);
            this.algorithmGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algorithmGroupBox.Location = new System.Drawing.Point(31, 108);
            this.algorithmGroupBox.Name = "algorithmGroupBox";
            this.algorithmGroupBox.Size = new System.Drawing.Size(668, 68);
            this.algorithmGroupBox.TabIndex = 30;
            this.algorithmGroupBox.TabStop = false;
            this.algorithmGroupBox.Text = "Choose algorithm to apply";
            // 
            // radioButtonClustering
            // 
            this.radioButtonClustering.AutoSize = true;
            this.radioButtonClustering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonClustering.Location = new System.Drawing.Point(474, 32);
            this.radioButtonClustering.Name = "radioButtonClustering";
            this.radioButtonClustering.Size = new System.Drawing.Size(89, 21);
            this.radioButtonClustering.TabIndex = 2;
            this.radioButtonClustering.TabStop = true;
            this.radioButtonClustering.Text = "Clustering";
            this.radioButtonClustering.UseVisualStyleBackColor = true;
            // 
            // radioButtonLR
            // 
            this.radioButtonLR.AutoSize = true;
            this.radioButtonLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLR.Location = new System.Drawing.Point(257, 32);
            this.radioButtonLR.Name = "radioButtonLR";
            this.radioButtonLR.Size = new System.Drawing.Size(150, 21);
            this.radioButtonLR.TabIndex = 1;
            this.radioButtonLR.TabStop = true;
            this.radioButtonLR.Text = "Logistic Regression";
            this.radioButtonLR.UseVisualStyleBackColor = true;
            // 
            // radioButtonANN
            // 
            this.radioButtonANN.AutoSize = true;
            this.radioButtonANN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonANN.Location = new System.Drawing.Point(28, 32);
            this.radioButtonANN.Name = "radioButtonANN";
            this.radioButtonANN.Size = new System.Drawing.Size(176, 21);
            this.radioButtonANN.TabIndex = 0;
            this.radioButtonANN.TabStop = true;
            this.radioButtonANN.Text = "Artificial Neural Network";
            this.radioButtonANN.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 98);
            this.panel1.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(799, 5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(66, 20);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.TabStop = true;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.logoutButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutButton_LinkClicked);
            // 
            // pricingDataSetBindingSource
            // 
            this.pricingDataSetBindingSource.DataSource = this.pricingDataSet;
            this.pricingDataSetBindingSource.Position = 0;
            // 
            // pricingDataSet
            // 
            this.pricingDataSet.DataSetName = "PricingDataSet";
            this.pricingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageAQ
            // 
            this.tabPageAQ.Controls.Add(this.algorithmGridView);
            this.tabPageAQ.Location = new System.Drawing.Point(4, 25);
            this.tabPageAQ.Name = "tabPageAQ";
            this.tabPageAQ.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAQ.Size = new System.Drawing.Size(664, 442);
            this.tabPageAQ.TabIndex = 1;
            this.tabPageAQ.Text = "All Results Query";
            this.tabPageAQ.UseVisualStyleBackColor = true;
            // 
            // algorithmGridView
            // 
            this.algorithmGridView.AllowUserToAddRows = false;
            this.algorithmGridView.AllowUserToDeleteRows = false;
            this.algorithmGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.algorithmGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.algorithmGridView.Location = new System.Drawing.Point(3, 3);
            this.algorithmGridView.Name = "algorithmGridView";
            this.algorithmGridView.ReadOnly = true;
            this.algorithmGridView.Size = new System.Drawing.Size(658, 436);
            this.algorithmGridView.TabIndex = 0;
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 734);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Analytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSQ.ResumeLayout(false);
            this.tabPageSQ.PerformLayout();
            this.algorithmGroupBox.ResumeLayout(false);
            this.algorithmGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricingDataSet)).EndInit();
            this.tabPageAQ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.algorithmGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelMgt;
        private System.Windows.Forms.Label labelAnalytics;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel logoutButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPredict;
        private System.Windows.Forms.TextBox predictedValue;
        private System.Windows.Forms.TextBox dependentVariable;
        private System.Windows.Forms.GroupBox algorithmGroupBox;
        private System.Windows.Forms.RadioButton radioButtonClustering;
        private System.Windows.Forms.RadioButton radioButtonLR;
        private System.Windows.Forms.RadioButton radioButtonANN;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSQ;
        private System.Windows.Forms.BindingSource pricingDataSetBindingSource;
        private PricingDataSet pricingDataSet;
        private System.Windows.Forms.TabPage tabPageAQ;
        private System.Windows.Forms.DataGridView algorithmGridView;
    }
}