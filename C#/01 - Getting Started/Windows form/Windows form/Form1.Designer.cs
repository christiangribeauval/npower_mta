namespace Windows_form
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
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Purple;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Fuchsia;
			this.button1.Location = new System.Drawing.Point(200, 58);
			this.button1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 35);
			this.button1.TabIndex = 0;
			this.button1.Text = "A Message";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Windows_form.Properties.Resources.level_up_real;
			this.ClientSize = new System.Drawing.Size(584, 192);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Hanzel Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
			this.Name = "Form1";
			this.Text = "A New Message";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
	}
}

