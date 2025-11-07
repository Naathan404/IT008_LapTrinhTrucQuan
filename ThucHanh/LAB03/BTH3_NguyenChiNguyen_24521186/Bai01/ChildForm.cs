using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class ChildForm : Form
    {
        Form1 parentForm;
        public ChildForm(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }
       
        private void ChildFrom_Activated(object sender, EventArgs e)
        {
            parentForm.lsbLog.Items.Add("ChildForm_Activated");
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            parentForm.lsbLog.Items.Add("ChildForm_Load");
        }

        private void ChildForm_Deactivate(object sender, EventArgs e)
        {
            parentForm.lsbLog.Items.Add("ChildForm_Deactivate");
        }

        private void ChildForm_Closed(object sender, FormClosedEventArgs e)
        {
            parentForm.lsbLog.Items.Add("ChildForm_Closed");
        }

        private void ChildForm_Closing(object sender, FormClosingEventArgs e)
        {
            parentForm.lsbLog.Items.Add("ChildForm_Closing");
        }

        private void ChildForm_Shown(object sender, EventArgs e)
        {
            parentForm.lsbLog.Items.Add("ChildForm_Shown");
        }
    }
}
