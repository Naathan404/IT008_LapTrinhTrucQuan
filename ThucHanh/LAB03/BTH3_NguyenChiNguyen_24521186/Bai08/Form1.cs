using System;
using System.Windows.Forms;

namespace Bai08
{
    public partial class frmAccountManager : Form
    {
        public frmAccountManager()
        {
            InitializeComponent();
            UpdateTotal();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng đã nhập đủ thông tin chưa
            if (txbAccountNum.Text == "" || txbName.Text == "" || txbAddress.Text == "" || txbBalance.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            // Kiểm tra số dư tài khoản có hợp lệ không
            if (!long.TryParse(txbBalance.Text, out long balance) || balance < 0)
            {
                MessageBox.Show("Số dư không hợp lệ!");
                return;
            }
            // Kiểm tra số tài khoản có hợp lệ không
            if(!long.TryParse(txbAccountNum.Text, out long stk) || stk <= 0)
            {
                MessageBox.Show("Số tài khoản không hợp lệ!");
                return;
            }
            
            int index = -1;
            bool isExisted = false;
            // Kiểm tra xem số tài khoản đó đã tồn tại hay chưa
            foreach (ListViewItem row in lsvListView.Items)
            {
                index++;
                if (row.SubItems[1].Text == txbAccountNum.Text)
                {
                    isExisted = true;
                    break;
                }
            }

            // Nếu chưa tồn tại thì thêm mới
            if(!isExisted)
            {
                ListViewItem item = new ListViewItem(new String[] { (lsvListView.Items.Count + 1).ToString(),
                                                     txbAccountNum.Text,
                                                     txbName.Text,
                                                     txbAddress.Text,
                                                     txbBalance.Text });
                lsvListView.Items.Add(item);
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            else    // Nếu đã tồn tại thì cập nhật lại 
            {
                lsvListView.Items[index].SubItems[1].Text = txbAccountNum.Text;
                lsvListView.Items[index].SubItems[2].Text = txbName.Text;
                lsvListView.Items[index].SubItems[3].Text = txbAddress.Text;
                lsvListView.Items[index].SubItems[4].Text = txbBalance.Text;
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
            txbAccountNum.Text = "";
            txbAddress.Text = "";
            txbBalance.Text = "";
            txbName.Text = "";
            UpdateTotal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Tìm xem số tài khoản cần xóa có tồn tại hay chưa
            foreach(ListViewItem item in lsvListView.Items)
            {
                // Thực hiện quá trình xóa tài khoản
                if (item.SubItems[1].Text == txbAccountNum.Text)
                {
                    DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", 
                        "Xác nhận xóa", 
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        lsvListView.Items.Remove(item);
                        txbAccountNum.Text = "";
                        txbAddress.Text = "";
                        txbBalance.Text = "";
                        txbName.Text = "";
                        UpdateTotal();
                        UpdateOrderNumber();
                        MessageBox.Show("Xóa tài khoản thành công!");
                    }   
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy số tài khoản cần xóa!");
        }

        // Khi người dùng ấn vào 1 hàng, hiển thị ngược thông tin lên các ô bên trên
        private void SelectRow_Changed(object sender, EventArgs e)
        {
            if(lsvListView.SelectedItems.Count <= 0)
            {
                return;
            }    
            txbAccountNum.Text = lsvListView.SelectedItems[0].SubItems[1].Text;
            txbName.Text = lsvListView.SelectedItems[0].SubItems[2].Text;
            txbAddress.Text = lsvListView.SelectedItems[0].SubItems[3].Text;
            txbBalance.Text = lsvListView.SelectedItems[0].SubItems[4].Text;
        }

        // Đóng cửa sổ
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTotal()
        {
            long total = 0;
            foreach (ListViewItem item in lsvListView.Items)
            {
                total += long.Parse(item.SubItems[4].Text);
            }
            txbTotal.Text = total.ToString();
        }

        private void UpdateOrderNumber()
        {
            int num = 1;
            foreach(ListViewItem item in lsvListView.Items)
            {
                item.SubItems[0].Text = num.ToString();
                num++;
            }
        }
    }
}