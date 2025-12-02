using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace Bai03_WindowsMediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            statusStripDateTime.Enabled = true;
            statusStripDateTime.Text = DateTime.Now.ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "AVI file|*.avi|MPEG file|*.mpeg|WAV file|*.wav|MIDI file|*.midi|MP4 file|*.mp4|MP3 file|*.mp3|All files|*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();
                string[] validExtensions = { ".avi", ".mpeg", ".wav", ".midi", ".mp4", ".mp3" };

                if (Array.IndexOf(validExtensions, fileExtension) > -1)
                {
                    WWPlayer.URL = filePath;
                }
                else
                {
                    MessageBox.Show(
                        "Định dạng file này không được hỗ trợ để phát.\n\nCác định dạng được hỗ trợ: AVI, MPEG, WAV, MIDI, MP4, MP3.",
                        "Lỗi Định Dạng File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    WWPlayer.URL = "";
                }
            }
        }

        private void timer1_TickEvt(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                statusStripDateTime.Text = "Hôm nay là ngày " + DateTime.Today.ToString("dd-MM-yyyy")
                    + " - Bây giờ là " + DateTime.Now.ToString("HH:mm:ss");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
