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
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
            SaveDataToXML();
            LoadDataFromXML();

            TableSachNhap.CellClick += TableSach_CellClick;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Home quanLiThuocForm = new Home();
                quanLiThuocForm.Show();
                this.Hide();
            }
        }

        private void SaveDataToXML()
        {
            try
            {
                string connString = "Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM SachNhap";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dt.TableName = "SachNhap";
                            dt.WriteXml("SachNhap.xml", XmlWriteMode.WriteSchema); // Lưu vào XML
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
                if (System.IO.File.Exists("SachNhap.xml"))
                {
                    DataTable dt = new DataTable();
                    dt.ReadXml("SachNhap.xml");
                    TableSachNhap.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("File SachNhap.xml không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void AddIntoSQL(string maNhap, string maSach, DateTime ngayNhap, int soLuong, int giaBan, string trangThai)
        {
            string connString = "Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "INSERT INTO SachNhap (maNhap, maSach, ngayNhap, soLuong, giaBan, thanhTien, trangThai) " +
                               "VALUES (@maNhap, @maSach, @ngayNhap, @soLuong, @giaBan, 0, @trangThai)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maNhap", maNhap);
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    cmd.Parameters.AddWithValue("@ngayNhap", ngayNhap);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@giaBan", giaBan);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thông tin sách nhập thành công.");
                }
            }
        }

        private void AddNewRow(string maNhap, string maSach, DateTime ngayNhap, int soLuong, int giaBan, string trangThai)
        {
            DataTable dt = (DataTable)TableSachNhap.DataSource;

            if (dt != null)
            {
                DataRow newRow = dt.NewRow();
                newRow["maNhap"] = maNhap;
                newRow["maSach"] = maSach;
                newRow["ngayNhap"] = ngayNhap;
                newRow["soLuong"] = soLuong;
                newRow["giaBan"] = giaBan;
                newRow["trangThai"] = trangThai;

                dt.Rows.Add(newRow);
                TableSachNhap.DataSource = dt;

                // Lưu lại vào XML
                dt.WriteXml("SachNhap.xml", XmlWriteMode.WriteSchema);

                // Thêm dữ liệu vào SQL
                AddIntoSQL(maNhap, maSach, ngayNhap, soLuong, giaBan, trangThai);
            }
            else
            {
                MessageBox.Show("Không thể thêm dữ liệu vì DataTable chưa được khởi tạo.");
            }
        }

        private void UpdateSQL(string maNhap, string maSach, DateTime ngayNhap, int soLuong, int giaBan, string trangThai)
        {
            string connString = "Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE SachNhap SET maSach = @maSach, ngayNhap = @ngayNhap, soLuong = @soLuong, " +
                               "giaBan = @giaBan, trangThai = @trangThai WHERE maNhap = @maNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maNhap", maNhap);
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    cmd.Parameters.AddWithValue("@ngayNhap", ngayNhap);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@giaBan", giaBan);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);

                    cmd.ExecuteNonQuery();
                }
            }
            SaveDataToXML(); // Cập nhật XML sau khi sửa
        }

        private void DeleteSQL(string maNhap)
        {
            string connString = "Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM SachNhap WHERE maNhap = @maNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maNhap", maNhap);
                    cmd.ExecuteNonQuery();
                }
            }
            SaveDataToXML(); // Cập nhật XML sau khi xóa
        }

        private void Them_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhap = MaNhap.Text;
                string maSach = MaSach.Text;
                DateTime ngayNhap = DateTime.Parse(dtpNgayNhap.Text);
                int soLuong = int.Parse(SoLuong.Text);
                int giaBan = int.Parse(GiaBan.Text);
                string trangThai = TrangThai.Text;

                AddNewRow(maNhap, maSach, ngayNhap, soLuong, giaBan, trangThai);
                MessageBox.Show("Thêm sách nhập thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void TrangThai_Click(object sender, EventArgs e)
        {

        }

        private void TableSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Kiểm tra hàng hợp lệ
                {
                    DataGridViewRow selectedRow = TableSachNhap.Rows[e.RowIndex];
                    MaNhap.Text = selectedRow.Cells["maNhap"].Value?.ToString() ?? "";
                    MaSach.Text = selectedRow.Cells["maSach"].Value?.ToString() ?? "";
                    dtpNgayNhap.Text = selectedRow.Cells["ngayNhap"].Value?.ToString() ?? "";
                    SoLuong.Text = selectedRow.Cells["soLuong"].Value?.ToString() ?? "";
                    GiaBan.Text = selectedRow.Cells["giaBan"].Value?.ToString() ?? "";
                    TrangThai.Text = selectedRow.Cells["trangThai"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu từ bảng: " + ex.Message);
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhap = MaNhap.Text;
                string maSach = MaSach.Text;
                DateTime ngayNhap = DateTime.Parse(dtpNgayNhap.Text);
                int soLuong = int.Parse(SoLuong.Text);
                int giaBan = int.Parse(GiaBan.Text);
                string trangThai = TrangThai.Text;

                UpdateSQL(maNhap, maSach, ngayNhap, soLuong, giaBan, trangThai);
                MessageBox.Show("Cập nhật sách nhập thành công!");
                LoadDataFromXML(); // Tải lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhap = MaNhap.Text;
                DeleteSQL(maNhap);
                MessageBox.Show("Xóa sách nhập thành công!");
                LoadDataFromXML(); // Tải lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
