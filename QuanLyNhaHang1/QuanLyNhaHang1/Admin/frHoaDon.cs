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
    public partial class frHoaDon : Form
    {
        public frHoaDon()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4IRSTF4;Initial Catalog=QLNH2;Integrated Security=True");
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
        public void showHoaDon()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HOADON";
            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetDateTime(1).ToString());
                liv.SubItems.Add(reader.GetTimeSpan(2).ToString());
                liv.SubItems.Add(reader.GetString(3));
                liv.SubItems.Add(reader.GetInt32(4).ToString());            
                lvHoaDon.Items.Add(liv);
            }
            reader.Close();
        }
        public void showcbbKH()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select HOTEN From KHACHHANG", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbKh.DataSource = dt;
            cbbKh.DisplayMember = "HOTEN";
            cbbKh.ValueMember = "HOTEN";
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frHoaDon_Load(object sender, EventArgs e)
        {
            this.showHoaDon();
            this.showcbbKH();
        }
    }
}
