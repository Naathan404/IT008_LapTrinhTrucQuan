using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float sum = int .Parse(txbTextbox1.Text) + int.Parse(txbTextbox2.Text);
            MessageBox.Show("The sum = " + sum.ToString());
        }

        private void txbTextbox1_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if(!int.TryParse(control.Text, out int value))
            {
                errorProvider1.SetError(control, "This is not a valid number");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
