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
        
        QuanLy quanLy = new QuanLy();
        public static string username;
        public static string password;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            if (txtUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tài khoản", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (quanLy.AuthenticateUser(username, password))
            {
                // Đăng nhập thành công
                TrangChu tc = new TrangChu();
                TrangchuUser tcu = new TrangchuUser();
                if(quanLy.typeacc(username,password) == 1)
                {
                    this.Hide();
                    tc.ShowDialog();
                }
                else
                {
                    this.Hide();
                    tcu.ShowDialog();
                }
               // this.Show();

            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }


        


        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}

