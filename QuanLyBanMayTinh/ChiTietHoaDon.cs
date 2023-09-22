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
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        public void ThemChiTietHoaDon(string connectionString, TextBox MaHoaDon, TextBox MaSanPham, TextBox SoLuong, TextBox Gia, TextBox TongTien)
        {
            string query = "Insert into ChiTietHoaDon (MaHoaDon, MaSanPham, SoLuong, Gia, TongTien) Values (@MaHoaDon, @MaSanPham, @SoLuong, @Gia, @TongTien)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHoaDon", ttbmahd.Text);
                command.Parameters.AddWithValue("@MaSanPham", ttbmasp.Text);
                command.Parameters.AddWithValue("@SoLuong", ttbsoluong.Text);
                command.Parameters.AddWithValue("@Gia", ttbgia.Text);
                command.Parameters.AddWithValue("@TongTien", ttbtongtien.Text);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=BanMayTinh;Integrated Security=True";
            ThemChiTietHoaDon(connectionString, ttbmahd, ttbmasp, ttbsoluong, ttbgia, ttbtongtien);
        }

        public void HienThiChiTietHoaDon()
        {
            string connectionString = @"Data Source=(local);Initial Catalog=BanMayTinh;Integrated Security=True";
            string query = "SELECT * FROM ChiTietHoaDon";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                // Gán dữ liệu từ DataTable vào DataGridView.
                dgvct.DataSource = dataTable;
            }
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            HienThiChiTietHoaDon();
        }

        private string connectionString = "Data Source=DESKTOP-A78SARK;Initial Catalog=BanMayTinh;Integrated Security=True";

        private void btnSuaCT_Click(object sender, EventArgs e)
        {

            string query = "UPDATE ChiTietHoaDon SET SoLuong = @SoLuong, Gia = @Gia, TongTien = @TongTien WHERE MaHoaDon = @MaHoaDon, MaSanPham = @MaSanPham";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHoaDon", ttbmahd.Text);
                    command.Parameters.AddWithValue("@MaSanPham", ttbmasp.Text);
                    command.Parameters.AddWithValue("@SoLuong", ttbsoluong.Text);
                    command.Parameters.AddWithValue("@Gia", ttbgia.Text);
                    command.Parameters.AddWithValue("@TongTien", ttbtongtien.Text);

                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Lỗi cập nhật dữ liệu!");
                    else
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
            }
        }

    }
}
