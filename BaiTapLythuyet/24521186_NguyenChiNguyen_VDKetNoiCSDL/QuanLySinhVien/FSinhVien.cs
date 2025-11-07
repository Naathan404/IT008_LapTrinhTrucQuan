using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FSinhVien : Form
    {
        private string connStr = @"Server=LAPTOP-UEB0IP6O;Database=QLSV;User Id=ngnguyen;Password=123;"; // Chuoi ket noi
        private SqlConnection conn; // Bien ket noi
        private SqlDataAdapter myAdapter;
        private DataSet ds;
        private DataTable dt;

        public FSinhVien()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            conn = new SqlConnection(connStr); // Tao ket noi CSDL
            conn.Open(); // Mo ket noi

            string sqlStr = "Select * from TSinhVien"; // Cau lenh truy van lay toan bo du lieu tu bang TSinhVien
            myAdapter = new SqlDataAdapter(sqlStr, conn); // Tao adapter

            ds = new DataSet();
            myAdapter.Fill(ds, "TSinhVien"); // Lay du lieu dataset tu bang tren
            dt = ds.Tables["TSinhVien"]; // Lay du lieu cho table tu bang tren


            dgvSinhVien.DataSource = dt; // Gan du liue tu dt cho dgvSinhVien

            conn.Close();
        }

        private void FSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txbMaSo.ReadOnly = false;
            txbMaSo.ResetText();
            txbHoTen.ResetText();
            txbNgaySinh.ResetText();
            txbGioiTinh.ResetText();
            txbDiaChi.ResetText();
            txbDienThoai.ResetText();
            txbMaSo.Focus();

            this.btnGhi.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnThemMoi.Enabled = false;
            this.btnXoa.Enabled = true;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();

            string sqlStr = @"INSERT INTO TSinhVien values (@MaSo, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai)";

            SqlCommand comm = new SqlCommand(sqlStr, conn);
            comm.Parameters.Add("@MaSo", SqlDbType.Int).Value = int.Parse(txbMaSo.Text);
            comm.Parameters.Add("@HoTen", SqlDbType.NChar).Value = txbHoTen.Text;
            comm.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime).Value = DateTime.Parse(txbNgaySinh.Text);
            comm.Parameters.Add("@GioiTinh", SqlDbType.NChar).Value = txbGioiTinh.Text;
            comm.Parameters.Add("@DiaChi", SqlDbType.NChar).Value = txbDiaChi.Text;
            comm.Parameters.Add("@DienThoai", SqlDbType.Int).Value = int.Parse(txbDienThoai.Text);

            int count = (int)comm.ExecuteNonQuery();
            LoadData();
            conn.Close();
            txbMaSo.ReadOnly = true;
            this.btnThemMoi.Enabled = true;
        }

        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txbMaSo.Text = dt.Rows[row]["MaSo"].ToString();
            txbHoTen.Text = dt.Rows[row]["HoTen"].ToString();
            txbNgaySinh.Text = dt.Rows[row]["NgaySinh"].ToString();
            txbGioiTinh.Text = dt.Rows[row]["GioiTinh"].ToString();
            txbDiaChi.Text = dt.Rows[row]["DiaChi"].ToString();
            txbDienThoai.Text = dt.Rows[row]["DienThoai"].ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sqlStr = "UPDATE TSinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, "
                + "GioiTinh = @GioiTinh, DiaChi = @DiaChi, DienThoai = @DienThoai WHERE MaSo = @MaSo";

            SqlCommand comm = new SqlCommand(sqlStr, conn);

            comm.Parameters.Add("@MaSo", SqlDbType.Int).Value = int.Parse(txbMaSo.Text);
            comm.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txbHoTen.Text;
            comm.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime).Value = DateTime.Parse(txbNgaySinh.Text);
            comm.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = txbGioiTinh.Text;
            comm.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txbDiaChi.Text;
            comm.Parameters.Add("@DienThoai", SqlDbType.Int).Value = int.Parse(txbDienThoai.Text);

            int count = (int)comm.ExecuteNonQuery(); // thực thi lệnh truy vấn
            LoadData();
            conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question
);

            if (result == DialogResult.Yes)
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                string sqlStr = "DELETE FROM TSinhVien WHERE MaSo = @MaSo";
                SqlCommand comm = new SqlCommand(sqlStr, conn);

                comm.Parameters.Add("@MaSo", SqlDbType.Int).Value = int.Parse(txbMaSo.Text);

                int count = (int)comm.ExecuteNonQuery(); // thực thi lệnh truy vấn

                LoadData();
                conn.Close();
            }

        }
    }

    
}
