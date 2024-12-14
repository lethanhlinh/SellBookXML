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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebBanSach
{
    public partial class TKBanGiao : Form
    {

        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataSet ds;
        public TKBanGiao()
        {
            InitializeComponent();
        }

        public void Display()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            con = new SqlConnection("Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;Encrypt=True;");
            con.Open();

            // Câu truy vấn để lấy tất cả dữ liệu từ bảng BanSach
            string query = "SELECT * FROM BanSach";
            cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);

            // Gán dữ liệu cho DataGrid
            DataGrid1.DataSource = ds.Tables[0];

            // Đặt tiêu đề cột
            DataGrid1.Columns["maBan"].HeaderText = "Mã Bán";
            DataGrid1.Columns["maNV"].HeaderText = "Mã Nhân Viên";
            DataGrid1.Columns["maSach"].HeaderText = "Mã Sách";
            DataGrid1.Columns["donVi"].HeaderText = "Đơn Vị";
            DataGrid1.Columns["ngayBan"].HeaderText = "Ngày Bán";

            // Đóng kết nối
            con.Close();
        }



        private void TimKiemBanSach()
        {
            // Tạo câu truy vấn cơ bản
            string query = "SELECT * FROM BanSach WHERE 1 = 1";

            // Danh sách điều kiện tìm kiếm
            List<string> conditions = new List<string>();

            // Kiểm tra TextBox cho từng điều kiện

            if (!string.IsNullOrWhiteSpace(TextBox3.Text)) // Tìm theo mã nhân viên
            {
                conditions.Add("maNV LIKE @maNV");
            }

            if (!string.IsNullOrWhiteSpace(TextBox1.Text)) // Tìm theo mã sách
            {
                conditions.Add("maSach LIKE @maSach");
            }

            if (!string.IsNullOrWhiteSpace(Textbox2.Text)) // Tìm theo đơn vị bán
            {
                conditions.Add("donVi LIKE @donVi");
            }


            // Ghép các điều kiện vào câu truy vấn
            if (conditions.Count > 0)
            {
                query += " AND " + string.Join(" AND ", conditions);
            }

            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection("Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;Encrypt=True;"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Thêm tham số tìm kiếm

                        if (conditions.Contains("maNV LIKE @maNV"))
                        {
                            cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = "%" + TextBox3.Text + "%";
                        }

                        if (conditions.Contains("maSach LIKE @maSach"))
                        {
                            cmd.Parameters.Add("@maSach", SqlDbType.Char).Value = "%" + TextBox1.Text + "%";
                        }

                        if (conditions.Contains("donVi LIKE @donVi"))
                        {
                            cmd.Parameters.Add("@donVi", SqlDbType.NVarChar).Value = "%" + Textbox2.Text + "%";
                        }

                        // Thực thi câu lệnh và lấy dữ liệu
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "BanSach");

                        // Gán dữ liệu vào DataGrid
                        DataGrid1.DataSource = ds.Tables["BanSach"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TKBanGiao_Load(object sender, EventArgs e)
        {
            Display();
            con = new SqlConnection("Data Source=quancutee\\QUANCUTEE;Initial Catalog=qlSachCuaHang;Integrated Security=True;Encrypt=True;");
            con.Open();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                TimKiemBanSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }
    }
}
