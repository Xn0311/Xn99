using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace QuanLyBanMayTinh
{
    internal class QuanLy
    {
        // Câu lệnh truy vấn thực thi
        public static void Executenonquery(string query, DataGridView dgv)
        {
            SqlConnection con = new SqlConnection(Connect.ConnectDTB);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgv.DataSource = dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        // tìm kiếm tài khoản 
        public bool AuthenticateUser(string username, string password)
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
        // tìm kiếm kiểu tài khoản
        public int typeacc(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(Connect.ConnectDTB))
            {
                connection.Open();
                string sql = "SELECT dn.type FROM DangNhap dn WHERE dn.usename = @username AND dn.pass = @password";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int type = (int)command.ExecuteScalar();
                return type;
            }
        }
        public int indexmahd()
        {
            // Mở kết nối
            SqlConnection connection = new SqlConnection(Connect.ConnectDTB);
            connection.Open();
            string sql = "SELECT MAX(MaHoaDon) from HoaDon";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            // Lấy kết quả
            int maHoaDon = (int)command.ExecuteScalar();
            return maHoaDon;
        }

    }
}
