using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace Pen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static SolidBrush blueBrush = new SolidBrush(Color.Blue);
        static HatchBrush hatchBrush = new HatchBrush(HatchStyle.DashedVertical,
        Color.Black, Color.Green);
        System.Drawing.Pen pn1 = new System.Drawing.Pen(blueBrush, 3);
        System.Drawing.Pen pn2 = new System.Drawing.Pen(hatchBrush, 8);
        System.Drawing.Pen pn3 = new System.Drawing.Pen(Color.Red);

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(pn1, new Rectangle(5, 5, 200, 80));
            g.DrawRectangle(pn2, new Rectangle(5, 100, 200, 80));
            g.DrawRectangle(pn3, new Rectangle(5, 200, 200, 80));
            g.DrawRectangle(Pens.Magenta, new Rectangle(5, 300, 200, 80));
            g.DrawEllipse(pn1, new Rectangle(300, 5, 200, 200));
        }
    }
}
