using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ageNumber;
            

            ageNumber = int.Parse(textBox1.Text);
            

            if (ageNumber < 16)
            {
                MessageBox.Show("You're still a youngster!");
            }
            else if (ageNumber > 16 && ageNumber < 25)
            {
                MessageBox.Show("Fame beckons!");
            }
            else if (ageNumber > 25 && ageNumber < 40)
            {
                MessageBox.Show("There's still time!");
            }
            else if (ageNumber > 40)
            {
                MessageBox.Show("You probably missed it!");
            }
        }
    }
}
