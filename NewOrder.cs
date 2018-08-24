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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.hDPurchasingDataSet.Drug);
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.hDPurchasingDataSet.Users);
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Drug_Suppliers' table. You can move, or remove it, as needed.
            this.drug_SuppliersTableAdapter.Fill(this.hDPurchasingDataSet.Drug_Suppliers);
            // TODO: This line of code loads data into the 'hDPurchasingDataSet.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.hDPurchasingDataSet.Orders);

            orderDateTime.Format = DateTimePickerFormat.Custom;
            orderDateTime.CustomFormat = "dd-mm-yy hh:mm";
            //drugOrderQuantity.Controls[0].Visible = false;
            drugOrderQuantity.Controls.RemoveAt(0);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            new Management().Show();
            this.Hide();
        }

        private void orderDrug_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=TJ-PC;Initial Catalog=HDPurch;Integrated Security=True");
                SqlCommand getPrice = new SqlCommand("Select Drug_Cost_$ From Drug Where Brand_Name = '" + orderDrug.SelectedValue + "'", connection);

                connection.Open();

                using (SqlDataReader readPrice = getPrice.ExecuteReader())
                {
                    readPrice.Read();
                    drugPrice.Text = readPrice.GetDecimal(0).ToString();
                    readPrice.Close();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString());
                //throw;
            }
        }

        private void drugOrderQuantity_ValueChanged(object sender, EventArgs e)
        {
            //orderTotalCost = (Convert.ToInt32(drugPrice.Text) * (drugOrderQuantity.Value);
            //int price;
            decimal price;
            //int.TryParse(drugPrice.Text, out price);
            decimal.TryParse(drugPrice.Text, out price);
            orderTotalCost.Text = (price * drugOrderQuantity.Value).ToString();
            Convert.ToDecimal(orderTotalCost);
        }

        //Get the drug price and place it into the 
        private void orderDrug_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        //When the value of the quantity changes, the multiplication happens and is put into the Total Cost text box

        private void drugOrderQunatity_TextChanged(object sender, EventArgs e)
        {

            //orderTotalCost = (Convert.ToInt32(drugPrice.Text) * (drugOrderQuantity.Value);
           
            decimal price;
            //int.TryParse(drugPrice.Text, out price);
            decimal.TryParse(drugPrice.Text, out price);
            orderTotalCost.Text = (price * drugOrderQuantity.Value).ToString();
            Convert.ToDecimal(orderTotalCost);
            
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                HDPurchasingDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter = new HDPurchasingDataSetTableAdapters.OrdersTableAdapter();
                ordersTableAdapter.Insert(orderedBy.Text, (Convert.ToDateTime(orderDateTime.Value)), orderDrug.Text, (Convert.ToInt32(drugOrderQuantity.Value)), (Convert.ToDecimal(orderTotalCost.Text)));
                MessageBox.Show("A new drug order has been placed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }

        }
    }
}
