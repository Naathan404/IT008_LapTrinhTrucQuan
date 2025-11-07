using System.Collections.Generic;

namespace Bai07
{
    partial class frmCinema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<SeatButton> seatButtons = new List<SeatButton>();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn15 = new Bai07.SeatButton();
            this.btn14 = new Bai07.SeatButton();
            this.btn13 = new Bai07.SeatButton();
            this.btn12 = new Bai07.SeatButton();
            this.btn11 = new Bai07.SeatButton();
            this.btn10 = new Bai07.SeatButton();
            this.btn9 = new Bai07.SeatButton();
            this.btn8 = new Bai07.SeatButton();
            this.btn7 = new Bai07.SeatButton();
            this.btn6 = new Bai07.SeatButton();
            this.btn5 = new Bai07.SeatButton();
            this.btn4 = new Bai07.SeatButton();
            this.btn3 = new Bai07.SeatButton();
            this.btn2 = new Bai07.SeatButton();
            this.btn1 = new Bai07.SeatButton();
            this.lblScreen = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFinish = new Bai07.SeatButton();
            this.btnCancel = new Bai07.SeatButton();
            this.btnSelect = new Bai07.SeatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            seatButtons.Add(btn1);
            seatButtons.Add(btn2);
            seatButtons.Add(btn3);
            seatButtons.Add(btn4);
            seatButtons.Add(btn5);
            seatButtons.Add(btn6);
            seatButtons.Add(btn7);
            seatButtons.Add(btn8);
            seatButtons.Add(btn9);
            seatButtons.Add(btn10);
            seatButtons.Add(btn11);
            seatButtons.Add(btn12);
            seatButtons.Add(btn13);
            seatButtons.Add(btn14);
            seatButtons.Add(btn15);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn15);
            this.panel1.Controls.Add(this.btn14);
            this.panel1.Controls.Add(this.btn13);
            this.panel1.Controls.Add(this.btn12);
            this.panel1.Controls.Add(this.btn11);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Location = new System.Drawing.Point(114, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 289);
            this.panel1.TabIndex = 0;
            // 
            // btn15
            // 
            this.btn15.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15.isSelected = false;
            this.btn15.isSold = false;
            this.btn15.Location = new System.Drawing.Point(458, 198);
            this.btn15.Name = "btn15";
            this.btn15.price = 8000;
            this.btn15.Size = new System.Drawing.Size(100, 75);
            this.btn15.TabIndex = 14;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn14
            // 
            this.btn14.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14.isSelected = false;
            this.btn14.isSold = false;
            this.btn14.Location = new System.Drawing.Point(349, 198);
            this.btn14.Name = "btn14";
            this.btn14.price = 8000;
            this.btn14.Size = new System.Drawing.Size(100, 75);
            this.btn14.TabIndex = 13;
            this.btn14.Text = "14";
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn13
            // 
            this.btn13.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.isSelected = false;
            this.btn13.isSold = false;
            this.btn13.Location = new System.Drawing.Point(239, 198);
            this.btn13.Name = "btn13";
            this.btn13.price = 8000;
            this.btn13.Size = new System.Drawing.Size(100, 75);
            this.btn13.TabIndex = 12;
            this.btn13.Text = "13";
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn12
            // 
            this.btn12.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.isSelected = false;
            this.btn12.isSold = false;
            this.btn12.Location = new System.Drawing.Point(127, 198);
            this.btn12.Name = "btn12";
            this.btn12.price = 8000;
            this.btn12.Size = new System.Drawing.Size(100, 75);
            this.btn12.TabIndex = 11;
            this.btn12.Text = "12";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn11
            // 
            this.btn11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.isSelected = false;
            this.btn11.isSold = false;
            this.btn11.Location = new System.Drawing.Point(15, 198);
            this.btn11.Name = "btn11";
            this.btn11.price = 8000;
            this.btn11.Size = new System.Drawing.Size(100, 75);
            this.btn11.TabIndex = 10;
            this.btn11.Text = "11";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.isSelected = false;
            this.btn10.isSold = false;
            this.btn10.Location = new System.Drawing.Point(458, 110);
            this.btn10.Name = "btn10";
            this.btn10.price = 6500;
            this.btn10.Size = new System.Drawing.Size(100, 75);
            this.btn10.TabIndex = 9;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.isSelected = false;
            this.btn9.isSold = false;
            this.btn9.Location = new System.Drawing.Point(349, 110);
            this.btn9.Name = "btn9";
            this.btn9.price = 6500;
            this.btn9.Size = new System.Drawing.Size(100, 75);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.isSelected = false;
            this.btn8.isSold = false;
            this.btn8.Location = new System.Drawing.Point(239, 110);
            this.btn8.Name = "btn8";
            this.btn8.price = 6500;
            this.btn8.Size = new System.Drawing.Size(100, 75);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.isSelected = false;
            this.btn7.isSold = false;
            this.btn7.Location = new System.Drawing.Point(127, 110);
            this.btn7.Name = "btn7";
            this.btn7.price = 6500;
            this.btn7.Size = new System.Drawing.Size(100, 75);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.isSelected = false;
            this.btn6.isSold = false;
            this.btn6.Location = new System.Drawing.Point(15, 110);
            this.btn6.Name = "btn6";
            this.btn6.price = 6500;
            this.btn6.Size = new System.Drawing.Size(100, 75);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.isSelected = false;
            this.btn5.isSold = false;
            this.btn5.Location = new System.Drawing.Point(457, 20);
            this.btn5.Name = "btn5";
            this.btn5.price = 5000;
            this.btn5.Size = new System.Drawing.Size(100, 75);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.isSelected = false;
            this.btn4.isSold = false;
            this.btn4.Location = new System.Drawing.Point(348, 20);
            this.btn4.Name = "btn4";
            this.btn4.price = 5000;
            this.btn4.Size = new System.Drawing.Size(100, 75);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.isSelected = false;
            this.btn3.isSold = false;
            this.btn3.Location = new System.Drawing.Point(238, 20);
            this.btn3.Name = "btn3";
            this.btn3.price = 5000;
            this.btn3.Size = new System.Drawing.Size(100, 75);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.isSelected = false;
            this.btn2.isSold = false;
            this.btn2.Location = new System.Drawing.Point(126, 20);
            this.btn2.Name = "btn2";
            this.btn2.price = 5000;
            this.btn2.Size = new System.Drawing.Size(100, 75);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.isSelected = false;
            this.btn1.isSold = false;
            this.btn1.Location = new System.Drawing.Point(14, 20);
            this.btn1.Name = "btn1";
            this.btn1.price = 5000;
            this.btn1.Size = new System.Drawing.Size(100, 75);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.seatButton_Click);
            // 
            // lblScreen
            // 
            this.lblScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScreen.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblScreen.Location = new System.Drawing.Point(12, 3);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(776, 67);
            this.lblScreen.TabIndex = 2;
            this.lblScreen.Text = "MÀN ẢNH";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(124, 445);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(127, 28);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "THÀNH TIỀN:";
            // 
            // txbTotal
            // 
            this.txbTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(278, 442);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(394, 34);
            this.txbTotal.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnFinish);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Location = new System.Drawing.Point(201, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 69);
            this.panel2.TabIndex = 8;
            // 
            // btnFinish
            // 
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.isSelected = false;
            this.btnFinish.isSold = false;
            this.btnFinish.Location = new System.Drawing.Point(266, 19);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.price = 0;
            this.btnFinish.Size = new System.Drawing.Size(119, 42);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Kết thúc";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.isSelected = false;
            this.btnCancel.isSold = false;
            this.btnCancel.Location = new System.Drawing.Point(141, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.price = 0;
            this.btnCancel.Size = new System.Drawing.Size(119, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.isSelected = false;
            this.btnSelect.isSold = false;
            this.btnSelect.Location = new System.Drawing.Point(16, 19);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.price = 0;
            this.btnSelect.Size = new System.Drawing.Size(119, 42);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCinema";
            this.Text = "BÁN VÉ RẠP CHIẾU BÓNG";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScreen;
        private Bai07.SeatButton btn1;
        private Bai07.SeatButton btn15;
        private Bai07.SeatButton btn14;
        private Bai07.SeatButton btn13;
        private Bai07.SeatButton btn12;
        private Bai07.SeatButton btn11;
        private Bai07.SeatButton btn10;
        private Bai07.SeatButton btn9;
        private Bai07.SeatButton btn8;
        private Bai07.SeatButton btn7;
        private Bai07.SeatButton btn6;
        private Bai07.SeatButton btn5;
        private Bai07.SeatButton btn4;
        private Bai07.SeatButton btn3;
        private Bai07.SeatButton btn2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txbTotal;
        private Bai07.SeatButton btnSelect;
        private Bai07.SeatButton btnCancel;
        private Bai07.SeatButton btnFinish;
        private System.Windows.Forms.Panel panel2;
    }
}