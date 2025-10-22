namespace Label_Textbox_Button
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
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.btnToLower = new System.Windows.Forms.Button();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInstruction.Location = new System.Drawing.Point(318, 143);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(142, 25);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Enter the string";
            // 
            // txtTextBox
            // 
            this.txtTextBox.Location = new System.Drawing.Point(268, 171);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(221, 22);
            this.txtTextBox.TabIndex = 1;
            // 
            // btnToLower
            // 
            this.btnToLower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnToLower.Location = new System.Drawing.Point(268, 211);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(110, 30);
            this.btnToLower.TabIndex = 2;
            this.btnToLower.Text = "Lower";
            this.btnToLower.UseVisualStyleBackColor = false;
            this.btnToLower.Click += new System.EventHandler(this.txtToLower_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnToUpper.Location = new System.Drawing.Point(379, 211);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(110, 30);
            this.btnToUpper.TabIndex = 3;
            this.btnToUpper.Text = "Upper";
            this.btnToUpper.UseVisualStyleBackColor = false;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnQuit.Location = new System.Drawing.Point(323, 247);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(110, 30);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(143, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(538, 39);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "LABEL - TEXTBOX - BUTTON DEMO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnToUpper);
            this.Controls.Add(this.btnToLower);
            this.Controls.Add(this.txtTextBox);
            this.Controls.Add(this.lblInstruction);
            this.Name = "Form1";
            this.Text = "Label_Textbox_Button_Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtTextBox;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTitle;
    }
}

