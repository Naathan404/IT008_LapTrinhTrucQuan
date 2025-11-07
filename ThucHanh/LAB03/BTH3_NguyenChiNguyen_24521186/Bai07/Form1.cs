using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai07
{
    public partial class frmCinema : Form
    {
        Color unselectedColor = Color.White;
        Color selectedColor = Color.Blue;
        Color soldColor = Color.Yellow;
        public frmCinema()
        {
            InitializeComponent();
        }

        private void seatButton_Click(object sender, EventArgs e)
        {
            SeatButton selectedButton = (SeatButton)sender;
            if(selectedButton.isSold)
            {
                MessageBox.Show("Vé tại vị trí này đã được bán!");
                return;
            }
            if(selectedButton.isSelected)
            {
                selectedButton.BackColor = unselectedColor;
                selectedButton.isSelected = false;
            }
            else
            {
                selectedButton.BackColor = selectedColor;
                selectedButton.isSelected = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach(var seat in seatButtons)
            {
                if(seat.isSelected)
                {
                    seat.isSelected = false;
                    seat.isSold = true;
                    seat.BackColor = soldColor;
                    total += seat.price;
                }
            }
            txbTotal.Text = total.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach(var seat in seatButtons)
            {
                if(seat.isSelected)
                {
                    seat.isSelected = false;
                    seat.BackColor = unselectedColor;
                }
            }
            txbTotal.Text = "0";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class SeatButton : Button
    {
        public bool isSold {  get; set; }
        public bool isSelected { get; set; }
        public int price { get; set; }
        public SeatButton()
        {
            isSold = false;
            isSelected = false;
        }
    }
}
