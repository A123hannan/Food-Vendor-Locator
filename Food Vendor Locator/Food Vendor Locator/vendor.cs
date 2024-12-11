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
    public partial class vendor : Form
    {
        public vendor()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rolepanel jump = new rolepanel();
            jump.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemform jump = new itemform();
            jump.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkitem jump = new checkitem();
            jump.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updatevendor updatevendor = new updatevendor(); 
            updatevendor.Show();
            this.Hide();
        }

        private void vendor_Load(object sender, EventArgs e)
        {

        }
    }
}
