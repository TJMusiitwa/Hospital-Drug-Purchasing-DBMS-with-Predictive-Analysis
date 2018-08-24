using System;
using System.Windows.Forms;


//=============================================
//Author:		Jonathan Thomas Musiitwa
//Create date:  July-August 2018
//Description:	Hospital Drug Purchasing System with Predictive Analytics
//=============================================

namespace HDP_DBMSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logoutButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void labelMgt_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Management().Show();
        }

        private void labelReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Reports().Show();
        }

        private void labelAnalytics_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Analytics().Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Sum_And_Average_Costs' table. You can move, or remove it, as needed.
            this.sum_And_Average_CostsTableAdapter.Fill(this.hDPurchasingDataSet.Sum_And_Average_Costs);
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.DrugPricingCost' table. You can move, or remove it, as needed.
            this.drugPricingCostTableAdapter.Fill(this.hDPurchasingDataSet.DrugPricingCost);
           
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.hDPurchasingDataSet.Orders);
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.DrugStock' table. You can move, or remove it, as needed.
            this.drugStockTableAdapter.Fill(this.hDPurchasingDataSet.DrugStock);

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void quickActionNewDrug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new New_Drug().Show();
        }

        private void quickactionViewDrugs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ViewDrugs().Show();
        }

        private void quickactionPlaceOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new NewOrder().Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartPie_Click(object sender, EventArgs e)
        {

        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
