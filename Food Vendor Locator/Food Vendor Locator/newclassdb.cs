using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Vendor_Locator
{
    class newclassdb
    {
        public static SqlConnection con = null;
        public void DBConnection()
        {
            try
            {
                con = new SqlConnection("Data Source=A-HANNAN\\SQLEXPRESS;Initial Catalog=Group5_project;Integrated Security=True;");
                con.Open();
                if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                {
                    MessageBox.Show("Fail to open database");
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}