namespace Bai11
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
            this.contentBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rabLinearGradientBRush = new System.Windows.Forms.RadioButton();
            this.rabTextureBrush = new System.Windows.Forms.RadioButton();
            this.rabHatchBrush = new System.Windows.Forms.RadioButton();
            this.rabSolidBrush = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbWidth = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rabEllipse = new System.Windows.Forms.RadioButton();
            this.rabRectangle = new System.Windows.Forms.RadioButton();
            this.rabLine = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.contentBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentBox
            // 
            this.contentBox.BackColor = System.Drawing.Color.White;
            this.contentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentBox.Location = new System.Drawing.Point(0, 0);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(800, 450);
            this.contentBox.TabIndex = 1;
            this.contentBox.TabStop = false;
            this.contentBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.contentBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 450);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.rabLinearGradientBRush);
            this.groupBox3.Controls.Add(this.rabTextureBrush);
            this.groupBox3.Controls.Add(this.rabHatchBrush);
            this.groupBox3.Controls.Add(this.rabSolidBrush);
            this.groupBox3.Location = new System.Drawing.Point(8, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 159);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // rabLinearGradientBRush
            // 
            this.rabLinearGradientBRush.AutoSize = true;
            this.rabLinearGradientBRush.Location = new System.Drawing.Point(6, 124);
            this.rabLinearGradientBRush.Name = "rabLinearGradientBRush";
            this.rabLinearGradientBRush.Size = new System.Drawing.Size(150, 20);
            this.rabLinearGradientBRush.TabIndex = 3;
            this.rabLinearGradientBRush.TabStop = true;
            this.rabLinearGradientBRush.Text = "LinearGradientBrush";
            this.rabLinearGradientBRush.UseVisualStyleBackColor = true;
            this.rabLinearGradientBRush.CheckedChanged += new System.EventHandler(this.BrushChanged);
            // 
            // rabTextureBrush
            // 
            this.rabTextureBrush.AutoSize = true;
            this.rabTextureBrush.Location = new System.Drawing.Point(6, 92);
            this.rabTextureBrush.Name = "rabTextureBrush";
            this.rabTextureBrush.Size = new System.Drawing.Size(107, 20);
            this.rabTextureBrush.TabIndex = 2;
            this.rabTextureBrush.TabStop = true;
            this.rabTextureBrush.Text = "TextureBrush";
            this.rabTextureBrush.UseVisualStyleBackColor = true;
            this.rabTextureBrush.CheckedChanged += new System.EventHandler(this.BrushChanged);
            // 
            // rabHatchBrush
            // 
            this.rabHatchBrush.AutoSize = true;
            this.rabHatchBrush.Location = new System.Drawing.Point(6, 60);
            this.rabHatchBrush.Name = "rabHatchBrush";
            this.rabHatchBrush.Size = new System.Drawing.Size(97, 20);
            this.rabHatchBrush.TabIndex = 1;
            this.rabHatchBrush.TabStop = true;
            this.rabHatchBrush.Text = "HatchBrush";
            this.rabHatchBrush.UseVisualStyleBackColor = true;
            this.rabHatchBrush.CheckedChanged += new System.EventHandler(this.BrushChanged);
            // 
            // rabSolidBrush
            // 
            this.rabSolidBrush.AutoSize = true;
            this.rabSolidBrush.Location = new System.Drawing.Point(6, 30);
            this.rabSolidBrush.Name = "rabSolidBrush";
            this.rabSolidBrush.Size = new System.Drawing.Size(93, 20);
            this.rabSolidBrush.TabIndex = 0;
            this.rabSolidBrush.TabStop = true;
            this.rabSolidBrush.Text = "SolidBrush";
            this.rabSolidBrush.UseVisualStyleBackColor = true;
            this.rabSolidBrush.CheckedChanged += new System.EventHandler(this.BrushChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbbWidth);
            this.groupBox2.Location = new System.Drawing.Point(8, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor.Location = new System.Drawing.Point(71, 69);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(84, 22);
            this.btnColor.TabIndex = 2;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            // 
            // cbbWidth
            // 
            this.cbbWidth.FormattingEnabled = true;
            this.cbbWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbWidth.Location = new System.Drawing.Point(71, 30);
            this.cbbWidth.Name = "cbbWidth";
            this.cbbWidth.Size = new System.Drawing.Size(84, 24);
            this.cbbWidth.TabIndex = 0;
            this.cbbWidth.SelectedIndexChanged += new System.EventHandler(this.cbbWidth_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rabEllipse);
            this.groupBox1.Controls.Add(this.rabRectangle);
            this.groupBox1.Controls.Add(this.rabLine);
            this.groupBox1.Location = new System.Drawing.Point(8, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rabEllipse
            // 
            this.rabEllipse.AutoSize = true;
            this.rabEllipse.Location = new System.Drawing.Point(6, 83);
            this.rabEllipse.Name = "rabEllipse";
            this.rabEllipse.Size = new System.Drawing.Size(69, 20);
            this.rabEllipse.TabIndex = 2;
            this.rabEllipse.TabStop = true;
            this.rabEllipse.Text = "Ellipse";
            this.rabEllipse.UseVisualStyleBackColor = true;
            // 
            // rabRectangle
            // 
            this.rabRectangle.AutoSize = true;
            this.rabRectangle.Location = new System.Drawing.Point(6, 57);
            this.rabRectangle.Name = "rabRectangle";
            this.rabRectangle.Size = new System.Drawing.Size(90, 20);
            this.rabRectangle.TabIndex = 1;
            this.rabRectangle.TabStop = true;
            this.rabRectangle.Text = "Rectangle";
            this.rabRectangle.UseVisualStyleBackColor = true;
            // 
            // rabLine
            // 
            this.rabLine.AutoSize = true;
            this.rabLine.Location = new System.Drawing.Point(6, 31);
            this.rabLine.Name = "rabLine";
            this.rabLine.Size = new System.Drawing.Size(53, 20);
            this.rabLine.TabIndex = 0;
            this.rabLine.TabStop = true;
            this.rabLine.Text = "Line";
            this.rabLine.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contentBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.contentBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox contentBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rabEllipse;
        private System.Windows.Forms.RadioButton rabRectangle;
        private System.Windows.Forms.RadioButton rabLine;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rabLinearGradientBRush;
        private System.Windows.Forms.RadioButton rabTextureBrush;
        private System.Windows.Forms.RadioButton rabHatchBrush;
        private System.Windows.Forms.RadioButton rabSolidBrush;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbWidth;
    }
}
