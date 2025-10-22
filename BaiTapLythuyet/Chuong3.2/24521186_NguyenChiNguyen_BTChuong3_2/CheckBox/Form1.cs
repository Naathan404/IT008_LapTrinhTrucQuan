using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ECheckBox
{
    public partial class Form1 : Form
    {
        public List<CheckBox> FruitList = new List<CheckBox>();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            lblSelectedFruit.Text = "You have selected: ";
            foreach(CheckBox fruit in FruitList)
            {
                if (fruit.Checked)
                {
                    lblSelectedFruit.Text += "\n" + fruit.Text;
                }
                else
                {
                    lblSelectedFruit.Text += "";
                }
            }
        }
    }
}
