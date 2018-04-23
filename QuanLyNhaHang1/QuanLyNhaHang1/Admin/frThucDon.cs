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
    public partial class frThucDon : Form
    {
        public frThucDon()
        {
            InitializeComponent();
            searchbox1.ForeColor = Color.LightGray;
            searchbox1.Text = "Tìm kiếm";
            this.searchbox1.Leave += new System.EventHandler(this.searchbox1_Leave);
            this.searchbox1.Enter += new System.EventHandler(this.searchbox1_Enter);
        }
        DataConnections con = new DataConnections();
        #region ShowInList
        public void Showlist()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MAMON,TENMON,DONGIA,TENNM from MONAN,NHOMMON WHERE MONAN.MANM=NHOMMON.MANM";
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                liv.SubItems.Add(reader.GetInt32(2).ToString());         
                liv.SubItems.Add(reader.GetString(3));
                lvThucDon.Items.Add(liv);
            }
            reader.Close();
        }

        public void ShowlistNM()
        {         
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from NHOMMON";
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                lvNhomMon.Items.Add(liv);
            }
            reader.Close();
        }

        public void showcbbNM()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select TENNM From NHOMMON", con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbNM.DataSource = dt;
            cbbNM.DisplayMember = "TENNM";
            cbbNM.ValueMember = "TENNM";
        }
        private void frThucDon_Load(object sender, EventArgs e)
        {
            this.Showlist();
            this.ShowlistNM();
            this.showcbbNM();
        }
        #endregion
        #region TimKiem
        private void searchbox1_Leave(object sender, EventArgs e)
        {
            if (searchbox1.Text == "")
            {
                searchbox1.Text = "Tìm kiếm";
                searchbox1.ForeColor = Color.Gray;
            }
        }

        private void searchbox1_Enter(object sender, EventArgs e)
        {
            if (searchbox1.Text == "Tìm kiếm")
            {
                searchbox1.Text = "";
                searchbox1.ForeColor = Color.Black;
            }
        }
        #endregion

    }
}
