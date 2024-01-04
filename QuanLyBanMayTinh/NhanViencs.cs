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
    public partial class NhanViencs : Form
    {
        public NhanViencs()
        {
            InitializeComponent();
        }
        QuanLy QuanLy = new QuanLy();
        void Hienthithongtin()
        {
            string query = "select * from NhanVien";
            QuanLy.Executenonquery(query,dgvnv);
        }
        private void NhanViencs_Load(object sender, EventArgs e)
        {
            Hienthithongtin();
        }
        private void btTHEM_Click(object sender, EventArgs e)
        {
            string query = " insert into Nhanvien values('" + txtMaNv.Text +  "',N' " + txtTenNhanVien.Text +  "',' " + dtpNgaySinh.Value.ToString( "yyyy-MM-dd ") +  "',N' " + txtGioiTinh.Text +  "',N' " + txtChucVu.Text +  "',' " + txtTTLH.Text +  "')";
            QuanLy.Executenonquery(query,dgvnv);
            Hienthithongtin();
        }
        private void btSUA_Click(object sender, EventArgs e)
        {
            string query = "update NhanVien set TenNV = N'"+txtTenNhanVien.Text+"',NgaySinh = '"+ dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "',GioiTinh = '"+txtGioiTinh.Text+"',ChucVu =N'"+txtChucVu.Text+"',ThongTinLienHe = '"+txtTTLH.Text+"' where MaNV = '"+txtMaNv.Text+"'";
            if (MessageBox.Show("Bạn có muốn SỬA bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QuanLy.Executenonquery(query,dgvnv);
            }
            Hienthithongtin();
        }
        private void btXOA_Click(object sender, EventArgs e)
        {
          string query = "delete from NhanVien where MaNV ='" + txtMaNv.Text + "'";
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QuanLy.Executenonquery(query, dgvnv);
            }
            Hienthithongtin();
        }
        private void ttbtk_TextChanged(object sender, EventArgs e)
        {
            string query = "select nv.MaNV,nv.TenNV,nv.NgaySinh,nv.GioiTinh,nv.ChucVu,nv.ThongTinLienHe from NhanVien nv where TenNV LIKE N'%" + txtTimKiem.Text + "%'";
            QuanLy.Executenonquery(query,dgvnv);
            dgvnv.Refresh();
        }
        private void dgvnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvnv.Rows[e.RowIndex];
                txtMaNv.Text = row.Cells[0].Value.ToString();
                txtTenNhanVien.Text = row.Cells[1].Value.ToString();
                dtpNgaySinh.Text = row.Cells[2].Value.ToString();
                txtGioiTinh.Text = row.Cells[3].Value.ToString();
                txtChucVu.Text = row.Cells[4].Value.ToString();
                txtTTLH.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
