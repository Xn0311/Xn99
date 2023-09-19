using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanMayTinh
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanViencs nv = new NhanViencs();
            nv.ShowDialog();
            this.Show();
        }

        private void muaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MuaBan mb = new MuaBan();
            mb.ShowDialog();
            this.Show();
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KHACHHANG kh = new KHACHHANG();
            kh.ShowDialog();
            this.Show();
        }
        private void SanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham sp = new SanPham();
            sp.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
