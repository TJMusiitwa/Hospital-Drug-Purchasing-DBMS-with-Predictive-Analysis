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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private string connection_string = "Data Source=TJ-PC;Initial Catalog=HDPurch;Integrated Security=True";

        private void NewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.hDPurchasingDataSet.Users);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Management().Show();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            //Connect to the SQL Database and create the new user
            try
            {
                SqlConnection con = new SqlConnection(connection_string);
                //SqlCommand addUser = new SqlCommand("INSERT Users(Username,Users_Password,Users_Fname,Users_Lname,Users_Gender,Job_Title) VALUES (" + usernameTextBox.Text + password.Text + firstName.Text + lastName.Text + genderBox.Text + jobTitle.Text + " )", con);


                SqlCommand addUser = new SqlCommand("INSERT Users(Username,Users_Password,Users_Fname,Users_Lname,Users_Gender,Job_Title) VALUES (@Username, @Users_Password, @Users_Fname, @Users_Lname, @Users_Gender, @Job_Title)", con);

                
                addUser.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                addUser.Parameters.AddWithValue("@Users_Password", password.Text);
                addUser.Parameters.AddWithValue("@Users_Fname", firstName.Text);
                addUser.Parameters.AddWithValue("@Users_Lname", lastName.Text);
                addUser.Parameters.AddWithValue("@Users_Gender", genderBox.Text);
                addUser.Parameters.AddWithValue("@Job_Title", jobTitle.Text);

                con.Open();

                int i = addUser.ExecuteNonQuery();

                con.Close();

                if (i != 0)
                {
                    MessageBox.Show("User " + firstName.Text + lastName.Text + " has been created");
                    //Then Clear the Text Boxes
                    usernameTextBox.Clear();
                    password.Clear();
                    firstName.Clear();
                    lastName.Clear();
                    genderBox.ResetText();
                    jobTitle.ResetText();
                }
                else if (string.IsNullOrEmpty(usernameTextBox.Text)|| string.IsNullOrEmpty(password.Text)|| string.IsNullOrEmpty(firstName.Text)|| string.IsNullOrEmpty(lastName.Text) || string.IsNullOrEmpty(genderBox.Text) || string.IsNullOrEmpty(jobTitle.Text))
                {
                    MessageBox.Show("Please ensure all fields are filled up and not empty");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void labelMgt_Click(object sender, EventArgs e)
        {
            new Management().Show();
            this.Hide();
        }

        private void labelReports_Click(object sender, EventArgs e)
        {
            new Reports().Show();
            this.Hide();
        }

        private void labelAnalytics_Click(object sender, EventArgs e)
        {
            new Analytics().Show();
            this.Hide();
        }
    }
}
