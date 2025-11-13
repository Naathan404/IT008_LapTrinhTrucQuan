using System;
using System.Drawing;
using System.Windows.Forms;

namespace Font
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Drawing.Font f1 = new System.Drawing.Font("Times New Roman", 16, FontStyle.Bold);
        System.Drawing.Font f2 = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
        System.Drawing.Font f3 = new System.Drawing.Font("Arial", 1, GraphicsUnit.Inch);

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("This is Times New Roman, 16pt, Bold", f1, Brushes.Magenta, 10, 10);
            g.DrawString("This is Arial, 16pt, Bold", f2, Brushes.Blue, 10, 50);
            g.DrawString("This is Arial, 1 inch, Regular", f3, Brushes.Red, 10, 90);
        }
    }
}
