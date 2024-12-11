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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sigbtn_Click(object sender, EventArgs e)
        {
            signup sig = new signup();
            sig.Show();
            this.Hide();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
              if (combo.SelectedItem == null)
            {
                MessageBox.Show("who you are Vendor or Customer");
                
            }
            else if (combo.SelectedItem.ToString()=="customer")
            {
                newclassdb myconnection = new newclassdb();
                myconnection.DBConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = newclassdb.con;
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = " Select * from Customer where Name ='" + textBox1.Text + "' and Password= '" + textbox2.Text + "'Collate SQL_Latin1_General_CP1_CS_AS";
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("password is correct");
                    customer jump = new customer();
                    jump.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("password is incorrrect");
                }
               
            }
           
            else if (combo.SelectedItem.ToString()== "vendor")
            {
                newclassdb myconnection = new newclassdb();
                myconnection.DBConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = newclassdb.con;
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = " Select * from Vendor where Name ='" + textBox1.Text + "' and Password= '" + textbox2.Text + "'Collate SQL_Latin1_General_CP1_CS_AS";
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("password is correct");
                    vendor jump = new vendor();
                    jump.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("password is incorrrect");
                }
             
            }
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
