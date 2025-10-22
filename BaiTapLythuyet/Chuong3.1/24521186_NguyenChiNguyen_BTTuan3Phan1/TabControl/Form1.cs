using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float a, b;
            if(float.TryParse(txbNum1.Text, out a) && float.TryParse(txbNum2.Text, out b))
            {
                float sum = a + b;
                txbAnswer.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Invalid data!");
                btnClear_Click(sender, e);
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            float a, b;
            if (float.TryParse(txbNum1.Text, out a) && float.TryParse(txbNum2.Text, out b))
            {
                float sum = a - b;
                txbAnswer.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Invalid data!");
                btnClear_Click(sender, e);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            float a, b;
            if (float.TryParse(txbNum1.Text, out a) && float.TryParse(txbNum2.Text, out b))
            {
                float sum = a * b;
                txbAnswer.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Invalid data!");
                btnClear_Click(sender, e);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            float a, b;
            if (float.TryParse(txbNum1.Text, out a) && float.TryParse(txbNum2.Text, out b) && b != 0)
            {
                float sum = a / b;
                txbAnswer.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Invalid data!");
                btnClear_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbAnswer.Text = "";
            txbNum1.Text = "";
            txbNum2.Text = "";
        }
    }
}
