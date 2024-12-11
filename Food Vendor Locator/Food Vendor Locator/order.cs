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

namespace Food_Vendor_Locator
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            ShowOrderDetails();
        }
        private void ShowOrderDetails()
        {
            newclassdb connection1 = new newclassdb();
            connection1.DBConnection();

            // Query to get item details from ORDERT and Item tables
            string query = "SELECT Item.Name AS ItemName, Item.price AS ItemPrice " +
                           "FROM ORDERT " +
                           "INNER JOIN Item ON ORDERT.item_id = Item.item_id";

            SqlDataAdapter da = new SqlDataAdapter(query, newclassdb.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Display the item details in the DataGridView
            dataGridView1.DataSource = dt;

            // Calculate the total price of all items
            decimal totalPrice = dt.AsEnumerable().Sum(row => row.Field<int>("ItemPrice"));

            // Add a row to display the total price
            DataRow totalRow = dt.NewRow();
            totalRow["ItemName"] = "Total";
            totalRow["ItemPrice"] = totalPrice;
            dt.Rows.Add(totalRow);
        }

        private void buttonShowOrders_Click(object sender, EventArgs e)
        {
            ShowOrderDetails();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            Visible = false;
            c.Show();
        }

        private void order_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Show a message box with Yes/No buttons and capture the result
            DialogResult result = MessageBox.Show("If you exit you will have to add new items again. Do you want to proceed?", "Keep in Mind", MessageBoxButtons.YesNo);

            // If the user clicks "Yes", delete all data from the ORDERT table
            if (result == DialogResult.Yes)
            {
                try
                {
                    newclassdb connection1 = new newclassdb();
                    connection1.DBConnection();

                    string deleteQuery = "DELETE FROM ORDERT";
                    SqlCommand cmd = new SqlCommand(deleteQuery, newclassdb.con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("All orders have been deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting orders: " + ex.Message);
                }

                customer jump = new customer();
                jump.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

