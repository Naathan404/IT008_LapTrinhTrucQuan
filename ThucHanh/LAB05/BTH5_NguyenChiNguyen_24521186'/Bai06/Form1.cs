using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ImportSystemFonts();
            lsvSystemFonts.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void ImportSystemFonts()
        {
            InstalledFontCollection installedFont = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFont.Families;
            lsvSystemFonts.BeginUpdate();
            foreach (FontFamily family in fontFamilies)
            {
                ListViewItem item = new ListViewItem();
                item.Text = family.Name;
                item.Font = new Font(family, 12);
                lsvSystemFonts.Items.Add(item);
            }
            lsvSystemFonts.EndUpdate();
        }
    }
}
