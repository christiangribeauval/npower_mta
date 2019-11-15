using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Manipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringVar = textBox1.Text;

            textBox1.Text = stringVar.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringTrim = textBox2.Text;

            stringTrim = stringTrim.Trim();

            int stringLength = stringTrim.Length;

            MessageBox.Show(stringLength.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stringEmail = textBox3.Text;

            int result = stringEmail.IndexOf("@");

            if (result == -1)
                {
                MessageBox.Show("Invalid Email");
                }
            else
            {
                result++;
                MessageBox.Show("@ found at position " + result.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string stringInsert = textBox4.Text;

            stringInsert = stringInsert.Insert(5, "More ");

            MessageBox.Show(textBox4.Text);
            MessageBox.Show(stringInsert);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string paddingLeft = textBox5.Text;

            paddingLeft = paddingLeft.PadLeft(20,'*');

            textBox5.Text = paddingLeft;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string oldString = "some text text text";

            MessageBox.Show(oldString);

            string newString = oldString.Remove(10, 9);

            MessageBox.Show(newString);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string stringEmail = "me@me.co.ul";

            string result = "";

            result = stringEmail.Substring(5, 5);

            if (result == ".co.uk")
            {
                MessageBox.Show("email address ok");
            }
            else
            {
                MessageBox.Show("email address bad");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string lineOfText = "item1,item2,item3";
            string joinedText = "";

            string[] wordArray = lineOfText.Split(',');

            MessageBox.Show(wordArray[0]);
            MessageBox.Show(wordArray[1]);
            MessageBox.Show(wordArray[2]);

            joinedText = String.Join("-", wordArray);
            MessageBox.Show(joinedText);
        }
    }
}
