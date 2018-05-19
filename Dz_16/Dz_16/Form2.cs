using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_16
{
    public partial class Form2 : Form
    {
        Employee inEmployee;
        public Form2(Employee employee)
        {
            InitializeComponent();
            openFile = new OpenFileDialog();
            pictureBox1.Image = new Bitmap(Image.FromFile("User.png"), new Size(pictureBox1.Width, pictureBox1.Height));
            this.inEmployee = employee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inEmployee.Photo = pictureBox1.Image;
            inEmployee.BirthDay = dateTimePicker1.Value;
            inEmployee.FIO = textBox1.Text;
            inEmployee.Position = textBox2.Text;
            inEmployee.Salary = Double.Parse(textBox3.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        OpenFileDialog openFile;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Photo (*.jpg)|*jpg| Image(*.png)|*.png";
            openFile.FilterIndex = 1;
            if(MessageBox.Show("Load new photo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(Image.FromFile(openFile.FileName), new Size(pictureBox1.Width, pictureBox1.Height));
                }
            }
        }
    }
}
