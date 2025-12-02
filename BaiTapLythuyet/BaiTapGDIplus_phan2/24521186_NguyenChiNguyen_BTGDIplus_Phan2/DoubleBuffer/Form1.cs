using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleBuffer
{
    public partial class Form1 : Form
    {
        int _xOffset = 0;
        int _yOffset = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Enabled = true;
            // Enable double buffer
            DoubleBuffered = true;
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void PaintEvt(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillRectangle(new SolidBrush(Color.DarkRed), 100 + _xOffset, 100 + _yOffset, 200, 50);
            g.FillEllipse(new SolidBrush(Color.LightYellow), 200 - _xOffset, 200 + _yOffset, 100, 100);
            g.FillEllipse(new SolidBrush(Color.DarkSeaGreen), 250 - _xOffset, 250 - _yOffset, 100, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _xOffset++;
            _yOffset++;
            this.Refresh();
        }
    }
}
