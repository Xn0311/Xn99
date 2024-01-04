using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanMayTinh
{
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }
        public void HienThiChiTietHoaDon()
        {
            string query = "SELECT MaHoaDon, MaSanPham, SoLuong, Gia, SoLuong * Gia AS TongTien FROM ChiTietHoaDon";
            QuanLy.Executenonquery(query,dgvct);
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            HienThiChiTietHoaDon();
        }
        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            string query = "update ChiTietHoaDon set MaHoaDon ='" + ttbmahd.Text + "' , MaSanPham = '" + ttbmasp.Text + "' , SoLuong= '" + ttbsoluong.Text + "', Gia = '" + ttbgia.Text +  "' where MaHoaDon =  '" + ttbmahd.Text + "'";
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QuanLy.Executenonquery(query, dgvct);
            }
            HienThiChiTietHoaDon();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
          
            string query = "delete ChiTietHoaDon where MaHoaDon= '" + ttbmahd.Text + "'";
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QuanLy.Executenonquery(query, dgvct);
            }
            HienThiChiTietHoaDon();
        }
        private void dgvct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvct.Rows[e.RowIndex];
                ttbmahd.Text = row.Cells[0].Value.ToString();
                ttbmasp.Text = row.Cells[1].Value.ToString();
                ttbsoluong.Text = row.Cells[2].Value.ToString();
                ttbgia.Text = row.Cells[3].Value.ToString();
                ttbtongtien.Text = row.Cells[4].Value.ToString();           
            }
        }
        private void txttk_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from ChiTietHoaDon where MaHoaDon LIKE N'%" + txttk.Text + "%'";
            QuanLy.Executenonquery(query, dgvct);
            dgvct.Refresh();
        }
    }
}
