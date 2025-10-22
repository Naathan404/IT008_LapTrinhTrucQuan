namespace TabControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tbcTabCtrl1 = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txbAnswer = new System.Windows.Forms.TextBox();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tbcTabCtrl1.SuspendLayout();
            this.General.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcTabCtrl1
            // 
            this.tbcTabCtrl1.Controls.Add(this.General);
            this.tbcTabCtrl1.Controls.Add(this.tabPage2);
            this.tbcTabCtrl1.Controls.Add(this.tabPage1);
            this.tbcTabCtrl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcTabCtrl1.Location = new System.Drawing.Point(204, 77);
            this.tbcTabCtrl1.Name = "tbcTabCtrl1";
            this.tbcTabCtrl1.SelectedIndex = 0;
            this.tbcTabCtrl1.Size = new System.Drawing.Size(365, 257);
            this.tbcTabCtrl1.TabIndex = 0;
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.General.CausesValidation = false;
            this.General.Controls.Add(this.label1);
            this.General.Location = new System.Drawing.Point(4, 29);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(3);
            this.General.Size = new System.Drawing.Size(357, 224);
            this.General.TabIndex = 0;
            this.General.Text = "General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppin-Story", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAB CONTROL DEMO";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnDivide);
            this.tabPage2.Controls.Add(this.btnMultiple);
            this.tabPage2.Controls.Add(this.btnSubtract);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.lblNum2);
            this.tabPage2.Controls.Add(this.lblNum1);
            this.tabPage2.Controls.Add(this.txbAnswer);
            this.tabPage2.Controls.Add(this.txbNum2);
            this.tabPage2.Controls.Add(this.txbNum1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(357, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculator";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Salmon;
            this.btnClear.Location = new System.Drawing.Point(258, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(37, 37);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(215, 135);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(37, 37);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(172, 135);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(37, 37);
            this.btnMultiple.TabIndex = 7;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(129, 135);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(37, 37);
            this.btnSubtract.TabIndex = 6;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(86, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(35, 83);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(69, 20);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Num 2:";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(35, 35);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(69, 20);
            this.lblNum1.TabIndex = 3;
            this.lblNum1.Text = "Num 1:";
            // 
            // txbAnswer
            // 
            this.txbAnswer.Location = new System.Drawing.Point(215, 57);
            this.txbAnswer.Name = "txbAnswer";
            this.txbAnswer.Size = new System.Drawing.Size(99, 27);
            this.txbAnswer.TabIndex = 2;
            // 
            // txbNum2
            // 
            this.txbNum2.Location = new System.Drawing.Point(110, 80);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(99, 27);
            this.txbNum2.TabIndex = 1;
            // 
            // txbNum1
            // 
            this.txbNum1.Location = new System.Drawing.Point(110, 32);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(99, 27);
            this.txbNum1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.btnQuit);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(357, 224);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Setting";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Crimson;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.No;
            this.btnQuit.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuit.Location = new System.Drawing.Point(123, 90);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(124, 36);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcTabCtrl1);
            this.Name = "Form1";
            this.Text = "TabControl Demo";
            this.tbcTabCtrl1.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTabCtrl1;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txbAnswer;
        private System.Windows.Forms.TextBox txbNum2;
        private System.Windows.Forms.TextBox txbNum1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}

