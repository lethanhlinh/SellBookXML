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

        private void menu4_Click(object sender, EventArgs e)
        {
             BanGiao bg = new BanGiao();
            bg.Show();
            this.Hide();
        }

        private void TìmKiếmbgToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
    }
}
