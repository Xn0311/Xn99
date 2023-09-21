using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanMayTinh
{
    public partial class Logincs : Form
    {
        public Logincs()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateUser(username, password))
            {
                // Đăng nhập thành công
                TrangChu tc = new TrangChu();
                this.Hide();
                tc.ShowDialog();
                this.Show();

            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(Connect.ConnectDTB))
            {
                string query = "SELECT COUNT(*) FROM DangNhap WHERE Usename = @Usename AND Pass = @Pass";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usename", username);
                command.Parameters.AddWithValue("@Pass", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logincs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

