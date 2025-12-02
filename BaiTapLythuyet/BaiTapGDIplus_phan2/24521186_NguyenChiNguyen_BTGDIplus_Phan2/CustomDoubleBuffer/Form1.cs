using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDoubleBuffer
{
    public partial class Form1 : Form
    {
        private Bitmap _backBuffer;
        float _angle;
        bool _doBuffer;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Enabled = true;

            DoubleBuffered = true;
        }
        // Dùng timer để thay đổi góc chuyển động 
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            _angle += 3;
            if (_angle > 359)
                _angle = 0;
            Invalidate();
        } 

        protected override void OnPaint(PaintEventArgs e)
        {
            // Tạo một back buffer 
            if (_backBuffer == null)
            {
                _backBuffer = new Bitmap(this.ClientSize.Width,
                this.ClientSize.Height);
            }
            // Khởi tạo đối tượng Graphics 
            Graphics g = null;
            if (_doBuffer)
                // Lấy đối tượng Graphics để vẽ lên back buffer 
                g = Graphics.FromImage(_backBuffer);
            else
                g = e.Graphics;
            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int w = this.ClientSize.Width / 2;
            int h = this.ClientSize.Height / 2;
            // Chuyển động các đối tượng bằng cách xoay 
            Matrix mx = new Matrix();
            mx.Rotate(_angle, MatrixOrder.Append);
            mx.Translate(w, h, MatrixOrder.Append);
            g.Transform = mx;
            g.FillRectangle(Brushes.Red, -100, -100, 200, 200);
            mx = new Matrix();
            mx.Rotate(-_angle, MatrixOrder.Append);
            mx.Translate(w, h, MatrixOrder.Append);
            g.Transform = mx;
            g.FillRectangle(Brushes.Green, -75, -75, 149, 149);
            mx = new Matrix();
            mx.Rotate(_angle * 2, MatrixOrder.Append);
            mx.Translate(w, h, MatrixOrder.Append);
            g.Transform = mx;
            g.FillRectangle(Brushes.Blue, -50, -50, 100, 100);
            // Nếu checkbox được chọn vẽ lên màn hình bằng back buffer 
            if (_doBuffer)
            {
                g.Dispose();
                e.Graphics.DrawImageUnscaled(_backBuffer, 0, 0);
            }
        }
    }
}
