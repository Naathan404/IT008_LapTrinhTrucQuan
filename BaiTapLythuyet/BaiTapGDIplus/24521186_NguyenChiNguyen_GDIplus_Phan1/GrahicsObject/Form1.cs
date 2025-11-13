using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrahicsObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Draw_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)), 2);
            g.DrawLine(pen, rnd.Next(0, Width), rnd.Next(0, Height), rnd.Next(0, Width), rnd.Next(0, Height));
            g.Dispose();
        }
    }
}
