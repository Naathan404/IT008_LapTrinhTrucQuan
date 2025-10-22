namespace _24521186_NguyenChiNguyen_BTChuong4
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
            this.picPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // picPicture
            // 
            this.picPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPicture.ErrorImage = global::_24521186_NguyenChiNguyen_BTChuong4.Properties.Resources.coffee;
            this.picPicture.Image = global::_24521186_NguyenChiNguyen_BTChuong4.Properties.Resources.coffee;
            this.picPicture.InitialImage = global::_24521186_NguyenChiNguyen_BTChuong4.Properties.Resources.coffee;
            this.picPicture.Location = new System.Drawing.Point(0, 0);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(800, 450);
            this.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPicture.TabIndex = 0;
            this.picPicture.TabStop = false;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picPicture);
            this.Name = "ChildForm";
            this.Text = "Image";
            this.Load += new System.EventHandler(this.ChildForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPicture;
    }
}