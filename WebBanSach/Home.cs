using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBanSach
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.Show();
            this.Hide();
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
            this.Hide();
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            Kho Form3 = new Kho();
            Form3.Show();
            this.Hide();
        }

     

        private void TìmKiếmbgToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void TìmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKNhanVien tknv = new TKNhanVien();
            tknv.Show();    
            this.Hide();
        }

        private void TìmKiếmThuốcBànGiaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKSach tks = new TKSach();
            tks.Show();
            this.Hide();
        }

        private void tKSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKSach tks = new TKSach();
            tks.Show();
            this.Hide();
        }

        private void ĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }
    }
}
