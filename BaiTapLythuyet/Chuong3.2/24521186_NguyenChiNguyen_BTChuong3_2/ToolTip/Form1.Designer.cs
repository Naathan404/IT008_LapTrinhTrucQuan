namespace ToolTip
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lsbListName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(185, 95);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(321, 22);
            this.txbName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txbName, "Nhập họ tên");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(522, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.toolTip1.SetToolTip(this.btnAdd, "Thêm vào danh sách");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(182, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ Tên";
            // 
            // lsbListName
            // 
            this.lsbListName.FormattingEnabled = true;
            this.lsbListName.ItemHeight = 16;
            this.lsbListName.Items.AddRange(new object[] {
            "Nathan",
            "Mary",
            "Elliot",
            "Sophia",
            "Ruby",
            "Alex"});
            this.lsbListName.Location = new System.Drawing.Point(185, 139);
            this.lsbListName.Name = "lsbListName";
            this.lsbListName.Size = new System.Drawing.Size(321, 180);
            this.lsbListName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.lsbListName, "Danh sách họ tên");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbListName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbName);
            this.Name = "Form1";
            this.Text = "ToolTip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lsbListName;
    }
}

