using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        private int _offset = 20;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            timer1.Interval = 10;
            timer1.Tick += TimerClock_Tick;
            timer1.Start();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // tâm đồng hồ
            int cx = this.ClientSize.Width / 2;
            int cy = this.ClientSize.Height / 2;
            g.TranslateTransform(cx, cy); // góc tọa độ về tâm đồng hồ

            int radius = Math.Min(cx, cy) - _offset;


            // lưu trạng thái ban đầu của g
            var originalState = g.Save();

            for (int i = 0; i < 60; i++)
            {
                if (i % 5 == 0)     // vạch giờ
                    g.FillEllipse(Brushes.White, -6, -radius - 5f, 12, 12);
                else                // vạch phút
                    g.FillEllipse(Brushes.White, -2, -radius, 4, 4);
                g.RotateTransform(6);
            }
            // khôi phục g về trang thái ban đầu
            g.Restore(originalState);

            // lấy thời gian hiện tại
            DateTime now = DateTime.Now;
            float hour = now.Hour;
            float minute = now.Minute;
            float second = now.Second;


            // vẽ kim giờ: góc = (giờ + phút/60) * 30 độ
            float hourAngle = (hour % 12 + minute / 60f) * 30;

            originalState = g.Save();
            g.RotateTransform(hourAngle);
            PointF[] hourHand = new PointF[]
            {
                new PointF(0, 20),
                new PointF(-10, -radius * 0.2f),
                new PointF(0, -radius * 0.6f),
                new PointF(10, -radius * 0.2f)
            };
            g.DrawPolygon(new Pen(Color.White, 2), hourHand);
            g.Restore(originalState);


            // vẽ kim giờ: góc = (phút + giây/60) * 6 độ
            float minuteAngle = (minute + second / 60f) * 6;
            originalState = g.Save();
            g.RotateTransform(minuteAngle);
            PointF[] minuteHand = new PointF[]
            {
                new PointF(0, 20),
                new PointF(-6, -radius * 0.2f),
                new PointF(0, -radius * 0.9f),
                new PointF(6, -radius * 0.2f)
            };
            g.DrawPolygon(new Pen(Color.White, 2), minuteHand);
            g.Restore(originalState);


            //vẽ kim giây
            float secondAngle = (second + now.Millisecond / 1000f) * 6;
            originalState = g.Save();
            g.RotateTransform(secondAngle);
            g.DrawLine(new Pen(Color.Red, 2), 0, 10, 0, -radius * 0.9f);
            g.Restore(originalState);

            // vẽ tâm đồng hồ
            g.FillEllipse(Brushes.White, -5, -5, 10, 10);
        }
    }
}
