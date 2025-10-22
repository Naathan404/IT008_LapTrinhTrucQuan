using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveFileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = saveFileDialog1.OpenFile();
                StreamWriter writer = new StreamWriter(myStream);   

                writer.Write(textBox1.Text);
                writer.Close();
                myStream.Close();
            }
        }
    }
}
