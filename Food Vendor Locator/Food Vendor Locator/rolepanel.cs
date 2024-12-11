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
    public partial class rolepanel : Form
    {
        public rolepanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminlogin jump = new adminlogin();
            jump.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginform jump = new loginform();
            jump.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginform jump = new loginform();
            jump.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rolepanel_Load(object sender, EventArgs e)
        {

        }
    }
}
