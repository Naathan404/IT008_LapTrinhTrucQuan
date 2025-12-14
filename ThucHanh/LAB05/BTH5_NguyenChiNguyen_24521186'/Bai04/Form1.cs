using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ImportSystemFonts();
            cbbFont.SelectedItem = "Times New Roman";
            cbbSize.SelectedItem = "16";
            ApplyTextFormat();
        }

        private void ImportSystemFonts()
        {
            InstalledFontCollection installedFont = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFont.Families;
            foreach (FontFamily family in fontFamilies)
            {
                cbbFont.Items.Add(family.Name);
            }
        }

        private void ApplyTextFormat()
        {
            if (cbbFont.SelectedItem == null || cbbSize.SelectedItem == null)
                return;
            string fontName = cbbFont.SelectedItem.ToString();
            float fontSize = float.Parse(cbbSize.SelectedItem.ToString());
            FontStyle fontStyle = FontStyle.Regular;
            if (chbBold.Checked)
                fontStyle |= FontStyle.Bold;
            if (chbItalic.Checked)
                fontStyle |= FontStyle.Italic;
            if (chbUnderline.Checked)
                fontStyle |= FontStyle.Underline;
            txbText.Font = new Font(fontName, fontSize, fontStyle);
        }

        private void FormatChanged(object sender, EventArgs e)
        {
            ApplyTextFormat();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txbText.ForeColor = colorDialog.Color;
                btnColor.BackColor = colorDialog.Color;
            }
        }

        private void AlignChanged(object sender, EventArgs e)
        {
            if (radLeft.Checked)
            {
                txbText.TextAlign = HorizontalAlignment.Left;
            }
            else if (radCenter.Checked)
            {
                txbText.TextAlign = HorizontalAlignment.Center;
            }
            else if (radRight.Checked)
            {
                txbText.TextAlign = HorizontalAlignment.Right;
            }
        }
    }
}
