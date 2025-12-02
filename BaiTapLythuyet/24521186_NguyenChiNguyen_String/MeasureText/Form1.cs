using System.Drawing;
using System.Windows.Forms;

namespace MeasureText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Time New Roman", 25, FontStyle.Bold);
            string strText = "measure string";
            SizeF sizef = g.MeasureString(strText, font);
            g.DrawString(strText, font, Brushes.Black,
                (ClientSize.Width - sizef.Width) / 2,
                (ClientSize.Height - sizef.Height) / 2);
        }
    }
}