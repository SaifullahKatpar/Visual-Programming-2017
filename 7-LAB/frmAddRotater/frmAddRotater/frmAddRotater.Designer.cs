namespace frmAddRotater
{
    partial class frmAddRotater
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
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(34, 55);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(199, 121);
            this.myPictureBox.TabIndex = 0;
            this.myPictureBox.TabStop = false;
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // frmAddRotater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.myPictureBox);
            this.Name = "frmAddRotater";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.Timer myTimer;
    }
}

