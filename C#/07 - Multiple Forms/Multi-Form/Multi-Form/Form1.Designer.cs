namespace Multi_Form
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
            this.txtChangeCase = new System.Windows.Forms.TextBox();
            this.btnFormTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChangeCase
            // 
            this.txtChangeCase.Location = new System.Drawing.Point(54, 77);
            this.txtChangeCase.Name = "txtChangeCase";
            this.txtChangeCase.Size = new System.Drawing.Size(100, 20);
            this.txtChangeCase.TabIndex = 0;
            this.txtChangeCase.Text = "some default text";
            // 
            // btnFormTwo
            // 
            this.btnFormTwo.Location = new System.Drawing.Point(54, 129);
            this.btnFormTwo.Name = "btnFormTwo";
            this.btnFormTwo.Size = new System.Drawing.Size(100, 23);
            this.btnFormTwo.TabIndex = 1;
            this.btnFormTwo.Text = "Change Case";
            this.btnFormTwo.UseVisualStyleBackColor = true;
            this.btnFormTwo.Click += new System.EventHandler(this.btnFormTwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormTwo);
            this.Controls.Add(this.txtChangeCase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChangeCase;
        private System.Windows.Forms.Button btnFormTwo;
    }
}

