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
    public partial class update_customer : Form
    {
        public update_customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newclassdb connection1 = new newclassdb();
            connection1.DBConnection();
            string update = "UPDATE Customer SET Name = '" + custname.Text + "', Email = '" + custmail.Text + "', PhoneNumber = '" + custphone.Text + "', Password = '" + custpass.Text + "' WHERE customer_id = " + Convert.ToInt32(custid.Text) + ";";
            SqlDataAdapter ad = new SqlDataAdapter(update, newclassdb.con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            MessageBox.Show("succesfully updated");
            newclassdb.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer jump = new customer();
            jump.Show();
            this.Hide();
        }

        private void update_customer_Load(object sender, EventArgs e)
        {

        }
    }
}
