using System;
using System.Windows.Forms;

//=============================================
//Author:		Jonathan Thomas Musiitwa
//Create date:  July-August 2018
//Description:	Hospital Drug Purchasing System with Predictive Analytics
//=============================================

namespace HDP_DBMSystem
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void containerControl1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newDrug_Click(object sender, EventArgs e)
        {
            new New_Drug().Show();
            this.Hide();
            
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            new NewOrder().Show();
            this.Hide();
            
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            new NewUser().Show();
            this.Hide();
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewUsers_Click(object sender, EventArgs e)
        {
            new ViewUsers().Show();
            this.Hide();
            
        }

        private void viewDrugs_Click(object sender, EventArgs e)
        {

            new ViewDrugs().Show();
            this.Hide();
        }

        private void viewSuppliers_Click(object sender, EventArgs e)
        {

            new ViewSuppliers().Show();
            this.Hide();
        }

        private void modifyUser_Click(object sender, EventArgs e)
        {
            new ModifyUser().Show();
            this.Hide();
        }

        private void viewOrders_Click(object sender, EventArgs e)
        {
            new viewOrders().Show();
            this.Hide();
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void labelAnalytics_Click(object sender, EventArgs e)
        {
            new Analytics().Show();
            this.Hide();
        }

        private void labelReports_Click(object sender, EventArgs e)
        {
            new Reports().Show();
            this.Hide();
        }

        private void labelMgt_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void newSupplier_Click(object sender, EventArgs e)
        {
            new NewSupplier().Show();
            this.Hide();
        }

        private void modifyDrug_Click(object sender, EventArgs e)
        {
            new ModifyDrug().Show();
            this.Hide();
        }

        private void modifySupplier_Click(object sender, EventArgs e)
        {
            new ModifySuppliers().Show();
            this.Hide();
        }
    }
}
