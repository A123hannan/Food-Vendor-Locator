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
    public partial class vendorshop : Form
    {
        public vendorshop()
        {
            InitializeComponent();
            vendorsearch();
        }
        string location;
        int vendorid;
        private void vendorsearch()
        {
            newclassdb connection1 = new newclassdb();
            connection1.DBConnection();
            string query = "SELECT Name FROM Vendor";
            SqlDataAdapter da = new SqlDataAdapter(query, newclassdb.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Assuming you have a ComboBox named comboBoxVendor to display the vendor names
            comboBox1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["Name"].ToString());
            }
        }
        private void shops()
        {
            // Get the selected vendor name from comboBox1
            string selectedVendorName = comboBox1.SelectedItem.ToString();

            // Retrieve the vendor_id for the selected vendor name
            newclassdb connection1 = new newclassdb();
            connection1.DBConnection();
            string getVendorIdQuery = "SELECT vendor_id FROM Vendor WHERE Name = '" + selectedVendorName + "'";
            SqlCommand cmd = new SqlCommand(getVendorIdQuery, newclassdb.con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                vendorid = reader.GetInt32(0);
                reader.Close();
                dataGridView1.DataSource = null;
                // Use the retrieved vendor_id in your query
                string query = "SELECT Item.item_id ,Vendor.Name AS VendorName, Vendor.Location, Item.Name AS ItemName, Item.price " +
                               "FROM Vendor " +
                               "INNER JOIN Item ON Vendor.vendor_id = Item.vendor_id WHERE Vendor.vendor_id = " + vendorid;
              
                SqlDataAdapter da = new SqlDataAdapter(query, newclassdb.con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Assuming you have a DataGridView or similar control to display the data
                dataGridView1.DataSource = dt;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Replace "your_connection_string" with your actual connection string
                string connectionString = @"Data Source=A-HANNAN\SQLEXPRESS;Initial Catalog=Group5_project;Integrated Security=True;";

                string query = "SELECT Location FROM Vendor";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // Display the location in a MessageBox
                            StringBuilder locations = new StringBuilder();
                            foreach (DataRow row in dt.Rows)
                            {
                                locations.AppendLine(row["Location"].ToString());
                            }
                            MessageBox.Show("Locations of vendors:\n" + locations.ToString());
                        }
                        else
                        {
                            MessageBox.Show("No vendors found.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions separately
                MessageBox.Show("A SQL error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Catch any other exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void showbtn_Click(object sender, EventArgs e)
        {
            shops();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                location = row.Cells[2].Value.ToString();
            }

        }

        private void ordrbtn_Click(object sender, EventArgs e)
        {
            newclassdb myconnection = new newclassdb();
            myconnection.DBConnection();

            // Get the item_id from textBox1
            int itemId;
            if (int.TryParse(textBox1.Text, out itemId))
            {
                // Create the SQL INSERT command
                string query = "INSERT INTO ORDERT (item_id) VALUES(" + itemId + ")";
                SqlDataAdapter da = new SqlDataAdapter(query, newclassdb.con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                MessageBox.Show("Order successfully added");
            }
            else
            {
                MessageBox.Show("Invalid item ID");
            }
        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            customer jump = new customer();
            jump.Show();
            this.Hide();
        }
    }
}
