namespace ComboBox
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
            this.cbbFruitBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbFruitBox
            // 
            this.cbbFruitBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbFruitBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFruitBox.FormattingEnabled = true;
            this.cbbFruitBox.Items.AddRange(new object[] {
            "Apple",
            "Banana",
            "Orange",
            "Grape",
            "Peanut",
            "Starfruit",
            "Blueberry",
            "Strawberry",
            "Coconut",
            "Jackfruit",
            "Durian"});
            this.cbbFruitBox.Location = new System.Drawing.Point(224, 200);
            this.cbbFruitBox.Name = "cbbFruitBox";
            this.cbbFruitBox.Size = new System.Drawing.Size(346, 24);
            this.cbbFruitBox.TabIndex = 0;
            this.cbbFruitBox.SelectedIndexChanged += new System.EventHandler(this.cbbFruitBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppin-Story", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECT A FRUIT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbFruitBox);
            this.Name = "Form1";
            this.Text = "ComboBox Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbFruitBox;
        private System.Windows.Forms.Label label1;
    }
}

