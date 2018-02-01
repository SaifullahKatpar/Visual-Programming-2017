namespace frmDynamicArray
{
    partial class frmDynamicArray
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
            this.txtStudents = new System.Windows.Forms.TextBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.lblStudents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudents
            // 
            this.txtStudents.Location = new System.Drawing.Point(95, 59);
            this.txtStudents.Name = "txtStudents";
            this.txtStudents.Size = new System.Drawing.Size(217, 20);
            this.txtStudents.TabIndex = 0;
            this.txtStudents.Text = "Enter Student Name";
            this.txtStudents.TextChanged += new System.EventHandler(this.txtStudents_TextChanged);
            this.txtStudents.Enter += new System.EventHandler(this.enterdTextBox);
            this.txtStudents.Leave += new System.EventHandler(this.leftTextBox);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(318, 59);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecord.TabIndex = 1;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStudents
            // 
            this.lblStudents.Location = new System.Drawing.Point(102, 94);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(291, 183);
            this.lblStudents.TabIndex = 0;
            // 
            // frmDynamicArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 345);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.txtStudents);
            this.Name = "frmDynamicArray";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDynamicArray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudents;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label lblStudents;
    }
}

