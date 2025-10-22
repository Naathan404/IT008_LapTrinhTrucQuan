using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvent
{
    public partial class Form1 : Form
    {
        private List<Point> _points = new List<Point>();
        private bool _isPainting = false;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isPainting = true;
                _points.Clear(); 
                _points.Add(e.Location); 
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isPainting)
            {
                _points.Add(e.Location);
                this.Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isPainting = false;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (_points.Count > 1)
            {
                Pen pen = new Pen(Color.Red, 2f);
                e.Graphics.DrawLines(pen, _points.ToArray());
            }
        }
    }
}
