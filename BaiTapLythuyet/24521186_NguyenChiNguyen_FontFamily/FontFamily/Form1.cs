using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontFamily
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.FontFamily myFamily = new System.Drawing.FontFamily("Times New Roman");
            Font myFont = new Font(myFamily, 15, FontStyle.Regular);
            Graphics g = e.Graphics;

            // Print our Family ties...
            string strText = "Measurements are in GraphicsUnit: " +
                             myFont.Unit.ToString() + "\n" +
                             "Font Family Name: " + myFamily.GetName(0) + "\n" +
                             "Ascent for bold: " +
                             myFamily.GetCellAscent(FontStyle.Bold) + "\n" +
                             "Descent for bold: " +
                             myFamily.GetCellDescent(FontStyle.Bold) + "\n" +
                             "Line spacing for: " +
                             myFamily.GetLineSpacing(FontStyle.Bold) + "\n" +
                             "Height for bold: " +
                             myFamily.GetEmHeight(FontStyle.Bold);

            g.DrawString(strText, myFont, Brushes.Black, Point.Empty);
            myFont.Dispose();
        }
    }
}
