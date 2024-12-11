namespace Food_Vendor_Locator
{
    partial class itemform
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
            this.itmname = new System.Windows.Forms.TextBox();
            this.itmprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.additm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.vendorid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // itmname
            // 
            this.itmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmname.Location = new System.Drawing.Point(180, 60);
            this.itmname.Name = "itmname";
            this.itmname.Size = new System.Drawing.Size(191, 35);
            this.itmname.TabIndex = 0;
            this.itmname.TextChanged += new System.EventHandler(this.itmname_TextChanged);
            // 
            // itmprice
            // 
            this.itmprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmprice.Location = new System.Drawing.Point(180, 159);
            this.itmprice.Name = "itmprice";
            this.itmprice.Size = new System.Drawing.Size(191, 35);
            this.itmprice.TabIndex = 1;
            this.itmprice.TextChanged += new System.EventHandler(this.itmprice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter item name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter item price";
            // 
            // additm
            // 
            this.additm.Location = new System.Drawing.Point(513, 203);
            this.additm.Name = "additm";
            this.additm.Size = new System.Drawing.Size(194, 72);
            this.additm.TabIndex = 4;
            this.additm.Text = "ADD ITEM";
            this.additm.UseVisualStyleBackColor = true;
            this.additm.Click += new System.EventHandler(this.additm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Vendor Id";
            // 
            // vendorid
            // 
            this.vendorid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorid.Location = new System.Drawing.Point(180, 267);
            this.vendorid.Name = "vendorid";
            this.vendorid.Size = new System.Drawing.Size(191, 35);
            this.vendorid.TabIndex = 5;
            this.vendorid.TextChanged += new System.EventHandler(this.vendorid_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 84);
            this.button1.TabIndex = 7;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Food_Vendor_Locator.Properties.Resources.WhatsApp_Image_2024_06_13_at_11_41_08_005426c1;
            this.pictureBox1.Location = new System.Drawing.Point(0, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // itemform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vendorid);
            this.Controls.Add(this.additm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itmprice);
            this.Controls.Add(this.itmname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "itemform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "itemform";
            this.Load += new System.EventHandler(this.itemform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itmname;
        private System.Windows.Forms.TextBox itmprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button additm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vendorid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}