using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace BestOil
{
    public enum OilMark { A95, A98, A92, Gas, Diesel };

    public partial class BestOilForm : Form
    {
        public BestOilForm()
        {
            InitializeComponent();
            comboBox1.Items.Add(OilMark.A95);
            comboBox1.Items.Add(OilMark.A98);
            comboBox1.Items.Add(OilMark.A92);
            comboBox1.Items.Add(OilMark.Gas);
            comboBox1.Items.Add(OilMark.Diesel);
            timer = new System.Windows.Forms.Timer();
            clock = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            timer.Interval = 8000;
            timer.Tick += Timer_Tick;
            comboBox1.Text = OilMark.A95.ToString();
            clock.Tick += Clock_Tick;
            clock.Start();
            toolStripStatusLabel1.Text = "00:00:00";
            if(radioButton2.Checked)
            {
                button1.Click += Button1_Click;
            }
            else
            {
                button1.Click += Button1_Click_2;
            }
            toolStripDropDownButton1.DropDownItems[0].Image = Image.FromFile("UnitedStates.ico");
            toolStripDropDownButton1.DropDownItems[1].Image = Image.FromFile("Ukraine.ico");
            toolStripDropDownButton1.DropDownItems[2].Image = Image.FromFile("Russia.ico");
            toolStripDropDownButton1.Image = toolStripDropDownButton1.DropDownItems[0].Image;
            this.Resize += BestOilForm_Resize;
        }

        private void BestOilForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
            
        }
        private System.Windows.Forms.Timer timer, clock;

        private double allSumm;
        private void Timer_Tick(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Очистить поля?", "Завершение покупок", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                foreach (Control item in Controls)
                {
                    if (item is GroupBox)
                    {
                        GroupBox item1 = (GroupBox)item;
                        foreach (Control item2 in item1.Controls)
                        {
                            if (item2 is TextBox)
                            {
                                TextBox textBox = (TextBox)item2;
                                textBox.Clear();
                            }
                        }
                    }
                }
                label8.Text = "0";
                label9.Text = "0";
                label14.Text = "0";
                timer.Stop();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1)
            {
                textBox3.ReadOnly = true;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        textBox3.Text = (26.7).ToString();
                        break;
                    case 1:
                        textBox3.Text = (29.17).ToString();
                        break;
                    case 2:
                        textBox3.Text = (28.5).ToString();
                        break;
                    case 3:
                        textBox3.Text = (12.5).ToString();
                        break;
                    case 4:
                        textBox3.Text = (25.5).ToString();
                        break;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Clear();
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = true;
                textBox2.Clear();
                groupBox4.Text = "К оплате";
                label10.Text = "грн.";
                label9.Text = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Clear();
                textBox2.ReadOnly = false;
                textBox1.ReadOnly = true;
                textBox1.Clear();
                groupBox4.Text = "К выдачи";
                label10.Text = "л.";
                label9.Text = "0";
            }
        }

        private void BestOilForm_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox10.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox1.Text))
                label9.Text = (Double.Parse(textBox3.Text) * Int32.Parse(textBox1.Text)).ToString();
            else
                label9.Text = "0";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                label9.Text = (Math.Round(Double.Parse(textBox2.Text) / Double.Parse(textBox3.Text), 2)).ToString();
            }
            else
                label9.Text = "0";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox4.Text = (19.7).ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                textBox6.Text = (31).ToString();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                textBox8.Text = (9.3).ToString();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                textBox10.Text = (12).ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text))
                label14.Text = (Double.Parse(textBox4.Text) * Int32.Parse(textBox5.Text) + Double.Parse(label14.Text)).ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox6.Text) && !String.IsNullOrEmpty(textBox7.Text))
                label14.Text = (Double.Parse(textBox6.Text) * Int32.Parse(textBox7.Text) + Double.Parse(label14.Text)).ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox8.Text) && !String.IsNullOrEmpty(textBox9.Text))
                label14.Text = ((Double.Parse(textBox8.Text) * Int32.Parse(textBox9.Text)) + Double.Parse(label14.Text)).ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox10.Text) && !String.IsNullOrEmpty(textBox11.Text))
                label14.Text = (Double.Parse(textBox10.Text) * Int32.Parse(textBox11.Text) + Double.Parse(label14.Text)).ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(label14.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                label8.Text = (Double.Parse(textBox2.Text) + Double.Parse(label14.Text)).ToString();
            }
            allSumm += Double.Parse(label8.Text);
            timer.Start();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(label14.Text) && !String.IsNullOrEmpty(textBox1.Text))
            {
                label8.Text = (Double.Parse(label14.Text) + Double.Parse(label9.Text)).ToString();
            }
            allSumm += Double.Parse(label8.Text);
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void українськаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("uk-UA");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk-UA");
            System.ComponentModel.ComponentResourceManager manager = new ComponentResourceManager(this.GetType());
            manager.ApplyResources(this, "$this");
            foreach (Control c in this.Controls)
                manager.ApplyResources(c, c.Name);
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void englishUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("eng-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("eng-US");
            System.ComponentModel.ComponentResourceManager manager = new ComponentResourceManager(this.GetType());
            manager.ApplyResources(this, "$this");
            foreach (Control c in this.Controls)
                manager.ApplyResources(c, c.Name);
        }

        private void BestOilForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Выручка за весь день составила {allSumm} гривен.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}