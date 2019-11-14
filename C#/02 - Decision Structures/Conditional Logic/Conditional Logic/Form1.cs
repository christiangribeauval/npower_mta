using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conditional_Logic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ButtonClicked = false;
            if (ButtonClicked == true)
            {
                MessageBox.Show("The Button was clicked");
            }
            else
            {
                MessageBox.Show("The Button was not clicked");
            }
        }
    }
}
