using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AnalysisServices.AdomdClient;

namespace HDP_DBMSystem
{
    public interface PredictDrugPricing
    {
        string Command(string analysisSever, string dependentValue);
    }


    public class PredictionClass : PredictDrugPricing
    {
        public PredictionClass()
        { }

        public string Command(string analysisSever, string depenedentValue)
        {
            StringBuilder stringBuilder = new StringBuilder();

            //Analysis Server Connection String
            string analysisServer = "Provider=MSOLAP;Data Source=TJ-PC;Integrated Security=SSPI;Initial Catalog=HDPurchasingPredictiveAnalysis;Location=TJ-PC";

            using (AdomdConnection serverConnection = new AdomdConnection(analysisServer))
            {
                //Initialise a new command
                AdomdCommand command = new AdomdCommand();
                //Connect to the Analysis Server
                command.Connection = serverConnection;
                //Run this singleton query
                command.CommandText = "SELECT [DrugPricingCostLR].[Drug Cost_] From[DrugPricingCostLR] NATURAL PREDICTION JOIN (SELECT 234 AS[ASP 2016]) AS t";
                //This is the parameter we are using to predict
                AdomdParameter parameter = null;
                parameter = command.CreateParameter();
                parameter.Direction = ParameterDirection.Input;
                parameter.ParameterName = "ASP 2016";
                parameter.Value = depenedentValue;
                command.Parameters.Add(parameter);

                //Open the connection to the Analysis Server
                serverConnection.Open();

                //Execute the prediction query and return the results
                AdomdDataReader reader = null;
                reader = command.ExecuteReader();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    stringBuilder.Append(reader.GetName(i) + "\t");
                }
                stringBuilder.Append("\r\n--------------------------------------------\r\n");
                //Important before accessing any data, call the .Read method
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        stringBuilder.Append(reader.GetValue(i).ToString() + "\t");
                    }
                    stringBuilder.Append("\r\n");
                }
                reader.Close();
            }
            return stringBuilder.ToString();
        }
        

    }
}
