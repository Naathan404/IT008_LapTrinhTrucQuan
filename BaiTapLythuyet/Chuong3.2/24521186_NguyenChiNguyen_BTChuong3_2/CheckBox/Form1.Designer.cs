namespace ECheckBox
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
            this.chbApple = new System.Windows.Forms.CheckBox();
            this.chbBanana = new System.Windows.Forms.CheckBox();
            this.chbOrange = new System.Windows.Forms.CheckBox();
            this.chbKiwi = new System.Windows.Forms.CheckBox();
            this.chbStrawberry = new System.Windows.Forms.CheckBox();
            this.lblNotify = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSelectedFruit = new System.Windows.Forms.Label();
            this.SuspendLayout();

            FruitList.Add(chbApple);
            FruitList.Add(chbBanana);
            FruitList.Add(chbOrange);
            FruitList.Add(chbKiwi);
            FruitList.Add(chbStrawberry);
            // 
            // chbApple
            // 
            this.chbApple.AutoSize = true;
            this.chbApple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbApple.Location = new System.Drawing.Point(205, 137);
            this.chbApple.Name = "chbApple";
            this.chbApple.Size = new System.Drawing.Size(85, 29);
            this.chbApple.TabIndex = 0;
            this.chbApple.Text = "Apple";
            this.chbApple.UseVisualStyleBackColor = true;
            // 
            // chbBanana
            // 
            this.chbBanana.AutoSize = true;
            this.chbBanana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBanana.Location = new System.Drawing.Point(205, 172);
            this.chbBanana.Name = "chbBanana";
            this.chbBanana.Size = new System.Drawing.Size(102, 29);
            this.chbBanana.TabIndex = 1;
            this.chbBanana.Text = "Banana";
            this.chbBanana.UseVisualStyleBackColor = true;
            // 
            // chbOrange
            // 
            this.chbOrange.AutoSize = true;
            this.chbOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOrange.Location = new System.Drawing.Point(205, 206);
            this.chbOrange.Name = "chbOrange";
            this.chbOrange.Size = new System.Drawing.Size(100, 29);
            this.chbOrange.TabIndex = 2;
            this.chbOrange.Text = "Orange";
            this.chbOrange.UseVisualStyleBackColor = true;
            // 
            // chbKiwi
            // 
            this.chbKiwi.AutoSize = true;
            this.chbKiwi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbKiwi.Location = new System.Drawing.Point(205, 241);
            this.chbKiwi.Name = "chbKiwi";
            this.chbKiwi.Size = new System.Drawing.Size(70, 29);
            this.chbKiwi.TabIndex = 3;
            this.chbKiwi.Text = "Kiwi";
            this.chbKiwi.UseVisualStyleBackColor = true;
            // 
            // chbStrawberry
            // 
            this.chbStrawberry.AutoSize = true;
            this.chbStrawberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbStrawberry.Location = new System.Drawing.Point(205, 276);
            this.chbStrawberry.Name = "chbStrawberry";
            this.chbStrawberry.Size = new System.Drawing.Size(128, 29);
            this.chbStrawberry.TabIndex = 4;
            this.chbStrawberry.Text = "Strawberry";
            this.chbStrawberry.UseVisualStyleBackColor = true;
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.Location = new System.Drawing.Point(242, 58);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(316, 34);
            this.lblNotify.TabIndex = 5;
            this.lblNotify.Text = "CHOOSE THE FRUITS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSelectedFruit
            // 
            this.lblSelectedFruit.AutoSize = true;
            this.lblSelectedFruit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFruit.ForeColor = System.Drawing.Color.Maroon;
            this.lblSelectedFruit.Location = new System.Drawing.Point(409, 140);
            this.lblSelectedFruit.Name = "lblSelectedFruit";
            this.lblSelectedFruit.Size = new System.Drawing.Size(167, 23);
            this.lblSelectedFruit.TabIndex = 7;
            this.lblSelectedFruit.Text = "You have selected: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectedFruit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNotify);
            this.Controls.Add(this.chbStrawberry);
            this.Controls.Add(this.chbKiwi);
            this.Controls.Add(this.chbOrange);
            this.Controls.Add(this.chbBanana);
            this.Controls.Add(this.chbApple);
            this.Name = "Form1";
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbApple;
        private System.Windows.Forms.CheckBox chbBanana;
        private System.Windows.Forms.CheckBox chbOrange;
        private System.Windows.Forms.CheckBox chbKiwi;
        private System.Windows.Forms.CheckBox chbStrawberry;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSelectedFruit;
    }
}

