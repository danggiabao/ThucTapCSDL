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

namespace QuanLyNhaHang1
{
    public partial class frPhucVuKH : Form
    {
        public frPhucVuKH()
        {
            InitializeComponent();          
        }
        DataConnections con = new DataConnections();
        #region ShowListview
        List<string> lst = new List<string>();
        public void ShowKH()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from KHACHHANG";
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetInt32(0).ToString());
                liv.SubItems.Add(reader.GetString(1));
                lvKH.Items.Add(liv);
            }
            reader.Close();
        }
        #endregion
        #region ShowCombobox
        private void frPhucVuKH_Load(object sender, EventArgs e)
        {
            this.ShowKH();
            this.showcbb();
            this.showcbbKH();
        }
        public void showcbb()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select TENMON From MONAN", con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMonAn.DataSource = dt;
            cbbMonAn.DisplayMember = "TENMON";
            cbbMonAn.ValueMember = "TENMON";
        }
        public void showcbbKH()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select HOTEN From KHACHHANG", con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbKH.DataSource = dt;
            cbbKH.DisplayMember = "HOTEN";
            cbbKH.ValueMember = "HOTEN";
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            string soban = "";
            ListViewItem liv = new ListViewItem(soban);
            liv.SubItems.Add(cbbKH.Text);
            liv.SubItems.Add(cbbMonAn.Text);
            liv.SubItems.Add(nudSoluong.Text);
            lvPhucVu.Items.Add(liv);
        }
    }
}
