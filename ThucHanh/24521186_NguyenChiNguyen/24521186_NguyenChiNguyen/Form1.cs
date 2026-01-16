using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24521186_NguyenChiNguyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMaTB.Text = "";
            txtTenTB.Text = "";
            txtSoLuong.Text = "0";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
            cboLoaiTB.SelectedIndex = 0;
            cboPhong.SelectedIndex = 0;
            cboTinhTrang.SelectedIndex = 0;
            dtpNgayNhap.Value = DateTime.Now;
            txtMaTB.Focus();
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            int index = -1;
            for(int i = 0; i < dgvBangHienThi.Rows.Count; i++)
            {
                if(txtMaTB.Text == dgvBangHienThi.Rows[i].Cells["MaTB"].Value.ToString())
                {
                    index = i;
                }    
            }
            
            // Trường hợp thêm
            if(index == -1)
            {
                dgvBangHienThi.Rows.Add
                (
                    "",
                    txtMaTB.Text.Trim(),
                    txtTenTB.Text.Trim(),
                    cboLoaiTB.Text,
                    cboPhong.Text,
                    txtSoLuong.Text.Trim(),
                    string.Format("N0", txtDonGia.Text.Trim()),
                    dtpNgayNhap.Value,
                    cboTinhTrang.Text,
                    string.Format("N0", txtThanhTien.Text)
                );
            }
            else        // Cập nhật
            {
                dgvBangHienThi.Rows[index].Cells["TenTB"].Value = txtTenTB.Text.Trim();
                dgvBangHienThi.Rows[index].Cells["LoaiTB"].Value = cboLoaiTB.Text;
                dgvBangHienThi.Rows[index].Cells["Phong"].Value = cboPhong.Text;
                dgvBangHienThi.Rows[index].Cells["SoLuong"].Value = txtSoLuong.Text.Trim();
                dgvBangHienThi.Rows[index].Cells["DonGia"].Value = string.Format("N0", txtDonGia.Text.Trim());
                dgvBangHienThi.Rows[index].Cells["NgayNhap"].Value = dtpNgayNhap.Value;
                dgvBangHienThi.Rows[index].Cells["TinhTrang"].Value = cboTinhTrang.Text;
                dgvBangHienThi.Rows[index].Cells["ThanhTien"].Value = string.Format("N0", txtThanhTien.Text.Trim());

            }    

            // Cập nhật số TT và refresh
            CapNhatSTT();
            btnLamMoi_Click(sender, e);
        }

        /// <summary>
        /// Cập nhật số thứ tự trên DataGridView
        /// </summary>
        private void CapNhatSTT()
        {
            for (int i = 0; i < dgvBangHienThi.Rows.Count; i++)
            {
                dgvBangHienThi.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        /// <summary>
        /// Tải lại dữ liệu trên trang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTB.Text = "";
            txtTenTB.Text = "";
            txtSoLuong.Text = "0";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
            cboLoaiTB.SelectedIndex = 0;
            cboPhong.SelectedIndex = 0;
            cboTinhTrang.SelectedIndex = 0;
            dtpNgayNhap.Value = DateTime.Now;

            txtMaTB.Focus();
            dgvBangHienThi.ClearSelection();
            txtTimKiem.Text = "";
            foreach (DataGridViewRow r in dgvBangHienThi.Rows)
            {
                r.Visible = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBangHienThi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvBangHienThi.SelectedRows)
                {
                    dgvBangHienThi.Rows.Remove(row);
                }

                MessageBox.Show("Đã xóa dữ liệu thành công!", "Thông báo");

                CapNhatSTT();
                btnLamMoi_Click(sender, e);
            }
        }

        /// <summary>
        /// Thoát ứng dụng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void dgvBangHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0) return;
            if (dgvBangHienThi.SelectedRows.Count < 1)
                return;

            DataGridViewRow r = dgvBangHienThi.Rows[e.RowIndex];
            txtMaTB.Text = r.Cells["MaTB"].Value.ToString();
            txtTenTB.Text = r.Cells["TenTB"].Value.ToString();
            cboLoaiTB.Text = r.Cells["LoaiTB"].Value.ToString();
            cboPhong.Text = r.Cells["Phong"].Value.ToString();
            cboTinhTrang.Text = r.Cells["TinhTrang"].Value.ToString();
            txtSoLuong.Text = r.Cells["SoLuong"].Value.ToString().Replace(".", "").Replace(",", "");
            txtDonGia.Text = r.Cells["DonGia"].Value.ToString().Replace(".", "").Replace(",", "");
            if(DateTime.TryParse(dtpNgayNhap.Text, out DateTime dt))
            {
                dtpNgayNhap.Value = dt;
            }
            // Thanh tien khong can cap nhat vi da co su kien
        }

        /// <summary>
        /// Chặn ký tự nhập vào không phải là số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evt_GetInputNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void evt_CapNhatThanhTien(object sender, EventArgs e)
        {
            txtThanhTien.Text = "0";
            if(decimal.TryParse(txtDonGia.Text, out decimal dt) && decimal.TryParse(txtSoLuong.Text, out decimal sl))
            {
                txtThanhTien.Text = (dt * sl).ToString();
            }    
        }

        private bool CheckInput()
        {
            // Kiểm tra đã nhập đầy đủ chưa
            if(string.IsNullOrWhiteSpace(txtMaTB.Text))
            {
                MessageBox.Show("Mã thiết bị không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTB.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenTB.Text))
            {
                MessageBox.Show("Tên thiết bị không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTB.Focus();
                return false;
            }

            // Kiểm tra mã thiết bị
            if (txtMaTB.Text.Trim().Length != 8)
            {
                MessageBox.Show("Mã đặt phòng phải chứa 8 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTB.Focus();
                return false;
            }

            bool chuaKTDB1 = false;
            foreach (char c in txtMaTB.Text.Trim())
            {
                if(char.IsPunctuation(c)) chuaKTDB1 = true;
                if (char.IsLower(c) || (char.IsDigit(c) && int.Parse(c.ToString()) >= 6))
                {
                    MessageBox.Show("Mã thiết bị phải và chỉ chứa chữ viết hoa, các số từ 0 - 5 và các ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaTB.Focus();
                    return false;
                }
            }
            if(!chuaKTDB1)
            {
                MessageBox.Show("Mã thiết bị phải và chỉ chứa chữ viết hoa, các số từ 0 - 5 và các ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTB.Focus();
                return false;
            }

            // Kiểm tra tên thiết bị
            bool chuaChuVietHoa = false;
            bool chuaChuVietThuong = false;
            bool chuaKyTuDB = false;
            bool chuaSo = false;
            foreach (char c in txtTenTB.Text)
            {
                if(char.IsUpper(c)) chuaChuVietHoa = true;
                if (char.IsLower(c)) chuaChuVietThuong = true;
                if(char.IsPunctuation(c)) chuaKyTuDB = true;
                if(char.IsDigit(c)) chuaSo = true;
            }
            if(!chuaChuVietHoa || !chuaChuVietThuong || !chuaKyTuDB || !chuaSo)
            {
                MessageBox.Show("Tên thiết bị phải có đủ chữ viết hoa, chữ viết thường, số và ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTB.Focus();
                return false;
            }

            // Kiểm tra số lượng
            if (int.TryParse(txtSoLuong.Text, out int sl))
            {
                if (sl <= 0 || sl > 10)
                {
                    MessageBox.Show("Số lượng phải là số nguyên > 0 và <= 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Số lượng phải là số nguyên > 0 và <= 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return false;
            }

            // Kiểm tra đơn giá
            if (decimal.TryParse(txtSoLuong.Text, out decimal dg))
            {
                if (dg <= 0 || dg > 12000000)
                {
                    MessageBox.Show("Đơn giá phải là số > 0 và <= 12000000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDonGia.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Đơn giá phải là số > 0 và <= 12000000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return false;
            }

            // Kiểm tra ngày nhập
            if(dtpNgayNhap.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày nhập không được lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayNhap.Focus();
                return false;
            }    

            // Ok hết rồi thì trả về true nè :333
            return true;
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvBangHienThi.Rows)
            {
                r.Visible = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                foreach (DataGridViewRow r in dgvBangHienThi.Rows)
                {
                    r.Visible = true;
                }
                return;
            }    

            if(cboTimTheo.Text == "Mã thiết bị")
            {
                foreach (DataGridViewRow row in dgvBangHienThi.Rows)
                {
                    if (row.Cells["MaTB"].Value != null &&
                        row.Cells["MaTB"].Value.ToString().Contains(txtTimKiem.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        dgvBangHienThi.CurrentCell = null;
                        row.Visible = false;
                    }
                }
            }
            else if (cboTimTheo.Text == "Phòng")
            {
                foreach (DataGridViewRow row in dgvBangHienThi.Rows)
                {
                    if (row.Cells["Phong"].Value != null &&
                        row.Cells["Phong"].Value.ToString().Contains(txtTimKiem.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        dgvBangHienThi.CurrentCell = null;
                        row.Visible = false;
                    }
                }
            }
        }
    }
}
