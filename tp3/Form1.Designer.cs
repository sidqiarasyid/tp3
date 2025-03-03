namespace tp3
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
            this.txtField = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(12, 31);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(216, 26);
            this.txtField.TabIndex = 0;
            this.txtField.TextChanged += new System.EventHandler(this.txtField_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 63);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 32);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // hasil
            // 
            this.hasil.AutoSize = true;
            this.hasil.Location = new System.Drawing.Point(12, 108);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(0, 20);
            this.hasil.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label hasil;
    }
}

