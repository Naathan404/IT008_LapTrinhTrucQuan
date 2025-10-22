using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_Textbox_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtToLower_Click(object sender, EventArgs e)
        {
            string str = txtTextBox.Text;
            txtTextBox.Text = str.ToLower();
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            string str = txtTextBox.Text;
            txtTextBox.Text = str.ToUpper();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
