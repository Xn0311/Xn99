using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanMayTinh
{
    public partial class TrangchuUser : Form
    {
        public TrangchuUser()
        {
            InitializeComponent();
        }

        
        private void muaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddHoaDon mb = new AddHoaDon();
            mb.ShowDialog();
            this.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KHACHHANG kHACHHANG = new KHACHHANG();
            this.Hide();
            kHACHHANG.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ 'Liêu Xuân Nghĩa' để giải quyết tình huống mắc phải");
            string url = "https://www.facebook.com/LieuXuanNghia";
            DialogResult result = MessageBox.Show("Bạn có muốn liên hệ trang cá nhân này không ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Process.Start(url);
            }
        }
    }
}
