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
    public partial class SoNguyen : Form
    {
        public SoNguyen()
        {
            InitializeComponent();
        }

        private void SoNguyen_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int res = num1 + num2;
            textBox3.Text = res.ToString();
        }

        private void btnSUB_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int res = num1 - num2;
            textBox3.Text = res.ToString();
        }
    }
}
