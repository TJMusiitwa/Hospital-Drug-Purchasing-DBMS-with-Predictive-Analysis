using System;
using System.Windows.Forms;
using System.Data.SqlClient;

//=============================================
//Author:		Jonathan Thomas Musiitwa
//Create date:  July-August 2018
//Description:	Hospital Drug Purchasing System with Predictive Analytics
//=============================================

namespace HDP_DBMSystem
{
    public partial class New_Drug : Form
    {
        public New_Drug()
        {
            InitializeComponent();
        }

        private string connection_string = "Data Source=TJ-PC;Initial Catalog=HDPurch;Integrated Security=True";

        private void New_Drug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.hDPurchasingDataSet.Drug);
            drugPrice.Controls.RemoveAt(0);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {

                //HDPurchasingDataSetTableAdapters.DrugTableAdapter drugTableAdapter = new HDPurchasingDataSetTableAdapters.DrugTableAdapter();
                //drugTableAdapter.Insert(drugProductID.Text, brandName.Text, genericName.Text, dosageInfo.Text, moaList.SelectedText, (decimal.TryParse(drugPrice.Text, out decimal result)), descriptionText.Text);

                SqlConnection connection = new SqlConnection(connection_string);

                SqlCommand newDrug = new SqlCommand("INSERT Drug(Drug_ID,Brand_Name,Generic_Name,Dosage,Method_of_Administration,Drug_Cost_$, Drug_Description) " +
                    "VALUES (@Drug_ID, @Brand_Name, @Generic_Name, @Dosage, @Method_of_Administration, @Drug_Cost_$, @Drug_Description)", connection);

                //newDrug.Parameters.AddWithValue("@Drug_Cost_$", (decimal.TryParse(drugPrice.Text, out decimal result)));
                newDrug.Parameters.AddWithValue("@Drug_Cost_$", drugPrice.Value);
                newDrug.Parameters.AddWithValue("@Brand_Name", brandName.Text);
                newDrug.Parameters.AddWithValue("@Generic_Name", genericName.Text);
                newDrug.Parameters.AddWithValue("@Dosage", dosageInfo.Text);
                newDrug.Parameters.AddWithValue("@Method_of_Administration", moaList.Text);
                newDrug.Parameters.AddWithValue("@Drug_Description", descriptionText.Text);
                newDrug.Parameters.AddWithValue("@Drug_ID", drugProductID.Text);


                connection.Open();

                int i = newDrug.ExecuteNonQuery();

                connection.Close();

                if (i != 0 )
                {
                    MessageBox.Show("A new drug entry has been added");
                    drugPrice.ResetText();
                    drugProductID.Clear();
                    brandName.Clear();
                    genericName.Clear();
                    moaList.ResetText();
                    dosageInfo.Clear();
                    descriptionText.Clear();

                }
                else
                {
                    MessageBox.Show("The operation ran into a problem adding the new drug to the database");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            drugProductID.Clear();
            brandName.Clear();
            genericName.Clear();
            dosageInfo.Clear();
            drugPrice.ResetText();
            descriptionText.Clear();
            moaList.ResetText();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Management().Show();
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void labelAnalytics_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
}
