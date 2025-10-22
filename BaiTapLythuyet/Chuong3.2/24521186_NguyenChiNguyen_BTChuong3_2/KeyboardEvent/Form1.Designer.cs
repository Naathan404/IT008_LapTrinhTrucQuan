namespace KeyboardEvent
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
            this.lblChar = new System.Windows.Forms.Label();
            this.lblKeyInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChar.ForeColor = System.Drawing.Color.Blue;
            this.lblChar.Location = new System.Drawing.Point(123, 100);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(146, 25);
            this.lblChar.TabIndex = 0;
            this.lblChar.Text = "Key pressed: ";
            // 
            // lblKeyInfo
            // 
            this.lblKeyInfo.AutoSize = true;
            this.lblKeyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblKeyInfo.Location = new System.Drawing.Point(123, 177);
            this.lblKeyInfo.Name = "lblKeyInfo";
            this.lblKeyInfo.Size = new System.Drawing.Size(108, 25);
            this.lblKeyInfo.TabIndex = 1;
            this.lblKeyInfo.Text = "lblKeyInfo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKeyInfo);
            this.Controls.Add(this.lblChar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvt);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvt);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label lblKeyInfo;
    }
}

