using System;
using System.Data;
using System.Windows.Forms;

namespace Bai06
{
    public partial class frmCaculator : Form
    {
        char? pendingOperator = null;
        string firstOperand = "";
        string secondOperand = "";
        int? secondOperandFirstIndex = null;
        bool isTypingFirstOperand = true;
        float? memory = null;
        public frmCaculator()
        {
            InitializeComponent();
        }

        // NUMBER BUTTONS 
        private void numberButton_Click(object sender, EventArgs e)
        {
            FirstClick();
            Button clickedButton = (Button)sender;
            char c;
            int value = (int)clickedButton.Tag;
            switch (value)
            {
                case 1:
                    c = '1';
                    break;
                case 2:
                    c = '2';
                    break;
                case 3:
                    c = '3';
                    break;
                case 4:
                    c = '4';
                    break;
                case 5:
                    c = '5';
                    break;
                case 6:
                    c = '6';
                    break;
                case 7:
                    c = '7';
                    break;
                case 8:
                    c = '8';
                    break;
                case 9:
                    c = '9';
                    break;
                default:
                    c = '0';
                    break;
            }
            txbMainTextbox.Text += c;
            AddNumberToOperand(c);
        }


        // OPERATOR BUTTONS //
        #region Operator buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstClick();
            txbMainTextbox.Text += "+";
            pendingOperator = '+';
            HandleOperand();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            FirstClick();
            txbMainTextbox.Text += "-";
            pendingOperator = '-';
            HandleOperand();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            FirstClick();
            txbMainTextbox.Text += "*";
            pendingOperator = '*';
            HandleOperand();
        }

