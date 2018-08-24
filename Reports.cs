using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

//=============================================
//Author:		Jonathan Thomas Musiitwa
//Create date:  July-August 2018
//Description:	Hospital Drug Purchasing System with Predictive Analytics
//=============================================

namespace HDP_DBMSystem
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void logoutButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void labelAnalytics_Click(object sender, EventArgs e)
        {
            new Analytics().Show();
            this.Hide();
        }

        private void labelReports_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void labelMgt_Click(object sender, EventArgs e)
        {
            new Management().Show();
            this.Hide();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.hDPurchasingDataSet.Orders);
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.DrugPricingCost' table. You can move, or remove it, as needed.
            this.drugPricingCostTableAdapter.Fill(this.hDPurchasingDataSet.DrugPricingCost);          

        }

        private void fillOrderReportToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.FillOrderReport(this.hDPurchasingDataSet.Orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            DataTable table = new DataTable(hDPurchasingDataSet.Orders.ToString());
            var reportAdapter = new HDPurchasingDataSetTableAdapters.OrdersTableAdapter();
            reportAdapter.Fill(hDPurchasingDataSet.Orders);
            ReportDataSource reportDataSource = new ReportDataSource("dataset", table);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.ReportPath = "C:/Users/TJ Musiitwa/Desktop/Assignments/Level 3/DBA-FYP/System/HDP-DBMSystem/HDP-DBMSystem/Order Purchase Report.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
