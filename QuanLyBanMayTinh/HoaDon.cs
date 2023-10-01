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

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Insert into HoaDon values ('" + ttbmahd.Text + "', N'" + ttbmakh.Text + "', N'" + ttbmanv.Text + "', N'" + dtpngaydat.Value.ToString("yyyy-MM-dd") + "', N'" + dtpngaynhan.Value.ToString("yyyy-MM-dd") + "', '" + ttbnoinhan.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Lỗi thêm dữ liệu!");
            else
                MessageBox.Show("Thêm dữ liệu thành công!");
            conn.Close();
            HienThiHoaDon();
        }

        public void HienThiHoaDon()
        {
            conn.Open();
            string query = "SELECT * FROM HoaDon";
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
            string query = "update HoaDon set MaHoaDon ='" + ttbmahd.Text + "' , MaKhachHang = N'" + ttbmakh.Text + "' , MaNV= N'" + ttbmanv.Text + "', NgayDat = '" + dtpngaydat.Value.ToString("yyyy-MM-dd") + "', NgayNhan = N'" + dtpngaynhan.Value.ToString("yyyy-MM-dd") + "', NoiNhan = '" + ttbnoinhan.Text + "' where MaHoaDon =  '" + ttbmahd.Text + "'";
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

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgv1.CurrentCell.RowIndex;
            ttbmahd.Text = dgv1.Rows[t].Cells[0].Value.ToString();
            ttbmakh.Text = dgv1.Rows[t].Cells[1].Value.ToString();
            ttbmanv.Text = dgv1.Rows[t].Cells[2].Value.ToString();
            dtpngaydat.Text = dgv1.Rows[t].Cells[3].Value.ToString();
            dtpngaynhan.Text = dgv1.Rows[t].Cells[4].Value.ToString();
            ttbnoinhan.Text = dgv1.Rows[t].Cells[5].Value.ToString();         
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from HoaDon where MaHoaDon = '" + txttk.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgv1.DataSource = dt;
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            TrangChu c = new TrangChu();
            c.Show();
            this.Hide();
        }
    }
}
