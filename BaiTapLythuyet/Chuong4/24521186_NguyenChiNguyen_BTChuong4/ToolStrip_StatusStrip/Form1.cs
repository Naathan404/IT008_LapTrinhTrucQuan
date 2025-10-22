using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolStrip_StatusStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The first button has been clicked");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The second button has been clicked");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The third button has been clicked");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The fourth button has been clicked");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerTick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
