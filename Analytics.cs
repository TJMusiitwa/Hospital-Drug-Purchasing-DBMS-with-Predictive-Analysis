using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.Text;
using System.Windows.Forms;

//=============================================
//Author:		Jonathan Thomas Musiitwa
//Create date:  July-August 2018
//Description:	Hospital Drug Purchasing System with Predictive Analytics
//=============================================

namespace HDP_DBMSystem
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();

        }

        string analysisServer = "Provider=MSOLAP.8;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HDPurchasingPredictiveAnalysis;Data Source=TJ-PC;Impersonation Level=Impersonate;Location=TJ-PC;Update Isolation Level=2";

        //string drugDatabase = "Data Source=TJ-PC;Initial Catalog=HDPurch;Integrated Security=True";

        private void buttonPredict_Click(object sender, EventArgs e)
        {


            if (radioButtonANN.Checked.Equals(true) && !(string.IsNullOrEmpty(dependentVariable.Text)))
            {
                //SingletonQuery
                string dmxQuery = @"SELECT [DrugPricingCostNN].[Drug Cost_] From [DrugPricingCostNN] NATURAL PREDICTION JOIN (SELECT '" + dependentVariable.Text + @"'AS [ASP 2016]) AS t";
                //AllResultQuery
                string AnnResults = "SELECT[DrugPricingCostNN].[Drug Cost_] From [DrugPricingCostNN] PREDICTION JOIN OPENQUERY([HD Purch], " +
                    "'SELECT [Drug_Cost_$], [ASP_2012], [ASP_2013], [ASP_2014], [ASP_2015], [ASP_2016] " +
                    "FROM [dbo].[DrugPricingCost] ') AS t ON " +
                    "[DrugPricingCostNN].[Drug Cost_] = t.[Drug_Cost_$] AND " +
                    "[DrugPricingCostNN].[ASP 2012] = t.[ASP_2012] AND " +
                    "[DrugPricingCostNN].[ASP 2013] = t.[ASP_2013] AND " +
                    "[DrugPricingCostNN].[ASP 2014] = t.[ASP_2014] AND " +
                    "[DrugPricingCostNN].[ASP 2015] = t.[ASP_2015] AND " +
                    "[DrugPricingCostNN].[ASP 2016] = t.[ASP_2016]";
                try
                {
                    //Open a connection to the analysis services server
                    AdomdConnection connection = new AdomdConnection(analysisServer);
                    connection.Open();
                    //SingletonQuery
                    AdomdCommand command = new AdomdCommand(dmxQuery, connection);
                    AdomdDataReader reader = command.ExecuteReader();
                    reader.Read();


                    //Init stringBuilder
                    StringBuilder stringBuilder = new StringBuilder();

                    //Init a data table
                    //DataGrid grid = new DataGrid();


                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        stringBuilder.Append("Predicted " + reader.GetName(i) + "\t");
                        stringBuilder.Append(reader.GetValue(i).ToString().Trim() + "\t");
                        //allResultGridView.DataSource = reader;
                    }

                    //Important before accessing any data, call the .Read method
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            //stringBuilder.Append(reader.GetName(i) + "\t");
                            stringBuilder.Append(reader.GetValue(i).ToString() + "\t");

                        }
                        stringBuilder.Append("\r\n");
                    }
                    //Return the predicted value and display it in the text box
                    predictedValue.Text = stringBuilder.ToString();
                    Console.Write(stringBuilder.ToString());
                    reader.Close();
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }

                try
                {
                    AdomdConnection allANNConnect = new AdomdConnection(analysisServer);
                    allANNConnect.Open();
                    AdomdCommand allClusterQuery = new AdomdCommand(AnnResults, allANNConnect);

                    AdomdDataReader annReader = allClusterQuery.ExecuteReader();
                    annReader.Read();

                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    dataTable.Load(annReader);
                    algorithmGridView.DataSource = dataTable;
                    allANNConnect.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }

            }
            //Run the Logistic Regression Algorthim
            else if (radioButtonLR.Checked.Equals(true) && !(string.IsNullOrEmpty(dependentVariable.Text)))
            {

                string dmxQuery = @"SELECT [DrugPricingCostLogReg].[Drug Cost_] From [DrugPricingCostLogReg] NATURAL PREDICTION JOIN (SELECT '" + dependentVariable.Text + @"'AS [ASP 2016]) AS t";

                //AllResultQuery
                string LogRegResults = "SELECT[DrugPricingCostLogReg].[Drug Cost_] From [DrugPricingCostLogReg] PREDICTION JOIN OPENQUERY([HD Purch], " +
                    "'SELECT [Drug_Cost_$], [ASP_2012], [ASP_2013], [ASP_2014], [ASP_2015], [ASP_2016] " +
                    "FROM [dbo].[DrugPricingCost] ') AS t ON " +
                    "[DrugPricingCostLogReg].[Drug Cost_] = t.[Drug_Cost_$] AND " +
                    "[DrugPricingCostLogReg].[ASP 2012] = t.[ASP_2012] AND " +
                    "[DrugPricingCostLogReg].[ASP 2013] = t.[ASP_2013] AND " +
                    "[DrugPricingCostLogReg].[ASP 2014] = t.[ASP_2014] AND " +
                    "[DrugPricingCostLogReg].[ASP 2015] = t.[ASP_2015] AND " +
                    "[DrugPricingCostLogReg].[ASP 2016] = t.[ASP_2016]";

                try
                {
                    AdomdConnection connection = new AdomdConnection(analysisServer);
                    connection.Open();

                    AdomdCommand command = new AdomdCommand(dmxQuery, connection);
                    AdomdDataReader reader = command.ExecuteReader();
                    reader.Read();

                    StringBuilder stringBuilder = new StringBuilder();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        stringBuilder.Append("Predicted " + reader.GetName(i) + "\t");
                        stringBuilder.Append(reader.GetValue(i).ToString() + "\t");
                    }

                    //Important before accessing any data, call the .Read method
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            //stringBuilder.Append(reader.GetValue(i).ToString() + "\t");
                        }
                        stringBuilder.Append("\r\n");
                    }
                    predictedValue.Text = stringBuilder.ToString();
                    Console.Write(stringBuilder.ToString());
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                //Display the results in the grid view tab
                try
                {
                    //string drugData = "Select Drug_ID From Drug";
                    //SqlConnection sqlConnection = new SqlConnection(drugDatabase);

                    AdomdConnection allLogRegConnect = new AdomdConnection(analysisServer);

                    allLogRegConnect.Open();
                    AdomdCommand allLogRegQuery = new AdomdCommand(LogRegResults, allLogRegConnect);

                    //sqlConnection.Open();
                    //SqlCommand sqlCommand = new SqlCommand(drugData, sqlConnection);
                    //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    //sqlDataReader.Read();

                    AdomdDataReader logRegReader = allLogRegQuery.ExecuteReader();
                    logRegReader.Read();


                    System.Data.DataTable dataTable = new System.Data.DataTable();

                    //dataTable.Columns.Add("Drug_ID");
                    //dataTable.Columns.Add("Brand_Name");
                    //dataTable.Columns.Add("Generic_Name");
                    //dataTable.Columns.Add("Drug_Cost_$");

                    //System.Data.DataRow row = dataTable.NewRow();
                    //while (sqlDataReader.Read())
                    //{

                    //    row["Drug_ID"] = sqlDataReader[0];
                    //    row["Brand_Name"] = sqlDataReader[1];
                    //    row["Generic_Name"] = sqlDataReader[2];
                    //    row["Drug_Cost_$"] = sqlDataReader[3];

                    //    dataTable.Rows.Add(row);

                    //}

                    //dataTable.Load(sqlDataReader);
                    dataTable.Load(logRegReader);
                    algorithmGridView.DataSource = dataTable;
                    allLogRegConnect.Close();
                    //sqlConnection.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                    throw;
                }
            }
            //Run the clustering algorithm
            else if (radioButtonClustering.Checked.Equals(true) && !(string.IsNullOrEmpty(dependentVariable.Text)))
            {
                string dmxQuery = @"SELECT [DrugPricingClustering].[Drug Cost_] From [DrugPricingClustering] NATURAL PREDICTION JOIN (SELECT '" + dependentVariable.Text + @"'AS [ASP 2016]) AS t";

                //AllResultQuery
                string ClusterResults = "SELECT [DrugPricingClustering].[Drug Cost_] From [DrugPricingClustering] PREDICTION JOIN OPENQUERY([HD Purch], " +
                    "'SELECT [Drug_Cost_$], [ASP_2012], [ASP_2013],[ASP_2014],[ASP_2015], [ASP_2016] FROM [dbo].[DrugPricingCost] ') AS t " +
                    "ON " +
                    "[DrugPricingClustering].[Drug Cost_] = t.[Drug_Cost_$] AND " +
                    "[DrugPricingClustering].[ASP 2012] = t.[ASP_2012] AND " +
                    "[DrugPricingClustering].[ASP 2013] = t.[ASP_2013] AND " +
                    "[DrugPricingClustering].[ASP 2014] = t.[ASP_2014] AND " +
                    "[DrugPricingClustering].[ASP 2015] = t.[ASP_2015] AND " +
                    "[DrugPricingClustering].[ASP 2016] = t.[ASP_2016]";
                try
                {
                    AdomdConnection connection = new AdomdConnection(analysisServer);
                    connection.Open();

                    AdomdCommand command = new AdomdCommand(dmxQuery, connection);
                    AdomdDataReader reader = command.ExecuteReader();
                    reader.Read();

                    StringBuilder stringBuilder = new StringBuilder();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        stringBuilder.Append("Predicted " + reader.GetName(i) + "\t");
                        stringBuilder.Append(reader.GetValue(i).ToString() + "\t");
                    }
                    //Important before accessing any data, call the .Read method
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            //stringBuilder.Append(reader.GetValue(i).ToString() + "\t");
                        }
                        stringBuilder.Append("\r\n");
                    }
                    predictedValue.Text = stringBuilder.ToString();
                    //Console.Write(stringBuilder.ToString());
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                try
                {
                    AdomdConnection allClusterConnect = new AdomdConnection(analysisServer);
                    allClusterConnect.Open();
                    AdomdCommand allClusterQuery = new AdomdCommand(ClusterResults, allClusterConnect);

                    AdomdDataReader clusterReader = allClusterQuery.ExecuteReader();
                    clusterReader.Read();

                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    dataTable.Load(clusterReader);
                    algorithmGridView.DataSource = dataTable;
                    allClusterConnect.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
            else
            {

                //Display an error message implying that the user has to select a specific algorithm button
                MessageBox.Show("Please select an algorithm to commence the prediction & enter a prediction value into the text box");

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void labelAnalytics_Click(object sender, EventArgs e)
        {
            this.Refresh();
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

        private void logoutButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dependentVariable.Clear();
            predictedValue.Clear();
        }

        private void labelDashboard_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }


    }
}
