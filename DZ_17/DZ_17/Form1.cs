using System;
using System.Drawing;
using System.Windows.Forms;

namespace DZ_17
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen pen = new Pen(Color.Black, 3f);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(pen, new Point(10, pictureBox1.ClientSize.Height - 10), new Point(pictureBox1.ClientSize.Width - 10, pictureBox1.ClientSize.Height - 10));
            g.DrawLine(pen, new Point(10, pictureBox1.ClientSize.Height - 10), new Point(10, 10));
            int y = (pictureBox1.ClientSize.Height - 20) / 10;
            int x = (pictureBox1.ClientSize.Width - 20) / 10;
            using (Pen pen2 = new Pen(Color.Gray, 1f))
            {
                pen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                for (int i = 0; i < 15; i++)
                {
                    g.DrawLine(pen2, new Point(10, i * y + 10), new Point(pictureBox1.ClientSize.Width - 10, i * y + 10));
                    g.DrawLine(pen2, new Point(i * x + 10, 10), new Point(i * x + 10, pictureBox1.ClientSize.Width - 10));
                }
            }
        }
    }
}
