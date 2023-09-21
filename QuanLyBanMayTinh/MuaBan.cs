using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanMayTinh
{
    public partial class MuaBan : Form
    {
        public MuaBan()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanViencs nv = new NhanViencs();
            nv.ShowDialog();
            this.Show();
        }

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public string chuoikh = "Select * from KhachHang kh";
        public string chuoidm = "select * from SanPham sp";
        
        // show thông tin máy tính 

        // show thông tin khách hàng
        public void showData(DataGridView dgv,string s)
        {
            con = new SqlConnection(Connect.ConnectDTB );
            con.Open();
            cmd = new SqlCommand(s, con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            dgv.DataSource = tb;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void muaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MuaBan mb = new MuaBan();
            mb.ShowDialog();
            this.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MuaBan_Load(object sender, EventArgs e)
        {

            showData(dgvDongMay,chuoidm);
            showData(dgvKhachHang,chuoikh);
            
        }

        private void txtTimDongMay_Enter(object sender, EventArgs e)
        {

        }

        private void txtTimDongMay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string str = "select sp.TenSanPham,sp.HangSX,sp.ThongSo,sp.TGBaoHanh from SanPham sp where TenSanPham LIKE '%" + txtTimDongMay.Text + "%'";
                showData(dgvDongMay, str);
                dgvDongMay.Refresh();

            }
        }

        private void txtTimKhach_KeyDown(object sender, KeyEventArgs e)
        {   if (e.KeyCode == Keys.Enter)
            {
                string str = "select kh.TenKhachHang,kh.GioiTinh,kh.NgaySinh,kh.SDT from KhachHang kh  where TenKhachHang LIKE '%" + txtTimKhach.Text + "%'";
                showData(dgvKhachHang, str);
                dgvKhachHang.Refresh();

            }


        }

        private void dgvDongMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            string Masp;
            string MaHd;
            string Hangsx;
            int SoLuong = Convert.ToInt32(nudSoLuong.Value);
            double Gia;
            string MaKh;
            DateTime GetNow = DateTime.Now;
            MaHd = "1";
            Masp = dgvDongMay.Rows[e.RowIndex].Cells[0].Value.ToString();
            Hangsx = dgvDongMay.Rows[e.RowIndex].Cells[2].Value.ToString();
            MaKh = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            
           
        }
        
    }
}
