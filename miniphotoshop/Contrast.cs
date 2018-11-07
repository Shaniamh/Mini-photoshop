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
    public partial class Contrast : Form
    {
        Bitmap objBitmap;
        Bitmap objBitmap1;
        public Contrast()
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
            objBitmap1 = new Bitmap(objBitmap);
            float c = Convert.ToSingle(textBox1.Text);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(c * xg);
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
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
            MenuUtama md = new MenuUtama();
            md.Show();
            md.setContrast(objBitmap1);
            md.setBitmap(objBitmap);
            this.Hide();
        }


    }
}
