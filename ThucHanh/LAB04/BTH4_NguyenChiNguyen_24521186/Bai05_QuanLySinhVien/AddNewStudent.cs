using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05_QuanLySinhVien
{
    public partial class AddNewStudent : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=QuanLySinhVien;User ID=ngnguyen;Password=123";
        private Form1 parent;
        public AddNewStudent(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbMSSV.Text == "" || txbName.Text == "" || txbAvg.Text == "" || cbbFaculty.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            int ms;
            string mssv = txbMSSV.Text;
            string name = txbName.Text;
            string faculty = cbbFaculty.Text;
            float dtb;
            if(mssv.Length != 8 || !int.TryParse(mssv, out ms))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ! Mã số sinh viên phải là 8 ký tự số. Ví dụ: 24521186.\n\nVui lòng nhập lại");
                return;
            }    
            if(!float.TryParse(txbAvg.Text, out dtb) || dtb < 0 || dtb > 10)
            {
                MessageBox.Show("Điểm trung bình không hợp lệ! Điểm trung bình phải nằm trong đoạn [0, 10].\n\nVui lòng nhập lại");
                txbAvg.Text = null;
                return;
            }

            string query = "INSERT INTO Student (ID, Name, Faculty, AvgPoint) VALUES (@id, @name, @faculty, @dtb)";

            // SỬA: Dùng SqlCommand và ExecuteNonQuery
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số: SQL tự động xử lý dấu nháy và kiểu dữ liệu (bao gồm cả NVARCHAR)
                command.Parameters.AddWithValue("@id", mssv);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@faculty", faculty);
                command.Parameters.AddWithValue("@dtb", dtb); // float được thêm chính xác

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Thêm sinh viên thành công!");

                    parent.LoadStudentData();
                    this.Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) 
                    {
                        MessageBox.Show($"Lỗi: Mã số sinh viên '{mssv}' đã tồn tại.", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!\n" + ex.Message, "Lỗi kết nối database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
