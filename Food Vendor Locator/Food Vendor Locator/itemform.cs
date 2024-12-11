using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml.Linq;

namespace Food_Vendor_Locator
{
    public partial class itemform : Form
    {
        public itemform()
        {
            InitializeComponent();
        }

        private void additm_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate and parse the item price
                if (!int.TryParse(itmprice.Text, out int price))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                // Validate and parse the vendor ID
                if (!int.TryParse(vendorid.Text, out int vendorId))
                {
                    MessageBox.Show("Please enter a valid vendor ID.");
                    return;
                }

                newclassdb connection1 = new newclassdb();
                connection1.DBConnection();
                string itemadd = "INSERT INTO Item (Name, price, vendor_id) VALUES ('" + itmname.Text + "', " + price + ", " + vendorId + ")";
                SqlDataAdapter da = new SqlDataAdapter(itemadd, newclassdb.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Successfully added item.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            vendor jump = new vendor();
            jump.Show();
            this.Hide();
        }

        private void itemform_Load(object sender, EventArgs e)
        {

        }

        private void vendorid_TextChanged(object sender, EventArgs e)
        {

        }

        private void itmprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void itmname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
