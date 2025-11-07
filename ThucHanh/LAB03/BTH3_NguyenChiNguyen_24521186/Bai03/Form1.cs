using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            // Chon mau ngau nhien
            Color color = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            this.BackColor = color;
        }
    }
}
