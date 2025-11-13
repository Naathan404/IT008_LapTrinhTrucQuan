using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawBezier
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
            Point pt1 = new Point(110, 50);
            Point pt2 = new Point(10, 200);
            Point pt3 = new Point(290, 20);
            Point pt4 = new Point(300, 100);
            Pen p = new Pen(Color.Red, 3);
            g.DrawBezier(Pens.Blue, pt1, pt2, pt3, pt4);
        }
    }
}
