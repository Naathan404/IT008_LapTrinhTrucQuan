namespace Bai04
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbFont = new System.Windows.Forms.ComboBox();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chbUnderline = new System.Windows.Forms.CheckBox();
            this.chbItalic = new System.Windows.Forms.CheckBox();
            this.grbAlignText = new System.Windows.Forms.GroupBox();
            this.radRight = new System.Windows.Forms.RadioButton();
            this.radCenter = new System.Windows.Forms.RadioButton();
            this.radLeft = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbText = new System.Windows.Forms.TextBox();
            this.chbBold = new System.Windows.Forms.CheckBox();
            this.grbAlignText.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font:";
            // 
            // cbbFont
            // 
            this.cbbFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFont.FormattingEnabled = true;
            this.cbbFont.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbFont.Location = new System.Drawing.Point(100, 47);
            this.cbbFont.Name = "cbbFont";
            this.cbbFont.Size = new System.Drawing.Size(195, 24);
            this.cbbFont.TabIndex = 1;
            this.cbbFont.SelectedIndexChanged += new System.EventHandler(this.FormatChanged);
            // 
            // cbbSize
            // 
            this.cbbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbbSize.Location = new System.Drawing.Point(442, 49);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(83, 24);
            this.cbbSize.TabIndex = 3;
            this.cbbSize.SelectedIndexChanged += new System.EventHandler(this.FormatChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(442, 106);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(41, 37);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color:";
            // 
            // chbUnderline
            // 
            this.chbUnderline.AutoSize = true;
            this.chbUnderline.Image = global::Bai04.Properties.Resources.icons8_underline_30;
            this.chbUnderline.Location = new System.Drawing.Point(247, 109);
            this.chbUnderline.Name = "chbUnderline";
            this.chbUnderline.Size = new System.Drawing.Size(48, 30);
            this.chbUnderline.TabIndex = 8;
            this.chbUnderline.UseVisualStyleBackColor = true;
            this.chbUnderline.CheckedChanged += new System.EventHandler(this.FormatChanged);
            // 
            // chbItalic
            // 
            this.chbItalic.AutoSize = true;
            this.chbItalic.Image = global::Bai04.Properties.Resources.icons8_italic_30;
            this.chbItalic.Location = new System.Drawing.Point(182, 109);
            this.chbItalic.Name = "chbItalic";
            this.chbItalic.Size = new System.Drawing.Size(48, 30);
            this.chbItalic.TabIndex = 7;
            this.chbItalic.UseVisualStyleBackColor = true;
            this.chbItalic.CheckedChanged += new System.EventHandler(this.FormatChanged);
            // 
            // grbAlignText
            // 
            this.grbAlignText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grbAlignText.Controls.Add(this.radRight);
            this.grbAlignText.Controls.Add(this.radCenter);
            this.grbAlignText.Controls.Add(this.radLeft);
            this.grbAlignText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAlignText.Location = new System.Drawing.Point(22, 223);
            this.grbAlignText.Name = "grbAlignText";
            this.grbAlignText.Size = new System.Drawing.Size(128, 204);
            this.grbAlignText.TabIndex = 9;
            this.grbAlignText.TabStop = false;
            this.grbAlignText.Text = "Align Text";
            // 
            // radRight
            // 
            this.radRight.AutoSize = true;
            this.radRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRight.Location = new System.Drawing.Point(6, 131);
            this.radRight.Name = "radRight";
            this.radRight.Size = new System.Drawing.Size(77, 29);
            this.radRight.TabIndex = 2;
            this.radRight.TabStop = true;
            this.radRight.Text = "Right";
            this.radRight.UseVisualStyleBackColor = true;
            this.radRight.CheckedChanged += new System.EventHandler(this.AlignChanged);
            // 
            // radCenter
            // 
            this.radCenter.AutoSize = true;
            this.radCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCenter.Location = new System.Drawing.Point(6, 87);
            this.radCenter.Name = "radCenter";
            this.radCenter.Size = new System.Drawing.Size(92, 29);
            this.radCenter.TabIndex = 1;
            this.radCenter.TabStop = true;
            this.radCenter.Text = "Center";
            this.radCenter.UseVisualStyleBackColor = true;
            this.radCenter.CheckedChanged += new System.EventHandler(this.AlignChanged);
            // 
            // radLeft
            // 
            this.radLeft.AutoSize = true;
            this.radLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLeft.Location = new System.Drawing.Point(6, 43);
            this.radLeft.Name = "radLeft";
            this.radLeft.Size = new System.Drawing.Size(65, 29);
            this.radLeft.TabIndex = 0;
            this.radLeft.TabStop = true;
            this.radLeft.Text = "Left";
            this.radLeft.UseVisualStyleBackColor = true;
            this.radLeft.CheckedChanged += new System.EventHandler(this.AlignChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chbUnderline);
            this.panel1.Controls.Add(this.chbItalic);
            this.panel1.Controls.Add(this.chbBold);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.cbbSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbFont);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 170);
            this.panel1.TabIndex = 10;
            // 
            // txbText
            // 
            this.txbText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbText.Location = new System.Drawing.Point(156, 234);
            this.txbText.Multiline = true;
            this.txbText.Name = "txbText";
            this.txbText.ReadOnly = true;
            this.txbText.Size = new System.Drawing.Size(425, 204);
            this.txbText.TabIndex = 11;
            this.txbText.Text = "Hello";
            // 
            // chbBold
            // 
            this.chbBold.AutoSize = true;
            this.chbBold.Image = global::Bai04.Properties.Resources.icons8_bold_30;
            this.chbBold.Location = new System.Drawing.Point(109, 109);
            this.chbBold.Name = "chbBold";
            this.chbBold.Size = new System.Drawing.Size(48, 30);
            this.chbBold.TabIndex = 6;
            this.chbBold.UseVisualStyleBackColor = true;
            this.chbBold.CheckedChanged += new System.EventHandler(this.FormatChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.txbText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbAlignText);
            this.Name = "Form1";
            this.Text = "Bai 04 - Xử lý font";
            this.grbAlignText.ResumeLayout(false);
            this.grbAlignText.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbFont;
        private System.Windows.Forms.ComboBox cbbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbBold;
        private System.Windows.Forms.CheckBox chbItalic;
        private System.Windows.Forms.CheckBox chbUnderline;
        private System.Windows.Forms.GroupBox grbAlignText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbText;
        private System.Windows.Forms.RadioButton radRight;
        private System.Windows.Forms.RadioButton radCenter;
        private System.Windows.Forms.RadioButton radLeft;
    }
}

