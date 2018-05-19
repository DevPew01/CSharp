using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.Text = toolStripComboBox1.Items[1].ToString();
            toolStripComboBox2.Text = toolStripComboBox2.Items[1].ToString();
            toolStripComboBox3.Text = toolStripComboBox3.Items[6].ToString();
        }

        private OpenFileDialog fileDialog = new OpenFileDialog();
        private SaveFileDialog saveFile = new SaveFileDialog();
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "Text files (*.txt)|*.txt|MS word (*.doc)|*.doc|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(fileDialog.FileName, Encoding.Default))
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "Text files (*.txt)|*.txt|MS word (*.doc)|*.doc|All files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    writer.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    richTextBox1.SelectionStart += richTextBox1.SelectionLength;
                }
                richTextBox1.Paste();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != null)
                richTextBox1.Cut();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(toolStripComboBox1.SelectedIndex != -1)
            {
                richTextBox1.Font = new Font(toolStripComboBox1.Items[toolStripComboBox1.SelectedIndex].ToString(), 12);
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox2.SelectedIndex != -1)
            {
                switch (toolStripComboBox2.SelectedIndex)
                {
                    case 0:
                        richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
                        break;
                    case 1:
                        richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
                        break;
                    case 2:
                        richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
                        break;
                    case 3:
                        richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
                        break;
                }
               
            }
        }

        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(toolStripComboBox1.SelectedIndex != -1)
            {
                richTextBox1.Font = new Font(toolStripComboBox3.Text, float.Parse(toolStripComboBox3.Text));       
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
                richTextBox1.Undo();
            richTextBox1.ClearUndo();
        }

        private void clearToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
