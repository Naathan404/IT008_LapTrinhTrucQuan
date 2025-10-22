using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tinhTrangHonNhan = "";
            string thuNhap = "";
            if (radChoice1.Checked)
                tinhTrangHonNhan = radChoice1.Text;
            else if (radChoice2.Checked)
                tinhTrangHonNhan = radChoice2.Text;
            else if (radChoice3.Checked)
                tinhTrangHonNhan = radChoice3.Text;
            if (radChoice4.Checked)
                thuNhap = radChoice4.Text;
            else if (radChoice5.Checked)
                thuNhap = radChoice5.Text;
            else if (radChoice6.Checked)
                thuNhap = radChoice6.Text;

            MessageBox.Show("Tình trạng hôn nhân: " + tinhTrangHonNhan + "\nThu nhập một tháng: " + thuNhap, "Thông tin cá nhân");
        }
    }
}
