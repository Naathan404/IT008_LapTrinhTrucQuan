using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multimedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "All File|*|AVI file|*.avi|MPEG File|*.mpeg|Wave File|*.wav|MIDI File|*midi|MP4 File|*.mp4";

            if(fileDialog.ShowDialog() == DialogResult.OK )
            {
                WWPlayer.URL = fileDialog.FileName;
            }
        }
    }
}
