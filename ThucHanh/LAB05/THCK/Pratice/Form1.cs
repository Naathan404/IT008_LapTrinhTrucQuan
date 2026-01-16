using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtpNgayNhan.Text = DateTime.Now.ToString();
            dtpNgayTra.Text = DateTime.Now.AddDays(1).ToString();
            cboLoaiPhong.SelectedIndex = 0;
            NapDuLieuMau();
            TinhToanTongTien();
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            int index = -1;

            for (int i = 0; i < dgvBangHienThi.Rows.Count; i++)
            {
                if (dgvBangHienThi.Rows[i].Cells["MaDatPhong"].Value?.ToString() == txtMaDatPhong.Text)
                {
                    index = i;
                    break;
                }
            }

            Booking dp = new Booking()
            {
                MaDatPhong = txtMaDatPhong.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                TenKhach = txtTenKhach.Text.Trim(),
                LoaiPhong = cboLoaiPhong.Text,
                TienCoc = decimal.Parse(txtTienCoc.Text),
                NgayNhan = dtpNgayNhan.Value,
                NgayTra = dtpNgayTra.Value,
                TongTien = decimal.Parse(txtTongTien.Text),
            };

            if(index == -1)
            {
                dgvBangHienThi.Rows.Add(
                    "",
                    dp.MaDatPhong,
                    dp.TenKhach,
                    dp.SoDienThoai,
                    dp.LoaiPhong,
                    dp.NgayNhan,
                    dp.NgayTra,
                    dp.TienCoc.ToString("N0"),
                    dp.TongTien.ToString("N0")
                );
            }
            else
            {
                dgvBangHienThi.Rows[index].Cells["TenKhach"].Value = dp.TenKhach;
                dgvBangHienThi.Rows[index].Cells["SoDienThoai"].Value = dp.SoDienThoai;
                dgvBangHienThi.Rows[index].Cells["LoaiPhong"].Value = dp.LoaiPhong;
                dgvBangHienThi.Rows[index].Cells["NgayNhan"].Value = dp.NgayNhan;
                dgvBangHienThi.Rows[index].Cells["NgayTra"].Value = dp.NgayTra;
                dgvBangHienThi.Rows[index].Cells["TienCoc"].Value = dp.TienCoc.ToString("N0");
                dgvBangHienThi.Rows[index].Cells["TongTien"].Value = dp.TongTien.ToString("N0");
            }

            CapNhatSTT();
            btnLamMoi_Click(sender, e);
        }

        private bool CheckInput()
        {
            // Kiểm tra đã nhập đầy đủ chưa
            if
            (
                string.IsNullOrWhiteSpace(txtMaDatPhong.Text) ||
                string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtTenKhach.Text) ||
                string.IsNullOrWhiteSpace(cboLoaiPhong.Text) ||
                string.IsNullOrWhiteSpace(txtTienCoc.Text) ||
                string.IsNullOrWhiteSpace(dtpNgayNhan.Text) ||
                string.IsNullOrWhiteSpace(dtpNgayTra.Text)
            )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra mã đặt phòng
            if (txtMaDatPhong.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã đặt phòng phải đúng 5 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach(char c in txtMaDatPhong.Text.Trim())
            {
                if(!char.IsLetterOrDigit(c))
                {
                    MessageBox.Show("Mã đặt phòng chỉ được chứa ký tự chữ và số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Kiểm tra tên khách
            foreach (char c in txtTenKhach.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Tên khách chỉ được chứa ký tự chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Kiểm tra số điện thoại
            if(txtSoDienThoai.Text.Trim().Length > 11 || txtSoDienThoai.Text.Trim().Length < 9)
            {
                MessageBox.Show("Số điện thoại chỉ gồm số và có độ dài 9 đến 11 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach (char c in txtSoDienThoai.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Số điện thoại chỉ được chứa ký tự số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Kiểm tra ngày trả và ngày nhận
            if (dtpNgayTra.Value <= dtpNgayNhan.Value)
            {
                MessageBox.Show("Ngày trả phải lớn hơn ngày nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra tiền cọc
            decimal tienCoc;
            if (!decimal.TryParse(txtTienCoc.Text, out tienCoc) || tienCoc < 100000 || tienCoc >= 500000)
            {
                MessageBox.Show("Tiền cọc phải là số >= 100.000 và < 500000!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Ok hết rồi thì trả về true nè :333
            return true;
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CapNhatSTT()
        {
            for (int i = 0; i < dgvBangHienThi.Rows.Count; i++)
            {
                dgvBangHienThi.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDatPhong.Text = "";
            txtTenKhach.Text = "";
            txtSoDienThoai.Text = "";
            txtTienCoc.Text = "";
            txtTongTien.Text = "";
            cboLoaiPhong.SelectedIndex = 0;
            dtpNgayNhan.Text = DateTime.Now.ToString();
            dtpNgayTra.Text = DateTime.Now.AddDays(1).ToString();

            txtMaDatPhong.Focus();
            dgvBangHienThi.ClearSelection();
            txtTimKiem.Text = "";
            foreach(DataGridViewRow r in dgvBangHienThi.Rows)
            {
                r.Visible = true;
            }    
        }

        private void dgvBangHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBangHienThi.Rows[e.RowIndex];

                txtMaDatPhong.Text = row.Cells["MaDatPhong"].Value.ToString();
                txtTenKhach.Text = row.Cells["TenKhach"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                cboLoaiPhong.Text = row.Cells["LoaiPhong"].Value.ToString();

                if (DateTime.TryParse(row.Cells["NgayNhan"].Value.ToString(), out DateTime ngayNhan))
                {
                    dtpNgayNhan.Value = ngayNhan;
                }

                if (DateTime.TryParse(row.Cells["NgayTra"].Value.ToString(), out DateTime ngayTra))
                {
                    dtpNgayTra.Value = ngayTra;
                }
                string tienCocStr = row.Cells["TienCoc"].Value.ToString()
                                    .Replace(",", "").Replace(".", "");
                txtTienCoc.Text = tienCocStr;
            }
        }

        private void TinhToanTongTien()
        {
            int soNgay = (dtpNgayTra.Value - dtpNgayNhan.Value).Days;

            decimal donGia = 0;
            if (cboLoaiPhong.Text == "Suite") donGia = 800000;
            else if (cboLoaiPhong.Text == "Deluxe") donGia = 500000;
            else donGia = 300000;
            decimal tongTien = soNgay * donGia;

            txtTongTien.Text = tongTien.ToString("N0");
        }

        private void evt_TongTienChanged(object sender, EventArgs e)
        {
            TinhToanTongTien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBangHienThi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa (các) dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvBangHienThi.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvBangHienThi.Rows.Remove(row);
                    }
                }

                MessageBox.Show("Đã xóa dữ liệu thành công!", "Thông báo");

                CapNhatSTT();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sdtCanTim = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                foreach (DataGridViewRow row in dgvBangHienThi.Rows)
                    row.Visible = true;
                return;
            }
            foreach (DataGridViewRow row in dgvBangHienThi.Rows)
            {
                if (row.Cells["SoDienThoai"].Value != null &&
                    row.Cells["SoDienThoai"].Value.ToString().Contains(sdtCanTim))
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

        private void NapDuLieuMau()
        {
            dgvBangHienThi.Rows.Add(
                "",
                "BK001",
                "Nguyen Van An",
                "0901234567",
                "Suite",
                DateTime.Now.ToString("dd/MM/yyyy"),
                DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"),
                (200000).ToString("N0"),
                (800000).ToString("N0")
            );
            dgvBangHienThi.Rows.Add(
                "",
                "BK002",
                "Tran Thi Binh",
                "0912345678",
                "Deluxe",
                DateTime.Now.ToString("dd/MM/yyyy"),
                DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                (150000).ToString("N0"),
                (1000000).ToString("N0")
            );
            dgvBangHienThi.Rows.Add(
                "",
                "BK003",
                "Le Van Cuong",
                "0987654321",
                "Standard",
                DateTime.Now.ToString("dd/MM/yyyy"),
                DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                (100000).ToString("N0"),
                (900000).ToString("N0")
            );

            CapNhatSTT();
        }
    }
}
