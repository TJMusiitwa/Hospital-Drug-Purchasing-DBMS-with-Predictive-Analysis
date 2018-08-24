using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//=============================================
//Author:		Jonathan Thomas Musiitwa
//Create date:  July-August 2018
//Description:	Hospital Drug Purchasing System with Predictive Analytics
//=============================================

namespace HDP_DBMSystem
{
    public partial class ViewSuppliers : Form
    {
        public ViewSuppliers()
        {
            InitializeComponent();
        }

        private void ViewSuppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Drug_Suppliers' table. You can move, or remove it, as needed.
            this.drug_SuppliersTableAdapter.Fill(this.hDPurchasingDataSet.Drug_Suppliers);

        }

        //private void labelDashboard_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    new Dashboard().Show();
        //}

        //private void labelReports_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    new Reports().Show();
        //}

        //private void labelAnalytics_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    new Analytics().Show();
        //}

        //private void labelMgt_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    new Management().Show();
        //}

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=TJ-PC;Initial Catalog=HDPurch;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Drug_Suppliers where Supplier_Name like '" + textBoxSearch.Text + "%'", con);
                DataTable userTable = new DataTable();
                adapter.Fill(userTable);
                dataGridView3.DataSource = userTable;
                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("This supplier you are searching for does not exist in the system ");
                throw;
            }
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            new Management().Show();
            this.Hide();
        }

        private void labelDashboard_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();

        }

        private void labelAnalytics_Click_1(object sender, EventArgs e)
        {
            new Analytics().Show();
            this.Hide();
        }

        private void labelReports_Click_1(object sender, EventArgs e)
        {
            new Reports().Show();
            this.Hide();
        }

        private void labelMgt_Click_1(object sender, EventArgs e)
        {
            new Management().Show();
            this.Hide();
        }
    }
}
