using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Color = lblTestFontDialog.ForeColor;
            fontDialog1.Font = lblTestFontDialog.Font;

            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lblTestFontDialog.Font = fontDialog1.Font;
                lblTestFontDialog.ForeColor = fontDialog1.Color;
            }
        }
    }
}
