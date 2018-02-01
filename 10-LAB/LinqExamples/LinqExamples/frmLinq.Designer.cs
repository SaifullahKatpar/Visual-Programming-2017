namespace LinqExamples
{
    partial class frmLinq
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
            this.filter = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // filter
            // 
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.FormattingEnabled = true;
            this.filter.Location = new System.Drawing.Point(28, 12);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(483, 28);
            this.filter.TabIndex = 0;
            this.filter.Text = " ";
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(28, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(293, 26);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Enter Last Name For Search";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(28, 78);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(293, 26);
            this.txtLname.TabIndex = 2;
            this.txtLname.Text = " Enter Last Name For Seacrh";
            this.txtLname.Click += new System.EventHandler(this.txtLname_Click);
            this.txtLname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(28, 110);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(293, 26);
            this.txtCity.TabIndex = 3;
            this.txtCity.Text = " Enter City For Search";
            this.txtCity.Click += new System.EventHandler(this.txtCity_Click);
            this.txtCity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = " OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = " OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = " OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(28, 162);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(483, 251);
            this.listBox.TabIndex = 7;
            // 
            // frmLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 449);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.filter);
            this.Name = "frmLinq";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLinq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox;
    }
}

