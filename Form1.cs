using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDP_DBMSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        //Connection String
        string dbconnect = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MyDatabase.mdf;Integrated Security=True;";

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //loginButton Click event
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "" || passwordtextBox.Text == "")
            {
                MessageBox.Show("Please enter the Username and Password");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(dbconnect);
                SqlCommand cmd = new SqlCommand("Select * from tbl_Login where Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", usernametextBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordtextBox.Text);
                //con.Open;
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                // con.Close;

                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful! Welcome " + usernametextBox.Text);
                    //Hide the Login Form, then display the Dashboard
                    this.Hide();
                    Dashboard dash = new Dashboard();
                    dash.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed! Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
