using System;
using System.Windows.Forms;

//=============================================
//Author:		Jonathan Thomas Musiitwa
//Create date:  July-August 2018
//Description:	Hospital Drug Purchasing System with Predictive Analytics
//=============================================

namespace HDP_DBMSystem
{
    public partial class NewSupplier : Form
    {
        public NewSupplier()
        {
            InitializeComponent();
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void labelAnalytics_Click(object sender, EventArgs e)
        {
            new Analytics().Show();
            this.Hide();
        }

        private void labelReports_Click(object sender, EventArgs e)
        {
            new Reports().Hide();
            this.Hide();
        }

        private void labelMgt_Click(object sender, EventArgs e)
        {
            new Management().Show();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            new Management().Show();
            this.Hide();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            supplierID.Clear();
            supplierName.Clear();
            supplierContact.Clear();
            supplierEmail.Clear();
            supplierAddress.Clear();
            drugsSupplied.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (supplierID.Text != "")
                {
                    HDPurchasingDataSetTableAdapters.Drug_SuppliersTableAdapter suppliersTableAdapter = new HDPurchasingDataSetTableAdapters.Drug_SuppliersTableAdapter();

                    suppliersTableAdapter.Insert(supplierID.Text, supplierName.Text, supplierAddress.Text, supplierContact.Text, supplierEmail.Text, drugsSupplied.Text);

                    MessageBox.Show("A new drug supplier has been added to the system");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("An error creating the new supplier");
                throw;
            }
        }

        private void NewSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Drug_Suppliers' table. You can move, or remove it, as needed.
            this.drug_SuppliersTableAdapter.Fill(this.hDPurchasingDataSet.Drug_Suppliers);

        }
    }
}
