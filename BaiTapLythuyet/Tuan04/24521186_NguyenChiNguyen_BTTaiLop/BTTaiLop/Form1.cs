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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void soNguyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoNguyen soNguyen = new SoNguyen();
            soNguyen.MdiParent = this;
            soNguyen.Show();
        }

        private void soPhucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoPhuc soPhuc = new SoPhuc();
            soPhuc.MdiParent = this;
            soPhuc.Show();
        }

        private void phanSoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanSo phanSo = new PhanSo();
            phanSo.MdiParent = this;
            phanSo.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
