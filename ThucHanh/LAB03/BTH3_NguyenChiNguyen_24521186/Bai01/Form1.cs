using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lsbLog.Items.Add("Form1_Construction");
        }

        // Load
        private void Form1_Load(object sender, EventArgs e)
        {
            lsbLog.Items.Add("Form1_Load");
        }
        // Activate
        private void Form1_Activate(object sender, EventArgs e)
        {
            lsbLog.Items.Add("Form1_Activate");
        }
        // Shown
        private void Form1_Shown(object sender, EventArgs e)
        {
            lsbLog.Items.Add("Form1_Shown");
        }
        // Deactivate
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            lsbLog.Items.Add("Form1_Deactivate");
        }
        // Closing
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            lsbLog.Items.Add("Form1_Closing");
        }
        // Closed
        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            lsbLog.Items.Add("Form1_Closed");
        }

        // Nút mở form con
        private void btnOpenChildForm_Click(object sender, EventArgs e)
        {
            Form childForm = new ChildForm(this);
            childForm.Show();
        }
        // Nút đóng form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
