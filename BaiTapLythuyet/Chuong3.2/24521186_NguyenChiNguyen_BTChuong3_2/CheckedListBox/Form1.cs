using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount1_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(var item in CheckListBox1.CheckedItems)
            {
                count++;
            }
            MessageBox.Show("Total checked items in check list box 1: " + count);
        }

        private void btnCount2_Click(object sender, EventArgs e)
        {
            int count = 0;
            for(int i = 0; i < CheckListBox2.CheckedItems.Count; i++)
            {
                count++;
            }
            MessageBox.Show("Total checked items in check list box 2: " + count);
        }
    }
}
