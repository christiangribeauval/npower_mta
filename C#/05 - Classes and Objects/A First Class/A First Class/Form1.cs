using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_First_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HappyBirthday.GetMessage+textBox1.Text+"!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            NotBirthday birthdayMessage;

            birthdayMessage = new NotBirthday();
            birthdayMessage.MyProperty = textBox1.Text;
            birthdayMessage.presentCount = Int32.Parse(textBox2.Text);
            MessageBox.Show(birthdayMessage.MyProperty);


        }
    }
}
