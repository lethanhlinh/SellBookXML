using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBanSach
{
    public partial class BanGiao : Form
    {
        public BanGiao()
        {
            InitializeComponent();
            LoadDataFromXML();
            SaveDataToXML();
            Display2();
            Display1();

        }

        private void SaveDataToXML()
        {
            try
            {
                string connString = "Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;Encrypt=True;";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Truy vấn bảng BanSach
                    string query = "SELECT * FROM BanSach";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dt.TableName = "BanSach"; // Đặt tên cho bảng

                            if (dt.Rows.Count > 0)
                            {
                                string filePath = "BanSach.xml";
                                dt.WriteXml(filePath, XmlWriteMode.WriteSchema);
                            }
                            else
                            {
                                MessageBox.Show("Không có dữ liệu từ bảng BanSach.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadDataFromXML()
        {
            try
            {
                DataTable dt = new DataTable();

                // Đọc dữ liệu từ file BanSach.xml
                dt.ReadXml("BanSach.xml");

                // Gán dữ liệu vào DataGridView
                TableBGT.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void AddIntoSQL(string maBan, string maNV, string maSach, string donVi, DateTime ngayBan)
        {
            string connString = "Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;Encrypt=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "INSERT INTO BanSach (maBan, maNV, maSach, donVi, ngayBan) VALUES (@maBan, @maNV, @maSach, @donVi, @ngayBan)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm tham số với giá trị tương ứng
                    cmd.Parameters.AddWithValue("@maBan", maBan);
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    cmd.Parameters.AddWithValue("@donVi", donVi);
                    cmd.Parameters.AddWithValue("@ngayBan", ngayBan);

                    // Thực thi câu lệnh INSERT
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Thêm thành công
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu được thêm.");
                    }
                }
            }
        }


        private void AddNewRow(string maBan, string maNV, string maSach, string donVi, DateTime ngayBan)
        {
            try
            {
                // Kiểm tra nếu DataSource của TableBGT là DataTable
                if (TableBGT.DataSource is DataTable dt)
                {
                    // Tạo một hàng mới và gán giá trị
                    DataRow newRow = dt.NewRow();
                    newRow["maBan"] = maBan;
                    newRow["maNV"] = maNV;
                    newRow["maSach"] = maSach;
                    newRow["donVi"] = donVi;
                    newRow["ngayBan"] = ngayBan;

                    // Thêm hàng mới vào DataTable
                    dt.Rows.Add(newRow);

                    // Lưu DataTable vào XML (tùy chọn, nếu muốn lưu trạng thái)
                    dt.WriteXml("BanSach.xml", XmlWriteMode.WriteSchema);

                    // Cập nhật lại DataSource cho DataGridView
                    TableBGT.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không thể thêm dữ liệu vì DataSource chưa được khởi tạo hoặc không đúng kiểu DataTable.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void UpdateRowInSQL(string maBan, string maNV, string maSach, string donVi, DateTime ngayBan)
        {
            try
            {
                string connString = "Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;Encrypt=True;";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
            UPDATE BanSach 
            SET maNV = @maNV, maSach = @maSach, donVi = @donVi, ngayBan = @ngayBan 
            WHERE maBan = @maBan";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gắn tham số cho câu lệnh SQL
                        cmd.Parameters.AddWithValue("@maBan", maBan);
                        cmd.Parameters.AddWithValue("@maNV", maNV);
                        cmd.Parameters.AddWithValue("@maSach", maSach);
                        cmd.Parameters.AddWithValue("@donVi", donVi);
                        cmd.Parameters.AddWithValue("@ngayBan", ngayBan);

                        // Thực thi câu lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Cập nhật thành công
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bản ghi bán sách để cập nhật.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void Display1()
        {
            try
            {
                string connString = "Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;Encrypt=True;";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // SQL Query để lấy thông tin
                    string query = "SELECT DISTINCT maSach FROM ThongTinSach";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Xóa các mục hiện tại trong ComboBox
                        MaThuoc.Items.Clear();

                        // Duyệt qua các dữ liệu và thêm vào ComboBox
                        while (reader.Read())
                        {
                            MaThuoc.Items.Add(reader["maSach"].ToString());
                        }

                        reader.Close();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void Display2()
        {
            try
            {
                string connString = "Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;Encrypt=True;";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // SQL Query để lấy thông tin nhân viên
                    string query = "SELECT DISTINCT maNV FROM NhanVien";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Xóa các mục hiện tại trong ComboBox
                        MaNV.Items.Clear();

                        // Duyệt qua các dữ liệu và thêm vào ComboBox
                        while (reader.Read())
                        {
                            MaNV.Items.Add(reader["maNV"].ToString());
                        }

                        reader.Close();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }




        private void menu4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Home quanLiThuocForme = new Home();
                quanLiThuocForme.Show();
                this.Hide();
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các ô nhập
                string maBG = MaBG.Text; // Mã bàn giao
                string maNV = MaNV.Text; // Mã nhân viên
                string maThuoc = MaThuoc.Text; // Mã thuốc
                string phong = Phong.Text; // Phòng
                DateTime ngayBanGiao = NgayBanGiao.Value; // Ngày bàn giao (định dạng yyyy-MM-dd)

                // Gọi hàm thêm vào DataGridView và SQL
                AddNewRow(maBG, maNV, maThuoc, phong, ngayBanGiao);
                AddIntoSQL(maBG, maNV, maThuoc, phong, ngayBanGiao);

                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm bàn giao thuốc thành công!");
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
        }
    }
}
