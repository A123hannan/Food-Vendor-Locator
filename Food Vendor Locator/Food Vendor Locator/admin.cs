﻿using System;
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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rolepanel jump = new rolepanel();
            jump.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete_vendor_form jump = new delete_vendor_form();
            jump.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete_customer_form jump = new delete_customer_form();
            jump.Show();
            this.Hide();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
