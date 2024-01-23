using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanMayTinh
{
    public partial class QLTaiKhoan : Form
    {
        public QLTaiKhoan()
        {
            InitializeComponent();
            Logincs loin = new Logincs();
        }
        Logincs loin = new Logincs();
        
        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
        }
        public void HienThiThongTin()
        {
            string query = "select dn.usename, dn.pass as password, dn.type from DangNhap dn";
            QuanLy.Executenonquery(query, DgvDangnhap);
        }
        
        private void button3_Click(object sender, EventArgs e)
        {   
            
            int type ;
            if(rbtNhanvien.Checked)
            {
                type = 0;
            }
            else
                type = 1;
            string query = "insert into DangNhap values (N'"+txtUsename.Text+"','"+txtPass.Text+"','"+type+"')";
            QuanLy.Executenonquery(query,DgvDangnhap);
            HienThiThongTin();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //string query = "update DangNhap set ";
        }
        
    }
}
