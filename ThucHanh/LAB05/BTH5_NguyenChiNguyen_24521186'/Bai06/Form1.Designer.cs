namespace Bai06
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
            this.lsvSystemFonts = new System.Windows.Forms.ListView();
            this.fontCHS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvSystemFonts
            // 
            this.lsvSystemFonts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fontCHS});
            this.lsvSystemFonts.HideSelection = false;
            this.lsvSystemFonts.Location = new System.Drawing.Point(12, 10);
            this.lsvSystemFonts.Name = "lsvSystemFonts";
            this.lsvSystemFonts.Size = new System.Drawing.Size(426, 478);
            this.lsvSystemFonts.TabIndex = 0;
            this.lsvSystemFonts.UseCompatibleStateImageBehavior = false;
            this.lsvSystemFonts.View = System.Windows.Forms.View.Details;
            // 
            // fontCHS
            // 
            this.fontCHS.Text = "Font";
            this.fontCHS.Width = 450;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.lsvSystemFonts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bài 06 - All Fonts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvSystemFonts;
        private System.Windows.Forms.ColumnHeader fontCHS;
    }
}
