namespace ControlsPractice
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btnClick1 = new System.Windows.Forms.Button();
            this.btnClick2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(101, 99);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = " Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnClick1
            // 
            this.btnClick1.Location = new System.Drawing.Point(201, 99);
            this.btnClick1.Name = "btnClick1";
            this.btnClick1.Size = new System.Drawing.Size(75, 23);
            this.btnClick1.TabIndex = 1;
            this.btnClick1.Text = "Click";
            this.btnClick1.UseVisualStyleBackColor = true;
            this.btnClick1.Click += new System.EventHandler(this.btnClick1_Click);
            // 
            // btnClick2
            // 
            this.btnClick2.Location = new System.Drawing.Point(318, 99);
            this.btnClick2.Name = "btnClick2";
            this.btnClick2.Size = new System.Drawing.Size(75, 23);
            this.btnClick2.TabIndex = 2;
            this.btnClick2.Text = " Click";
            this.btnClick2.UseVisualStyleBackColor = true;
            this.btnClick2.Click += new System.EventHandler(this.btnClick2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 227);
            this.Controls.Add(this.btnClick2);
            this.Controls.Add(this.btnClick1);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnClick1;
        private System.Windows.Forms.Button btnClick2;
    }
}

