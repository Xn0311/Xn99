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
    public partial class KHACHHANG : Form
    {
        public KHACHHANG()
        {
            InitializeComponent();
        }

        public void ThemKhachHang(string connectionString, TextBox MaKhachHang, TextBox TenKhachHang, TextBox GioiTinh, DateTimePicker NgaySinh, TextBox DiaChi, TextBox SDT)
        {
            string query = "Insert into KhachHang (MaKhachHang, TenKhachHang, GioiTinh, NgaySinh, DiaChi, SDT) Values (@MaKhachHang, @TenKhachHang, @GioiTinh, @NgaySinh, @DiaChi, @SDT)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKhachHang", ttbmakh.Text);
                command.Parameters.AddWithValue("@TenKhachHang", ttbtenkh.Text);
                command.Parameters.AddWithValue("@GioiTinh", ttbgioitinh.Text);
                command.Parameters.AddWithValue("@NgaySinh", dtpngaysinh.Value);
                command.Parameters.AddWithValue("@DiaChi", ttbdiachi.Text);
                command.Parameters.AddWithValue("@SDT", ttbsodt.Text);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btTHEM_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=BanMayTinh;Integrated Security=True";
            ThemKhachHang(connectionString, ttbmakh, ttbtenkh, ttbgioitinh, dtpngaysinh, ttbdiachi, ttbsodt);
        }

        public void HienThiKhachHang()
        {
            string connectionString = @"Data Source=(local);Initial Catalog=BanMayTinh;Integrated Security=True";
            string query = "SELECT * FROM KhachHang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                // Gán dữ liệu từ DataTable vào DataGridView.
                dgvkh.DataSource = dataTable;
            }
        }

        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            HienThiKhachHang();
        }


    }
}
