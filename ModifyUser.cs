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
    public partial class ModifyUser : Form
    {
        public ModifyUser()
        {
            InitializeComponent();
        }

        string connection_string = "Data Source=TJ-PC;Initial Catalog=HDPurch;Integrated Security=True";

        private void searchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.hDPurchasingDataSet.Users);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connection_string);


            if (searchName.Text != "")//Check that the search box is not empty
            {
                try
                {
                    string findUser = "SELECT Username,Users_Password, Users_Fname, Users_Lname From Users Where Users_Fname = '" + searchName.Text + "'";
              
                    connection.Open();

                    SqlCommand search = new SqlCommand(findUser, connection);

                    //search.ExecuteNonQuery();
                    using (SqlDataReader readSearch = search.ExecuteReader())
                    {
                        readSearch.Read();

                        //Set the values into the text box
                        usernameTextBox.Text = readSearch.GetString(0);
                        password.Text = readSearch.GetString(1);
                        firstName.Text = readSearch.GetString(2);
                        lastName.Text = readSearch.GetString(3);

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
                MessageBox.Show("Please enter a name into the search box");
            }


        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connection_string);

            //Delete User String
            string delUser = "DELETE FROM USERS Where Users_Fname='" + searchName.Text + "'";

            if (searchName.Text != "")
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(delUser, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("This User has been deleted");
                    usernameTextBox.Clear();
                    password.Clear();
                    firstName.Clear();
                    lastName.Clear();
                }
                catch (Exception)
                {

                    MessageBox.Show("The user " + searchName.Text + " does not exist in the system");
                    //throw;
                }
                
            }
            else
            {
                MessageBox.Show("Please enter the user's name to delete");
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Management().Show();
        }

        //Update User Details
        private void saveUser_Click(object sender, EventArgs e)
        {

            string updateUser = "UPDATE Users SET [Users_Password] = @Password, [Users_Fname] = @Firstname, [Users_Lname] = @Lastname WHERE [Username] =  @Username";

            SqlConnection connection = new SqlConnection(connection_string);
            SqlCommand command = new SqlCommand(updateUser, connection);

            command.Parameters.AddWithValue("@Username", usernameTextBox.Text);
            command.Parameters.AddWithValue("@Password", password.Text);
            command.Parameters.AddWithValue("@Firstname", firstName.Text);
            command.Parameters.AddWithValue("@Lastname", lastName.Text);

            try
            {
                connection.Open();
                command.ExecuteNonQuery().Equals(true);
                MessageBox.Show("The user's information has been updated");
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error updating this user");
                MessageBox.Show(ex.ToString());
                //throw;
            } 
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
    }
}
