using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai05_QuanLySinhVien
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;User ID=ngnguyen;Password=123";
        public Form1()
        {
            InitializeComponent();
            LoadStudentData();
        }

        public void LoadStudentData()
        {
            string query = "SELECT ROW_NUMBER() OVER (ORDER BY ID) AS STT, ID, Name, Faculty, AvgPoint FROM Student";
            // Đảm bảo tên DataGridView của bạn là 'dgvSinhVien'
            DataGridView dgv = dgvStudentInformation;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối hoặc truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void AddStudent()
        {
            AddNewStudent addNewStudent = new AddNewStudent(this);
            addNewStudent.ShowDialog();
        }

        private void SearchBarChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSearchBar.Text))
            {
                LoadStudentData();
                return;
            }

         
            string keyword = "%" + txbSearchBar.Text.Trim() + "%";
            string whereCondition = "Name LIKE @keyword";

            string query = "SELECT ROW_NUMBER() OVER (ORDER BY ID) AS STT, ID, Name, Faculty, AvgPoint FROM Student WHERE " + whereCondition;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@keyword", keyword);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvStudentInformation.DataSource = dataTable;
                    dgvStudentInformation.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
