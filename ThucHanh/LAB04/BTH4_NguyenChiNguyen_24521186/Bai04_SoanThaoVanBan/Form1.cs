using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Bai04_SoanThaoVanBan
{
    public partial class Form1 : Form
    {
        private string currentFilePath = null;
        private FontStyle style = FontStyle.Regular;
        public Form1()
        {
            InitializeComponent();
            ImportSystemFonts();
            SetDefault();
        }

        private void format_ClickEvt(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (cbbSize.SelectedItem != null && float.TryParse(cbbSize.SelectedItem.ToString(), out float size))
                {
                    fontDialog.Font = new Font(cbbFont.Text, size, style);
                }

                if(fontDialog.ShowDialog() == DialogResult.OK)
                {
                    if(rtxbTextBox.SelectionLength > 0)
                    {
                        rtxbTextBox.SelectionFont = fontDialog.Font;
                    }
                    else
                    {
                        rtxbTextBox.Font = fontDialog.Font;
                    }
                    cbbFont.SelectedItem = fontDialog.Font.Name;
                    cbbSize.SelectedItem = Math.Round(fontDialog.Font.SizeInPoints).ToString();
                }
            }    
        }

        private void SetDefault()
        {
            cbbSize.SelectedItem = "14";
            cbbFont.SelectedItem = "Tahoma";
            rtxbTextBox.Text = "";
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            SetDefault();
            currentFilePath = null;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "RTF file|*.rtf|Txt file|*.txt|All file|*";
            openDialog.FilterIndex = 1;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(openDialog.FileName).ToLower();
                string[] validExtensions = { ".rtf", ".txt" };

                if (Array.IndexOf(validExtensions, ext) > -1)
                {
                    rtxbTextBox.LoadFile(openDialog.FileName, RichTextBoxStreamType.RichText);
                    currentFilePath = openDialog.FileName;
                }
                else
                {
                    MessageBox.Show(
                        "Định dạng file này không được hỗ trợ để đọc.\n\nCác định dạng được hỗ trợ: RTF, TXT.",
                        "Lỗi Định Dạng File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }
        }

        private void ImportSystemFonts()
        {
            InstalledFontCollection installedFont = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFont.Families;
            foreach (FontFamily family in fontFamilies)
            {
                cbbFont.Items.Add(family.Name);
            }    
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if(currentFilePath == null)
            {
                using (SaveFileDialog  saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "RTF File|*.rtf";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.Title = "Lưu file";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        currentFilePath = saveFileDialog.FileName;
                    else
                        return;
                }
            }
            rtxbTextBox.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
            MessageBox.Show("Lưu tập tin thành công!", "Lưu thành công");
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FontChangedEvt(object sender, EventArgs e)
        {
            ChangeTextFormat();
        }

        private void SizeChangedEvt(object sender, EventArgs e)
        {
            ChangeTextFormat();
        }


        private void ChangeTextFormat()
        {
            Font newFont = new Font(cbbFont.Text, float.Parse(cbbSize.Text), style);
            if (rtxbTextBox.SelectionLength > 0)
            {
                rtxbTextBox.SelectionFont = newFont;
            }
            else
            {
                rtxbTextBox.Font = newFont;
            }
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);
        }
        private void Italic_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }

        private void ToggleFontStyle(FontStyle styleToToggle)
        {
            Font currentFont = rtxbTextBox.SelectionFont ?? rtxbTextBox.Font;
            style = currentFont.Style;

            if (currentFont.Style.HasFlag(styleToToggle))
            {
                style &= ~styleToToggle;
            }
            else
            {
                style |= styleToToggle;
            }
            Font newFont = new Font(currentFont, style);

            if (rtxbTextBox.SelectionLength > 0)
            {
                rtxbTextBox.SelectionFont = newFont;
            }
            else
            {
                rtxbTextBox.Font = newFont;
            }
        }
    }
}
