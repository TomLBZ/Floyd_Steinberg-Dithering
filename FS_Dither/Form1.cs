using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS_Dither
{
    public partial class frmDither : Form
    {
        public frmDither()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (fileLoadPic.ShowDialog() == DialogResult.OK)
            {
                Graphics g = Graphics.FromImage(picSource.Image);
                Bitmap f = new Bitmap(fileLoadPic.FileName);
                g.DrawImage(f, new Rectangle(0, 0, picSource.Width, picSource.Height));
                picSource.Refresh();
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Color[] pallet = GetPalletFromList();
            Bitmap bmp = new Bitmap(picSource.Image);
            Bitmap dest = new Bitmap(picDest.Image);
            int[,] maskR = new int[picSource.Width, picSource.Height];
            int[,] maskG = new int[picSource.Width, picSource.Height];
            int[,] maskB = new int[picSource.Width, picSource.Height];
            for (int y = 0; y < picSource.Height; y++)
            {
                for (int x = 0; x < picSource.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    Color p = ToPallette(pallet, c);
                    int dR = c.R - p.R, dG = c.G - p.G, dB = c.B - p.B;
                    int R_r = dR * 7 / 16, R_bl = dR * 3 / 16, R_b = dR * 5 / 16, R_br = dR * 1 / 16;
                    int G_r = dG * 7 / 16, G_bl = dG * 3 / 16, G_b = dG * 5 / 16, G_br = dG * 1 / 16;
                    int B_r = dB * 7 / 16, B_bl = dB * 3 / 16, B_b = dB * 5 / 16, B_br = dB * 1 / 16;
                    if (x < picSource.Width - 1)
                    {
                        maskR[x + 1, y] = R_r;
                        maskG[x + 1, y] = G_r;
                        maskB[x + 1, y] = B_r;
                        Color c_r = bmp.GetPixel(x + 1, y);
                        bmp.SetPixel(x + 1, y, ApplyMaskToPixel(c_r, R_r, G_r, B_r));
                    }
                    if (y < picSource.Height - 1)
                    {
                        if (x > 0)
                        {
                            maskR[x - 1, y + 1] = R_bl;
                            maskG[x - 1, y + 1] = G_bl;
                            maskB[x - 1, y + 1] = B_bl;
                            Color c_bl = bmp.GetPixel(x - 1, y + 1);
                            bmp.SetPixel(x - 1, y + 1, ApplyMaskToPixel(c_bl, R_bl, G_bl, B_bl));
                        }
                        if (x < picSource.Width - 1)
                        {
                            maskR[x + 1, y + 1] = R_br;
                            maskG[x + 1, y + 1] = G_br;
                            maskB[x + 1, y + 1] = B_br;
                            Color c_br = bmp.GetPixel(x + 1, y + 1);
                            bmp.SetPixel(x + 1, y + 1, ApplyMaskToPixel(c_br, R_br, G_br, B_br));
                        }
                        maskR[x, y + 1] = R_b;
                        maskG[x, y + 1] = G_b;
                        maskB[x, y + 1] = B_b;
                        Color c_b = bmp.GetPixel(x, y + 1);
                        bmp.SetPixel(x, y + 1, ApplyMaskToPixel(c_b, R_b, G_b, B_b));
                    }
                    dest.SetPixel(x, y, p);
                }
            }
            Bitmap mask = new Bitmap(picMask.Image);
            for (int xx = 0; xx < picMask.Width; xx++)
            {
                for (int yy = 0; yy < picMask.Height; yy++)
                {
                    mask.SetPixel(xx, yy, Color.FromArgb(maskR[xx, yy] / 2 + 127, maskG[xx, yy] / 2 + 127, maskB[xx, yy] / 2 + 127));
                }
            }
            picMask.Image = mask;
            picMask.Refresh();
            picDest.Image = dest;
            picDest.Refresh();
        }

        private Color[] GetPalletFromList()
        {
            Color[] rtn = new Color[lstPallet.Items.Count];
            int index = 0;
            foreach (ListViewItem item in lstPallet.Items)
            {
                rtn[index] = item.BackColor;
                index++;
            }
            return rtn;
        }

        private Color ToPallette(Color[] pallete, Color pixel)
        {
            int min = int.MaxValue;
            int index = -1;
            for (int i = 0; i < pallete.Length; i++)
            {
                int diff = ColorDiffEuclidean(pixel, pallete[i]);
                if (min > diff)
                {
                    min = diff;
                    index = i;
                }
            }
            return pallete[index];
        }

        private int ColorDiffEuclidean(Color pixel, Color reference)
        {
            return (pixel.R - reference.R) * ((pixel.R - reference.R)) + (pixel.G - reference.G) * ((pixel.G - reference.G)) + (pixel.B - reference.B) * ((pixel.B - reference.B));
        }

        private Color ApplyMaskToPixel(Color pixel, int maskR, int maskG, int maskB)
        {
            int r = pixel.R + maskR;
            int g = pixel.G + maskG;
            int b = pixel.B + maskB;
            if (r > 255) r = 255;
            if (g > 255) g = 255;
            if (b > 255) b = 255;
            if (r < 0) r = 0;
            if (g < 0) g = 0;
            if (b < 0) b = 0;
            return Color.FromArgb(r, g, b);
        }

        private void frmDither_Load(object sender, EventArgs e)
        {
            Bitmap bmps = new Bitmap(picSource.Width, picSource.Height);
            picSource.Image = bmps;
            Bitmap bmpm = new Bitmap(picMask.Width, picMask.Height);
            picMask.Image = bmpm;
            Bitmap bmpd = new Bitmap(picDest.Width, picDest.Height);
            picDest.Image = bmpd;
        }

        private void btnRemoveColor_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstPallet.SelectedItems)
            {
                lstPallet.Items.Remove(item);
            }
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (colorSelect.ShowDialog() == DialogResult.OK)
            {
                Color c = colorSelect.Color;
                string itemText = "RGB(" + c.R + "," + c.G + "," + c.B + ")";
                int index = lstPallet.Items.Count;
                lstPallet.Items.Add(itemText);
                lstPallet.Items[index].BackColor = c;
                lstPallet.Items[index].ForeColor = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
