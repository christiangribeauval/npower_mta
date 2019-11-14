using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {

            int outputValue = 0;
            bool isNumber = false;
            bool isNumber2 = false;
            bool isNumber3 = false;

            isNumber = int.TryParse(textBox1.Text, out outputValue);
            isNumber2 = int.TryParse(textBox2.Text, out outputValue);
            isNumber3 = int.TryParse(textBox3.Text, out outputValue);

            if (isNumber && isNumber2 && isNumber3)
            {
                int answer = 0;
                int loopStart;
                int loopEnd;
                int multiplyBy;

                loopStart = int.Parse(textBox1.Text);
                loopEnd = int.Parse(textBox2.Text);
                multiplyBy = int.Parse(textBox3.Text);

                listBox1.Items.Clear();

                for (int i = loopStart; i < (loopEnd + 1); i++)
                {
                    answer = multiplyBy * i;

                    listBox1.Items.Add(i + " times " + multiplyBy + " = " + answer.ToString());
                }
                MessageBox.Show(answer.ToString());
            }
            else
            {
                MessageBox.Show("Type numbers in the boxes");
            }

            
        }
    }
}
