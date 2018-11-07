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
    public partial class Brigthness : Form
    {
        Bitmap objBitmap1;
        Bitmap objBitmap;
        Bitmap objBitmap11;
        public Brigthness()
        {
            InitializeComponent();
        }

        public void setBitmap(Bitmap bitmap)
        {
            objBitmap = bitmap;
            pictureBox1.Image = objBitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            int a = (int)Convert.ToSingle(textBox1.Text);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = (int)((w.R + w.G + w.B) / 3);
                    int xb = (int)xg + a;
                    if (xb > 255)
                        xb = 255;
                    else if (xb < 0)
                        xb = 0;
                    Color new_w = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, new_w);
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

       

        private void button1_Click(object sender, EventArgs e)
        {
            MenuUtama md = new MenuUtama();
            md.Show();
            md.setBrightness(objBitmap1);
            md.setBitmap(objBitmap);
            this.Hide();
        }


        
    }
}
