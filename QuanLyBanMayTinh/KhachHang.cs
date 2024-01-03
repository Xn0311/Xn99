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
    public partial class KHACHHANG : Form
    {
        public KHACHHANG()
        {
            InitializeComponent();
        }
        QuanLy QuanLy = new QuanLy();
        private void btTHEM_Click(object sender, EventArgs e)
        {
            string query = "Insert into KhachHang values ('" + txtMaKhachHang.Text + "', N'" + txtTenKH.Text + "', N'" + txtGioiTinh.Text + "', '" + dtpngaysinh.Value.ToString("yyyy-MM-dd") + "', N'" + txtDiaChi.Text + "', '" + txtSdt.Text + "')";
            QuanLy.Executenonquery(query, dgvkh);
            dgvkh.Refresh();   
        }
        public void Hienthikhachhang()
        {
            QuanLy.Executenonquery("select * from khachhang", dgvkh);
        }
        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            Hienthikhachhang();
        }       
        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            string query = "update KhachHang set MaKhachHang ='" + txtMaKhachHang.Text + "' , TenKhachHang = N'" + txtTenKH.Text + "' , GioiTinh= N'" + txtGioiTinh.Text + "', NgaySinh = '" + dtpngaysinh.Value.ToString("yyyy-MM-dd") + "', DiaChi = N'" + txtDiaChi.Text + "', SDT = '" + txtSdt.Text + "' where MaKhachHang =  '" + txtMaKhachHang.Text + "'";
            if (MessageBox.Show("Bạn có muốn sửa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QuanLy.Executenonquery(query,dgvkh);
            }
            Hienthikhachhang();
        }
        private void btXOA_Click(object sender, EventArgs e)
        {
            string query = "delete KhachHang where MaKhachHang= '" + txtMaKhachHang.Text + "'";
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QuanLy.Executenonquery(query,dgvkh);
            }
            Hienthikhachhang();
        }
        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvkh.Rows[e.RowIndex];
                txtMaKhachHang.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtGioiTinh.Text = row.Cells[2].Value.ToString();
                dtpngaysinh.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtSdt.Text = row.Cells[5].Value.ToString();
            }
        }
        private void txttk_TextChanged(object sender, EventArgs e)
        {
            string query = "select kh.MaKhachHang, kh.TenKhachHang,kh.GioiTinh,kh.NgaySinh,kh.DiaChi,kh.SDT from KhachHang kh  where TenKhachHang LIKE '%" + txttk.Text + "%'";
            QuanLy.Executenonquery(query,dgvkh);
            dgvkh.Refresh();
        }
    }
}
