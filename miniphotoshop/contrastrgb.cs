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
    public partial class contrastrgb : Form
    {
        Bitmap objBitmap1;
        Bitmap objBitmap;
        public contrastrgb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = (float)(hScrollBar1.Value / 100.0);
            button1.Text = a.ToString();
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = (int)(a * (float)w.R);
                    int g = (int)(a * (float)w.G);
                    int b = (int)(a * (float)w.B);
                    if (r < 0) r = 0;
                    if (r > 255) r = 255;
                    if (g < 0) g = 0;
                    if (g > 255) g = 255;
                    if (b < 0) b = 0;
                    if (b > 255) b = 255;
                    Color wb = Color.FromArgb(r, g, b);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
            hScrollBar1.Value = 100;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            MenuUtama md = new MenuUtama();
            md.Show();
            md.setContrastrgb(objBitmap1);
            md.setBitmap(objBitmap);
            this.Hide();
        }

    }
}
