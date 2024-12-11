using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Food_Vendor_Locator
{
    public partial class see_vendor_form : Form
    {
        public see_vendor_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer jump = new customer();
            jump.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Replace "your_connection_string" with your actual connection string
                string connectionString = @"Data Source=A-HANNAN\SQLEXPRESS;Initial Catalog=Group5_project;Integrated Security=True;";

                string query = "SELECT Name FROM Vendor";
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
                            // Display the names of vendors in a MessageBox
                            string vendorNames = string.Join("\n", dt.AsEnumerable().Select(row => row.Field<string>("Name")));
                            MessageBox.Show("Names of vendors:\n" + vendorNames);
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
            dataGridView1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
        }
    }
}
