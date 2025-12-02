namespace Bai04_SoanThaoVanBan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnubtnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbbtnNewFile = new System.Windows.Forms.ToolStripButton();
            this.tbbtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tbbtnSave = new System.Windows.Forms.ToolStripButton();
            this.cbbFont = new System.Windows.Forms.ToolStripComboBox();
            this.cbbSize = new System.Windows.Forms.ToolStripComboBox();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.rtxbTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuFormat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubtnNewFile,
            this.mnubtnOpenFile,
            this.toolStripMenuItem1,
            this.mnubtnSave,
            this.mnubtnQuit});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(85, 26);
            this.mnuSystem.Text = "Hệ thống";
            // 
            // mnubtnNewFile
            // 
            this.mnubtnNewFile.Image = global::Bai04_SoanThaoVanBan.Properties.Resources.icons8_file_50;
            this.mnubtnNewFile.Name = "mnubtnNewFile";
            this.mnubtnNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnubtnNewFile.Size = new System.Drawing.Size(285, 26);
            this.mnubtnNewFile.Text = "Tạo văn bản mới";
            this.mnubtnNewFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // mnubtnOpenFile
            // 
            this.mnubtnOpenFile.Image = global::Bai04_SoanThaoVanBan.Properties.Resources.icons8_open_file_48;
            this.mnubtnOpenFile.Name = "mnubtnOpenFile";
            this.mnubtnOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnubtnOpenFile.Size = new System.Drawing.Size(285, 26);
            this.mnubtnOpenFile.Text = "Mở tập tin";
            this.mnubtnOpenFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(282, 6);
            // 
            // mnubtnSave
            // 
            this.mnubtnSave.Image = global::Bai04_SoanThaoVanBan.Properties.Resources.icons8_save_48;
            this.mnubtnSave.Name = "mnubtnSave";
            this.mnubtnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnubtnSave.Size = new System.Drawing.Size(285, 26);
            this.mnubtnSave.Text = "Lưu nội dung văn bản";
            this.mnubtnSave.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // mnubtnQuit
            // 
            this.mnubtnQuit.Image = global::Bai04_SoanThaoVanBan.Properties.Resources.icons8_quit_50;
            this.mnubtnQuit.Name = "mnubtnQuit";
            this.mnubtnQuit.Size = new System.Drawing.Size(285, 26);
            this.mnubtnQuit.Text = "Thoát";
            this.mnubtnQuit.Click += new System.EventHandler(this.quit_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFormat.Size = new System.Drawing.Size(92, 26);
            this.mnuFormat.Text = "Định dạng";
            this.mnuFormat.Click += new System.EventHandler(this.format_ClickEvt);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbtnNewFile,
            this.tbbtnOpenFile,
            this.tbbtnSave,
            this.cbbFont,
            this.cbbSize,
            this.Bold,
            this.Italic,
            this.Underline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbbtnNewFile
            // 
            this.tbbtnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtnNewFile.Image = global::Bai04_SoanThaoVanBan.Properties.Resources.icons8_file_50;
            this.tbbtnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbtnNewFile.Name = "tbbtnNewFile";
            this.tbbtnNewFile.Size = new System.Drawing.Size(29, 30);
            this.tbbtnNewFile.Text = "File mới";
            this.tbbtnNewFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // tbbtnOpenFile
            // 
            this.tbbtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtnOpenFile.Image = global::Bai04_SoanThaoVanBan.Properties.Resources.icons8_open_file_48;
            this.tbbtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbtnOpenFile.Name = "tbbtnOpenFile";
            this.tbbtnOpenFile.Size = new System.Drawing.Size(29, 30);
            this.tbbtnOpenFile.Text = "Mở file";
            this.tbbtnOpenFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // tbbtnSave
            // 
            this.tbbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtnSave.Image = global::Bai04_SoanThaoVanBan.Properties.Resources.icons8_save_48;
            this.tbbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbtnSave.Name = "tbbtnSave";
            this.tbbtnSave.Size = new System.Drawing.Size(29, 30);
            this.tbbtnSave.Text = "Lưu";
            this.tbbtnSave.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // cbbFont
            // 
            this.cbbFont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbFont.Name = "cbbFont";
            this.cbbFont.Size = new System.Drawing.Size(180, 33);
            this.cbbFont.Text = "Times New Roman";
            this.cbbFont.SelectedIndexChanged += new System.EventHandler(this.FontChangedEvt);
            // 
            // cbbSize
            // 
            this.cbbSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
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
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(121, 33);
            this.cbbSize.Text = "10";
            this.cbbSize.SelectedIndexChanged += new System.EventHandler(this.SizeChangedEvt);
            // 
            // Bold
            // 
            this.Bold.AutoSize = false;
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = global::Bai04_SoanThaoVanBan.Properties.Resources.icons8_bold_30;
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(28, 28);
            this.Bold.Text = "toolStripButton3";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.AutoSize = false;
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italic.Image = global::Bai04_SoanThaoVanBan.Properties.Resources.icons8_italic_26;
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(20, 20);
            this.Italic.Text = "toolStripButton4";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // Underline
            // 
            this.Underline.AutoSize = false;
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = global::Bai04_SoanThaoVanBan.Properties.Resources.icons8_underline_30;
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(30, 30);
            this.Underline.Text = "toolStripButton5";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // rtxbTextBox
            // 
            this.rtxbTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxbTextBox.Location = new System.Drawing.Point(0, 63);
            this.rtxbTextBox.Name = "rtxbTextBox";
            this.rtxbTextBox.Size = new System.Drawing.Size(800, 387);
            this.rtxbTextBox.TabIndex = 2;
            this.rtxbTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxbTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Soạn thảo văn bản";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox rtxbTextBox;
        private System.Windows.Forms.ToolStripMenuItem mnubtnNewFile;
        private System.Windows.Forms.ToolStripMenuItem mnubtnOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnubtnSave;
        private System.Windows.Forms.ToolStripMenuItem mnubtnQuit;
        private System.Windows.Forms.ToolStripButton tbbtnNewFile;
        private System.Windows.Forms.ToolStripButton tbbtnOpenFile;
        private System.Windows.Forms.ToolStripComboBox cbbFont;
        private System.Windows.Forms.ToolStripComboBox cbbSize;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italic;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.ToolStripButton tbbtnSave;
    }
}