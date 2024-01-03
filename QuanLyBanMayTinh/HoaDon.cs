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
            string query = "select hd.MaHoaDon , hd.MaKhachHang, hd.NgayDat as 'Ngay Mua' from HoaDon hd";
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

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update HoaDon set MaHoaDon ='" + ttbmahd.Text + "' , MaKhachHang = N'" + ttbmakh.Text + "', NgayDat = '" + dtpngaydat.Value.ToString("yyyy-MM-dd") + "' where MaHoaDon =  '" + ttbmahd.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Lỗi cập nhật dữ liệu!");
            else
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            conn.Close();
            HienThiHoaDon();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "delete HoaDon where MaHoaDon= '" + ttbmahd.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Lỗi cập nhật dữ liệu!");
            else
                MessageBox.Show("Xóa dữ liệu thành công!");
            conn.Close();
            HienThiHoaDon();
        }


        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv1.Rows[e.RowIndex];
                ttbmahd.Text = row.Cells[0].Value.ToString();
                ttbmakh.Text = row.Cells[1].Value.ToString();
                dtpngaydat.Text = row.Cells[2].Value.ToString();
               
            }
        }
    }
}
