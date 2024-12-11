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
    public partial class updatevendor : Form
    {
        public updatevendor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newclassdb connection1=new newclassdb();
            connection1.DBConnection();
            string update = "UPDATE Vendor SET Name = '" + vendorname.Text + "', Email = '" + vendoremail.Text + "', PhoneNumber = '" + vendorphone.Text + "', Password = '" + vendorpass.Text + "' WHERE vendor_id = " + Convert.ToInt32(vendorid.Text) + ";";
            SqlDataAdapter ad = new SqlDataAdapter(update, newclassdb.con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            MessageBox.Show("succesfully updated");
            newclassdb.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vendor jump = new vendor();
            jump.Show();
            this.Hide();
        }
    }
}
