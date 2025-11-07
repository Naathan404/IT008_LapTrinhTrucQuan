using System;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        private float _num1, _num2;
        public Form1()
        {
            InitializeComponent();
        }
        // Cộng
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckInput())
                txbAnswer.Text = (_num1 + _num2).ToString();
        }
        // Trừ
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (CheckInput())
                txbAnswer.Text = (_num1 - _num2).ToString();
        }
        // Nhân
        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (CheckInput())
                txbAnswer.Text = (_num1 * _num2).ToString("");
        }
        // Chia
        private void btnDevide_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            if(_num2 == 0)
            {
                MessageBox.Show("Không thể chia cho 0!");
                txbNum2.Text = "";
                return;
            }    
            txbAnswer.Text = (_num1 / _num2).ToString("");
        }
        // Kiểm tra điều kiện nhập
        private bool CheckInput()
        {
            if (txbNum1.Text == "" || txbNum2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ cả hai số!");
                return false;
            }
            if (!float.TryParse(txbNum1.Text, out _num1) || !float.TryParse(txbNum2.Text, out _num2))
            {
                MessageBox.Show("Dữ liệu không hợp lệ, vui lòng nhập lại!");
                txbNum1.Text = "";
                txbNum2.Text = "";
                txbAnswer.Text = "";
                return false;
            }
            return true;
        }
    }
}