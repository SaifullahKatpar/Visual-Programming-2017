namespace Mid_Lab_2
{
    partial class frmStopWatch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStopWatch));
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblTimeCount = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnTimeCount = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSec
            // 
            this.lblSec.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(34, 50);
            this.lblSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(133, 43);
            this.lblSec.TabIndex = 0;
            this.lblSec.Text = "Seconds";
            this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(206, 50);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(133, 43);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Minutes";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHour
            // 
            this.lblHour.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(379, 50);
            this.lblHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(133, 43);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "Hours";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeCount
            // 
            this.lblTimeCount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTimeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeCount.Location = new System.Drawing.Point(34, 130);
            this.lblTimeCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeCount.Name = "lblTimeCount";
            this.lblTimeCount.Size = new System.Drawing.Size(133, 252);
            this.lblTimeCount.TabIndex = 3;
            this.lblTimeCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnActivate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.Location = new System.Drawing.Point(264, 154);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(215, 64);
            this.btnActivate.TabIndex = 4;
            this.btnActivate.Text = " Activate";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnTimeCount
            // 
            this.btnTimeCount.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTimeCount.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeCount.Location = new System.Drawing.Point(264, 239);
            this.btnTimeCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimeCount.Name = "btnTimeCount";
            this.btnTimeCount.Size = new System.Drawing.Size(215, 64);
            this.btnTimeCount.TabIndex = 5;
            this.btnTimeCount.Text = " Time Count";
            this.btnTimeCount.UseVisualStyleBackColor = false;
            this.btnTimeCount.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmStopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(544, 438);
            this.Controls.Add(this.btnTimeCount);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.lblTimeCount);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblSec);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStopWatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stop Watch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblTimeCount;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnTimeCount;
        private System.Windows.Forms.Timer timer1;
    }
}

