using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBanSach
{
    public partial class TKSach : Form
    {
        public TKSach()
        {
            InitializeComponent();
            LoadAllBooks(); // Tải tất cả sách khi form mở
        }

        private void LoadAllBooks()
        {
            string connString = "Data Source=ADMIN-PC;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM ThongTinSach"; // 
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewSach.DataSource = dt; // Hiển thị tất cả dữ liệu
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Home quanLiThuocForm = new Home();
                quanLiThuocForm.Show();
                this.Hide();
            }
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text.Trim();
            string tenSach = txtTenSach.Text.Trim();

            // Gọi hàm tìm kiếm
            SearchBook(maSach, tenSach);
        }

        private void SearchBook(string maSach, string tenSach)
        {
            string connString = "Data Source=ADMIN-PC;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM ThongTinSach WHERE 1=1"; // Bắt đầu với điều kiện luôn đúng

                if (!string.IsNullOrEmpty(maSach))
                {
                    query += " AND maSach = @maSach";
                }

                if (!string.IsNullOrEmpty(tenSach))
                {
                    query += " AND tenSach LIKE @tenSach"; // Sử dụng LIKE cho tìm kiếm tên
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(maSach))
                    {
                        cmd.Parameters.AddWithValue("@maSach", maSach);
                    }

                    if (!string.IsNullOrEmpty(tenSach))
                    {
                        cmd.Parameters.AddWithValue("@tenSach", "%" + tenSach + "%"); // Thêm ký tự "%" để tìm kiếm
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewSach.DataSource = dt; // Hiển thị kết quả trên DataGridView
                    }
                }
            }
        }

    }
}
