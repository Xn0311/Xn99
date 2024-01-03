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
            QuanLy.Executenonquery("select * form NhanVien",dgvnv);
        }

        private void NhanViencs_Load(object sender, EventArgs e)
        {
            Hienthithongtin();
        }

        private void btTHEM_Click(object sender, EventArgs e)
        {
            string query = " insert into Nhanvien values(' " + txtMaNv.Text +  "',N' " + txtTenNhanVien.Text +  "',' " + dtpNgaySinh.Value.ToString( "yyyy-MM-dd ") +  "',N' " + txtGioiTinh.Text +  "',N' " + txtChucVu.Text +  "',' " + txtTTLH.Text +  "')";
            QuanLy.Executenonquery(query,dgvnv);
            Hienthithongtin();
        }

        private void btSUA_Click(object sender, EventArgs e)
        {
            string query = "update NhanVien set MaNV = ' " + txtMaNv.Text +  "' , TenNV = N' " + txtTenNhanVien.Text +  "', NgaySinh = ' " + dtpNgaySinh.Value.ToString( "yyyy-MM-dd ") +  "', GioiTinh = N' " + txtGioiTinh.Text +  "', ChucVu = N' " + txtChucVu.Text +  "', ThongTinLienHe = N' " + txtTTLH.Text +  "'where MaNV=' " + txtMaNv.Text +  "' ";
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        }
        private void ttbtk_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from NhanVien where TenNV LIKE " + txtTimKiem.Text + "%'";
            QuanLy.Executenonquery(query, dgvnv);
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
