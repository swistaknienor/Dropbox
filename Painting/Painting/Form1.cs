using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;

namespace Painting
{
    public partial class Form1 : Form
    {

        bool paint = false;
        SolidBrush color;
        Color paintcolor;
        bool choose = false;
        bool draw = false;
        int x, y, lx, ly = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (eraserbtn.Text == "Eraser")
                {
                    int size = Convert.ToInt32(tbSize.Text);
                    Graphics g = Canvas.CreateGraphics();
                    color = new SolidBrush(Color.Gray);
                    g.FillEllipse(color, e.X - size / 2, e.Y - size / 2, size, size);
                }
                else
                {
                    int EraserSize = Convert.ToInt32(tberaser.Text);
                    Graphics g = Canvas.CreateGraphics();
                    color = new SolidBrush(Color.White);
                    g.FillEllipse(color, e.X - EraserSize / 2, e.Y - EraserSize / 2, EraserSize, EraserSize);
                }
            }

        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearCanvasbtn_Click(object sender, EventArgs e)
        {
            Graphics g = Canvas.CreateGraphics();
            g.Clear(Canvas.BackColor);
        }

        private void eraserbtn_Click(object sender, EventArgs e)
        {
            if (eraserbtn.Text == "Eraser")
            {
                eraserbtn.Text = "Paint";
            }
            else
            {
                eraserbtn.Text = "Eraser";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tberaser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSize_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void pictureBox10_Click(object sender, EventArgs e)
        {
               
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           /* PictureBox p = (PictureBox)sender;
            NewMethod(p);
            {
                private void NewMethod(PictureBox p)
                {
                    color = new SolidBrush(p.BackColor);
                }
            }*/
            
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
        
        private void palette_Click(object sender, EventArgs e)
        {

        }

        private void palette_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;
        }

        private void palette_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
        }

        private void palette_MouseMove(object sender, MouseEventArgs e)
        {
            if (choose)
            {
                Bitmap bmp = (Bitmap)palette.Image.Clone();
                paintcolor = bmp.GetPixel(e.X, e.Y);
                /*red.Value = paintcolor.R;
                green.Value = paintcolor.G;
                blue.Value = paintcolor.B;
                alpha.Value = paintcolor.A;
                redval.Text = paintcolor.R.ToString();
                greenval.Text = paintcolor.G.ToString();
                blueval.Text = paintcolor.B.ToString();
                alphaval.Text = paintcolor.A.ToString();
                pictureBox11.BackColor = paintcolor;*/
            }
        }
    }
}
