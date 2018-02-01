namespace WebStart
{
    partial class GoogleForm
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
            this.Google = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Google
            // 
            this.Google.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Google.Location = new System.Drawing.Point(0, 0);
            this.Google.MinimumSize = new System.Drawing.Size(20, 20);
            this.Google.Name = "Google";
            this.Google.Size = new System.Drawing.Size(675, 491);
            this.Google.TabIndex = 0;
            this.Google.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.Google.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Google_DocumentCompleted);
            // 
            // GoogleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 491);
            this.Controls.Add(this.Google);
            this.Name = "GoogleForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser Google;
    }
}

