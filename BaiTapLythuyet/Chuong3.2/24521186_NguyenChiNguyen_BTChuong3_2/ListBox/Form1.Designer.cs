namespace ListBox
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
            this.lsbListBox = new System.Windows.Forms.ListBox();
            this.txbText = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbListBox
            // 
            this.lsbListBox.FormattingEnabled = true;
            this.lsbListBox.ItemHeight = 16;
            this.lsbListBox.Items.AddRange(new object[] {
            "Banana",
            "Apple",
            "Mango",
            "Durian",
            "Strawberry",
            "Guava",
            "Orange",
            "Peach",
            "Blueberry",
            "Cranberry",
            "Grape",
            "Longan",
            "Lychee"});
            this.lsbListBox.Location = new System.Drawing.Point(276, 129);
            this.lsbListBox.MultiColumn = true;
            this.lsbListBox.Name = "lsbListBox";
            this.lsbListBox.Size = new System.Drawing.Size(285, 180);
            this.lsbListBox.TabIndex = 10;
            // 
            // txbText
            // 
            this.txbText.BackColor = System.Drawing.Color.LightGray;
            this.txbText.Location = new System.Drawing.Point(276, 93);
            this.txbText.Name = "txbText";
            this.txbText.Size = new System.Drawing.Size(189, 22);
            this.txbText.TabIndex = 0;
            this.txbText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbText_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAdd.Location = new System.Drawing.Point(483, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbText);
            this.Controls.Add(this.lsbListBox);
            this.Name = "Form1";
            this.Text = "Demo Listbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbListBox;
        private System.Windows.Forms.TextBox txbText;
        private System.Windows.Forms.Button btnAdd;
    }
}

