using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        ColorDialog colorDialog = new ColorDialog();
        Bitmap bitmap;
        Graphics bitmapGraphics;
        Pen pen = new Pen(Color.Red);
        Point lastPos;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(contentBox.Width, contentBox.Height);
            bitmapGraphics = Graphics.FromImage(bitmap);
            bitmapGraphics.Clear(Color.White);
            contentBox.Image = bitmap;

            cbbWidth.SelectedItem = "4";
            btnColor.BackColor = Color.Red;
            rabSolidBrush.Checked = true;
            rabLine.Checked = true;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                pen.Color = colorDialog.Color;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            lastPos = e.Location;
        }

        //private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (rabLine.Checked)
        //    {
        //        if (e.Button == MouseButtons.Left)
        //        {
        //            bitmapGraphics.DrawLine(pen, lastPos, e.Location);
        //            lastPos = e.Location;
        //            contentBox.Refresh();
        //        }
        //    }
        //}

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (rabLine.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    bitmapGraphics.DrawLine(pen, lastPos, e.Location);
                    contentBox.Refresh();
                }
            }
            else if (rabRectangle.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int x = Math.Min(lastPos.X, e.X);
                    int y = Math.Min(lastPos.Y, e.Y);
                    int width = Math.Abs(e.X - lastPos.X);
                    int height = Math.Abs(e.Y - lastPos.Y);
                    bitmapGraphics.FillRectangle(pen.Brush, x, y, width, height);
                    contentBox.Refresh();
                }
            }
            else if (rabEllipse.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int x = Math.Min(lastPos.X, e.X);
                    int y = Math.Min(lastPos.Y, e.Y);
                    int width = Math.Abs(e.X - lastPos.X);
                    int height = Math.Abs(e.Y - lastPos.Y);
                    bitmapGraphics.FillEllipse(pen.Brush, x, y, width, height);
                    contentBox.Refresh();
                }
            }
        }

        private void cbbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen.Width = float.Parse(cbbWidth.SelectedItem.ToString());
        }

        private void BrushChanged(object sender, EventArgs e)
        {
            if (rabSolidBrush.Checked)
            {
                pen.Brush = new SolidBrush(pen.Color);
            }
            else if (rabHatchBrush.Checked)
            {
                pen.Brush = new System.Drawing.Drawing2D.HatchBrush(
                    System.Drawing.Drawing2D.HatchStyle.Horizontal,
                    Color.Blue,
                    Color.Green);
            }
            else if (rabTextureBrush.Checked)
            {
                int textureSize = 16;
                Bitmap textureBitmap = new Bitmap(textureSize, textureSize);
                using (Graphics g = Graphics.FromImage(textureBitmap))
                {
                    g.Clear(Color.LightGray);
                    SolidBrush dotBrush = new SolidBrush(Color.Black);
                    g.FillEllipse(dotBrush,
                                  textureSize / 4,
                                  textureSize / 4,
                                  textureSize / 2,
                                  textureSize / 2);
                }
                pen.Brush = new TextureBrush(textureBitmap);
            }
            else if (rabLinearGradientBRush.Checked)
            {
                pen.Brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Point(0, 0),
                    new Point(0, 200),
                    Color.Red,
                    Color.Green);
            }
        }

        private void btnColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                pen.Color = colorDialog.Color;
            }
        }
    }
}
