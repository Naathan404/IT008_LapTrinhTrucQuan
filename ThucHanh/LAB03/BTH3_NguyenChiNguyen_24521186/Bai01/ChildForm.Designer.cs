namespace Bai01
{
    partial class ChildForm
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
            this.lblFormCon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFormCon
            // 
            this.lblFormCon.AutoSize = true;
            this.lblFormCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormCon.Location = new System.Drawing.Point(260, 200);
            this.lblFormCon.Name = "lblFormCon";
            this.lblFormCon.Size = new System.Drawing.Size(247, 29);
            this.lblFormCon.TabIndex = 0;
            this.lblFormCon.Text = "ĐÂY LÀ FORM CON";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFormCon);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.Activated += new System.EventHandler(this.ChildFrom_Activated);
            this.Deactivate += new System.EventHandler(this.ChildForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChildForm_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChildForm_Closed);
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.Shown += new System.EventHandler(this.ChildForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblFormCon;
    }
}