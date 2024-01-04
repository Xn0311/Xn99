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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(Connect.ConnectDTB);

        

        public void HienThiHoaDon()
        {
            conn.Open();
            string query = "select hd.MaHoaDon,hd.MaKhachHang,ct.MaSanPham,ct.SoLuong, ct.Gia,ct.TongTien,hd.NgayDat from  HoaDon hd, ChiTietHoaDon ct where hd.MaHoaDon = ct.MaHoaDon ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgv1.DataSource = dt;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            HienThiHoaDon();
        }  


        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
