namespace Bai01
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
            this.lsbLog = new System.Windows.Forms.ListBox();
            this.btnOpenChildForm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbLog
            // 
            this.lsbLog.FormattingEnabled = true;
            this.lsbLog.ItemHeight = 16;
            this.lsbLog.Location = new System.Drawing.Point(166, 12);
            this.lsbLog.Name = "lsbLog";
            this.lsbLog.Size = new System.Drawing.Size(474, 308);
            this.lsbLog.TabIndex = 0;
            // 
            // btnOpenChildForm
            // 
            this.btnOpenChildForm.Location = new System.Drawing.Point(241, 364);
            this.btnOpenChildForm.Name = "btnOpenChildForm";
            this.btnOpenChildForm.Size = new System.Drawing.Size(120, 27);
            this.btnOpenChildForm.TabIndex = 1;
            this.btnOpenChildForm.Text = "Mở form con";
            this.btnOpenChildForm.UseVisualStyleBackColor = true;
            this.btnOpenChildForm.Click += new System.EventHandler(this.btnOpenChildForm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(445, 364);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenChildForm);
            this.Controls.Add(this.lsbLog);
            this.Name = "Form1";
            this.Text = "Bai01 - Sự kiện trong vòng đời của form";
            this.Activated += new System.EventHandler(this.Form1_Activate);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lsbLog;
        private System.Windows.Forms.Button btnOpenChildForm;
        private System.Windows.Forms.Button btnClose;
    }
}