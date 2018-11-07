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
    public partial class Threshols : Form
    {
        Bitmap objBitmap;
        Bitmap objBitmap1;
        public Threshols()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            int m = objBitmap1.Height;
            int n = objBitmap1.Width;

            Color w;
            int i;
            int threshold;
            threshold = int.Parse(textBox1.Text);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    w = objBitmap1.GetPixel(x, y);
                    i = w.R;
                    if (i >= threshold)
                    {
                        objBitmap1.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        objBitmap1.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }
            pictureBox2.Image = objBitmap1;

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

        private void button1_Click(object sender, EventArgs e)
        {
            MenuUtama md = new MenuUtama();
            md.Show();
            md.setThres(objBitmap1);
            md.setBitmap(objBitmap);
            this.Hide();
        }
    }
}
