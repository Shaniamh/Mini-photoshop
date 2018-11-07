using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace miniphotoshop
{
    public partial class Ekualisasi : Form
    {
        Bitmap objBitmap;
        Bitmap objBitmap1;
        Bitmap objBitmap2;
        public Ekualisasi()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int xg = (int)((r + g + b) / 3);
                    Color wb = Color.FromArgb(xg, xg, xg);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objBitmap2 = new Bitmap(objBitmap1);
            float[] h = new float[256];
            float[] c = new float[256];
            int i;
            for (i = 0; i < 256; i++) h[i] = 0;
            for (int x = 0; x < objBitmap1.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap1.GetPixel(x, y);
                    int xg = w.R;
                    h[xg] = h[xg] + 1;
                }
            c[0] = h[0];
            for (i = 1; i < 256; i++)
                c[i] = c[i - 1] + h[i];
            int nx = objBitmap1.Width;
            int ny = objBitmap1.Height;
            for (int x = 0; x < objBitmap1.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap1.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(255 * c[xg] / nx / ny);
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap2;
            for (i = 0; i < 256; i++) h[i] = 0;
            for (int x = 0; x < objBitmap1.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap1.GetPixel(x, y);
                    int xg = w.R;
                    h[xg] = h[xg] + 1;
                }
            chart1.Series["Series1"].Points.Clear();
            for (i = 0; i < 256; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, h[i]);
            }
          }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuUtama mu = new MenuUtama();
            mu.Show();
            mu.setBitmap(objBitmap);
            this.Hide();
        }

        public void setBitmap(Bitmap bitmap)
        {
            objBitmap = bitmap;
            pictureBox1.Image = objBitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            float[] h = new float[256];
            float[] c = new float[256];
            int i;
            for (i = 0; i < 256; i++) h[i] = 0;
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    h[xg] = h[xg] + 1;
                }
            c[0] = h[0];
            for (i = 1; i < 256; i++)
                c[i] = c[i - 1] + h[i];
            int nx = objBitmap.Width;
            int ny = objBitmap.Height;
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(255 * c[xg] / nx / ny);
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
            for (i = 0; i < 256; i++) h[i] = 0;
            for (int x = 0; x < objBitmap1.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap1.GetPixel(x, y);
                    int xg = w.R;
                    h[xg] = h[xg] + 1;
                }
            chart2.Series["Series1"].Points.Clear();
            for (i = 0; i < 256; i++)
            {
                chart2.Series["Series1"].Points.AddXY(i, h[i]);
            }

        }

        }
    }
