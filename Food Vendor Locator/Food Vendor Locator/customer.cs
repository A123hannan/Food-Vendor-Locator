using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Vendor_Locator
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vendorshop JUMP = new vendorshop();
            JUMP.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rolepanel jump = new rolepanel();
            jump.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            see_vendor_form jump = new see_vendor_form();
            jump.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            order jump = new order();
            jump.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            update_customer jump = new update_customer();
            jump.Show();
            this.Hide();
        }

        private void customer_Load(object sender, EventArgs e)
        {

        }
    }
}
