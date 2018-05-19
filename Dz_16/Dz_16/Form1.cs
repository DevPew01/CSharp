using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
            formatter = new BinaryFormatter();
        }

        List<Employee> employees;

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        BinaryFormatter formatter;
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("employers.dat", FileMode.OpenOrCreate))
            {
                    formatter.Serialize(fs, employees);
                MessageBox.Show("Serialization succsess");
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("employers.dat", FileMode.OpenOrCreate))
            {
                employees = (List<Employee>)formatter.Deserialize(fs);
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            Form2 form2 = new Form2(employee);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(employee.FIO, employee.FIO);
                imageList1.Images.Add(employee.FIO, employee.Photo);
                item.SubItems.Add(employee.BirthDay.ToShortDateString());
                item.SubItems.Add(employee.Salary.ToString());
                listView1.Items.Add(item);
            }
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("FIO");
            listView1.Columns.Add("BirthDay");
            listView1.Columns.Add("Salary");
            listView1.Columns.Add("Position");

        }
    }
}
