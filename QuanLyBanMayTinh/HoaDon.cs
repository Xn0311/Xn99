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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void ThemHoaDon(string connectionString, TextBox MaHoaDon, TextBox MaKhachHang, TextBox MaNV, DateTimePicker NgayDat, DateTimePicker NgayNhan, TextBox NoiNhan)
        {
            string query = "Insert into HoaDon (MaHoaDon, MaKhachHang, MaNV, NgayDat, NgayNhan, NoiNhan) Values (@MaHoaDon, @MaKhachHang, @MaNV, @NgayDat, @NgayNhan, @NoiNhan)";
            using (SqlConnection connection = new SqlConnection(Connect.ConnectDTB))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHoaDon", ttbmahd.Text);
                command.Parameters.AddWithValue("@MaKhachHang", ttbmakh.Text);
                command.Parameters.AddWithValue("@MaNV", ttbmanv.Text);
                command.Parameters.AddWithValue("@NgayDat", dtpngaydat.Value);
                command.Parameters.AddWithValue("@NgayNhan", dtpngaynhan.Value);
                command.Parameters.AddWithValue("@NoiNhan", ttbnoinhan.Text);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connect.ConnectDTB);
            ThemHoaDon(Connect.ConnectDTB, ttbmahd, ttbmakh, ttbmanv, dtpngaydat, dtpngaynhan, ttbnoinhan);
        }

        public void HienThiHoaDon()
        {
            SqlConnection con = new SqlConnection(Connect.ConnectDTB);
            string query = "SELECT * FROM HoaDon";

            using (SqlConnection connection = new SqlConnection(Connect.ConnectDTB))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                // Gán dữ liệu từ DataTable vào DataGridView.
                dgv1.DataSource = dataTable;
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            HienThiHoaDon();
        }

       

        private void btnSuaHD_Click(object sender, EventArgs e)
        {

            string query = "UPDATE HoaDon SET MaKhachHang = @MaKhachHang, MaNV = @MaNV, NgayDat = @NgayDat, NgayNhan = @NgayNhan, NoiNhan = @NoiNhan WHERE MaHoaDon = @MaHoaDon";

            using (SqlConnection connection = new SqlConnection(Connect.ConnectDTB))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHoaDon", ttbmahd.Text);
                    command.Parameters.AddWithValue("@MaKhachHang", ttbmakh.Text);
                    command.Parameters.AddWithValue("@MaNV", ttbmanv.Text);
                    command.Parameters.AddWithValue("@NgayDat", dtpngaydat.Value);
                    command.Parameters.AddWithValue("@NgayNhan", dtpngaynhan.Value);
                    command.Parameters.AddWithValue("@NoiNhan", ttbnoinhan.Text);

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
