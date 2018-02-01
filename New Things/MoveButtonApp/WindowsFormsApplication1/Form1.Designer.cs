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
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(88, 42);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(150, 170);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(75, 23);
            this.btnDemo.TabIndex = 1;
            this.btnDemo.Text = " Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.Location = new System.Drawing.Point(236, 80);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(75, 23);
            this.btnBottom.TabIndex = 2;
            this.btnBottom.Text = " Bottom";
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(88, 80);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(75, 23);
            this.btnTop.TabIndex = 3;
            this.btnTop.Text = " Top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(236, 42);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = " Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 311);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btnRight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnLeft;
    }
}

