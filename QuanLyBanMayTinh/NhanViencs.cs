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
    public partial class NhanViencs : Form
    {
        public NhanViencs()
        {
            InitializeComponent();            
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Them_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=BanMayTinh;Integrated Security=True";
            ThemDuLieu(connectionString, ttbmanv, ttbtennv, dtpns, ttbgt, ttbcv, ttbttlh);
        }
        public void ThemDuLieu(string connectionString, TextBox MaNV, TextBox TenNV, DateTimePicker NgaySinh, TextBox GioiTinh, TextBox ChucVu, TextBox ThongTinLienHe)
        {
            string query = "Insert into NhanVien (MaNV, TenNV, NgaySinh, GioiTinh, ChucVu, ThongTinLienHe) Values (@MaNV, @TenNV, @NgaySinh, @GioiTinh, @ChucVu, @ThongTinLienHe)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNV", ttbmanv.Text);
                command.Parameters.AddWithValue("@TenNV", ttbtennv.Text);
                command.Parameters.AddWithValue("@NgaySinh", dtpns.Value);
                command.Parameters.AddWithValue("@GioiTinh", ttbgt.Text);
                command.Parameters.AddWithValue("@ChucVu", ttbcv.Text);
                command.Parameters.AddWithValue("@ThongTinLienHe", ttbttlh.Text);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void HienThiNhanVien()
        {
            string connectionString = @"Data Source=(local);Initial Catalog=BanMayTinh;Integrated Security=True";
            string query = "SELECT * FROM NhanVien";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                // Gán dữ liệu từ DataTable vào DataGridView.
                dgvnv.DataSource = dataTable;
            }
        }

        private void NhanViencs_Load(object sender, EventArgs e)
        {
            HienThiNhanVien();
        }

        private void dgvnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
