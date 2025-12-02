namespace Bai06_SaoChepTapTin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDestPath = new System.Windows.Forms.Button();
            this.btnSourcePath = new System.Windows.Forms.Button();
            this.txbDestPath = new System.Windows.Forms.TextBox();
            this.txbSourcePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.grbCopyProgress = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.grbCopyProgress.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.btnDestPath);
            this.groupBox1.Controls.Add(this.btnSourcePath);
            this.groupBox1.Controls.Add(this.txbDestPath);
            this.groupBox1.Controls.Add(this.txbSourcePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSourcePath);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(49, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao chép tập tin";
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.ForeColor = System.Drawing.Color.Black;
            this.btnCopy.Location = new System.Drawing.Point(296, 168);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(200, 45);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Sao Chép";
            this.toolTip1.SetToolTip(this.btnCopy, "Thực hiện sao chép tập tin");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDestPath
            // 
            this.btnDestPath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDestPath.ForeColor = System.Drawing.Color.Black;
            this.btnDestPath.Location = new System.Drawing.Point(668, 102);
            this.btnDestPath.Name = "btnDestPath";
            this.btnDestPath.Size = new System.Drawing.Size(46, 34);
            this.btnDestPath.TabIndex = 5;
            this.btnDestPath.Text = "...";
            this.toolTip1.SetToolTip(this.btnDestPath, "Chọn đường dẫn thư mục đích");
            this.btnDestPath.UseVisualStyleBackColor = true;
            this.btnDestPath.Click += new System.EventHandler(this.btnDestPath_Click);
            // 
            // btnSourcePath
            // 
            this.btnSourcePath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSourcePath.ForeColor = System.Drawing.Color.Black;
            this.btnSourcePath.Location = new System.Drawing.Point(668, 65);
            this.btnSourcePath.Name = "btnSourcePath";
            this.btnSourcePath.Size = new System.Drawing.Size(46, 34);
            this.btnSourcePath.TabIndex = 4;
            this.btnSourcePath.Text = "...";
            this.toolTip1.SetToolTip(this.btnSourcePath, "Chọn đường dẫn thư mục nguồn");
            this.btnSourcePath.UseVisualStyleBackColor = true;
            this.btnSourcePath.Click += new System.EventHandler(this.btnSourcePath_Click);
            // 
            // txbDestPath
            // 
            this.txbDestPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDestPath.Location = new System.Drawing.Point(296, 102);
            this.txbDestPath.Name = "txbDestPath";
            this.txbDestPath.Size = new System.Drawing.Size(352, 30);
            this.txbDestPath.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txbDestPath, "Đường dẫn thư mục đích để sao chép các tập tin tới đó");
            // 
            // txbSourcePath
            // 
            this.txbSourcePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSourcePath.Location = new System.Drawing.Point(296, 66);
            this.txbSourcePath.Name = "txbSourcePath";
            this.txbSourcePath.Size = new System.Drawing.Size(352, 30);
            this.txbSourcePath.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txbSourcePath, "Đường dẫn thư mục nguồn để sao chép các tập tin");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đường dẫn thư mục đích:";
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSourcePath.Location = new System.Drawing.Point(16, 72);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(226, 23);
            this.lblSourcePath.TabIndex = 0;
            this.lblSourcePath.Text = "Đường dẫn thư mục nguồn:";
            // 
            // grbCopyProgress
            // 
            this.grbCopyProgress.Controls.Add(this.progressBar1);
            this.grbCopyProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCopyProgress.ForeColor = System.Drawing.Color.Blue;
            this.grbCopyProgress.Location = new System.Drawing.Point(48, 303);
            this.grbCopyProgress.Name = "grbCopyProgress";
            this.grbCopyProgress.Size = new System.Drawing.Size(745, 110);
            this.grbCopyProgress.TabIndex = 1;
            this.grbCopyProgress.TabStop = false;
            this.grbCopyProgress.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(694, 33);
            this.progressBar1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.progressBar1, "Thanh tiến trình sao chép");
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grbCopyProgress);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sao Chép Tập TIn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCopyProgress.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDestPath;
        private System.Windows.Forms.Button btnSourcePath;
        private System.Windows.Forms.TextBox txbDestPath;
        private System.Windows.Forms.TextBox txbSourcePath;
        private System.Windows.Forms.GroupBox grbCopyProgress;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}

