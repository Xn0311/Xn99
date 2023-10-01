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
        SqlConnection conn = new SqlConnection(Connect.ConnectDTB);

        private void btTHEM_Click(object sender, EventArgs e)
        {

            conn.Open();
            string query = "Insert into KhachHang values ('" + txtMaKhachHang.Text + "', N'" + txtTenKH.Text + "', N'" + txtGioiTinh.Text + "', '" + dtpngaysinh.Value.ToString("yyyy-MM-dd") + "', N'" + txtDiaChi.Text + "', '" + txtSdt.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Lỗi thêm dữ liệu!");
            else
                MessageBox.Show("Thêm dữ liệu thành công!");
            conn.Close();
            HienThiKhachHang();
        }

        public void HienThiKhachHang()
        {
            conn.Open();
            string query = "SELECT * FROM KhachHang";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgvkh.DataSource = dt;
        }

        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            HienThiKhachHang();
        }       

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update KhachHang set MaKhachHang ='" + txtMaKhachHang.Text + "' , TenKhachHang = N'" + txtTenKH.Text + "' , GioiTinh= N'" + txtGioiTinh.Text + "', NgaySinh = '" + dtpngaysinh.Value.ToString("yyyy-MM-dd") + "', DiaChi = N'" + txtDiaChi.Text + "', SDT = '" + txtSdt.Text + "' where MaKhachHang =  '" + txtMaKhachHang.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Lỗi cập nhật dữ liệu!");
            else
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            conn.Close();
            HienThiKhachHang();
        }

        private void btXOA_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "delete KhachHang where MaKhachHang= '" + txtMaKhachHang.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Lỗi cập nhật dữ liệu!");
            else
                MessageBox.Show("Xóa dữ liệu thành công!");
            conn.Close();
            HienThiKhachHang();
        }

        private void btTIMKIEM_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from KhachHang where MaKhachHang = '" + txttk.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgvkh.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrangChu c = new TrangChu();
            c.Show();
            this.Hide();
        }

        private void dgvkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvkh.CurrentCell.RowIndex;
            txtMaKhachHang.Text = dgvkh.Rows[t].Cells[0].Value.ToString();
            txtTenKH.Text = dgvkh.Rows[t].Cells[1].Value.ToString();
            txtGioiTinh.Text = dgvkh.Rows[t].Cells[2].Value.ToString();
            dtpngaysinh.Text = dgvkh.Rows[t].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvkh.Rows[t].Cells[4].Value.ToString();
            txtSdt.Text = dgvkh.Rows[t].Cells[5].Value.ToString();
        }
    }
}
