using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace PC_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tovars = new List<Pc_part>
            {
                new Body() { Name = "Deepcool", Characteristic = "Middle tower", Description = "without PA", Price = "200$" },
                new HDD() { Name = "Seagate", Characteristic = "2TB, 7200 rpm", Description = "SATA III", Price = "21$" },
                new CPU() { Name = "INTEL Core i9X", Characteristic = "18 cores, 34 threads, 5 GHz", Description = "Coffe lake, 14nm, socket S1151", Price = "1000$" },
                new PowerAdapter() { Name = "Chieftec", Characteristic = "750W", Description = "6-pin for videocards", Price = "50$" },
                new MotherBoard() { Name = "ASUS prime", Characteristic = "Socket 1151, ATX", Description = "", Price = "42$" },
                new CoolingSystem() { Name = "", Characteristic = "", Description = "", Price = "22$" },
                new RAM() { Name = "Kingston black fury", Characteristic = "8 Gb DDR4", Description = "DIMM, ", Price = "100$" },
                new GPU() { Name = "Nvidia GeForce GTX 1080Ti", Characteristic = "GDDR5 11Gb, 256-bit, PciExpress 16x", Description = "Биткотны не майнила, совсем как новая Атвичаю", Price = "1200$" },
                new OpticalDrive() { Name = "DVD", Characteristic = "", Description = "", Price = "" },
                new AudioCard() { Name = "Asus", Characteristic = "", Description = "stereo mode", Price = "600$" },
                new NIC() {Name = "Broadcom", Characteristic = "Network adapter", Description = "", Price = "27$" }
            };
        }


        public void ValidateListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Tovars;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                Form2 form2 = new Form2();
                form2.Text = "Добавление";
                form2.Owner = this;
                form2.Show();
            }
            else MessageBox.Show("Выберете устройство");
        }

        private List<Pc_part> tovars;

        internal List<Pc_part> Tovars { get => tovars; }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                if (!String.IsNullOrEmpty(comboBox1.Text))
                {
                    if (listBox1.SelectedItem != null)
                    {
                        Form2 form2 = new Form2
                        {
                            Text = "Редактирование"
                        };
                        form2.textBox1.Text = ((Pc_part)listBox1.SelectedItem).Name;
                        form2.textBox2.Text = ((Pc_part)listBox1.SelectedItem).Characteristic;
                        form2.textBox3.Text = ((Pc_part)listBox1.SelectedItem).Description;
                        form2.textBox4.Text = ((Pc_part)listBox1.SelectedItem).Price;
                        form2.Show();
                    }
                }
                else MessageBox.Show("Выберете устройство");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                try
                {
                    listBox1.Items.Clear();
                    foreach (Pc_part item in tovars)
                    {
                        switch (comboBox1.SelectedIndex)
                        {
                            case 0:

                                if (item is Body)
                                {
                                    listBox1.Items.Add(item);
                                }
                                break;
                            case 1:
                                if (item is HDD)
                                    listBox1.Items.Add(item);
                                break;
                            case 2:
                                if (item is CPU)
                                    listBox1.Items.Add(item);
                                break;
                            case 3:
                                if (item is PowerAdapter)
                                    listBox1.Items.Add(item);
                                break;
                            case 4:
                                if (item is MotherBoard)
                                    listBox1.Items.Add(item);
                                break;
                            case 5:
                                if (item is RAM)
                                    listBox1.Items.Add(item);
                                break;
                            case 6:
                                if (item is CoolingSystem)
                                    listBox1.Items.Add(item);
                                break;
                            case 7:
                                if (item is GPU)
                                    listBox1.Items.Add(item);
                                break;
                            case 8:
                                if (item is OpticalDrive)
                                    listBox1.Items.Add(item);
                                break;
                            case 9:
                                if (item is AudioCard)
                                    listBox1.Items.Add(item);
                                break;
                            case 10:
                                if (item is NIC)
                                    listBox1.Items.Add(item);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                Pc_part part = (Pc_part)listBox1.SelectedItem;
                textBox1.Text = part.Price;
                textBox1.ReadOnly = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
