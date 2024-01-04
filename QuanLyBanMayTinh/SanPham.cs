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
      
        private void btTHEM_Click(object sender, EventArgs e)
        {
          
            string query = "Insert into SanPham values ('" + ttbmasp.Text + "', N'" + ttbtensp.Text + "', N'" + ttbhangsx.Text + "', N'" + ttbtgbh.Text + "', N'" + ttbthongso.Text + "', '" +ttbsoluong.Text + "', '" + ttbgiatien.Text+ "')";
            QuanLy.Executenonquery(query, dgvsp);
            HienThiSanPham();
        }

        public void HienThiSanPham()
        {
            string query = "SELECT * FROM SanPham";
            QuanLy.Executenonquery(query,dgvsp);
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
        
            string query = "update SanPham set MaSanPham ='" + ttbmasp.Text + "' , TenSanPham = N'" + ttbtensp.Text + "' , HangSX= N'" + ttbhangsx.Text + "', TGBaoHanh = '" + ttbtgbh.Text + "', ThongSo = N'" + ttbthongso.Text + "', SoLuong = '"+ ttbsoluong.Text + "', GiaTien = '" +ttbgiatien.Text + "' where MaSanPham =  '" + ttbmasp.Text + "'";
            if (MessageBox.Show("Bạn có muốn sửa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QuanLy.Executenonquery(query, dgvsp);
            }

                HienThiSanPham();
        }


        private void btXOA_Click(object sender, EventArgs e)
        {
       
            string query = "delete SanPham where MaSanPham= '" + ttbmasp.Text + "'";
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QuanLy.Executenonquery(query, dgvsp);
            }

                
            HienThiSanPham();
        }

        private void dgvsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvsp.Rows[e.RowIndex]; 
                ttbmasp.Text = row.Cells[0].Value.ToString();
                ttbtensp.Text = row.Cells[1].Value.ToString();
                ttbhangsx.Text = row.Cells[2].Value.ToString();
                ttbtgbh.Text = row.Cells[3].Value.ToString();
                ttbthongso.Text = row.Cells[4].Value.ToString();
                ttbsoluong.Text = row.Cells[5].Value.ToString();
                ttbgiatien.Text = row.Cells[6].Value.ToString();
            }
            
        }

        private void ttbtk_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from SanPham where TenSanPham LIKE N'%" + txtTimKiem.Text + "%'"; 
            QuanLy.Executenonquery(query,dgvsp);
            dgvsp.Refresh();
        }
    }
}
