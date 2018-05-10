using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToPaint
{
    public partial class Form1 : Form
    {

        Graphics g;
        int x= -1;
        int y= -1;
        bool moving = false;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox2.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Gray, 3);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            pictureBox2.Cursor = Cursors.Cross;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x!= -1 && y!= -1)
            {
                g.DrawLine(pen, new Point(x,y),e.Location);
                x = e.X;
                y = e.Y;

            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            pictureBox2.Cursor = Cursors.Default;
        }
    }
}
