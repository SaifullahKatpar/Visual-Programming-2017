namespace DesktopReporting
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
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.Location = new System.Drawing.Point(94, 22);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(163, 44);
            this.btnScreenShot.TabIndex = 0;
            this.btnScreenShot.Text = "Take Screen Shot";
            this.btnScreenShot.UseVisualStyleBackColor = true;
            this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(263, 22);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(163, 44);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = " Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(182, 93);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(125, 37);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "New Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 466);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnScreenShot);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnScreenShot;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReport;
    }
}