        private void btnDevision_Click(object sender, EventArgs e)
        {
            FirstClick();
            txbMainTextbox.Text += "/";
            pendingOperator = '/';
            HandleOperand();
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double res = Math.Sqrt(double.Parse(txbMainTextbox.Text));
                txbMainTextbox.Text = FormatResult(res);
                firstOperand = txbMainTextbox.Text;
                secondOperand = "";
                pendingOperator = null;
                secondOperandFirstIndex = null;
                isTypingFirstOperand = true;
            }
            catch
            {
                MessageBox.Show("Phép tính không hợp lệ!");
            }
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (firstOperand == "" || secondOperand == "")
                return;
            txbMainTextbox.Text = txbMainTextbox.Text.Remove((int)secondOperandFirstIndex);
            double num = 0;
            if(pendingOperator == '+' || pendingOperator == '-')
            {
                num = (double.Parse(secondOperand) / 100f) * double.Parse(firstOperand);
            }
            else if (pendingOperator == '*' || pendingOperator == '/')
            {
                num = double.Parse(secondOperand) / 100f;
            }
            txbMainTextbox.Text += num.ToString(); 
        }

        private void btnDevideByX_Click(object sender, EventArgs e)
        {
            try
            {
                if(txbMainTextbox.Text == "0")
                {
                    MessageBox.Show("Phép tính không hợp lệ!");
                    return;
                }
                double res = 1f / double.Parse(txbMainTextbox.Text);
                txbMainTextbox.Text = FormatResult(res);
                firstOperand = txbMainTextbox.Text;
                secondOperand = "";
                pendingOperator = null;
                secondOperandFirstIndex = null;
                isTypingFirstOperand = true;
            }
            catch
            {
                MessageBox.Show("Phép tính không hợp lệ!");
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            FirstClick();
            txbMainTextbox.Text += ".";
            AddNumberToOperand('.');
        }

        private void btnAddSubtract_Click(object sender, EventArgs e)
        {
            if(secondOperand == "")
            { 
                float temp = float.Parse(firstOperand);
                temp *= -1;
                string revNum = temp.ToString();
                
                btnCE_Click(sender, e);
                txbMainTextbox.Text = "";
                txbMainTextbox.Text += revNum;
                firstOperand = revNum;
            }
            else
            {
                float temp = float.Parse(secondOperand);
                temp *= -1;
                string revNum = temp.ToString();

                btnCE_Click(sender, e);
                txbMainTextbox.Text += revNum;
                secondOperand = revNum;
            }

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                object res = dt.Compute(txbMainTextbox.Text, "");
                txbMainTextbox.Text = FormatResult(res);
                firstOperand = txbMainTextbox.Text;
                secondOperand = "";
                pendingOperator = null;
                secondOperandFirstIndex = null;
                isTypingFirstOperand = true;
            }
            catch
            {
                MessageBox.Show("Phép tính không hợp lệ!");
                txbMainTextbox.Text = "0";
            }
            
        }
        #endregion

        // Kiem tra neu la ky tu dau tien duoc an
        private void FirstClick()
        {
            if(txbMainTextbox.Text == "0")
            {
                txbMainTextbox.Text = "";
            }
        }
        private void AddNumberToOperand(char c)
        {
            if (isTypingFirstOperand)
            {
                firstOperand += c;
            }
            else
            {
                secondOperand += c;
            }
        }
        private void HandleOperand()
        {
            if (secondOperand == "")    //Typing the second operand
            {
                isTypingFirstOperand = false;
            }
            else    //Handle when user typing more than two operands 
            {
                firstOperand = secondOperand;
                secondOperand = "";
            }
            secondOperandFirstIndex = txbMainTextbox.Text.Length;
        }

        private string FormatResult(object res)
        {
            decimal decimalResult = Convert.ToDecimal(res);
            return decimalResult.ToString("G29");
        }

        // FUNCTION BUTTONS
        #region Function buttons
        private void btnC_Click(object sender, EventArgs e)
        {
            txbMainTextbox.Text = "0";
            firstOperand = secondOperand = "";
            secondOperandFirstIndex = null;
            pendingOperator = null;
            isTypingFirstOperand = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (isTypingFirstOperand)
            {
                btnC_Click(sender, e);
            }
            else
            {
                secondOperand = "";
                if (secondOperandFirstIndex.HasValue)
                {
                    txbMainTextbox.Text = txbMainTextbox.Text.Substring(0, secondOperandFirstIndex.Value);
                }
                else
                {
                    btnC_Click(sender, e);
                }
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txbMainTextbox.Text == "0")
                return;

            if (txbMainTextbox.Text.Length == 1)
            {
                txbMainTextbox.Text = "0";
                firstOperand = "";
                isTypingFirstOperand = true;
                return;
            }

            // Save the last char to showing what char to be removed
            char lastChar = txbMainTextbox.Text[txbMainTextbox.Text.Length - 1];

            txbMainTextbox.Text = txbMainTextbox.Text.Remove(txbMainTextbox.Text.Length - 1);
            if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
            {
                pendingOperator = null;         
                isTypingFirstOperand = true;    
                secondOperandFirstIndex = null;       
            }
            else if (isTypingFirstOperand)
            {
                if (firstOperand.Length > 0)
                {
                    firstOperand = firstOperand.Remove(firstOperand.Length - 1);
                }
            }
            else
            {
                if (secondOperand.Length > 0)
                {
                    secondOperand = secondOperand.Remove(secondOperand.Length - 1);
                }
            }
        }
        private void btnMS_Click(object sender, EventArgs e)
        {
            if(float.TryParse(txbMainTextbox.Text, out float value))
            {
                memory = value;
                txbSubTextbox.Text = value.ToString();
            }
            else
            {
                MessageBox.Show("Lưu vào bộ nhớ thất bại!");
            }
        }


        #endregion

        private void btnMR_Click(object sender, EventArgs e)
        {
            if(memory == null)
                return;
            txbMainTextbox.Text = memory.ToString();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            if(memory == null) return;
            txbSubTextbox.Text = null;
            memory = null;
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            if(memory == null) return;
            txbMainTextbox.Text += "+" + memory.ToString();
            btnEqual_Click(sender, e);
        }
    }
}