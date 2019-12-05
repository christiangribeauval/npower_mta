using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {

                textBox1.Cut();

            }
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo == true)
            {

                textBox1.Undo();
                textBox1.ClearUndo();

            }
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {

                textBox1.Copy();

            }
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {

                textBox2.Paste();
                Clipboard.Clear();

            }
        }

        private void mnuViewTextBoxes_Click(object sender, EventArgs e)
        {
            mnuViewTextBoxes.Checked = !mnuViewTextBoxes.Checked;
            textBox1.Visible = !textBox1.Visible;
            textBox2.Visible = !textBox2.Visible;
        }

        private void mnuViewImages_Click(object sender, EventArgs e)
        {
            string Chosen_File = "";

            openFD.InitialDirectory = "C:";
            openFD.Title = "Insert an Image";
            openFD.FileName = "";
            openFD.Filter = "JPEG Images|*.jpg|GIF Images|*.gif";

            if (openFD.ShowDialog() == DialogResult.Cancel)
            {

                MessageBox.Show("Operation Cancelled");

            }
            else
            {
                Chosen_File = openFD.FileName;
                pictureBox1.Image = Image.FromFile(Chosen_File);
            }
        
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            string Chosen_File = "";

            openFD.InitialDirectory = "C:";
            openFD.Title = "Open a Text File";
            openFD.FileName = "";
            openFD.Filter = "Text Files|*.txt|Word Documents|*.doc";

            if (openFD.ShowDialog() != DialogResult.Cancel)
            {

                Chosen_File = openFD.FileName;
                richTextBox1.LoadFile(Chosen_File, RichTextBoxStreamType.PlainText);

            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            string Saved_File = "";

            openFD.InitialDirectory = "C:";
            openFD.Title = "Save a Text File";
            openFD.FileName = "";
            openFD.Filter = "Text Files|*.txt|Word Documents|*.doc";

            if (openFD.ShowDialog() != DialogResult.Cancel)
            {

                Saved_File = openFD.FileName;
                richTextBox1.SaveFile(Saved_File, RichTextBoxStreamType.PlainText);

            }
        }
    }
}
