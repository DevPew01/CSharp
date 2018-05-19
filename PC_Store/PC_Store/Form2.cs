using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PC_Store
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();//(Form1)this.Owner;
            if (f.comboBox1.SelectedIndex != -1)
            {
                switch (f.comboBox1.SelectedIndex)
                {
                    case 0:
                        f.Tovars.Add(new Body() { Name = textBox1.Text, Characteristic = textBox2.Text, Description = textBox3.Text, Price = textBox4.Text });
                        break;
                    case 1:
                        f.Tovars.Add(new HDD() { Name = textBox1.Text, Characteristic = textBox2.Text, Description = textBox3.Text, Price = textBox4.Text });
                        break;
                    case 2:
                        f.Tovars.Add(new CPU() { Name = textBox1.Text, Characteristic = textBox2.Text, Description = textBox3.Text, Price = textBox4.Text });
                        break;
                    case 3:
                        f.Tovars.Add(new PowerAdapter() { Name = textBox1.Text, Characteristic = textBox2.Text, Description = textBox3.Text, Price = textBox4.Text });
                        break;
                    case 4:
                        f.Tovars.Add(new MotherBoard() { Name = textBox1.Text, Characteristic = textBox2.Text, Description = textBox3.Text, Price = textBox4.Text });
                        break;
                    case 5:
                        f.Tovars.Add(new CoolingSystem() { Name = textBox1.Text, Characteristic = textBox2.Text, Description = textBox3.Text, Price = textBox4.Text });
                        break;
                    case 6:
                        f.Tovars.Add(new RAM() { Name = textBox1.Text, Characteristic = textBox2.Text, Description = textBox3.Text, Price = textBox4.Text });
                        break;
                    case 7:
                        f.Tovars.Add(new GPU() { Name = textBox1.Text, Characteristic = textBox2.Text, Description = textBox3.Text, Price = textBox4.Text });
                        break;
                    case 8:
                        f.Tovars.Add(new OpticalDrive() { Name = textBox1.Text, Characteristic = textBox2.Text, Description = textBox3.Text, Price = textBox4.Text });
                        break;
                    case 9:
                        f.Tovars.Add(new AudioCard() { Name = textBox1.Text, Characteristic = textBox2.Text, Description = textBox3.Text, Price = textBox4.Text });
                        break;
                    case 10:
                        f.Tovars.Add(new NIC() { Name = textBox1.Text, Characteristic = textBox2.Text, Description = textBox3.Text, Price = textBox4.Text });
                        break;
                }
            }
        }
    }
}
