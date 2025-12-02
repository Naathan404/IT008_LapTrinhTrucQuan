using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Bai06_SaoChepTapTin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bgWorker.WorkerReportsProgress = true;
        }

        private void btnSourcePath_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txbSourcePath.Text = folderBrowserDialog.SelectedPath;
                }    
            }    
        }

        private void btnDestPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txbDestPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSourcePath.Text) || string.IsNullOrWhiteSpace(txbDestPath.Text))
            {
                MessageBox.Show("Vui lòng chọn cả thư mục nguồn và thư mục đích.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!bgWorker.IsBusy)
            {
                btnCopy.Enabled = false;

                string[] paths = { txbSourcePath.Text, txbDestPath.Text };
                bgWorker.RunWorkerAsync(paths);
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string[] paths = e.Argument as string[];
            string sourceDir = paths[0];
            string destDir = paths[1];

            if (!Directory.Exists(sourceDir) || !Directory.Exists(destDir))
            {
                e.Result = "Source directory not found";
                return;
            }

            string[] files = Directory.GetFiles(sourceDir);
            int totalFiles = files.Length;

            if (totalFiles == 0)
            {
                e.Cancel = true;
                return;
            }

            worker.ReportProgress(0, 100);

            for (int i = 0; i < totalFiles; i++)
            {
                string fileName = Path.GetFileName(files[i]);
                string destFile = Path.Combine(destDir, fileName);

                File.Copy(files[i], destFile, true);

                int percentComplete = (i + 1) * 100 / totalFiles;
                string status = $"Đang sao chép: {fileName} ({i + 1}/{totalFiles})";
                lblStatus.Text = status;
                worker.ReportProgress(percentComplete, status);
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (progressBar1.Maximum != 100)
            {
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;
            }
            if (e.ProgressPercentage < 100)
            {
                progressBar1.Value = e.ProgressPercentage;
            }
            if (e.UserState is string status)
            {
                lblStatus.Text = status;
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCopy.Enabled = true;

            progressBar1.Value = 100;

            if (e.Cancelled)
            {
                lblStatus.Text = "Hủy bỏ: Không tìm thấy tệp tin nào để sao chép.";
            }
            else if (e.Result is string resultMessage && resultMessage == "Source directory not found")
            {
                lblStatus.Text = "Lỗi: Thư mục nguồn không tồn tại.";
                MessageBox.Show("Thư mục nguồn không tồn tại. Vui lòng kiểm tra lại đường dẫn.", "Lỗi");
            }
            else if (e.Error != null)
            {
                lblStatus.Text = $"Lỗi: {e.Error.Message}";
                MessageBox.Show($"Đã xảy ra lỗi trong quá trình sao chép: {e.Error.Message}", "Lỗi Sao Chép");
            }
            else
            {
                lblStatus.Text = "Hoàn thành sao chép tất cả tệp tin!";
                MessageBox.Show("Sao chép thành công!", "Thông báo");
            }
        }
    }
}
