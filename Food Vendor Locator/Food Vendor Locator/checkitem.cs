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
    public partial class checkitem : Form
    {
        public checkitem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Attempt to convert the input text to an integer
                if (int.TryParse(vendorid.Text, out int vendorId))
                {
                    // Construct the connection string
                    string connectionString = @"Data Source=A-HANNAN\SQLEXPRESS;Initial Catalog=Group5_project;Integrated Security=True;";

                    // Use a parameterized query to prevent SQL injection
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM Item WHERE vendor_id = @VendorId";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@VendorId", vendorId);
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No items found for the specified vendor ID.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid vendor ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            vendor jump = new vendor();
            jump.Show();
            this.Hide();
        }

        private void checkitem_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
