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






        void load_data()
        {
            SqlConnection con = new SqlConnection(Connect.ConnectDTB);
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
            string Manv = txtMaNv.Text;
            string Ten = txtTenNhanVien.Text;
            DateTime date = dtpNgaySinh.Value;
            string gt = txtGioiTinh.Text;
            string chucvu = txtChucVu.Text;
            string tt = txtTTLH.Text;
            try
            {
                SqlConnection con = new SqlConnection(Connect.ConnectDTB);

                SqlCommand cmd = new SqlCommand("insert into Nhanvien values('" + Manv + "',N'" + Ten + "','" + date + "',N'" + gt + "',N'" + chucvu + "','" + tt + "')", con);
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
                string Manv = txtMaNv.Text;
                string Ten = txtTenNhanVien.Text;
                DateTime date = dtpNgaySinh.Value;
                string gt = txtGioiTinh.Text;
                string chucvu = txtChucVu.Text;
                string tt = txtTTLH.Text;

                SqlConnection con = new SqlConnection(Connect.ConnectDTB);
                SqlCommand cmd = new SqlCommand("update NhanVien set TenNV = N'" + Ten + "',NgaySinh = '" + date + "',GioiTinh = N'" + gt + "',ChucVu = N'" + chucvu + "',ThongTinLienHe = N'" + tt + "'where MaNV='" + Manv + "'", con);
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
                SqlConnection con = new SqlConnection(Connect.ConnectDTB);
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
            SqlConnection con = new SqlConnection(Connect.ConnectDTB);
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien where TenNV LIKE '%" + txtTenNhanVien.Text + "%'", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dgvnv.DataSource = dt;

            con.Close();
        }
    }
}
