namespace SlideShowApp
{
    partial class frmBookStore
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
            this.lbBookInfo = new System.Windows.Forms.ListBox();
            this.cbListAs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbBookInfo
            // 
            this.lbBookInfo.FormattingEnabled = true;
            this.lbBookInfo.Location = new System.Drawing.Point(114, 98);
            this.lbBookInfo.Name = "lbBookInfo";
            this.lbBookInfo.Size = new System.Drawing.Size(593, 303);
            this.lbBookInfo.TabIndex = 1;
            // 
            // cbListAs
            // 
            this.cbListAs.FormattingEnabled = true;
            this.cbListAs.Location = new System.Drawing.Point(114, 71);
            this.cbListAs.Name = "cbListAs";
            this.cbListAs.Size = new System.Drawing.Size(210, 21);
            this.cbListAs.TabIndex = 2;
            this.cbListAs.SelectedIndexChanged += new System.EventHandler(this.cbListAs_SelectedIndexChanged);
            // 
            // frmBookStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 489);
            this.Controls.Add(this.cbListAs);
            this.Controls.Add(this.lbBookInfo);
            this.Name = "frmBookStore";
            this.Text = "frmBookStore";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbBookInfo;
        private System.Windows.Forms.ComboBox cbListAs;
    }
}