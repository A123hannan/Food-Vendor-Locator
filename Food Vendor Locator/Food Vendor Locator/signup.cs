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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            if (rolelog.SelectedItem == null)
            {
                MessageBox.Show("who you are Vendor or Customer");
            }
            else if (rolelog.SelectedItem.ToString() == "customer")
            {
                newclassdb myconnection = new newclassdb();
                myconnection.DBConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = newclassdb.con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "INSERT INTO Customer (Name, Password) VALUES ('" + textBox1.Text + "', '" + passlog.Text + "')";
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Signup successful!  Now You Can Login");
                    loginform jump = new loginform();
                    jump.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (rolelog.SelectedItem.ToString() == "vendor")
            {
                newclassdb myconnection = new newclassdb();
                myconnection.DBConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = newclassdb.con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "INSERT INTO Vendor (Name,Location, Password) VALUES ('" + textBox1.Text + "','https" + textBox2.Text + "', '" + passlog.Text + "')";
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Signup successful!  Now You Can Login");
                    loginform jump = new loginform();
                    jump.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void signup_Load(object sender, EventArgs e)
        {
            string vendorcity = textBox2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

