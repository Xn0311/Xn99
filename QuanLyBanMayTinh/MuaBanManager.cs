using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanMayTinh
{
    internal class MuaBanManager
    {
        #region Properties
        private DataGridView dgv;  
        private DataGridView dgv2;
        public DataGridView dgv1 { get => dgv1; set => dgv1 = value; }
        public DataGridView Dgv2 { get => dgv2; set => dgv2 = value; }

       

        #endregion
        #region Initialize
        public MuaBanManager() { }
        public MuaBanManager(DataGridView dgv,DataGridView dgv2) 
        {    this.dgv1 = dgv;
             this.dgv2 = dgv2;
        }
        #endregion
        #region Methods
        public void showData(DataGridView dgv, string s)
        {
            SqlConnection con = new SqlConnection(Connect.ConnectDTB);
            con.Open();
            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            dgv.DataSource = tb;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion

    }
}
