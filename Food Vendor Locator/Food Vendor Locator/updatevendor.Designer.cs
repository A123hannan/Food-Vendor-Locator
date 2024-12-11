namespace Food_Vendor_Locator
{
    partial class updatevendor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vendorid = new System.Windows.Forms.TextBox();
            this.vendorname = new System.Windows.Forms.TextBox();
            this.vendoremail = new System.Windows.Forms.TextBox();
            this.vendorphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.vendorpass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vendorid
            // 
            this.vendorid.Location = new System.Drawing.Point(154, 59);
            this.vendorid.Name = "vendorid";
            this.vendorid.Size = new System.Drawing.Size(181, 26);
            this.vendorid.TabIndex = 0;
            // 
            // vendorname
            // 
            this.vendorname.Location = new System.Drawing.Point(154, 120);
            this.vendorname.Name = "vendorname";
            this.vendorname.Size = new System.Drawing.Size(181, 26);
            this.vendorname.TabIndex = 2;
            // 
            // vendoremail
            // 
            this.vendoremail.Location = new System.Drawing.Point(154, 194);
            this.vendoremail.Name = "vendoremail";
            this.vendoremail.Size = new System.Drawing.Size(181, 26);
            this.vendoremail.TabIndex = 3;
            // 
            // vendorphone
            // 
            this.vendorphone.Location = new System.Drawing.Point(154, 266);
            this.vendorphone.Name = "vendorphone";
            this.vendorphone.Size = new System.Drawing.Size(181, 26);
            this.vendorphone.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vendor Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 77);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // vendorpass
            // 
            this.vendorpass.Location = new System.Drawing.Point(154, 335);
            this.vendorpass.Name = "vendorpass";
            this.vendorpass.Size = new System.Drawing.Size(181, 26);
            this.vendorpass.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // updatevendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 436);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vendorpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendorphone);
            this.Controls.Add(this.vendoremail);
            this.Controls.Add(this.vendorname);
            this.Controls.Add(this.vendorid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updatevendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updatevendor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox vendorid;
        private System.Windows.Forms.TextBox vendorname;
        private System.Windows.Forms.TextBox vendoremail;
        private System.Windows.Forms.TextBox vendorphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vendorpass;
        private System.Windows.Forms.Button button2;
    }
}