using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transformation
{
    public partial class Form1 : Form
    {
        private float _x = 0, _y = 0;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Enabled = true;
        }
        
        private void PaintEvt(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawRectangle(Pens.Red, _x, 0, 200, 100);
            g.DrawRectangle(Pens.Green, 0, _y, 200, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _x = (_x + 1) % 200;
            _y = (_y + 1) % 200;
            this.Refresh();
        }
    }
}
