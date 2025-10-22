namespace CheckedListBox
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
            this.CheckListBox1 = new System.Windows.Forms.CheckedListBox();
            this.CheckListBox2 = new System.Windows.Forms.CheckedListBox();
            this.btnCount1 = new System.Windows.Forms.Button();
            this.btnCount2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckListBox1
            // 
            this.CheckListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckListBox1.FormattingEnabled = true;
            this.CheckListBox1.Items.AddRange(new object[] {
            "Apple",
            "Orange",
            "Kiwi",
            "Strawberry",
            "Mango",
            "Salmonberry",
            "Pineapple",
            "Guava",
            "Banana",
            "Coconut",
            "Papaya",
            "Dragonfruit"});
            this.CheckListBox1.Location = new System.Drawing.Point(102, 85);
            this.CheckListBox1.Name = "CheckListBox1";
            this.CheckListBox1.Size = new System.Drawing.Size(226, 246);
            this.CheckListBox1.TabIndex = 0;
            // 
            // CheckListBox2
            // 
            this.CheckListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckListBox2.FormattingEnabled = true;
            this.CheckListBox2.Items.AddRange(new object[] {
            "Apple",
            "Orange",
            "Kiwi",
            "Strawberry",
            "Mango",
            "Salmonberry",
            "Pineapple",
            "Guava",
            "Banana",
            "Coconut",
            "Papaya",
            "Dragonfruit"});
            this.CheckListBox2.Location = new System.Drawing.Point(432, 85);
            this.CheckListBox2.MultiColumn = true;
            this.CheckListBox2.Name = "CheckListBox2";
            this.CheckListBox2.Size = new System.Drawing.Size(287, 246);
            this.CheckListBox2.TabIndex = 1;
            // 
            // btnCount1
            // 
            this.btnCount1.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCount1.Location = new System.Drawing.Point(146, 364);
            this.btnCount1.Name = "btnCount1";
            this.btnCount1.Size = new System.Drawing.Size(141, 33);
            this.btnCount1.TabIndex = 3;
            this.btnCount1.Text = "COUNT";
            this.btnCount1.UseVisualStyleBackColor = false;
            this.btnCount1.Click += new System.EventHandler(this.btnCount1_Click);
            // 
            // btnCount2
            // 
            this.btnCount2.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCount2.Location = new System.Drawing.Point(510, 364);
            this.btnCount2.Name = "btnCount2";
            this.btnCount2.Size = new System.Drawing.Size(141, 33);
            this.btnCount2.TabIndex = 4;
            this.btnCount2.Text = "COUNT";
            this.btnCount2.UseVisualStyleBackColor = false;
            this.btnCount2.Click += new System.EventHandler(this.btnCount2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCount2);
            this.Controls.Add(this.btnCount1);
            this.Controls.Add(this.CheckListBox2);
            this.Controls.Add(this.CheckListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckListBox1;
        private System.Windows.Forms.CheckedListBox CheckListBox2;
        private System.Windows.Forms.Button btnCount1;
        private System.Windows.Forms.Button btnCount2;
    }
}

