using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Invalidate();
        }

        private void frmPaintEvt(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            Graphics g = e.Graphics;

            int x = rnd.Next(0, this.ClientSize.Width);     // Chieu rong cua window hien tai
            int y = rnd.Next(0, this.ClientSize.Height);    // Chieu cao cua window hien tai
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))))
            {
                g.FillRectangle(brush, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            }
            using (SolidBrush textBrush = new SolidBrush(Color.Black))
            {
                // Su dung DrawString de ve chu len form
                g.DrawString("Paint Event", new Font(this.Font.FontFamily, 12), textBrush, x, y);
            }
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
