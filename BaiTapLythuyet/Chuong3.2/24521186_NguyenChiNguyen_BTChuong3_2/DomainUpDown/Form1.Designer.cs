namespace DomainUpDown
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
            this.DomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DomainUpDown
            // 
            this.DomainUpDown.Items.Add("Apple");
            this.DomainUpDown.Items.Add("Kiwi");
            this.DomainUpDown.Items.Add("Pineapple");
            this.DomainUpDown.Items.Add("Strawberry");
            this.DomainUpDown.Items.Add("Mango");
            this.DomainUpDown.Location = new System.Drawing.Point(251, 187);
            this.DomainUpDown.Name = "DomainUpDown";
            this.DomainUpDown.Size = new System.Drawing.Size(274, 22);
            this.DomainUpDown.TabIndex = 0;
            this.DomainUpDown.Text = "Choose your fruit";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmit.Location = new System.Drawing.Point(342, 240);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.DomainUpDown);
            this.Name = "Form1";
            this.Text = "Domain Up/Down";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown DomainUpDown;
        private System.Windows.Forms.Button btnSubmit;
    }
}

