namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMonth.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblMonth.Location = new System.Drawing.Point(37, 56);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(100, 23);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Enter Month Number";
            this.lblMonth.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSeason
            // 
            this.lblSeason.BackColor = System.Drawing.SystemColors.Info;
            this.lblSeason.ForeColor = System.Drawing.Color.Turquoise;
            this.lblSeason.Location = new System.Drawing.Point(162, 164);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(132, 20);
            this.lblSeason.TabIndex = 1;
            this.lblSeason.Text = "Season will be dispalyed";
            this.lblSeason.Click += new System.EventHandler(this.lblSeason_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(165, 59);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(129, 20);
            this.txtMonth.TabIndex = 2;
            this.txtMonth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find Season";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.lblMonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button button1;
    }
}

