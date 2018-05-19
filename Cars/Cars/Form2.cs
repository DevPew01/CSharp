using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            form1.cars.Add(new Car()
            {
                Mark = textBox1.Text,
                CreationDate = dateTimePicker1.Value,
                BodyVin = textBox3.Text,
                EngineVin = textBox2.Text,
                Number = textBox4.Text,
                DriverFIO = textBox5.Text,
            });
            this.DialogResult = DialogResult.OK;
        }
    }
}
