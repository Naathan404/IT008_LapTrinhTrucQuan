using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsObject_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap btm = new Bitmap(200, 200);
            Graphics g = Graphics.FromImage(btm);
            Pen pen = new Pen(Color.Blue, 3);
            Pen pen1 = new Pen(Color.Yellow, 5);
            g.FillRectangle(Brushes.Red, 0, 0, 200, 200);
            g.DrawLine(pen, 0, 0, 200, 200);
            g.DrawLine(pen, 0, 200, 200, 0);
            g.DrawLine(pen1, 100, 0, 100, 200);
            g.DrawLine(pen1, 0, 100, 200, 100);
            e.Graphics.DrawImage(btm, 0, 0);
        }
    }
}
