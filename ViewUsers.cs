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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.hDPurchasingDataSet.Users);

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=TJ-PC;Initial Catalog=HDPurch;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Users where Users_Fname like '" + textBoxSearch.Text + "%'", con);
            DataTable userTable = new DataTable();
            adapter.Fill(userTable);
            dataGridView1.DataSource = userTable;
            con.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Management().Show();
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
