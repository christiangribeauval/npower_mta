﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int firstNumber;
			int secondNumber;
			int integerAnswer;

			firstNumber = 10;
			secondNumber = 32;

			integerAnswer = firstNumber + secondNumber;
			MessageBox.Show(integerAnswer.ToString());

		}

		private void btnAddFloats_Click(object sender, EventArgs e)
		{
			float firstNumber;
			float secondNumber;
			float floatAnswer;

			firstNumber = 10.5F;
			secondNumber = 32.5F;

			
			int integerAnswer = (int)firstNumber + (int)secondNumber;
			floatAnswer = firstNumber + secondNumber + integerAnswer;

			MessageBox.Show(floatAnswer.ToString());
			//MessageBox.Show(integerAnswer.ToString());
		}

		private void btnSubtract_Click(object sender, EventArgs e)
		{
			int answerSubtract;
			int numberOne = 12;
			int numberTwo = 4;



			answerSubtract = 50 - numberOne - numberTwo;

			MessageBox.Show(answerSubtract.ToString());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int firstNumber;
			int secondNumber;
			int thirdNumber;
			int answer;

			firstNumber = 100;
			secondNumber = 75;
			thirdNumber = 50;

			answer = firstNumber * (secondNumber / thirdNumber)

			MessageBox.Show(answer.ToString());


		}
	}
}
