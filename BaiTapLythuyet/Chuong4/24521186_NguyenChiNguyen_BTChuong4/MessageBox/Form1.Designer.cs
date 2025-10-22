namespace MessageBoxx
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInfo.Location = new System.Drawing.Point(276, 168);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(90, 23);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.Red;
            this.btnError.Location = new System.Drawing.Point(430, 168);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(89, 23);
            this.btnError.TabIndex = 1;
            this.btnError.Text = "Error";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.BackColor = System.Drawing.Color.Orange;
            this.btnWarning.Location = new System.Drawing.Point(276, 230);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(90, 27);
            this.btnWarning.TabIndex = 2;
            this.btnWarning.Text = "Warning";
            this.btnWarning.UseVisualStyleBackColor = false;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.BackColor = System.Drawing.Color.Lime;
            this.btnQuestion.Location = new System.Drawing.Point(430, 230);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(89, 27);
            this.btnQuestion.TabIndex = 3;
            this.btnQuestion.Text = "Question";
            this.btnQuestion.UseVisualStyleBackColor = false;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.Button btnQuestion;
    }
}

