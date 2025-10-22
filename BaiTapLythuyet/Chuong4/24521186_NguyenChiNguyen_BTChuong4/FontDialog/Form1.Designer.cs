namespace FontDialog
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblTestFontDialog = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTestFontDialog
            // 
            this.lblTestFontDialog.AutoSize = true;
            this.lblTestFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestFontDialog.Location = new System.Drawing.Point(276, 194);
            this.lblTestFontDialog.Name = "lblTestFontDialog";
            this.lblTestFontDialog.Size = new System.Drawing.Size(293, 25);
            this.lblTestFontDialog.TabIndex = 0;
            this.lblTestFontDialog.Text = "24521186 - Nguyen Chi Nguyen";
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFont.Location = new System.Drawing.Point(389, 271);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "FONT";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.lblTestFontDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblTestFontDialog;
        private System.Windows.Forms.Button btnFont;
    }
}

