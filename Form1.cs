using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _0427app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"can help in anything-logo.png");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnload2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.Title = "Please choose the picture!";
            dia.Filter = "JPEG files|*.jpg";
            if (dia.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(dia.FileName);
            }
        }

        private void btngray_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            int w, h;

            bmp = new Bitmap(pictureBox1.Image);
            w = bmp.Width;
            h = bmp.Height;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, Color.FromArgb(p.A, 255 - p.R, 255 - p.G, 255 - p.B));
                }
            }
            pictureBox2.Image = bmp;
        }

        private void btngray1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            int w, h;

            bmp = new Bitmap(pictureBox1.Image);
            w = bmp.Width;
            h = bmp.Height;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int avg = (int)((0.3 * p.R + p.G * 0.6 + p.B * 0.1));
                    bmp.SetPixel(x, y, Color.FromArgb(p.A, avg, avg, avg));
                }
            }
            pictureBox2.Image = bmp;
        }

        private void btnlighter_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            int w, h;

            bmp = new Bitmap(pictureBox1.Image);
            w = bmp.Width;
            h = bmp.Height;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int r = p.R * 1.8 > 255 ? 255 : (int)(p.R * 1.8);
                    int g = p.G * 1.8 > 255 ? 255 : (int)(p.G * 1.8);
                    int b = p.B * 1.8 > 255 ? 255 : (int)(p.B * 1.8);
                    bmp.SetPixel(x, y, Color.FromArgb(p.A, r, g, b));
                }
            }
            pictureBox2.Image = bmp;
        }

        private void btnMosaic_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            int w, h;

            bmp = new Bitmap(pictureBox1.Image);
            w = bmp.Width;
            h = bmp.Height;
            const int size = 20;
            for (int y = 0; y < h - size; y += size)
            {
                for (int x = 0; x < w - size; x += size)
                {
                    Color p = bmp.GetPixel(x, y);

                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            bmp.SetPixel(x + i, y + j, p);
                        }
                    }
                }
            }
            pictureBox2.Image = bmp;
        }

        private void btnblur_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            int w, h;

            bmp = new Bitmap(pictureBox1.Image);
            w = bmp.Width;
            h = bmp.Height;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int avg = (int)(p.R * 0.3 + p.G * 0.6 + p.B * 0.1);
                    bmp.SetPixel(x, y, Color.FromArgb(p.A, avg, avg, avg));
                }
            }
            pictureBox2.Image = bmp;
            Bitmap bmp1 = new Bitmap(pictureBox2.Image);
            for (int y = 10; y < h - 10; y++)
            {
                for (int x = 10; x < w - 10; x++)
                {
                    int total = 0;
                    int avg = 0;
                    int a = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Color p = bmp1.GetPixel(x + i, y + j);
                            a = p.A;
                            total += p.R;
                        }
                        avg = (int)(total / 100);
                    }
                    bmp1.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
            pictureBox1.Image = bmp1;
        }

        private void btnred_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            int w, h;

            bmp = new Bitmap(pictureBox1.Image);
            w = bmp.Width;
            h = bmp.Height;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, Color.FromArgb(p.A, p.R, p.G, p.B));
                }
            }
            bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
            pictureBox2.Image = bmp;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            int w, h;

            bmp = new Bitmap(pictureBox1.Image);
            w = bmp.Width;
            h = bmp.Height;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    if ((r + g + b) / 3 >= 127)
                        bmp.SetPixel(x, y, Color.FromArgb(p.A, 255, 255, 255));
                    else
                        bmp.SetPixel(x, y, Color.FromArgb(p.A, 0, 0, 0));
                }
            }
            pictureBox2.Image = bmp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Height = this.pictureBox1.Image.Height;
            int Width = this.pictureBox1.Image.Width;
            Bitmap newBitmap = new Bitmap(Width, Height);
            Bitmap oldBitmap = (Bitmap)this.pictureBox1.Image;
            Color pixel1, pixel2;
            for (int x = 0; x < Width - 1; x++)
            {
                for (int y = 0; y < Height - 1; y++)
                {
                    int r = 0, g = 0, b = 0;
                    pixel1 = oldBitmap.GetPixel(x, y);
                    pixel2 = oldBitmap.GetPixel(x + 1, y + 1);
                    r = Math.Abs(pixel1.R - pixel2.R + 128);
                    g = Math.Abs(pixel1.G - pixel2.G + 128);
                    b = Math.Abs(pixel1.B - pixel2.B + 128);
                    if (r > 255)
                        r = 255;
                    if (r < 0)
                        r = 0;
                    if (g > 255)
                        g = 255;
                    if (g < 0)
                        g = 0;
                    if (b > 255)
                        b = 255;
                    if (b < 0)
                        b = 0;
                    newBitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            this.pictureBox2.Image = newBitmap;
        }
    }
}
