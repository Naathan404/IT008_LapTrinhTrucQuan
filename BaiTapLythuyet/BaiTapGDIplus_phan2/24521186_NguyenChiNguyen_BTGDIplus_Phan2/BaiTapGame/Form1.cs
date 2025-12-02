using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapGame
{
    public partial class Form1 : Form
    {
        private int _numberOfGreenCircles = 4;
        private float _playTime = 15.0f;
        private int _score = 0;
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        private Rectangle _redCircleRect;
        private int _width, _height;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
            lblScore.Visible = false;
            lblTimer.Visible = false;
            _width = ClientSize.Width;
            _height = ClientSize.Height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!timer1.Enabled) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int diameter = (int)(0.125f * Height);
            Random rnd = new Random();

            _redCircleRect = new Rectangle(rnd.Next(0, _width),
                rnd.Next(100, _height),
                diameter, diameter);
            g.FillEllipse(redBrush, _redCircleRect);
            for (int i = 0; i < _numberOfGreenCircles; i++)
            {
                g.FillEllipse(greenBrush,
                rnd.Next(0, _width),
                rnd.Next(100, _height),
                diameter, diameter);
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            _score = 0;
            _playTime = 15.0f;
            _numberOfGreenCircles = 4;
            timer1.Enabled = true;
            btnStartGame.Visible = false;

            lblTimer.Visible = true;
            lblScore.Visible = true;
            lblTimer.Text = _playTime.ToString();
            lblScore.Text = _score.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _playTime -= 0.5f;
            if(_playTime % 1 == 0)
            {
                _numberOfGreenCircles++;
                lblTimer.Text = _playTime.ToString();
            }

            if(_playTime <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Time out! Your score is: " + _score);
                btnStartGame.Visible = true;
            }

            this.Refresh();
        }

        private void MouseClickEvt(object sender, MouseEventArgs e)
        {
            if(timer1.Enabled)
            {
                if(_redCircleRect.Contains(e.Location))
                {
                    _score++;
                    lblScore.Text = _score.ToString();
                }
            }
        }
    }
}
