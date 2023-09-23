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
                command.Parameters.AddWithValue("@MaKhachHang", txtMaKhachHang.Text);
                command.Parameters.AddWithValue("@TenKhachHang", txtTenKH.Text);
                command.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                command.Parameters.AddWithValue("@NgaySinh", dtpngaysinh.Value);
                command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                command.Parameters.AddWithValue("@SDT", txtSdt.Text);
                command.Connection.Open();

                command.ExecuteNonQuery();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    MessageBox.Show("Lỗi cập nhật dữ liệu!");
                else
                    MessageBox.Show("Cập nhật dữ liệu thành công!");

                HienThiKhachHang();
            }
        }

        private void btTHEM_Click(object sender, EventArgs e)
        {
            
            ThemKhachHang(Connect.ConnectDTB, txtMaKhachHang, txtTenKH, txtGioiTinh, dtpngaysinh, txtDiaChi, txtSdt);
        }

        public void HienThiKhachHang()
        {
            
            string query = "SELECT * FROM KhachHang";

                SqlConnection connection = new SqlConnection(Connect.ConnectDTB);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                connection.Open();
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                // Gán dữ liệu từ DataTable vào DataGridView.
                dgvkh.DataSource = dataTable;
                dgvkh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvkh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            
        }

        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            HienThiKhachHang();
        }

        

        private void btnSuaKH_Click(object sender, EventArgs e)
        {

            string query = "UPDATE KhachHang SET TenKhachHang = @TenKhachHang, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT WHERE MaKhachHang = @MaKhachHang";

            using (SqlConnection connection = new SqlConnection(Connect.ConnectDTB))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKhachHang", txtMaKhachHang.Text);
                    command.Parameters.AddWithValue("@TenKhachHang", txtTenKH.Text);
                    command.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                    command.Parameters.AddWithValue("@NgaySinh", dtpngaysinh.Value);                  
                    command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    command.Parameters.AddWithValue("@SDT", txtSdt.Text);

                    int result = command.ExecuteNonQuery();
                    HienThiKhachHang();
                    // Check Error
                    if (result < 0)
                        MessageBox.Show("Lỗi cập nhật dữ liệu!");
                    else
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
            }
        }

        private void btXOA_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connect.ConnectDTB);
                SqlCommand cmd = new SqlCommand("delete from KhachHang where MaKhachHang ='" + txtMaKhachHang.Text + "'", con);
                con.Open();
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    MessageBox.Show(" Xóa Thành Công");

                con.Close();
                HienThiKhachHang();

            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập thông tin");
            }
        }

        private void btTIMKIEM_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connect.ConnectDTB);
            SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang where TenKhachHang LIKE '%" + txtTenKH.Text + "%'", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dgvkh.DataSource = dt;
            dgvkh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvkh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }
    }
}
