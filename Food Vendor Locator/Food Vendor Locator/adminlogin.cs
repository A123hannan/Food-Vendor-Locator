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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
            passlog.PasswordChar = '*';
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            newclassdb myconnection = new newclassdb();
            myconnection.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = newclassdb.con;
            cmd.CommandType = CommandType.Text;

            
            cmd.CommandText = " Select * from Admin where Name ='" + textBox1.Text + "' and Password= '" + passlog.Text + "'Collate SQL_Latin1_General_CP1_CS_AS";
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                
                admin jump = new admin();
                jump.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("password is incorrrect");
            }
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passlog.PasswordChar = (char)0;

            }
            else
            {
                passlog.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rolepanel jump = new rolepanel();
            jump.Show();
            this.Hide();
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
