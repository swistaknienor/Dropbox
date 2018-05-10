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
        int x= 0;
        int y= 0;
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

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = 0;
            y = 0;
            pictureBox2.Cursor = Cursors.Default;
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
            if (moving && x != 0 && y != 0)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

            }
        }
        
        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            sfdImage.ShowDialog();
           if (sfdImage.FileName != "")
            {
                pictureBox2.BackgroundImage.Save(sfdImage.FileName);
            }
        }

        private void ColourSelection_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
           ofdImage.ShowDialog();
           if (ofdImage.FileName != "")
            {
               pictureBox2.BackgroundImage.ImageLocation = ofdImage.FileName;
            }

        }*/
    }
}
