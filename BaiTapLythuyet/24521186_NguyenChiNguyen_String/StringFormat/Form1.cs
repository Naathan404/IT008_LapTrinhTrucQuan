using System.Drawing;
using System.Windows.Forms;

namespace StringFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string strText = "Top to Bottom";
            Graphics g = e.Graphics;
            Font font = new Font("Times New Roman", 15, FontStyle.Bold);

            System.Drawing.StringFormat strFormat = new System.Drawing.StringFormat();
            strFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;

            g.Clear(Color.White);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            g.DrawString(strText, font, Brushes.Black,
                new RectangleF(0, 0, ClientRectangle.Width, ClientRectangle.Height), strFormat);
        }
    }
}