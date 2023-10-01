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
        SqlConnection con = new SqlConnection(Connect.ConnectDTB);
        void load_data()
        {         
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dgvnv.DataSource = dt;
            dgvnv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvnv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void NhanViencs_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void btTHEM_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Nhanvien values('" + txtMaNv.Text + "',N'" + txtTenNhanVien.Text + "','" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "',N'" + txtGioiTinh.Text + "',N'" + txtChucVu.Text + "','" + txtTTLH.Text + "')", con);
                con.Open();
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    MessageBox.Show("Thêm Thành Công");
                con.Close();
                load_data();

            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập thông tin");
            }
        }

        private void btSUA_Click(object sender, EventArgs e)
        {
            try
            {
  
                SqlCommand cmd = new SqlCommand("update NhanVien set MaNV = '" + txtMaNv.Text + "' , TenNV = N'" + txtTenNhanVien.Text + "', NgaySinh = '" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "', GioiTinh = N'" + txtGioiTinh.Text + "', ChucVu = N'" + txtChucVu.Text + "', ThongTinLienHe = N'" + txtTTLH.Text + "'where MaNV='" + txtMaNv.Text + "'", con);
                con.Open();
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    MessageBox.Show("Cập Nhật Thành Công");
                con.Close();
                load_data();
            }
            catch
            {
                MessageBox.Show("Bạn Chưa nhập thông tin");
            }
        }

        private void btXOA_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("delete from NhanVien where MaNV ='" + txtMaNv.Text + "'", con);
                con.Open();
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    MessageBox.Show(" Xóa Thành Công");

                con.Close();
                load_data();

            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập thông tin");
            }
        }

        private void btTIMKIEM_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from NhanVien where MaNV = '" + ttbtk.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvnv.DataSource = dt;
        }

        private void ttbtk_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvnv.CurrentCell.RowIndex;
            txtMaNv.Text = dgvnv.Rows[t].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgvnv.Rows[t].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvnv.Rows[t].Cells[2].Value.ToString();
            txtGioiTinh.Text = dgvnv.Rows[t].Cells[3].Value.ToString();
            txtChucVu.Text = dgvnv.Rows[t].Cells[4].Value.ToString();
            txtTTLH.Text = dgvnv.Rows[t].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrangChu c = new TrangChu();
            c.Show();
            this.Hide();
        }
    }
}
