using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Multi_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string changeCase = Form1.tb.Text;

            if (radioButton1.Checked==true)
            {
                changeCase = changeCase.ToUpper();
            }
            else if (radioButton2.Checked == true)
            {
                changeCase = changeCase.ToLower();
            }
            else if (radioButton3.Checked == true)
            {
                CultureInfo properCase = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfoObject = properCase.TextInfo;

                changeCase = textInfoObject.ToTitleCase(changeCase);
            }
            Form1.tb.Text = changeCase;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
