﻿namespace Numbers_From_Text_Boxes
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
			this.btnAnswer = new System.Windows.Forms.Button();
			this.tbFirstNumber = new System.Windows.Forms.TextBox();
			this.tbSecondNumber = new System.Windows.Forms.TextBox();
			this.tbThirdNumber = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnAnswer
			// 
			this.btnAnswer.Location = new System.Drawing.Point(90, 90);
			this.btnAnswer.Name = "btnAnswer";
			this.btnAnswer.Size = new System.Drawing.Size(75, 25);
			this.btnAnswer.TabIndex = 0;
			this.btnAnswer.Text = "Answer";
			this.btnAnswer.UseVisualStyleBackColor = true;
			this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
			// 
			// tbFirstNumber
			// 
			this.tbFirstNumber.Location = new System.Drawing.Point(40, 35);
			this.tbFirstNumber.Name = "tbFirstNumber";
			this.tbFirstNumber.Size = new System.Drawing.Size(50, 20);
			this.tbFirstNumber.TabIndex = 1;
			this.tbFirstNumber.Text = "5656";
			// 
			// tbSecondNumber
			// 
			this.tbSecondNumber.Location = new System.Drawing.Point(165, 35);
			this.tbSecondNumber.Name = "tbSecondNumber";
			this.tbSecondNumber.Size = new System.Drawing.Size(50, 20);
			this.tbSecondNumber.TabIndex = 2;
			this.tbSecondNumber.Text = "7";
			// 
			// tbThirdNumber
			// 
			this.tbThirdNumber.Location = new System.Drawing.Point(289, 35);
			this.tbThirdNumber.Name = "tbThirdNumber";
			this.tbThirdNumber.Size = new System.Drawing.Size(50, 20);
			this.tbThirdNumber.TabIndex = 3;
			this.tbThirdNumber.Text = "2156";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tbThirdNumber);
			this.Controls.Add(this.tbSecondNumber);
			this.Controls.Add(this.tbFirstNumber);
			this.Controls.Add(this.btnAnswer);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAnswer;
		private System.Windows.Forms.TextBox tbFirstNumber;
		private System.Windows.Forms.TextBox tbSecondNumber;
		private System.Windows.Forms.TextBox tbThirdNumber;
	}
}

