using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null) 
            {
                listBox1.Items.Add(Clipboard.GetText());
            }
        }
    }
}
