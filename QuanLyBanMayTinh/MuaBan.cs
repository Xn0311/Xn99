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
        public void Showcbb()
        {
            con = new SqlConnection(Connect.ConnectDTB);
            con.Open();
            cmd = new SqlCommand("select * from SanPham", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            cbbHang.DataSource = tb;
            cbbTensp.DisplayMember = "HangSX";
            cbbHang.DisplayMember = "TenSanPham";
            cbbTensp.ValueMember = "MaSanPham";
            cbbHang.ValueMember = "MaSanPham";

        }
        public void showDataGV()
        {
            con = new SqlConnection(Connect.ConnectDTB);
            con.Open();
            cmd = new SqlCommand("select * from SanPham", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            dgvDongMay.DataSource = tb;

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
            Showcbb();
            showDataGV();
        }
    }
}
