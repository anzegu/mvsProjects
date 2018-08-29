using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace notepad
{
    public partial class notepad : Form
    {
        string filename = "untitled.rtf";

        //konstruktor
        public notepad()
        {
            InitializeComponent();

            this.Text = "notepad - " + filename;
        }

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            filename = "untitled.rtf";
            this.Text = "notepad - " + filename;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //če je uporabnik izbral file in kliknil OK
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filename = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(filename);
                    this.Text = "notepad - " + filename;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //če je uporabnik izbral file in kliknil OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filename = openFileDialog1.FileName;
                    richTextBox1.LoadFile(filename);
                    this.Text = "notepad - " + filename;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //klik na gumb ali vnos n meni
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool checkedState;
            if (sender == boldToolStripButton)
            {
                checkedState = boldToolStripButton.Checked;
                boldToolStripMenuItem.Checked = checkedState;
            }

            else
            {
                checkedState = boldToolStripMenuItem.Checked;
                boldToolStripButton.Checked = checkedState;
            }

            boldStripStatusLabel.Enabled = checkedState;

            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;

            if (checkedState)
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
                boldStripStatusLabel.Enabled = true;
                boldToolStripButton.Checked = true;
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
                boldStripStatusLabel.Enabled = false;
                boldToolStripButton.Checked = false;
            }

            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool checkedState;
            if (sender == italicToolStripButton)
            {
                checkedState = italicToolStripButton.Checked;
                italicToolStripMenuItem.Checked = checkedState;
            }

            else
            {
                checkedState = italicToolStripMenuItem.Checked;
                italicToolStripButton.Checked = checkedState;
            }

            italicStripStatusLabel.Enabled = checkedState;

            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;

            if (checkedState)
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
                italicStripStatusLabel.Enabled = true;
                italicToolStripButton.Checked = true;
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
                italicStripStatusLabel.Enabled = false;
                italicToolStripButton.Checked = false;
            }

                richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool checkedState;
            if (sender == underlineToolStripButton)
            {
                checkedState = underlineToolStripButton.Checked;
                underlineToolStripMenuItem.Checked = checkedState;
            }

            else
            {
                checkedState = underlineToolStripMenuItem.Checked;
                underlineToolStripButton.Checked = checkedState;
            }

            underlineStripStatusLabel.Enabled = checkedState;

            Font oldFont = richTextBox1.SelectionFont;
            Font newFont;

            if (checkedState)
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
                underlineStripStatusLabel.Enabled = true;
                underlineToolStripButton.Checked = true;
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
                underlineStripStatusLabel.Enabled = false;
                underlineToolStripButton.Checked = false;
            }

                richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold)
            {
                boldToolStripMenuItem.Checked = true;
                boldStripStatusLabel.Enabled = true;
            }
            else
            {
                boldToolStripMenuItem.Checked = false;
                boldStripStatusLabel.Enabled = false;
            }

            if (richTextBox1.SelectionFont.Italic)
            {
                italicToolStripMenuItem.Checked = true;
                italicStripStatusLabel.Enabled = true;
            }
                
            else
            {
                italicToolStripMenuItem.Checked = false;
                italicStripStatusLabel.Enabled = false;
            }
                

            if (richTextBox1.SelectionFont.Underline)
            {
                underlineToolStripMenuItem.Checked = true;
                underlineStripStatusLabel.Enabled = true;
            }
                
            else
            {
                underlineToolStripMenuItem.Checked = false;
                underlineStripStatusLabel.Enabled = false;
            }
                

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            textLengthStripStatusLabel.Text = "Length: " + richTextBox1.Text.Length;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File | *.txt";
            saveFileDialog1.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm myForm = new aboutForm();

            myForm.Show();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog myForm = new FontDialog();
            if(myForm.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = myForm.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog myForm = new ColorDialog();
            if (myForm.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = myForm.Color;
            }
        }

        private void fontToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = fontToolStripComboBox.SelectedItem.ToString();

            Font oldFont = richTextBox1.SelectionFont;
            Font newFont = new Font(selectedFontName,oldFont.Size,oldFont.Style);

            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
        }

        private void biggerToolStripButton_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox1.SelectionFont;
            float oldSize = oldFont.Size;

            Font newFont = new Font(oldFont.FontFamily,oldSize+1,oldFont.Style);

            richTextBox1.SelectionFont = newFont;
        }

        private void smallerToolStripButton_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox1.SelectionFont;
            float oldSize = oldFont.Size;

            Font newFont = new Font(oldFont.FontFamily, oldSize-1, oldFont.Style);

            richTextBox1.SelectionFont = newFont;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 20, y = 30;

            string[] lines = richTextBox1.Text.Split('\n');

            foreach(string line in lines)
            {
                e.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, x, y);

                y += 20;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) 
                printDocument1.Print();
        }

        private void pritPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
