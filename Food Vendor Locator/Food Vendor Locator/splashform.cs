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
    public partial class splashform : Form
    {
        public splashform()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

            }
            else
            {

                timer2.Stop();
                rolepanel f3 = new rolepanel();
                Visible = false;
                f3.Show();



            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void splashform_Load(object sender, EventArgs e)
        {
            timer2.Start();
            progressBar1.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

    }
}