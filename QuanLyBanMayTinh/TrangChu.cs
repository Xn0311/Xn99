using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLyBanMayTinh
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent(); 
            //Logincs logincs = new Logincs();
        }
        //public int  MyVariable = logincs.MyVariable;
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
            ThongkeBc nv = new ThongkeBc();
            nv.ShowDialog();
            this.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon hd = new HoaDon();
            hd.ShowDialog();
            this.Show();
        }

        private void quảnLýChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.ShowDialog();
            this.Show();
        }

        private void quảnLýKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KHACHHANG kh = new KHACHHANG();
            kh.ShowDialog();
            this.Show();
        }

        private void quảnLýSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham sp = new SanPham();
            sp.ShowDialog();
            this.Show();
        }

        private void trợGiúpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ 'Liêu Xuân Nghĩa' để giải quyết tình huống mắc phải");
            string url = "https://www.facebook.com/LieuXuanNghia";
            DialogResult result = MessageBox.Show("Bạn có muốn liên hệ trang cá nhân này không ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Process.Start(url);
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }



        private void grbpic_Enter(object sender, EventArgs e)
        {

        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTaiKhoan qltk = new QLTaiKhoan();
            this.Hide();
            qltk.ShowDialog();
            this.Show();
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddHoaDon mb = new AddHoaDon();
            mb.ShowDialog();
            this.Show();

        }
    }
}
