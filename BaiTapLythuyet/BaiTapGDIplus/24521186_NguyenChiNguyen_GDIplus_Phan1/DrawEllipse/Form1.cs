using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawEllipse
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
            Rectangle rect = new Rectangle(80, 80, 50, 50);
            int x = 20, y = 30, width = 120, height = 230;
            Pen p1 = new Pen(Color.Red, 3);
            Pen p2 = new Pen(Color.Blue, 2);
            g.DrawEllipse(p2, rect);
            g.DrawEllipse(p1, x, y, width, height);

            g.DrawEllipse(p2, 530, 80, 50, 50);
            g.DrawEllipse(p1, x + 500, y, width, height);

            g.DrawLine(p1, 100, 300, 500, 300);
        }
    }
}
