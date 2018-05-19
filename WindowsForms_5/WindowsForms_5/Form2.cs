using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_5
{
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();
            button1.Text = "Hello";
            button1.BackColor = Color.Brown;
            this.BackColor = Color.Blue;
        }
    }
}
