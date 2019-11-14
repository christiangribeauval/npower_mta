using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers_From_Text_Boxes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAnswer_Click(object sender, EventArgs e)
		{
			int firstTextBoxNumber;
			int secondTextBoxNumber;
			int thirdTextBoxNumber;
			int answer;

			firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
			secondTextBoxNumber = int.Parse(tbSecondNumber.Text);
			thirdTextBoxNumber = int.Parse(tbThirdNumber.Text);

			answer = (firstTextBoxNumber / secondTextBoxNumber) - thirdTextBoxNumber;
			MessageBox.Show(answer.ToString());
		}
	}
}
