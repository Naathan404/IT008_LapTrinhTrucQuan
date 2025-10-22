using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an information message.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an error message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a warning message.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Is this a question message?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
