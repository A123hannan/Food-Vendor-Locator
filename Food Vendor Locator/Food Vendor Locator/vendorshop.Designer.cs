namespace Food_Vendor_Locator
{
    partial class vendorshop
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ordrbtn = new System.Windows.Forms.Button();
            this.extbtn = new System.Windows.Forms.Button();
            this.locbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(927, 307);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(829, 24);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(136, 37);
            this.showbtn.TabIndex = 2;
            this.showbtn.Text = "SHOW";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(38, 469);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 28);
            this.textBox1.TabIndex = 3;
            // 
            // ordrbtn
            // 
            this.ordrbtn.Location = new System.Drawing.Point(743, 451);
            this.ordrbtn.Name = "ordrbtn";
            this.ordrbtn.Size = new System.Drawing.Size(222, 46);
            this.ordrbtn.TabIndex = 4;
            this.ordrbtn.Text = "ADD TO ORDER";
            this.ordrbtn.UseVisualStyleBackColor = true;
            this.ordrbtn.Click += new System.EventHandler(this.ordrbtn_Click);
            // 
            // extbtn
            // 
            this.extbtn.Location = new System.Drawing.Point(888, 585);
            this.extbtn.Name = "extbtn";
            this.extbtn.Size = new System.Drawing.Size(125, 52);
            this.extbtn.TabIndex = 5;
            this.extbtn.Text = "EXIT";
            this.extbtn.UseVisualStyleBackColor = true;
            this.extbtn.Click += new System.EventHandler(this.extbtn_Click);
            // 
            // locbtn
            // 
            this.locbtn.Location = new System.Drawing.Point(38, 558);
            this.locbtn.Name = "locbtn";
            this.locbtn.Size = new System.Drawing.Size(171, 61);
            this.locbtn.TabIndex = 6;
            this.locbtn.Text = "SEE SHOP";
            this.locbtn.UseVisualStyleBackColor = true;
            this.locbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vendors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ItemID";
            // 
            // vendorshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locbtn);
            this.Controls.Add(this.extbtn);
            this.Controls.Add(this.ordrbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "vendorshop";
            this.Text = "vendorshop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ordrbtn;
        private System.Windows.Forms.Button extbtn;
        private System.Windows.Forms.Button locbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}