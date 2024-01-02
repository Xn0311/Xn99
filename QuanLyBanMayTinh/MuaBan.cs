using System;
using System.Collections;
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
        MuaBanManager mb = new MuaBanManager();
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanViencs nv = new NhanViencs();
            nv.ShowDialog();
            this.Show();
        }

        //SqlCommand cmd;
      //  SqlConnection con;
      //  SqlDataAdapter da;
        public string QueryKhachHang = "Select * from KhachHang kh";
        public string QuerySanPham = "select * from SanPham sp";
        private void muaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MuaBan mb = new MuaBan();
            mb.ShowDialog();
            this.Show();
        }
        private void MuaBan_Load(object sender, EventArgs e)
        {

            mb.showData(dgvSanPham, QuerySanPham);

            mb.showData(dgvKhachHang, QueryKhachHang);

        }
        private void txtTimDongMay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string str = "select sp.MaSanPham, sp.TenSanPham,sp.HangSX,sp.TGBaoHanh,sp.ThongSo,sp.SoLuong,sp.GiaTien from SanPham sp where TenSanPham LIKE '%" + txtTimDongMay.Text + "%'";
                mb.showData(dgvSanPham, str);
                dgvSanPham.Refresh();

            }
        }

        private void txtTimKhach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string str = "select kh.MaKhachHang, kh.TenKhachHang,kh.GioiTinh,kh.NgaySinh,kh.DiaChi,kh.SDT from KhachHang kh  where TenKhachHang LIKE '%" + txtTimKhach.Text + "%'";
                mb.showData(dgvKhachHang, str);
                dgvKhachHang.Refresh();

            }
        }
        string Masp;
        int MaHd = 1;
        string Hangsx;
        string Gia;
        string MaKh;
        DateTime GetNow = DateTime.Now;


        private void dgvDongMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  string tensp;

            Masp = dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Tensp = dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
            Hangsx = dgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
            string a = dgvSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();
            string b = dgvSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
            Gia = dgvSanPham.Rows[e.RowIndex].Cells[6].Value.ToString();



        }
        private void btnMua_Click(object sender, EventArgs e)
        {
            int SoLuong = Convert.ToInt32(nudSoLuong.Value);
            int Giaca = 0;
            SqlConnection con = new SqlConnection(Connect.ConnectDTB);
            if (int.TryParse(Gia, out Giaca))
            {
                int result = Giaca;

            }
            double TongTien = Giaca * SoLuong;
            string insertHoaDon = "insert into HoaDon values('" + Convert.ToString(MaHd) + "','" + MaKh + "','" + GetNow + "')";
            string insertChiTIetHoaDon = "insert into ChiTietHoaDon values('" + Convert.ToString(MaHd) + "','" + Masp + "','" + SoLuong + "','" + Gia + "','" + TongTien + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(insertHoaDon, con);
            SqlCommand cmd2 = new SqlCommand(insertChiTIetHoaDon, con);
            int ret = cmd.ExecuteNonQuery();
            int ret1 = cmd2.ExecuteNonQuery();
            if (ret == 1 && ret1 == 1)
                MessageBox.Show("Đã Thêm Vào Hóa Đơn");
            con.Close();
            MaHd += 1;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaKh = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

    }
}

