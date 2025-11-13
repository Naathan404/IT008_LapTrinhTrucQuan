using System;
using System.Collections.Generic;                                           
using System.Drawing;
using System.Windows.Forms;

namespace DrawApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshPen();
        }

        // Pen Attributes
        Pen _pen;
        float _thickness = 1;
        Color _color = Color.Black;

        // Start point & end point of mouse events
        Point _startPoint = new Point();
        Point _endPoint = new Point();
        DRAW_MODE _drawMode;

        // Stacks
        Stack<object> _undoStack = new Stack<object>();
        
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            _color = colorDialog1.Color;
            RefreshPen();
        }
        private void ThicknessValue_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripItm = sender as ToolStripMenuItem;
            _thickness = float.Parse(toolStripItm.Text.Trim());
            RefreshPen();
        }

        private void MouseMoveEvt(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                if (_drawMode == DRAW_MODE.FREELINE)
                {
                    g.DrawLine(_pen, _startPoint, e.Location);
                    _startPoint = e.Location;
                }
                
            }
        }


        private void RefreshPen()
        {
            _pen = new Pen(_color, _thickness);
        }

        private void MouseDownEvt(object sender, MouseEventArgs e)
        {
            _startPoint = e.Location;
        }

        private void DrawMode_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItm = sender as ToolStripMenuItem;
            switch (toolStripMenuItm.Text)
            {
                case "Ellipse":
                    _drawMode = DRAW_MODE.ELLIPSE; break;
                case "Curve":
                    _drawMode = DRAW_MODE.CURVE; break;
                case "Rectangle":
                    _drawMode = DRAW_MODE.RECTANGLE; break;
                default:
                    _drawMode = DRAW_MODE.FREELINE; break;
            }
        }

        private void MouseUpEvt(object sender, MouseEventArgs e)
        {
            _endPoint = e.Location;
            if (_startPoint.Y > _endPoint.Y)
            {
                int temp = _startPoint.Y;
                _startPoint.Y = _endPoint.Y;
                _endPoint.Y = temp;
            }

            if(_startPoint.X > _endPoint.X)
            {
                int temp = _startPoint.X;
                _startPoint.X = _endPoint.X;
                _endPoint.X = temp;
            }
            
            Graphics g = this.CreateGraphics();
            if (_drawMode == DRAW_MODE.RECTANGLE)
            {
                g.DrawRectangle(_pen, _startPoint.X, _startPoint.Y, _endPoint.X - _startPoint.X, _endPoint.Y - _startPoint.Y);
            }
            if(_drawMode == DRAW_MODE.ELLIPSE)
            {
                g.DrawEllipse(_pen, _startPoint.X, _startPoint.Y, _endPoint.X - _startPoint.X, _endPoint.Y - _startPoint.Y);
            }
        }
    }

    public enum DRAW_MODE
    {
        FREELINE,
        CURVE,
        RECTANGLE,
        ELLIPSE
    }
}
