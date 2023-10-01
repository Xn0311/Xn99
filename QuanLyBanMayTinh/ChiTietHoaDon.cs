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

        SqlConnection conn = new SqlConnection(Connect.ConnectDTB);

        private void them_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Insert into ChiTietHoaDon values ('" + ttbmahd.Text + "', '" + ttbmasp.Text + "', '" + ttbsoluong.Text + "', '" + ttbgia.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Lỗi thêm dữ liệu!");
            else
                MessageBox.Show("Thêm dữ liệu thành công!");
            conn.Close();
            HienThiChiTietHoaDon();
        }

        public void HienThiChiTietHoaDon()
        {
            conn.Open();
            string query = "SELECT MaHoaDon, MaSanPham, SoLuong, Gia, SoLuong * Gia AS TongTien FROM ChiTietHoaDon";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgvct.DataSource = dt;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            HienThiChiTietHoaDon();
        }


        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update ChiTietHoaDon set MaHoaDon ='" + ttbmahd.Text + "' , MaSanPham = '" + ttbmasp.Text + "' , SoLuong= '" + ttbsoluong.Text + "', Gia = '" + ttbgia.Text +  "' where MaHoaDon =  '" + ttbmahd.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Lỗi cập nhật dữ liệu!");
            else
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            conn.Close();
            HienThiChiTietHoaDon();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "delete ChiTietHoaDon where MaHoaDon= '" + ttbmahd.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Lỗi cập nhật dữ liệu!");
            else
                MessageBox.Show("Xóa dữ liệu thành công!");
            conn.Close();
            HienThiChiTietHoaDon();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Select MaHoaDon, MaSanPham, SoLuong, Gia, SoLuong * Gia AS TongTien FROM ChiTietHoaDon where MaHoaDon = '" + txttk.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgvct.DataSource = dt;
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            TrangChu c = new TrangChu();
            c.Show();
            this.Hide();
        }

        private void dgvct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvct.CurrentCell.RowIndex;
            ttbmahd.Text = dgvct.Rows[t].Cells[0].Value.ToString();
            ttbmasp.Text = dgvct.Rows[t].Cells[1].Value.ToString();
            ttbsoluong.Text = dgvct.Rows[t].Cells[2].Value.ToString();
            ttbgia.Text = dgvct.Rows[t].Cells[3].Value.ToString();
            ttbtongtien.Text = dgvct.Rows[t].Cells[4].Value.ToString();
        }
    }
}
