using System;
using System.Windows.Forms;

//=============================================
//Author:		Jonathan Thomas Musiitwa
//Create date:  July-August 2018
//Description:	Hospital Drug Purchasing System with Predictive Analytics
//=============================================

namespace HDP_DBMSystem
{
    public partial class viewOrders : Form
    {
        public viewOrders()
        {
            InitializeComponent();
        }

        private void viewOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.hDPurchasingDataSet.Orders);

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
            new Management().Show();
            this.Hide();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            new Management().Show();
            this.Hide();
        }
    }
}
