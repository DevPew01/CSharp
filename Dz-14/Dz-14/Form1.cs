using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int groupBoxCount;

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1)
            {
                Control cntr = null;
                switch(comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            Button button = new Button();
                            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                            button.Size = new Size(Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
                            if (!String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
                                button.Location = new Point(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
                            button.Text = "Button";
                            cntr = button;
                            break;
                        }
                    case 1:
                        {
                            Label label = new Label();
                            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                                label.Size = new Size(Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
                            if (!String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
                                label.Location = new Point(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
                            label.Text = "Label";
                            cntr = label;
                            break;
                        }
                    case 2:
                        {
                            TextBox textBox = new TextBox();
                            textBox.Text = "text box";
                            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                                textBox.Size = new Size(Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
                            if (!String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
                                textBox.Location = new Point(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
                            cntr = textBox;
                            break;
                        }
                    case 3:
                        {
                            Panel panel = new Panel();
                            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                                panel.Size = new Size(Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
                            if (!String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
                                panel.Location = new Point(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
                            cntr = panel;
                            break;
                        }
                    case 4:
                        {
                            GroupBox groupBox = new GroupBox();
                            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
                                groupBox.Size = new Size(Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
                            if (!String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
                                groupBox.Location = new Point(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
                            groupBoxCount++;
                            groupBox.Text = "Group box"+ groupBoxCount.ToString();
                            cntr = groupBox;
                            break;
                        }

                }
                if (treeView1.Nodes.Count == 0)
                {
                    treeView1.Nodes.Add(cntr.Text);
                    groupBox3.Controls.Add(cntr);
                }
                else if (treeView1.SelectedNode!=null && treeView1.SelectedNode.Text.Contains("Group box"))
                {
                    treeView1.SelectedNode.Nodes.Add(cntr.Text);
                    foreach (Control c in groupBox3.Controls)
                    {
                        if (c.Text == treeView1.SelectedNode.Text)
                        {
                            c.Controls.Add(cntr);
                        }
                    }
                }
                else
                {
                    treeView1.Nodes.Add(cntr.Text);
                    groupBox3.Controls.Add(cntr);
                }
            }
        }
    }
}
