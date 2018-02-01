namespace RegularExpressionsApp
{
    partial class frmRegex
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
            this.lblMatch = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.txtBoxPattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMatch
            // 
            this.lblMatch.Location = new System.Drawing.Point(47, 138);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(198, 122);
            this.lblMatch.TabIndex = 0;
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput.Location = new System.Drawing.Point(145, 105);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(166, 26);
            this.txtBoxInput.TabIndex = 1;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(313, 282);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(126, 56);
            this.btnMatch.TabIndex = 2;
            this.btnMatch.Text = "match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // txtBoxPattern
            // 
            this.txtBoxPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPattern.Location = new System.Drawing.Point(145, 190);
            this.txtBoxPattern.Name = "txtBoxPattern";
            this.txtBoxPattern.Size = new System.Drawing.Size(166, 26);
            this.txtBoxPattern.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pattern";
            // 
            // frmRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPattern);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.lblMatch);
            this.Name = "frmRegex";
            this.Text = "Regex";
            this.Load += new System.EventHandler(this.frmRegex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.TextBox txtBoxPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

