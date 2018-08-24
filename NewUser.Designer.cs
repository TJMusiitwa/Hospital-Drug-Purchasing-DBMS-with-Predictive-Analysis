namespace HDP_DBMSystem
{
    partial class NewUser
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.usersbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDPurchasingDataSet = new HDP_DBMSystem.HDPurchasingDataSet();
            this.usersTableAdapter = new HDP_DBMSystem.HDPurchasingDataSetTableAdapters.UsersTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelMgt = new System.Windows.Forms.Label();
            this.sideMenuIcons = new System.Windows.Forms.ImageList(this.components);
            this.labelAnalytics = new System.Windows.Forms.Label();
            this.labelReports = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.jobTitle = new System.Windows.Forms.ComboBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            linkLabel1.Text = "New User";
            linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(67, 145);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(149, 23);
            label3.TabIndex = 8;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(67, 361);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(149, 23);
            label2.TabIndex = 6;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(67, 289);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 23);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // dateLabel
            // 
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(67, 217);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(129, 23);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Password";
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(67, 430);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(129, 23);
            label4.TabIndex = 15;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(67, 497);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(129, 23);
            label5.TabIndex = 16;
            label5.Text = "Job Title";
            label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::HDP_DBMSystem.Properties.Resources.purchase_order_clipart_icon_png_43;
            pictureBox1.Location = new System.Drawing.Point(38, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(122, 131);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // usersbindingSource
            // 
            this.usersbindingSource.DataMember = "Users";
            this.usersbindingSource.DataSource = this.hDPurchasingDataSet;
            // 
            // hDPurchasingDataSet
            // 
            this.hDPurchasingDataSet.DataSetName = "HDPurchasingDataSet";
            this.hDPurchasingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Highlight;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitContainer1.Panel2.Controls.Add(this.genderBox);
            this.splitContainer1.Panel2.Controls.Add(this.jobTitle);
            this.splitContainer1.Panel2.Controls.Add(this.lastName);
            this.splitContainer1.Panel2.Controls.Add(this.firstName);
            this.splitContainer1.Panel2.Controls.Add(this.password);
            this.splitContainer1.Panel2.Controls.Add(this.usernameTextBox);
            this.splitContainer1.Panel2.Controls.Add(label5);
            this.splitContainer1.Panel2.Controls.Add(label4);
            this.splitContainer1.Panel2.Controls.Add(linkLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCreateUser);
            this.splitContainer1.Panel2.Controls.Add(this.cancelButton);
            this.splitContainer1.Panel2.Controls.Add(label3);
            this.splitContainer1.Panel2.Controls.Add(label2);
            this.splitContainer1.Panel2.Controls.Add(label1);
            this.splitContainer1.Panel2.Controls.Add(dateLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1167, 698);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 1;
            // 
            // labelMgt
            // 
            this.labelMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMgt.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMgt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMgt.ImageKey = "icons8-management.png";
            this.labelMgt.ImageList = this.sideMenuIcons;
            this.labelMgt.Location = new System.Drawing.Point(3, 449);
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
            this.labelAnalytics.Location = new System.Drawing.Point(3, 267);
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
            this.labelReports.Location = new System.Drawing.Point(3, 358);
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
            this.labelDashboard.Location = new System.Drawing.Point(3, 176);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(193, 72);
            this.labelDashboard.TabIndex = 8;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
            // 
            // genderBox
            // 
            this.genderBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.genderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genderBox.Location = new System.Drawing.Point(556, 430);
            this.genderBox.MaxLength = 1;
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(284, 28);
            this.genderBox.TabIndex = 24;
            // 
            // jobTitle
            // 
            this.jobTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.jobTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.jobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitle.FormattingEnabled = true;
            this.jobTitle.Items.AddRange(new object[] {
            "Pharmacist\t",
            "Doctor",
            "Administrator",
            "Clerk",
            "Accountant"});
            this.jobTitle.Location = new System.Drawing.Point(556, 497);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(284, 28);
            this.jobTitle.TabIndex = 23;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(556, 358);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(284, 26);
            this.lastName.TabIndex = 20;
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(556, 286);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(284, 26);
            this.firstName.TabIndex = 19;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(556, 214);
            this.password.MaxLength = 128;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(284, 26);
            this.password.TabIndex = 18;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(556, 142);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(284, 26);
            this.usernameTextBox.TabIndex = 17;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateUser.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreateUser.Location = new System.Drawing.Point(579, 620);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(147, 38);
            this.buttonCreateUser.TabIndex = 11;
            this.buttonCreateUser.Text = "Create User";
            this.buttonCreateUser.UseVisualStyleBackColor = false;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(186, 620);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(147, 38);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 698);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDPurchasingDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource usersbindingSource;
        private HDPurchasingDataSet hDPurchasingDataSet;
        private HDPurchasingDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelMgt;
        private System.Windows.Forms.Label labelAnalytics;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.ComboBox jobTitle;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.ImageList sideMenuIcons;
    }
}