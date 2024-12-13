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
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
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
    }
}
