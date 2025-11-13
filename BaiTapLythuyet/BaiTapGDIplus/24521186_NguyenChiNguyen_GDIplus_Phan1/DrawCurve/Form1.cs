using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawCurve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float tension = 1.0f;
        private void DrawCurve_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point pt1 = new Point(100, 10);
            Point pt2 = new Point(124, 75);
            Point pt3 = new Point(289, 100);
            Point pt4 = new Point(200, 280);
            Point pt5 = new Point(220, 190);
            Point pt6 = new Point(240, 230);
            Point[] ptsArray = { pt1, pt2, pt3, pt4, pt5, pt6 };
            g.DrawCurve(Pens.Red, ptsArray, tension);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tension = (float)Convert.ToDouble(textBox1.Text);
            Invalidate();
        }
    }
}
