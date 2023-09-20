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

        public void ThemSanPham(string connectionString, TextBox MaSanPham, TextBox TenSanPham, TextBox HangSX, DateTimePicker TGBaoHanh, TextBox ThongSo, TextBox SoLuong)
        {
            string query = "Insert into SanPham (MaSanPham, TenSanPham, HangSX, TGBaoHanh, ThongSo, SoLuong) Values (@MaSanPham, @TenSanPham, @HangSX, @TGBaoHanh, @ThongSo, @SoLuong)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSanPham", ttbmasp.Text);
                command.Parameters.AddWithValue("@TenSanPham", ttbtensp.Text);
                command.Parameters.AddWithValue("@HangSX", ttbhangsx.Text);
                command.Parameters.AddWithValue("@TGBaoHanh", dtptg.Value);
                command.Parameters.AddWithValue("@ThongSo", ttbthongso.Text);
                command.Parameters.AddWithValue("@SoLuong", ttbsoluong.Text);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btTHEM_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=BanMayTinh;Integrated Security=True";
            ThemSanPham(connectionString, ttbmasp, ttbtensp, ttbhangsx, dtptg, ttbthongso, ttbsoluong);
        }
    }
}
