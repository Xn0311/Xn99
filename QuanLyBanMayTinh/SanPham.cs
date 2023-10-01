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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(Connect.ConnectDTB);

        private void btTHEM_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Insert into SanPham values ('" + ttbmasp.Text + "', N'" + ttbtensp.Text + "', N'" + ttbhangsx.Text + "', N'" + ttbtgbh.Text + "', N'" + ttbthongso.Text + "', '" +ttbsoluong.Text + "', '" + ttbgiatien.Text+ "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Lỗi thêm dữ liệu!");
            else
                MessageBox.Show("Thêm dữ liệu thành công!");
            conn.Close();
            HienThiSanPham();
        }

        public void HienThiSanPham()
        {
            conn.Open();    
            string query = "SELECT * FROM SanPham";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgvsp.DataSource = dt;
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update SanPham set MaSanPham ='" + ttbmasp.Text + "' , TenSanPham = N'" + ttbtensp.Text + "' , HangSX= N'" + ttbhangsx.Text + "', TGBaoHanh = '" + ttbtgbh.Text + "', ThongSo = N'" + ttbthongso.Text + "', SoLuong = '"+ ttbsoluong.Text + "', GiaTien = '" +ttbgiatien.Text + "' where MaSanPham =  '" + ttbmasp.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);           
            int result = cmd.ExecuteNonQuery();
                    if (result < 0)
                        MessageBox.Show("Lỗi cập nhật dữ liệu!");
                    else
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
            conn.Close();
            HienThiSanPham();
        }

        private void btTIMKIEM_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from SanPham where MaSanPham = '" + ttbtk.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgvsp.DataSource = dt;
        }

        private void btQUAYLAI_Click(object sender, EventArgs e)
        {
            TrangChu c = new TrangChu();
            c.Show();
            this.Hide();
        }

        private void dgvsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvsp.CurrentCell.RowIndex;
            ttbmasp.Text = dgvsp.Rows[t].Cells[0].Value.ToString();
            ttbtensp.Text = dgvsp.Rows[t].Cells[1].Value.ToString();
            ttbhangsx.Text = dgvsp.Rows[t].Cells[2].Value.ToString();
            ttbtgbh.Text = dgvsp.Rows[t].Cells[3].Value.ToString();
            ttbthongso.Text = dgvsp.Rows[t].Cells[4].Value.ToString();
            ttbsoluong.Text = dgvsp.Rows[t].Cells[5].Value.ToString();
            ttbgiatien.Text = dgvsp.Rows[t].Cells[6].Value.ToString();
        }

        private void btXOA_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "delete SanPham where MaSanPham= '" + ttbmasp.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            if (result < 0)
                MessageBox.Show("Lỗi cập nhật dữ liệu!");
            else
                MessageBox.Show("Xóa dữ liệu thành công!");
            conn.Close();
            HienThiSanPham();
        }
    }
}
