using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics bitmapGraphics;
        private Pen _mainPen = new Pen(Color.Red, 1);
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(contentBox.Width, contentBox.Height);
            bitmapGraphics = Graphics.FromImage(bitmap);
            contentBox.Image = bitmap;

            float[] dashPattern = { 1f, 5f };
            _mainPen.DashPattern = dashPattern;

            SetComboBoxItems();
        }

        private void SetComboBoxItems()
        {
            cbDashStyle.SelectedIndex = 0;
            cbWidth.SelectedIndex = 0;
            cbLineJoin.SelectedIndex = 0;
            cbDashCap.SelectedIndex = 0;
            cbStartCap.SelectedIndex = 0;
            cbEndCap.SelectedIndex = 0;
        }

        private void DrawLine(object sender, PaintEventArgs e)
        {
            bitmapGraphics.Clear(Color.White);

            Point p1 = new Point(30, 30);
            Point p2 = new Point(150, 150);
            bitmapGraphics.DrawLine(_mainPen, p1, p2);

            Point[] polyPoints = new Point[]
                {
                    new Point(30, 180),
                    new Point(150, 300),
                    new Point(200, 180)
                };
            bitmapGraphics.DrawLines(_mainPen, polyPoints);

            contentBox.Refresh();
        }

        private void cbDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDashStyle.SelectedIndex > -1)
            {
                string selectedValue = cbDashStyle.SelectedItem.ToString();
                _mainPen.DashStyle = (System.Drawing.Drawing2D.DashStyle)Enum.Parse(
                typeof(System.Drawing.Drawing2D.DashStyle),
                selectedValue);
            }
        }

        private void cbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWidth.SelectedIndex > -1)
            {
                if (float.TryParse(cbWidth.SelectedItem.ToString(), out float width))
                {
                    _mainPen.Width = width;
                }
            }
        }

        private void cbLineJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLineJoin.SelectedIndex > -1)
            {
                _mainPen.LineJoin = (System.Drawing.Drawing2D.LineJoin)Enum.Parse(
                typeof(System.Drawing.Drawing2D.LineJoin),
                cbLineJoin.SelectedItem.ToString());
            }
        }

        private void cbDashCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDashCap.SelectedIndex > -1)
            {
                _mainPen.DashCap = (System.Drawing.Drawing2D.DashCap)Enum.Parse(
                typeof(System.Drawing.Drawing2D.DashCap),
                cbDashCap.SelectedItem.ToString());
            }
        }

        private void cbStartCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStartCap.SelectedIndex > -1)
            {
                _mainPen.StartCap = (System.Drawing.Drawing2D.LineCap)Enum.Parse(
                typeof(System.Drawing.Drawing2D.LineCap),
                cbStartCap.SelectedItem.ToString());
            }
        }

        private void cbEndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEndCap.SelectedIndex > -1)
            {
                _mainPen.EndCap = (System.Drawing.Drawing2D.LineCap)Enum.Parse(
                typeof(System.Drawing.Drawing2D.LineCap),
                cbEndCap.SelectedItem.ToString());
            }
        }
    }
}
