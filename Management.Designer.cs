namespace HDP_DBMSystem
{
    partial class Management
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
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Panel panel3;
            System.Windows.Forms.Panel panel4;
            System.Windows.Forms.Panel panel5;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelMgt = new System.Windows.Forms.Label();
            this.sideMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.labelReports = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.viewSuppliers = new System.Windows.Forms.Button();
            this.viewOrders = new System.Windows.Forms.Button();
            this.viewDrugs = new System.Windows.Forms.Button();
            this.viewUsers = new System.Windows.Forms.Button();
            this.modifyUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.newOrder = new System.Windows.Forms.Button();
            this.modifySupplier = new System.Windows.Forms.Button();
            this.newSupplier = new System.Windows.Forms.Button();
            this.modifyDrug = new System.Windows.Forms.Button();
            this.newDrug = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel2.Location = new System.Drawing.Point(30, 198);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(411, 5);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel3.Location = new System.Drawing.Point(26, 313);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(411, 5);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel4.Location = new System.Drawing.Point(18, 446);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(411, 5);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel5.Location = new System.Drawing.Point(18, 557);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(411, 5);
            panel5.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = global::HDP_DBMSystem.Properties.Resources.purchase_order_clipart_icon_png_43;
            pictureBox1.Location = new System.Drawing.Point(47, 17);
            pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(122, 131);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
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
            this.splitContainer1.Panel1.Controls.Add(pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.labelMgt);
            this.splitContainer1.Panel1.Controls.Add(this.labelAnalytics);
            this.splitContainer1.Panel1.Controls.Add(this.labelReports);
            this.splitContainer1.Panel1.Controls.Add(this.labelDashboard);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.viewSuppliers);
            this.splitContainer1.Panel2.Controls.Add(this.viewOrders);
            this.splitContainer1.Panel2.Controls.Add(this.viewDrugs);
            this.splitContainer1.Panel2.Controls.Add(this.viewUsers);
            this.splitContainer1.Panel2.Controls.Add(this.modifyUser);
            this.splitContainer1.Panel2.Controls.Add(this.addUser);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(panel5);
            this.splitContainer1.Panel2.Controls.Add(this.newOrder);
            this.splitContainer1.Panel2.Controls.Add(this.modifySupplier);
            this.splitContainer1.Panel2.Controls.Add(this.newSupplier);
            this.splitContainer1.Panel2.Controls.Add(this.modifyDrug);
            this.splitContainer1.Panel2.Controls.Add(this.newDrug);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(panel4);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(panel3);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(panel2);
            this.splitContainer1.Panel2.Controls.Add(this.logoutButton);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 734);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelMgt
            // 
            this.labelMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMgt.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMgt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMgt.ImageKey = "icons8-management.png";
            this.labelMgt.ImageList = this.sideMenuIcons;
            this.labelMgt.Location = new System.Drawing.Point(12, 460);
            this.labelMgt.Name = "labelMgt";
            this.labelMgt.Size = new System.Drawing.Size(193, 72);
            this.labelMgt.TabIndex = 12;
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
            this.labelAnalytics.Location = new System.Drawing.Point(12, 268);
            this.labelAnalytics.Name = "labelAnalytics";
            this.labelAnalytics.Size = new System.Drawing.Size(193, 72);
            this.labelAnalytics.TabIndex = 10;
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
            this.labelReports.Location = new System.Drawing.Point(12, 364);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(193, 72);
            this.labelReports.TabIndex = 11;
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
            this.labelDashboard.Location = new System.Drawing.Point(12, 172);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(193, 72);
            this.labelDashboard.TabIndex = 13;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
            // 
            // viewSuppliers
            // 
            this.viewSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSuppliers.Location = new System.Drawing.Point(455, 346);
            this.viewSuppliers.Name = "viewSuppliers";
            this.viewSuppliers.Size = new System.Drawing.Size(163, 47);
            this.viewSuppliers.TabIndex = 23;
            this.viewSuppliers.Text = "View Suppliers";
            this.viewSuppliers.UseVisualStyleBackColor = true;
            this.viewSuppliers.Click += new System.EventHandler(this.viewSuppliers_Click);
            // 
            // viewOrders
            // 
            this.viewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrders.Location = new System.Drawing.Point(241, 471);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Size = new System.Drawing.Size(163, 47);
            this.viewOrders.TabIndex = 22;
            this.viewOrders.Text = "View Orders";
            this.viewOrders.UseVisualStyleBackColor = true;
            this.viewOrders.Click += new System.EventHandler(this.viewOrders_Click);
            // 
            // viewDrugs
            // 
            this.viewDrugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDrugs.Location = new System.Drawing.Point(455, 222);
            this.viewDrugs.Name = "viewDrugs";
            this.viewDrugs.Size = new System.Drawing.Size(163, 47);
            this.viewDrugs.TabIndex = 21;
            this.viewDrugs.Text = "View Drugs";
            this.viewDrugs.UseVisualStyleBackColor = true;
            this.viewDrugs.Click += new System.EventHandler(this.viewDrugs_Click);
            // 
            // viewUsers
            // 
            this.viewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUsers.Location = new System.Drawing.Point(455, 574);
            this.viewUsers.Name = "viewUsers";
            this.viewUsers.Size = new System.Drawing.Size(163, 47);
            this.viewUsers.TabIndex = 20;
            this.viewUsers.Text = "View Users";
            this.viewUsers.UseVisualStyleBackColor = true;
            this.viewUsers.Click += new System.EventHandler(this.viewUsers_Click);
            // 
            // modifyUser
            // 
            this.modifyUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyUser.Location = new System.Drawing.Point(241, 574);
            this.modifyUser.Name = "modifyUser";
            this.modifyUser.Size = new System.Drawing.Size(163, 47);
            this.modifyUser.TabIndex = 19;
            this.modifyUser.Text = "Modify User";
            this.modifyUser.UseVisualStyleBackColor = true;
            this.modifyUser.Click += new System.EventHandler(this.modifyUser_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.ForeColor = System.Drawing.SystemColors.Control;
            this.addUser.Location = new System.Drawing.Point(26, 574);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(148, 47);
            this.addUser.TabIndex = 18;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "User Management";
            // 
            // newOrder
            // 
            this.newOrder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.newOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.newOrder.Location = new System.Drawing.Point(26, 471);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(148, 47);
            this.newOrder.TabIndex = 15;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = false;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // modifySupplier
            // 
            this.modifySupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifySupplier.Location = new System.Drawing.Point(241, 346);
            this.modifySupplier.Name = "modifySupplier";
            this.modifySupplier.Size = new System.Drawing.Size(163, 47);
            this.modifySupplier.TabIndex = 14;
            this.modifySupplier.Text = "Modify Supplier";
            this.modifySupplier.UseVisualStyleBackColor = true;
            this.modifySupplier.Click += new System.EventHandler(this.modifySupplier_Click);
            // 
            // newSupplier
            // 
            this.newSupplier.BackColor = System.Drawing.SystemColors.HotTrack;
            this.newSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSupplier.ForeColor = System.Drawing.SystemColors.Control;
            this.newSupplier.Location = new System.Drawing.Point(26, 346);
            this.newSupplier.Name = "newSupplier";
            this.newSupplier.Size = new System.Drawing.Size(148, 47);
            this.newSupplier.TabIndex = 13;
            this.newSupplier.Text = "New Supplier";
            this.newSupplier.UseVisualStyleBackColor = false;
            this.newSupplier.Click += new System.EventHandler(this.newSupplier_Click);
            // 
            // modifyDrug
            // 
            this.modifyDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyDrug.Location = new System.Drawing.Point(241, 222);
            this.modifyDrug.Name = "modifyDrug";
            this.modifyDrug.Size = new System.Drawing.Size(163, 47);
            this.modifyDrug.TabIndex = 12;
            this.modifyDrug.Text = "Modify Drug";
            this.modifyDrug.UseVisualStyleBackColor = true;
            this.modifyDrug.Click += new System.EventHandler(this.modifyDrug_Click);
            // 
            // newDrug
            // 
            this.newDrug.BackColor = System.Drawing.SystemColors.HotTrack;
            this.newDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDrug.ForeColor = System.Drawing.SystemColors.Control;
            this.newDrug.Location = new System.Drawing.Point(26, 222);
            this.newDrug.Name = "newDrug";
            this.newDrug.Size = new System.Drawing.Size(148, 47);
            this.newDrug.TabIndex = 11;
            this.newDrug.Text = "New Drug";
            this.newDrug.UseVisualStyleBackColor = false;
            this.newDrug.Click += new System.EventHandler(this.newDrug_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order Management";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Supplier Management";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Drug Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please select the action you wish to complete";
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(815, 9);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(66, 20);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.TabStop = true;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Management";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 100);
            this.panel1.TabIndex = 4;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 734);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelMgt;
        private System.Windows.Forms.Label labelAnalytics;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel logoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button modifyDrug;
        private System.Windows.Forms.Button newDrug;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newSupplier;
        private System.Windows.Forms.Button modifySupplier;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Button modifyUser;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button viewSuppliers;
        private System.Windows.Forms.Button viewOrders;
        private System.Windows.Forms.Button viewDrugs;
        private System.Windows.Forms.Button viewUsers;
        private System.Windows.Forms.ImageList sideMenuIcons;
    }
}