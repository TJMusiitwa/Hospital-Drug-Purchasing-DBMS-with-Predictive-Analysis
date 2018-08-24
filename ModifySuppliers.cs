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
    public partial class ModifySuppliers : Form
    {
        public ModifySuppliers()
        {
            InitializeComponent();
        }

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

        private void searchButton_Click(object sender, EventArgs e)
        {
            {
                SqlConnection connection = new SqlConnection(connection_string);


                if (searchName.Text != "")//Check that the search box is not empty
                {
                    try
                    {
                        string findSupplier = "SELECT Supplier_Name,Supplier_Address, Supplier_email, Supplier_Contact From Drug_Suppliers Where Supplier_Name = '" + searchName.Text + "'";

                        connection.Open();

                        SqlCommand search = new SqlCommand(findSupplier, connection);

                        //search.ExecuteNonQuery();
                        using (SqlDataReader readSearch = search.ExecuteReader())
                        {
                            readSearch.Read();

                            //Set the values into the text box
                            supplierNameTextBox.Text = readSearch.GetString(0);
                            supplierAddress.Text = readSearch.GetString(1);
                            supplierEmail.Text = readSearch.GetString(2);
                            supplierContact.Text = readSearch.GetString(3);

                            readSearch.Close();
                        }

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("The following supplier you have entered does not exist in the system");
                        //throw;
                    }

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a name into the search box");
                }

            }
        }

            private void deleteUser_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connection_string);

            //Delete Supplier String
            string delSupplier = "DELETE FROM Drug_Suppliers Where Supplier_Name='" + searchName.Text + "'";

            if (searchName.Text != "")
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(delSupplier, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("This supplier has been deleted");
                    supplierNameTextBox.Clear();
                    supplierAddress.Clear();
                    supplierEmail.Clear();
                    supplierContact.Clear();

                }
                catch (Exception)
                {

                    MessageBox.Show("The supplier " + searchName.Text + " does not exist in the system");
                    throw;
                }

            }
            else
            {
                MessageBox.Show("Please enter the supplier's name to delete");
            }
        }

        private void saveUser_Click(object sender, EventArgs e)
        {
            string updateSupplier = "UPDATE Drug_Suppliers SET [Supplier_Name] = @Supplier_Name, [Supplier_Address] = @Supplier_Address, [Supplier_Contact] = @Supplier_Contact, [Supplier_email] = @Supplier_email WHERE [Supplier_Name] =  @Supplier_Name";

            SqlConnection connection = new SqlConnection(connection_string);
            SqlCommand command = new SqlCommand(updateSupplier, connection);

            command.Parameters.AddWithValue("@Supplier_Name", supplierNameTextBox.Text);
            command.Parameters.AddWithValue("@Supplier_Address", supplierAddress.Text);
            command.Parameters.AddWithValue("@Supplier_Contact", supplierContact.Text);
            command.Parameters.AddWithValue("@Supplier_email", supplierEmail.Text);
            try
            {
                connection.Open();
                command.ExecuteNonQuery().Equals(true);
                MessageBox.Show("The supplier's information has been updated");
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error updating this supplier's information");
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }

        private void ModifySuppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Drug_Suppliers' table. You can move, or remove it, as needed.
            this.drug_SuppliersTableAdapter.Fill(this.hDPurchasingDataSet.Drug_Suppliers);

        }
    }
}
