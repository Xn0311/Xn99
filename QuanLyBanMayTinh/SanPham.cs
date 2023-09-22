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

        public void ThemSanPham(string connectionString, TextBox MaSanPham, TextBox TenSanPham, TextBox HangSX, TextBox TGBaoHanh, TextBox ThongSo, TextBox SoLuong, TextBox GiaTien)
        {
            string query = "Insert into SanPham (MaSanPham, TenSanPham, HangSX, TGBaoHanh, ThongSo, SoLuong, GiaTien) Values (@MaSanPham, @TenSanPham, @HangSX, @TGBaoHanh, @ThongSo, @SoLuong, @GiaTien)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSanPham", ttbmasp.Text);
                command.Parameters.AddWithValue("@TenSanPham", ttbtensp.Text);
                command.Parameters.AddWithValue("@HangSX", ttbhangsx.Text);
                command.Parameters.AddWithValue("@TGBaoHanh", ttbtgbh.Text);
                command.Parameters.AddWithValue("@ThongSo", ttbthongso.Text);
                command.Parameters.AddWithValue("@SoLuong", ttbsoluong.Text);
                command.Parameters.AddWithValue("@GiaTien", ttbgiatien.Text);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btTHEM_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=BanMayTinh;Integrated Security=True";
            ThemSanPham(connectionString, ttbmasp, ttbtensp, ttbhangsx, ttbtgbh, ttbthongso, ttbsoluong, ttbgiatien);
        }

        public void HienThiSanPham()
        {
            string connectionString = @"Data Source=(local);Initial Catalog=BanMayTinh;Integrated Security=True";
            string query = "SELECT * FROM SanPham";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                // Gán dữ liệu từ DataTable vào DataGridView.
                dgvsp.DataSource = dataTable;
            }
        }


        private void SanPham_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
        }
    }
}
