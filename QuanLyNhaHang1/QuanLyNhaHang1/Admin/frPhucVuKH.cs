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
        private void frPhucVuKH_Load(object sender, EventArgs e)
        {
            this.ShowKH();
            this.showcbbBan();
            this.showcbb();
            this.showcbbKH();
        }
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
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                lvKH.Items.Add(liv);
            }
            reader.Close();
        }
        #endregion
        #region ShowCombobox
     
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
        public void showcbbBan()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select TENBAN From BAN", con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbBan.DataSource = dt;
            cbbBan.DisplayMember = "TENBAN";
            cbbBan.ValueMember = "TENBAN";
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem liv = new ListViewItem(cbbKH.Text);
            liv.SubItems.Add(cbbMonAn.Text);
            liv.SubItems.Add(nudSoluong.Text);
            lvPhucVu.Items.Add(liv);
        }

    }
}
