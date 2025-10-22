using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool tempBoolVar = false;
        private void btnButton1_Click(object sender, EventArgs e)
        {
            if(tempBoolVar)
            {
                txbTextBox1.Text = txbTextBox1.Text.ToLower();
            }
            else
            {
                txbTextBox1.Text = txbTextBox1.Text.ToUpper();
            }
            tempBoolVar = !tempBoolVar;
        }
        
        bool tempBoolVar2 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (tempBoolVar2)
            {
                textBox1.Text = textBox1.Text.ToLower();
            }
            else
            {
                textBox1.Text = textBox1.Text.ToUpper();
            }
            tempBoolVar2 = !tempBoolVar2;
        }

        bool tempBoolVar3 = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (tempBoolVar3)
            {
                textBox2.Text = textBox2.Text.ToLower();
            }
            else
            {
                textBox2.Text = textBox2.Text.ToUpper();
            }
            tempBoolVar3 = !tempBoolVar3;
        }

        bool tempBoolVar4 = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (tempBoolVar4)
            {
                textBox3.Text = textBox3.Text.ToLower();
            }
            else
            {
                textBox3.Text = textBox3.Text.ToUpper();
            }
            tempBoolVar4 = !tempBoolVar4;
        }
    }
}
