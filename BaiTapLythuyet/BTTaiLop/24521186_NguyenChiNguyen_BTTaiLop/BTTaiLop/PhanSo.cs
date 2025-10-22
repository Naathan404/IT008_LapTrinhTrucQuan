using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTaiLop
{
    public partial class PhanSo : Form
    {
        public PhanSo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txbTu1.Text);
            int mau1 = int.Parse(txbMau1.Text);
            int tu2 = int.Parse(txbTu2.Text);
            int mau2 = int.Parse(txbMau2.Text);
            if(mau1 == 0 || mau2 == 0)
            {
                MessageBox.Show("Mẫu không hợp lệ!");
                return;
            }
            int tuKetQua = tu1 * mau2 + tu2 * mau1;
            int mauKetQua = mau1 * mau2;
            int ucln = UCLN(Math.Abs(tuKetQua), Math.Abs(mauKetQua));
            tuKetQua /= ucln;
            mauKetQua /= ucln;
            txbTu3.Text = tuKetQua.ToString();
            txbMau3.Text = mauKetQua.ToString();
        }

        private void btnSUB_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(txbTu1.Text);
            int mau1 = int.Parse(txbMau1.Text);
            int tu2 = int.Parse(txbTu2.Text);
            int mau2 = int.Parse(txbMau2.Text);
            if (mau1 == 0 || mau2 == 0)
            {
                MessageBox.Show("Mẫu không hợp lệ!");
                return;
            }
            int tuKetQua = tu1 * mau2 - tu2 * mau1;
            int mauKetQua = mau1 * mau2;
            int ucln = UCLN(Math.Abs(tuKetQua), Math.Abs(mauKetQua));
            tuKetQua /= ucln;
            mauKetQua /= ucln;
            txbTu3.Text = tuKetQua.ToString();
            txbMau3.Text = mauKetQua.ToString();
        }

        private int UCLN(int a, int b)
        {
            if (b == 0) return a;
            return UCLN(b, a % b);
        }

        private void PhanSo_Load(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;*0
                     //cai cua so phan so ten gi

            }
        }
    }
}
