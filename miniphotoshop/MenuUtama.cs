using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace miniphotoshop
{
    public partial class MenuUtama : Form
    {
        private int childFormNumber = 0;

        Image file;
        Bitmap objBitmap;
        Bitmap objBitmap1;
        Bitmap objBitmap2;
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                objBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = objBitmap;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    objBitmap1.SetPixel(x, y, w);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = saveFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                file.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void inversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void autoLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void flipHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    objBitmap1.SetPixel(objBitmap.Width - 1 - x, y, w);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void flipVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    objBitmap1.SetPixel(x, objBitmap.Height - 1 - y, w);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void rotate90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap.Height, objBitmap.Width);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    objBitmap1.SetPixel(objBitmap.Height - 1 - y, x, w);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    objBitmap1.SetPixel(x, objBitmap.Height - 1 - y, w);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void sephiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    Color new_w = Color.FromArgb((byte)(w.R), (byte)(w.R * 0.82), (byte)(w.R * 0.28));
                    objBitmap1.SetPixel(x, y, new_w);
                } pictureBox2.Image = objBitmap1;
        }

        private void blackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
            {
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r, g, b, xg, xbw = 0;
                    r = w.R;
                    g = w.G;
                    b = w.B;
                    xg = (int)((r + b + g) / 3);
                    if (xg >= 128) xbw = 255;
                    Color new_w = Color.FromArgb(xbw, xbw, xbw); objBitmap1.SetPixel(x, y, new_w);
                }
            } pictureBox2.Image = objBitmap1;
        }

        private void quantizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kuantisasi kuan = new Kuantisasi();
            kuan.Show();
            kuan.setBitmap(objBitmap);
            this.Hide();
        }

        private void thresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Threshols thr = new Threshols();
            thr.Show();
            thr.setBitmap(objBitmap);
            this.Hide();
        }

        private void showHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogram htg = new Histogram();
            htg.Show();
            htg.setBitmap(objBitmap);
            this.Hide();
        }

        private void showEqualizationHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekualisasi eku = new Ekualisasi();
            eku.Show();
            eku.setBitmap(objBitmap);
            this.Hide();
        }

        private void showCDFHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CDF cdf = new CDF();
            cdf.Show();
            cdf.setBitmap(objBitmap);
            this.Hide();
        }

        private void filter4NodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[] a = new float[5];
            a[1] = (float)0.2;
            a[2] = (float)0.2;
            a[3] = (float)0.2;
            a[4] = (float)0.2;
            a[0] = (float)0.2;
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y);
                    Color w2 = objBitmap.GetPixel(x + 1, y);
                    Color w3 = objBitmap.GetPixel(x, y - 1);
                    Color w4 = objBitmap.GetPixel(x, y + 1);
                    Color w = objBitmap.GetPixel(x, y);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int xg = w.R;
                    int xb = (int)(a[0] * xg);
                    xb = (int)(xb + a[1] * x1 + a[2] * x2 + a[3] * x3 + a[3] * x4);
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void filter8NodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float[] a = new float[10];
            a[1] = (float)0.1;
            a[2] = (float)0.1;
            a[3] = (float)0.1;
            a[4] = (float)0.1;
            a[5] = (float)0.2;
            a[6] = (float)0.1;
            a[7] = (float)0.1;
            a[8] = (float)0.1;
            a[9] = (float)0.1;
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap.GetPixel(x - 1, y);
                    Color w3 = objBitmap.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap.GetPixel(x, y - 1);
                    Color w5 = objBitmap.GetPixel(x, y);
                    Color w6 = objBitmap.GetPixel(x, y + 1);
                    Color w7 = objBitmap.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap.GetPixel(x + 1, y);
                    Color w9 = objBitmap.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
                    xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
                    xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void gaussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void speckleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            Random r = new Random();
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    int xb = xg;
                    int nr = r.Next(0, 100);
                    if (nr < 20) xb = 0;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void saltAndPapperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            Random r = new Random();
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    int xb = xg;
                    int nr = r.Next(0, 100);
                    if (nr < 20) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }


        private void filterGaussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap2 = new Bitmap(objBitmap1);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap1.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap1.GetPixel(x - 1, y);
                    Color w3 = objBitmap1.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap1.GetPixel(x, y - 1);
                    Color w5 = objBitmap1.GetPixel(x, y);
                    Color w6 = objBitmap1.GetPixel(x, y + 1);
                    Color w7 = objBitmap1.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap1.GetPixel(x + 1, y);
                    Color w9 = objBitmap1.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xb = (int)((x1 + x2 + x3 + x4 + 4 * x5 + x6 + x7 + x8 + x9) / 13);
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap2;
        }

        private void filterMedianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] xt = new int[10];
            objBitmap2 = new Bitmap(objBitmap1);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap1.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap1.GetPixel(x - 1, y);
                    Color w3 = objBitmap1.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap1.GetPixel(x, y - 1);
                    Color w5 = objBitmap1.GetPixel(x, y);
                    Color w6 = objBitmap1.GetPixel(x, y + 1);
                    Color w7 = objBitmap1.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap1.GetPixel(x + 1, y);
                    Color w9 = objBitmap1.GetPixel(x + 1, y + 1);
                    xt[1] = w1.R;
                    xt[2] = w2.R;
                    xt[3] = w3.R;
                    xt[4] = w4.R;
                    xt[5] = w5.R;
                    xt[6] = w6.R;
                    xt[7] = w7.R;
                    xt[8] = w8.R;
                    xt[9] = w9.R;
                    for (int i = 1; i < 9; i++)
                        for (int j = 1; j < 9; j++)
                        {
                            if (xt[j] > xt[j + 1])
                            {
                                int a = xt[j];
                                xt[j] = xt[j + 1];
                                xt[j + 1] = a;
                            }
                        }
                    int xb = xt[5];
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap2;
        }

        private void robertMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 1; x < objBitmap.Width; x++)
                for (int y = 1; y < objBitmap.Height; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y);
                    Color w2 = objBitmap.GetPixel(x, y);
                    Color w3 = objBitmap.GetPixel(x, y - 1);
                    Color w4 = objBitmap.GetPixel(x, y);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int xb = (int)((x2 - x1) + (x4 - x3));
                    if (xb < 0) xb = -xb;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void prewittMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 1; x < objBitmap.Width-1; x++)
            for (int y = 1; y < objBitmap.Height-1; y++)
            {
            Color w1 = objBitmap.GetPixel(x - 1, y-1);
            Color w2 = objBitmap.GetPixel(x-1, y);
            Color w3 = objBitmap.GetPixel(x-1, y + 1);
            Color w4 = objBitmap.GetPixel(x, y-1);
            Color w5 = objBitmap.GetPixel(x, y);
            Color w6 = objBitmap.GetPixel(x, y + 1);
            Color w7 = objBitmap.GetPixel(x+1, y - 1);
            Color w8 = objBitmap.GetPixel(x+1, y );
            Color w9 = objBitmap.GetPixel(x+1, y + 1);
            int x1 = w1.R;
            int x2 = w2.R;
            int x3 = w3.R;
            int x4 = w4.R;
            int x5 = w5.R;
            int x6 = w6.R;
            int x7 = w7.R;
            int x8 = w8.R;
            int x9 = w9.R;
            int xh = (int)(-x1 - x4 - x7 + x3 + x6 + x9);
            int xv = (int)(-x1 - x2 - x3 + x7 + x8 + x9);
            int xb = (int)(xh + xv);
            if (xb < 0) xb = -xb;
            if (xb > 255) xb = 255;
            Color wb = Color.FromArgb(xb, xb, xb);
            objBitmap1.SetPixel(x, y, wb);
            }
            pictureBox2.Image = objBitmap1;
        }

        private void sobelMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap.GetPixel(x - 1, y);
                    Color w3 = objBitmap.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap.GetPixel(x, y - 1);
                    Color w5 = objBitmap.GetPixel(x, y);
                    Color w6 = objBitmap.GetPixel(x, y + 1);
                    Color w7 = objBitmap.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap.GetPixel(x + 1, y);
                    Color w9 = objBitmap.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xh = (int)(-x1 - 2 * x4 - x7 + x3 + 2 * x6 + x9);
                    int xv = (int)(-x1 - 2 * x2 - x3 + x7 + 2 * x8 + x9);
                    int xb = (int)(xh + xv);
                    if (xb < 0) xb = -xb;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void laplacianMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
           objBitmap1 = new Bitmap(objBitmap);
            for (int x = 1; x < objBitmap.Width - 1; x++)
            for (int y = 1; y < objBitmap.Height - 1; y++)
            {
            Color w1 = objBitmap.GetPixel(x - 1, y - 1);
            Color w2 = objBitmap.GetPixel(x - 1, y);
            Color w3 = objBitmap.GetPixel(x - 1, y + 1);
            Color w4 = objBitmap.GetPixel(x, y - 1);
            Color w5 = objBitmap.GetPixel(x, y);
            Color w6 = objBitmap.GetPixel(x, y + 1);
            Color w7 = objBitmap.GetPixel(x + 1, y - 1);
            Color w8 = objBitmap.GetPixel(x + 1, y);
            Color w9 = objBitmap.GetPixel(x + 1, y + 1);
            int x1 = w1.R;
            int x2 = w2.R;
            int x3 = w3.R;
            int x4 = w4.R;
            int x5 = w5.R;
            int x6 = w6.R;
            int x7 = w7.R;
            int x8 = w8.R;
            int x9 = w9.R;
            int xb = (int)(x1 - 2 * x2 + x3 - 2 * x4 + 4 * x5 - 2 * x6 + x7 - 2 * x8 + x9);
            if (xb < 0) xb = -xb;
            if (xb > 255) xb = 255;
            Color wb = Color.FromArgb(xb, xb, xb);
            objBitmap1.SetPixel(x, y, wb);
            }
            pictureBox2.Image = objBitmap1;
        }

        private void sharpnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int wr = w.R;
                    Color new_w = Color.FromArgb(wr, 0, 0);
                    objBitmap1.SetPixel(x, y, new_w);
                }
            pictureBox2.Image = objBitmap1;

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int wg = w.G;
                    Color new_w = Color.FromArgb(0, wg, 0);
                    objBitmap1.SetPixel(x, y, new_w);
                }
            pictureBox2.Image = objBitmap1;

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int wb = w.B;
                    Color new_w = Color.FromArgb(0, 0, wb);
                    objBitmap1.SetPixel(x, y, new_w);
                }
            pictureBox2.Image = objBitmap1;

        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int wr = w.R;
                    Color new_w = Color.FromArgb(wr, wr, wr);
                    objBitmap1.SetPixel(x, y, new_w);
                } pictureBox2.Image = objBitmap1;

        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int wg = w.G;
                    Color new_w = Color.FromArgb(wg, wg, wg);
                    objBitmap1.SetPixel(x, y, new_w);
                } pictureBox2.Image = objBitmap1;

        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int wb = w.B;
                    Color new_w = Color.FromArgb(wb, wb, wb);
                    objBitmap1.SetPixel(x, y, new_w);
                } pictureBox2.Image = objBitmap1;

        }

        private void citraGreyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    Color w1 = objBitmap.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap.GetPixel(x - 1, y);
                    Color w3 = objBitmap.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap.GetPixel(x, y - 1);
                    Color w5 = objBitmap.GetPixel(x, y);
                    Color w6 = objBitmap.GetPixel(x, y + 1);
                    Color w7 = objBitmap.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap.GetPixel(x + 1, y);
                    Color w9 = objBitmap.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xt1 = (int)((x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9) / 9);
                    int xt2 = (int)(-x1 - 2 * x2 - x3 + x7 + 2 * x8 + x9);
                    int xt3 = (int)(-x1 - 2 * x4 - x7 + x3 + 2 * x6 + x9);
                    int xb = (int)(xt1 + xt2 + xt3);
                    if (xb < 0) xb = -xb;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void citraGreyscaleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    Color w1 = objBitmap.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap.GetPixel(x - 1, y);
                    Color w3 = objBitmap.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap.GetPixel(x, y - 1);
                    Color w5 = objBitmap.GetPixel(x, y);
                    Color w6 = objBitmap.GetPixel(x, y + 1);
                    Color w7 = objBitmap.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap.GetPixel(x + 1, y);
                    Color w9 = objBitmap.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xt1 = (int)((x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9) / 9);
                    int xt2 = (int)(-x1 - 2 * x2 - x3 + x7 + 2 * x8 + x9);
                    int xt3 = (int)(-x1 - 2 * x4 - x7 + x3 + 2 * x6 + x9);
                    int xb = (int)(xt1 + xt2 + xt3);
                    if (xb < 0) xb = -xb;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void citraRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap.GetPixel(x - 1, y);
                    Color w3 = objBitmap.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap.GetPixel(x, y - 1);
                    Color w5 = objBitmap.GetPixel(x, y);
                    Color w6 = objBitmap.GetPixel(x, y + 1);
                    Color w7 = objBitmap.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap.GetPixel(x + 1, y);
                    Color w9 = objBitmap.GetPixel(x + 1, y + 1);
                    int rh = (int)(-w1.R - w4.R - w7.R + w3.R + w6.R + w9.R);
                    int gh = (int)(-w1.G - w4.G - w7.G + w3.G + w6.G + w9.G);
                    int bh = (int)(-w1.B - w4.B - w7.B + w3.B + w6.B + w9.B);
                    int rv = (int)(-w1.R - w2.R - w3.R + w7.R + w8.R + w9.R);
                    int gv = (int)(-w1.G - w2.G - w3.G + w7.G + w8.G + w9.G);
                    int bv = (int)(-w1.B - w2.B - w3.B + w7.B + w8.B + w9.B);
                    int rr = (int)((w1.R + w2.R + w3.R + w4.R + w5.R + w6.R + w7.R + w8.R + w9.R) / 9);
                    int gr = (int)((w1.G + w2.G + w3.G + w4.G + w5.G + w6.G + w7.G + w8.G + w9.G) / 9);
                    int br = (int)((w1.B + w2.B + w3.B + w4.B + w5.B + w6.B + w7.B + w8.B + w9.B) / 9);
                    int r = (int)(rr + rh + rv);
                    if (r < 0) r = -r;
                    if (r > 255) r = 255;
                    int g = (int)(gr + gh + gv);
                    if (g < 0) g = -g;
                    if (g > 255) g = 255;
                    int b = (int)(br + bh + bv);
                    if (b < 0) b = -b;
                    if (b > 255) b = 255;
                    Color wb = Color.FromArgb(r, g, b);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void citraGreyscaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Brigthness br = new Brigthness();
            br.Show();
            br.setBitmap(objBitmap);
            this.Hide();
        }

        private void citraRGBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            brigthRgb brr = new brigthRgb();
            brr.Show();
            brr.setBitmap(objBitmap);
            this.Hide();
        }

        private void citraGreyscaleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Contrast cn = new Contrast();
            cn.Show();
            cn.setBitmap(objBitmap);
            this.Hide();
        }

        private void citraRGBToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            contrastrgb cnn = new contrastrgb();
            cnn.Show();
            cnn.setBitmap(objBitmap);
            this.Hide();
        }

        private void citraRGBToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = (int)(255 - w.R);
                    int g = (int)(255 - w.G);
                    int b = (int)(255 - w.B);
                    Color wb = Color.FromArgb(r, g, b);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void citraGreyscaleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(255 - xg);
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void citraGreyscaleToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            //Mencari nilai maksimum dan minimum
            int xgmax = 0;
            int xgmin = 255;
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    if (xg < xgmin) xgmin = xg;
                    if (xg > xgmax) xgmax = xg;
                }
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap1.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    int xb = (int)(255 * (xg - xgmin) / (xgmax - xgmin));
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void citraRGBToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            int rmin = 255;
            int gmin = 255;
            int bmin = 255;
            int rmax = 0;
            int gmax = 0;
            int bmax = 0;
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    if (r < rmin) rmin = r;
                    if (r > rmax) rmax = r;
                    if (g < gmin) gmin = g;
                    if (g > gmax) gmax = g;
                    if (b < bmin) bmin = b;
                    if (b > bmax) bmax = b;
                }
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int rbaru = (int)(255 * (r - rmin) / (rmax - rmin));
                    int gbaru = (int)(255 * (g - gmin) / (gmax - gmin));
                    int bbaru = (int)(255 * (b - bmin) / (bmax - bmin));
                    Color wb = Color.FromArgb(rbaru, gbaru, bbaru);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void citraGreyscaleToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            Random r = new Random();
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y);
                    int xg = w.R;
                    int xb = xg;
                    int nr = r.Next(0, 100);
                    if (nr < 20)
                    {
                        int ns = r.Next(0, 256) - 128;
                        xb = (int)(xg + ns);
                        if (xb < 0) xb = -xb;
                        if (xb > 255) xb = 255;
                    }
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void citraRGBToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            Random r = new Random();
            Color wb;
            for (int x = 0; x < objBitmap.Width; x++)
                for (int y = 0; y < objBitmap.Height; y++)
                {
                    int p = r.Next(0, 100);
                    Color w = objBitmap.GetPixel(x, y);
                    wb = w;
                    if (p < 20)
                    {
                        int nr = r.Next(0, 200);
                        int rb = w.R + nr - 100;
                        if (rb < 0) rb = 0;
                        if (rb > 255) rb = 255;
                        int gb = w.G + nr - 100;
                        if (gb < 0) gb = 0;
                        if (gb > 255) gb = 255;
                        int bb = w.B + nr - 100;
                        if (bb < 0) bb = 0;
                        if (bb > 255) bb = 255;
                        wb = Color.FromArgb(rb, gb, bb);
                    }
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        private void citraGreyscaleToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            objBitmap2 = new Bitmap(objBitmap1);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap1.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap1.GetPixel(x - 1, y);
                    Color w3 = objBitmap1.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap1.GetPixel(x, y - 1);
                    Color w5 = objBitmap1.GetPixel(x, y);
                    Color w6 = objBitmap1.GetPixel(x, y + 1);
                    Color w7 = objBitmap1.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap1.GetPixel(x + 1, y);
                    Color w9 = objBitmap1.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xb = (int)((x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9) / 9);
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap2.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap2;
        }

        private void citraRGBToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            objBitmap = new Bitmap(objBitmap1);
            pictureBox1.Image = objBitmap;
            for (int x = 1; x < objBitmap.Width-1; x++)
            for (int y = 1; y < objBitmap.Height-1; y++)
            {
            Color w1 = objBitmap.GetPixel(x - 1, y - 1);
            Color w2 = objBitmap.GetPixel(x - 1, y);
            Color w3 = objBitmap.GetPixel(x - 1, y + 1);
            Color w4 = objBitmap.GetPixel(x, y - 1);
            Color w5 = objBitmap.GetPixel(x, y);
            Color w6 = objBitmap.GetPixel(x, y + 1);
            Color w7 = objBitmap.GetPixel(x + 1, y - 1);
            Color w8 = objBitmap.GetPixel(x + 1, y);
            Color w9 = objBitmap.GetPixel(x + 1, y + 1);
            int r = (int)((w1.R + w2.R + w3.R + w4.R + w5.R + w6.R + w7.R + w8.R + w9.R) / 9);
            int g = (int)((w1.G + w2.G + w3.G + w4.G + w5.G + w6.G + w7.G + w8.G + w9.G) / 9);
            int b = (int)((w1.B + w2.B + w3.B + w4.B + w5.B + w6.B + w7.B + w8.B + w9.B) / 9);
            Color wb = Color.FromArgb(r, g, b);
            objBitmap1.SetPixel(x, y, wb);
            }
            pictureBox2.Image = objBitmap1;
        }

        private void citraRGBToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap);
            for (int x = 1; x < objBitmap.Width - 1; x++)
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y - 1);
                    Color w2 = objBitmap.GetPixel(x - 1, y);
                    Color w3 = objBitmap.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap.GetPixel(x, y - 1);
                    Color w5 = objBitmap.GetPixel(x, y);
                    Color w6 = objBitmap.GetPixel(x, y + 1);
                    Color w7 = objBitmap.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap.GetPixel(x + 1, y);
                    Color w9 = objBitmap.GetPixel(x + 1, y + 1);
                    int rh = (int)(-w1.R - w4.R - w7.R + w3.R + w6.R + w9.R);
                    int gh = (int)(-w1.G - w4.G - w7.G + w3.G + w6.G + w9.G);
                    int bh = (int)(-w1.B - w4.B - w7.B + w3.B + w6.B + w9.B);
                    int rv = (int)(-w1.R - w2.R - w3.R + w7.R + w8.R + w9.R);
                    int gv = (int)(-w1.G - w2.G - w3.G + w7.G + w8.G + w9.G);
                    int bv = (int)(-w1.B - w2.B - w3.B + w7.B + w8.B + w9.B);
                    int r = (int)(rh + rv);
                    if (r < 0) r = -r;
                    if (r > 255) r = 255;
                    int g = (int)(gh + gv);
                    if (g < 0) g = -g;
                    if (g > 255) g = 255;
                    int b = (int)(bh + bv);
                    if (b < 0) b = -b;
                    if (b > 255) b = 255;
                    Color wb = Color.FromArgb(r, g, b);
                    objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;
        }

        public void setBitmap(Bitmap bitmap)
        {
            objBitmap = bitmap;
            pictureBox1.Image = objBitmap;
        }

        public void setBrightness(Bitmap bitmap)
        {
            objBitmap1 = bitmap;
            pictureBox2.Image = objBitmap1;
        }

        public void setBrightRGB(Bitmap bitmap)
        {
            objBitmap1 = bitmap;
            pictureBox2.Image = objBitmap1;
        }

        public void setContrast(Bitmap bitmap)
        {
            objBitmap1 = bitmap;
            pictureBox2.Image = objBitmap1;
        }

        public void setContrastrgb(Bitmap bitmap)
        {
            objBitmap1 = bitmap;
            pictureBox2.Image = objBitmap1;
        }

        public void setKuan(Bitmap bitmap)
        {
            objBitmap1 = bitmap;
            pictureBox2.Image = objBitmap1;
        }

        public void setThres(Bitmap bitmap)
        {
            objBitmap1 = bitmap;
            pictureBox2.Image = objBitmap1;
        }

    }
}
