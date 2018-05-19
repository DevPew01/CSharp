using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cars
{

    public partial class Form1 : Form
    {
        TextBox textBox;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Автомобили";
            fileDialog = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            cars = new List<Car>();
            for (int i = 0; i < items.Length; i++)
                menu.Items.Add(items[i]);
            listBox1 = new ListBox();
            listBox1.Size = new Size(ClientSize.Height, ClientSize.Width / 2);
            listBox1.Location = new Point(20, 20);
            Label label = new Label(); 
            Button button = new Button();
            textBox = new TextBox();
            label.Text = "Марка";
            button.Text = "Поиск";
            textBox.Location = new Point(400, 170);
            label.Location = new Point(400, 150);
            button.Location = new Point(400, 200);
            Controls.Add(textBox);
            Controls.Add(label);
            Controls.Add(button);
            Controls.Add(listBox1);
            Controls.Add(menu);
            items[0].DropDownItems.Add(new ToolStripMenuItem { Text = "New" });
            items[0].DropDownItems.Add(new ToolStripMenuItem { Text = "Save" });
            items[0].DropDownItems.Add(new ToolStripMenuItem { Text = "Load" });
            items[1].DropDownItems.Add(new ToolStripMenuItem { Text = "Add" });
            items[1].DropDownItems.Add(new ToolStripMenuItem { Text = "Edit" });
            items[1].DropDownItems.Add(new ToolStripMenuItem { Text = "Remove" });
            items[0].DropDownItems[0].Click += Form1_Click;
            items[0].DropDownItems[1].Click += Form1_Click1;
            items[0].DropDownItems[2].Click += Form1_Click2;
            items[1].DropDownItems[0].Click += Form1_Click3;
            items[1].DropDownItems[1].Click += Form1_Click4;
            items[1].DropDownItems[2].Click += Form1_Click5;
            button.Click += Button_Click;
            f = new Form2
            {
                Owner = this
            };
        }

        BinaryFormatter formatter = new BinaryFormatter();
        private void Button_Click(object sender, EventArgs e)
        {
            foreach (Car item in cars)
            {
                if(item.Mark.Equals(textBox.Text))
                {
                    MessageBox.Show(item.ToString());
                }
            }
        }

        private void Form1_Click5(object sender, EventArgs e)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (i == listBox1.SelectedIndex)
                    cars.RemoveAt(i);
            }
            ValidateListBox();
        }

        private void Form1_Click4(object sender, EventArgs e)
        {
            f.Text = "Редактирование";
            if (listBox1.Items.Count != 0)
                f.ShowDialog();
        }

        private ListBox listBox1;

        public void ValidateListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = cars;
        }

        Form2 f;
        private void Form1_Click3(object sender, EventArgs e)
        {
            f.Text = "Добавление";
            foreach (Control c in f.Controls)
                if (c is TextBox)
                    c.Text = "";
            if(f.ShowDialog() == DialogResult.OK)
            {
                ValidateListBox();
            }
        }

        private void Form1_Click2(object sender, EventArgs e)
        {
            fileDialog.Filter = "Text files (*.txt)|*.txt|MS word (*.doc)|*.doc|All files (*.*)|*.*";
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(fileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        cars = (List<Car>)formatter.Deserialize(stream);
                        ValidateListBox();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private OpenFileDialog fileDialog;
        private SaveFileDialog saveFile;
        private void Form1_Click1(object sender, EventArgs e)
        {
            saveFile.Filter = "Text files (*.txt)|*.txt|MS word (*.doc)|*.doc|All files (*.*)|*.*";
            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFile.FileName, FileMode.Open))
                    {
                        formatter.Serialize(fs, cars);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Car> cars;
        private void Form1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private MenuStrip menu = new MenuStrip();
        private ToolStripMenuItem[] items = { new ToolStripMenuItem {Text = "File" }, new ToolStripMenuItem {Text = "Edit" }};
    }
}
