using System;
using System.Data.SqlClient;
using System.Windows.Forms;

//=============================================
//Author:		Jonathan Thomas Musiitwa
//Create date:  July-August 2018
//Description:	Hospital Drug Purchasing System with Predictive Analytics
//=============================================

namespace HDP_DBMSystem
{
    public partial class ModifyDrug : Form
    {
        public ModifyDrug()
        {
            InitializeComponent();
        }
        //Connection String
        string connection_string = "Data Source=TJ-PC;Initial Catalog=HDPurch;Integrated Security=True";

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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new Management().Show();
            this.Hide();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connection_string);

            //Delete Supplier String
            string delDrug = "DELETE FROM Drug Where Brand_Name='" + comboBoxSearchDrug.SelectedValue + "'";

            if (comboBoxSearchDrug.Text != "")
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(delDrug, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("This drug has been deleted");
                    brandName.Clear();
                    genericName.Clear();
                    dosageTextBox.Clear();
                    drugCost.Clear();
                    drugDescription.Clear();


                }
                catch (Exception)
                {

                    MessageBox.Show("The drug " + comboBoxSearchDrug.Text + " does not exist in the system");
                    //throw;
                }

            }
            else
            {
                MessageBox.Show("Please enter the drug's brand name to delete");
            }
        }

        private void saveUser_Click(object sender, EventArgs e)
        {

        }


        private void updateDrug_Click(object sender, EventArgs e)
        {
            string updateDrug = "UPDATE Drug SET [Brand_Name] = @Brand_Name, [Generic_Name] = @Generic_Name, [Dosage] = @Dosage, [Drug_Cost_$] = @Drug_Cost, [Drug_Description] = @Drug_Description WHERE [Brand_Name] =  @Brand_Name";

            SqlConnection connection = new SqlConnection(connection_string);
            SqlCommand command = new SqlCommand(updateDrug, connection);

            command.Parameters.AddWithValue("@Brand_Name", brandName.Text);
            command.Parameters.AddWithValue("@Generic_Name", genericName.Text);
            command.Parameters.AddWithValue("@Dosage", dosageTextBox.Text);
            command.Parameters.AddWithValue("@Drug_Cost", (Convert.ToDecimal(drugCost.Text)));
            command.Parameters.AddWithValue("@Drug_Description", drugDescription.Text);
            try
            {
                connection.Open();
                command.ExecuteNonQuery().Equals(true);
                MessageBox.Show("The drug's information has been updated");
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error updating this drug's information");
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connection_string);


            if (comboBoxSearchDrug.Text != "")//Check that the search box is not empty
            {
                try
                {
                    string findDrug = "SELECT Brand_Name, Generic_Name, Dosage, Drug_Cost_$, Drug_Description From Drug Where Brand_Name = '" + comboBoxSearchDrug.SelectedValue + "'";

                    connection.Open();

                    SqlCommand search = new SqlCommand(findDrug, connection);

                    
                    using (SqlDataReader readSearch = search.ExecuteReader())
                    {
                        readSearch.Read();

                        //Set the values into the text box
                        brandName.Text = readSearch.GetString(0);
                        genericName.Text = readSearch.GetString(1);
                        dosageTextBox.Text = readSearch.GetString(2);
                        drugCost.Text = readSearch.GetDecimal(3).ToString();
                        drugDescription.Text = readSearch.GetString(4);

                        readSearch.Close();
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("The following user you have entered does not exist in the system");
                    //throw;
                }

                connection.Close();
            }
            else
            {
                MessageBox.Show("Please enter a drug brand name into the search box");
            }
        }

        private void ModifyDrug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.hDPurchasingDataSet.Drug);

        }
    }
}
