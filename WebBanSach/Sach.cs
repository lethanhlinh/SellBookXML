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
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
            SaveDataToXML();
            LoadDataFromXML();
            TableSach.CellClick += TableSach_CellClick;
        }
        private void SaveDataToXML()
        {
            try
            {
                string connString = "Data Source=ADMIN-PC;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM ThongTinSach";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dt.TableName = "ThongTinSach"; // Đặt tên bảng

                            // Lưu vào XML
                            string filePath = "ThongTinSach.xml";
                            dt.WriteXml(filePath, XmlWriteMode.WriteSchema);
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
                if (System.IO.File.Exists("ThongTinSach.xml"))
                {
                    DataTable dt = new DataTable();
                    dt.ReadXml("ThongTinSach.xml");  // Đọc dữ liệu từ file XML
                    TableSach.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("File ThongTinSach.xml không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void AddIntoSQL(string maSach, string tenSach, string tacGia, string nhaXuatBan, int namXuatBan, int gia, string maNhomSach)
        {
            string connString = "Data Source=ADMIN-PC;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "INSERT INTO ThongTinSach (maSach, tenSach, tacGia, nhaXuatBan, namXuatBan, gia, maNhomSach) VALUES (@maSach, @tenSach, @tacGia, @nhaXuatBan, @namXuatBan, @gia, @maNhomSach)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    cmd.Parameters.AddWithValue("@tenSach", tenSach);
                    cmd.Parameters.AddWithValue("@tacGia", tacGia);
                    cmd.Parameters.AddWithValue("@nhaXuatBan", nhaXuatBan);
                    cmd.Parameters.AddWithValue("@namXuatBan", namXuatBan);
                    cmd.Parameters.AddWithValue("@gia", gia);
                    cmd.Parameters.AddWithValue("@maNhomSach", maNhomSach);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm thông tin sách vào cơ sở dữ liệu thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu được thêm.");
                    }
                }
            }
        }

        private void AddNewRow(string maSach, string tenSach, string tacGia, string nhaXuatBan, int namXuatBan, int gia, string maNhomSach)
        {
            DataTable dt = (DataTable)TableSach.DataSource;

            if (dt != null)
            {
                DataRow newRow = dt.NewRow();
                newRow["maSach"] = maSach;
                newRow["tenSach"] = tenSach;
                newRow["tacGia"] = tacGia;
                newRow["nhaXuatBan"] = nhaXuatBan;
                newRow["namXuatBan"] = namXuatBan;
                newRow["gia"] = gia;
                newRow["maNhomSach"] = maNhomSach;

                dt.Rows.Add(newRow);
                TableSach.DataSource = dt;

                // Lưu lại vào XML
                dt.WriteXml("ThongTinSach.xml", XmlWriteMode.WriteSchema);

                // Thêm dữ liệu vào SQL
                AddIntoSQL(maSach, tenSach, tacGia, nhaXuatBan, namXuatBan, gia, maNhomSach);
            }
            else
            {
                MessageBox.Show("Không thể thêm dữ liệu vì DataTable chưa được khởi tạo.");
            }
        }


        private void UpdateSQL(string maSach, string tenSach, string tacGia, string nhaXuatBan, int namXuatBan, int gia, string maNhomSach)
        {
            string connString = "Data Source=ADMIN-PC;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "UPDATE ThongTinSach SET tenSach = @tenSach, tacGia = @tacGia, nhaXuatBan = @nhaXuatBan, " +
                               "namXuatBan = @namXuatBan, gia = @gia, maNhomSach = @maNhomSach WHERE maSach = @maSach";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    cmd.Parameters.AddWithValue("@tenSach", tenSach);
                    cmd.Parameters.AddWithValue("@tacGia", tacGia);
                    cmd.Parameters.AddWithValue("@nhaXuatBan", nhaXuatBan);
                    cmd.Parameters.AddWithValue("@namXuatBan", namXuatBan);
                    cmd.Parameters.AddWithValue("@gia", gia);
                    cmd.Parameters.AddWithValue("@maNhomSach", maNhomSach);

                    cmd.ExecuteNonQuery();
                }

                // Sau khi cập nhật dữ liệu vào SQL, gọi lại phương thức lưu XML để cập nhật dữ liệu mới
                SaveDataToXML();
            }
        }


        private void DeleteSQL(string maSach)
        {
            string connString = "Data Source=ADMIN-PC;Initial Catalog=qlSachCuaHang;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "DELETE FROM ThongTinSach WHERE maSach = @maSach";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    cmd.ExecuteNonQuery();
                }
              
                // Sau khi xóa dữ liệu từ SQL, gọi lại phương thức lưu XML để cập nhật dữ liệu mới
                SaveDataToXML();
            }
        }




        private void Them_Click(object sender, EventArgs e)
        {
            try
            {
                string maSach = MaSach.Text;
                string tenSach = TenSach.Text;
                string tacGia = TacGia.Text;
                string nhaXuatBan = NhaXuatBan.Text;
                int namXuatBan = int.Parse(NamXuatBan.Text);
                int gia = int.Parse(GiaBan.Text);
                string maNhomSach = MaNhomSach.Text;

                AddNewRow(maSach, tenSach, tacGia, nhaXuatBan, namXuatBan, gia, maNhomSach);
                AddIntoSQL(maSach, tenSach, tacGia, nhaXuatBan, namXuatBan, gia, maNhomSach);

                MessageBox.Show("Thêm sách thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void TableSach_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (TableSach.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = TableSach.SelectedRows[0];

                    MaSach.Text = selectedRow.Cells["maSach"].Value?.ToString() ?? "";
                    TenSach.Text = selectedRow.Cells["tenSach"].Value?.ToString() ?? "";
                    TacGia.Text = selectedRow.Cells["tacGia"].Value?.ToString() ?? "";
                    NhaXuatBan.Text = selectedRow.Cells["nhaXuatBan"].Value?.ToString() ?? "";
                    NamXuatBan.Text = selectedRow.Cells["namXuatBan"].Value?.ToString() ?? "";
                    GiaBan.Text = selectedRow.Cells["gia"].Value?.ToString() ?? "";
                    MaNhomSach.Text = selectedRow.Cells["maNhomSach"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //  QuanLiThuoc quanLiThuocForm = new QuanLiThuoc();
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maSach = MaSach.Text;
                string tenSach = TenSach.Text;
                string tacGia = TacGia.Text;
                string nhaXuatBan = NhaXuatBan.Text;
                int namXuatBan = int.Parse(NamXuatBan.Text);
                int gia = int.Parse(GiaBan.Text);
                string maNhomSach = MaNhomSach.Text;

                UpdateSQL(maSach, tenSach, tacGia, nhaXuatBan, namXuatBan, gia, maNhomSach);

                MessageBox.Show("Cập nhật sách thành công!");
                LoadDataFromXML();
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
                string maSach = MaSach.Text;

                DeleteSQL(maSach);

                MessageBox.Show("Xóa sách thành công!");
                LoadDataFromXML();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void TableSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng có bấm vào một ô hợp lệ không
                if (e.RowIndex >= 0) // `RowIndex` >= 0 nghĩa là không phải tiêu đề
                {
                    // Lấy hàng được chọn
                    DataGridViewRow selectedRow = TableSach.Rows[e.RowIndex];

                    // Gán dữ liệu từ hàng vào các TextBox
                    MaSach.Text = selectedRow.Cells["maSach"].Value?.ToString() ?? "";
                    TenSach.Text = selectedRow.Cells["tenSach"].Value?.ToString() ?? "";
                    TacGia.Text = selectedRow.Cells["tacGia"].Value?.ToString() ?? "";
                    NhaXuatBan.Text = selectedRow.Cells["nhaXuatBan"].Value?.ToString() ?? "";
                    NamXuatBan.Text = selectedRow.Cells["namXuatBan"].Value?.ToString() ?? "";
                    GiaBan.Text = selectedRow.Cells["gia"].Value?.ToString() ?? "";
                    MaNhomSach.Text = selectedRow.Cells["maNhomSach"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu từ bảng: " + ex.Message);
            }
        }

        private void menu2_Click(object sender, EventArgs e)
        {

        }
    }
}
