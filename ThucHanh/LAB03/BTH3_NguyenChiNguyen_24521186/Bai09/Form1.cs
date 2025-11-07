using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        // Nút chọn các môn
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lsbSubject.SelectedItem == null) return;
            lsbSelectedSubject.Items.Add(lsbSubject.SelectedItem.ToString());
            lsbSubject.Items.Remove(lsbSubject.SelectedItem.ToString());
        }
        
        // Nút hủy chọn các môn
        private void btnUnselect_Click(object sender, EventArgs e)
        {
            if(lsbSelectedSubject.SelectedItem == null) return;
            lsbSubject.Items.Add(lsbSelectedSubject.SelectedItem.ToString());
            lsbSelectedSubject.Items.Remove(lsbSelectedSubject.SelectedItem.ToString());
        }

        // Nút lưu thông tin sinh viên
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Xử lý trường hợp chưa điền đủ thông tin
            if(txbName.Text == "" || txbSsn.Text == "" 
                || cbbMajor.SelectedItem == null
                || (rabMale.Checked == false && rabFemale.Checked == false) 
                || lsbSelectedSubject.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng cung cấp đủ thông tin!");
                return;
            }

            bool isExisted = false;
            int i = 0;
            // Kiểm tra xem sinh viên đó đã được lưu hay chưa thông qua mã số sinh viên
            foreach(DataGridViewRow row in dgvSudentInfo.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[0].Value.ToString() == txbSsn.Text)
                {
                    isExisted = true;
                    break;
                }
                i++;
            }
            
            // Nếu đã tồn tại sinh viên đó, cập nhật lại thông tin sinh viên theo thông tin mới mà người dùng đã nhập
            if(isExisted)
            {
                dgvSudentInfo.Rows[i].Cells[0].Value = txbSsn.Text;
                dgvSudentInfo.Rows[i].Cells[1].Value = txbName.Text;
                dgvSudentInfo.Rows[i].Cells[2].Value = cbbMajor.Text;
                dgvSudentInfo.Rows[i].Cells[3].Value = rabMale.Checked ? "Nam" : "Nữ";
                dgvSudentInfo.Rows[i].Cells[4].Value = lsbSelectedSubject.Items.Count.ToString();
            }
            // Nếu sinh viên đó chưa tồn tại thì lưu mới vào bảng
            else
            {
                dgvSudentInfo.Rows.Add(txbSsn.Text,
                    txbName.Text,
                    cbbMajor.Text,
                    rabMale.Checked ? "Nam" : "Nữ",
                    lsbSelectedSubject.Items.Count.ToString());
            }
            MessageBox.Show("Lưu dữ liệu thành công!");
            txbSsn.Text = "";
            txbName.Text = "";
            cbbMajor.Text = "";
            rabFemale.Checked = rabMale.Checked = false;
            foreach(string item in lsbSelectedSubject.Items)
            {
                lsbSubject.Items.Add(item);
            }
            lsbSelectedSubject.Items.Clear();
        }

        // Nút xóa chọn sinh viên hoặc thông tin được chọn trong bảng
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Xóa các hàng được chọn
            foreach(DataGridViewRow row in dgvSudentInfo.SelectedRows)
            {
                if (row.IsNewRow) continue;
                dgvSudentInfo.Rows.Remove(row);
                continue;
            }
            // Xóa các ô được chọn
            foreach(DataGridViewCell cell in dgvSudentInfo.SelectedCells)
            {
                cell.Value = null;
            }    
        }
    }
}