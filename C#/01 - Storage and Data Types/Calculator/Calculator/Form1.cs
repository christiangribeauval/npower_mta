﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		double total1 = 0;
		double total2 = 0;


		private void btnSix_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btnSix.Text;
		}

		private void btnOne_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btnOne.Text;
		}

		private void btnTwo_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
		}

		private void btnThree_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btnThree.Text;
		}

		private void btnFour_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btnFour.Text;
		}

		private void btnFive_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btnFive.Text;
		}

		private void btnSeven_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
		}

		private void btnEight_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btnEight.Text;
		}

		private void btnNine_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btnNine.Text;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtDisplay.Clear();
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			total1 += double.Parse(txtDisplay.Text);
			txtDisplay.Clear();

            theOperator = "+";
        }

		private void btnEquals_Click(object sender, EventArgs e)
		{
            switch (theOperator)
            {
                case "+":
                    total2 = total1 + double.Parse(txtDisplay.Text);
                    break;
                case "-":
                    total2 = total1 - double.Parse(txtDisplay.Text);
                    break;
                case "*":
                    total2 = total1 * double.Parse(txtDisplay.Text);
                    break;
                case "/":
                    total2 = total1 / double.Parse(txtDisplay.Text);
                    break;
            }
            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }

		private void btnPoint_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
		}

        string theOperator;

        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "/";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }
    }
}
