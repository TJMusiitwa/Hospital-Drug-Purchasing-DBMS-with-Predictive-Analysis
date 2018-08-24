using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HDP_DBMSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string connection_string = "Data Source=TJ-PC;Initial Catalog=HDPurch;Integrated Security=True";

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.hDPurchasingDataSet.Users);

        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            HDPurchasingDataSetTableAdapters.UsersTableAdapter usersTable = new HDPurchasingDataSetTableAdapters.UsersTableAdapter();

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please provide a correct username and password");
                return;
            }
            else
            {

            
            try
            {
                SqlConnection con = new SqlConnection(connection_string);
                SqlCommand cmd = new SqlCommand("Select * From Users where Username=@username and Users_password=@password",con);
                cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet usersDS = new DataSet();
                adapter.Fill(usersDS);
                con.Close();

                //usersTableAdapter.Connection.Open();
                //usersTableAdapter.GetData.textBoxUsername;
                //usersTableAdapter.GetData.Text("@username", textBoxUsername);
                //this.usersTableAdapter.Fill(this.hDPurchasingDataSet.Users);
                //usersTableAdapter.Connection.Close();

                //int count = hDPurchasingDataSet.Users.Rows.Count;

                int countDS = usersDS.Tables[0].Rows.Count;
                if (countDS == 1)
                {
                    this.Hide();
                    Dashboard dash = new Dashboard();
                    dash.Show();
                }
                    else
                    {
                        MessageBox.Show("The username or password entered is incorrect");
                        textBoxPassword.Clear();
                        textBoxUsername.Clear();
                    }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }

            }

        }

        private void linkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }
    }
}
