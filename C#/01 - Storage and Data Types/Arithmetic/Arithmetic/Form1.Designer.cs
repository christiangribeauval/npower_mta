﻿namespace Arithmetic
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnAddFloats = new System.Windows.Forms.Button();
			this.btnSubtract = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(100, 30);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Integer-Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnAddFloats
			// 
			this.btnAddFloats.Location = new System.Drawing.Point(100, 70);
			this.btnAddFloats.Name = "btnAddFloats";
			this.btnAddFloats.Size = new System.Drawing.Size(75, 23);
			this.btnAddFloats.TabIndex = 1;
			this.btnAddFloats.Text = "Float-Add";
			this.btnAddFloats.UseVisualStyleBackColor = true;
			this.btnAddFloats.Click += new System.EventHandler(this.btnAddFloats_Click);
			// 
			// btnSubtract
			// 
			this.btnSubtract.Location = new System.Drawing.Point(100, 110);
			this.btnSubtract.Name = "btnSubtract";
			this.btnSubtract.Size = new System.Drawing.Size(75, 23);
			this.btnSubtract.TabIndex = 2;
			this.btnSubtract.Text = "Subtract";
			this.btnSubtract.UseVisualStyleBackColor = true;
			this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(87, 148);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 30);
			this.button1.TabIndex = 3;
			this.button1.Text = "Add and Subtract";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSubtract);
			this.Controls.Add(this.btnAddFloats);
			this.Controls.Add(this.btnAdd);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnAddFloats;
		private System.Windows.Forms.Button btnSubtract;
		private System.Windows.Forms.Button button1;
	}
}

