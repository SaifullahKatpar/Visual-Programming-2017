namespace WindowsFormsApplication1
{
    partial class BillCalculation
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
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCalculateBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnits
            // 
            this.lblUnits.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblUnits.Location = new System.Drawing.Point(24, 53);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(79, 23);
            this.lblUnits.TabIndex = 0;
            this.lblUnits.Text = "Enter Units";
            this.lblUnits.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBill
            // 
            this.lblBill.ForeColor = System.Drawing.Color.Coral;
            this.lblBill.Location = new System.Drawing.Point(35, 102);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(68, 20);
            this.lblBill.TabIndex = 1;
            this.lblBill.Text = "Bill";
            this.lblBill.Click += new System.EventHandler(this.lblBill_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCalculateBill
            // 
            this.btnCalculateBill.Location = new System.Drawing.Point(109, 167);
            this.btnCalculateBill.Name = "btnCalculateBill";
            this.btnCalculateBill.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateBill.TabIndex = 4;
            this.btnCalculateBill.Text = "CalculateBill";
            this.btnCalculateBill.UseVisualStyleBackColor = true;
            this.btnCalculateBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 261);
            this.Controls.Add(this.btnCalculateBill);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.lblUnits);
            this.Name = "BillCalculation";
            this.Text = "BillCalculation";
            this.Load += new System.EventHandler(this.BillCalculation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCalculateBill;
    }
}