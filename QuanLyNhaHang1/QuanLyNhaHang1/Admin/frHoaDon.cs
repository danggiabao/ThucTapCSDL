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
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5LUMSRJ;Initial Catalog=QLNH2;Integrated Security=True");
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
            cmd.CommandText = "select MAHD,KHACHHANG.HOTEN,NGAYLAP,GIOTHANHTOAN,NHANVIEN.HOTEN from HOADON,KHACHHANG,NHANVIEN WHERE KHACHHANG.MAKH=HOADON.MAKH AND HOADON.MANV=NHANVIEN.MANV";
            
            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                liv.SubItems.Add(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
                liv.SubItems.Add(reader.GetTimeSpan(3).ToString());
                liv.SubItems.Add(reader.GetString(4));          
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
