namespace DrawingApp
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
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.Location = new System.Drawing.Point(147, 37);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(429, 361);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(20, 313);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(111, 59);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = " Draw Something";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(55, 37);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(76, 20);
            this.tbX1.TabIndex = 2;
            this.tbX1.Text = " ";
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(55, 63);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(76, 20);
            this.tbY1.TabIndex = 3;
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(55, 89);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(76, 20);
            this.tbX2.TabIndex = 4;
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(55, 115);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(76, 20);
            this.tbY2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = " X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = " Y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = " Y2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 422);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbY2);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbY1);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.drawingArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.TextBox tbY1;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbY2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

