namespace MenuStrip
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfaToolStripMenuItem,
            this.comboboxToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.fileToolStripMenuItem.Text = "TestMenu";
            // 
            // dfaToolStripMenuItem
            // 
            this.dfaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.text1ToolStripMenuItem,
            this.text2ToolStripMenuItem,
            this.text3ToolStripMenuItem});
            this.dfaToolStripMenuItem.Name = "dfaToolStripMenuItem";
            this.dfaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.dfaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dfaToolStripMenuItem.Text = "Textbox";
            // 
            // text1ToolStripMenuItem
            // 
            this.text1ToolStripMenuItem.Name = "text1ToolStripMenuItem";
            this.text1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.text1ToolStripMenuItem.Text = "Text 1";
            // 
            // text2ToolStripMenuItem
            // 
            this.text2ToolStripMenuItem.Name = "text2ToolStripMenuItem";
            this.text2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.text2ToolStripMenuItem.Text = "Text 2";
            // 
            // text3ToolStripMenuItem
            // 
            this.text3ToolStripMenuItem.Name = "text3ToolStripMenuItem";
            this.text3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.text3ToolStripMenuItem.Text = "Text 3";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboboxToolStripMenuItem
            // 
            this.comboboxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.comboboxToolStripMenuItem.Name = "comboboxToolStripMenuItem";
            this.comboboxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.comboboxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.comboboxToolStripMenuItem.Text = "Combobox";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Apple",
            "Pineapple",
            "Kiwi",
            "Banana"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.Text = "Fruit";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu Strip";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem text3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

