using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.TranslateTransform(100, 100);
            Pen pen1 = new Pen(Color.Red, 3);
            g.DrawRectangle(pen1, 0, 0, 120, 120);

            g.TranslateTransform(200, 200);
            g.RotateTransform(45);
            Pen pen2 = new Pen(Color.Green, 3);
            g.DrawRectangle(pen2, 0, 0, 100, 100);
        }

       
    }
}
