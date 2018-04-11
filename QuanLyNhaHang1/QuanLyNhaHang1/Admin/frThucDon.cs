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
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4IRSTF4;Initial Catalog=QLNH2;Integrated Security=True");
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        public void Showlist()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from MONAN";
            cmd.Connection = conn;

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
            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                lvNhomMon.Items.Add(liv);
            }
            reader.Close();
        }

        private void frThucDon_Load(object sender, EventArgs e)
        {
            this.Showlist();
            this.ShowlistNM();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void lvThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvNhomMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
