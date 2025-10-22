using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTaiLop
{
    public partial class SoPhuc : Form
    {
        public SoPhuc()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float thuc1 = float.Parse(txbThuc1.Text);
            float thuc2 = float.Parse(txbThuc2.Text);
            float ao1 = float.Parse(txbAo1.Text);
            float ao2 = float.Parse(txbAo2.Text);
            float thuc3 = thuc1 + thuc2;
            float ao3 = ao1 + ao2;
            txbThuc3.Text = thuc3.ToString();
            txbAo3.Text = ao3.ToString();
        }

        private void btnSUB_Click(object sender, EventArgs e)
        {
            float thuc1 = float.Parse(txbThuc1.Text);
            float thuc2 = float.Parse(txbThuc2.Text);
            float ao1 = float.Parse(txbAo1.Text);
            float ao2 = float.Parse(txbAo2.Text);
            float thuc3 = thuc1 - thuc2;
            float ao3 = ao1 - ao2;
            txbThuc3.Text = thuc3.ToString();
            txbAo3.Text = ao3.ToString();
        }

        private void SoPhuc_Load(object sender, EventArgs e)
        {

        }

        private void txbAo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbThuc2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbAo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbThuc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbAo3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbThuc3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
