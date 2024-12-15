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
    public partial class TKNhanVien : Form
    {
        public TKNhanVien()
        {
            InitializeComponent();
            LoadAllEmployees(); // Tải tất cả nhân viên khi form mở
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Home qls = new Home();
                qls.Show();
                this.Hide();
            }
        }
        private void LoadAllEmployees()
        {
            string connString = "Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM NhanVien";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewNV.DataSource = dt; // Hiển thị tất cả dữ liệu
                    }
                }
            }
        }
        private void TimKiem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();

            // Gọi hàm tìm kiếm
            SearchEmployee(maNV, tenNV);
        }

        private void SearchEmployee(string maNV, string tenNV)
        {
            string connString = "Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM NhanVien WHERE 1=1"; // Bắt đầu với điều kiện luôn đúng

                if (!string.IsNullOrEmpty(maNV))
                {
                    query += " AND maNV = @maNV";
                }

                if (!string.IsNullOrEmpty(tenNV))
                {
                    query += " AND tenNV LIKE @tenNV"; // Sử dụng LIKE cho tìm kiếm tên
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(maNV))
                    {
                        cmd.Parameters.AddWithValue("@maNV", maNV);
                    }

                    if (!string.IsNullOrEmpty(tenNV))
                    {
                        cmd.Parameters.AddWithValue("@tenNV", "%" + tenNV + "%"); // Thêm ký tự "%" để tìm kiếm
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewNV.DataSource = dt; // Hiển thị kết quả trên DataGridView
                    }
                }
            }
        }
    }
}
