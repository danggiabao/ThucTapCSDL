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
            txtTimKiem.ForeColor = Color.LightGray;
            txtTimKiem.Text = "Tìm kiếm";
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
        }
        DataConnections con = new DataConnections();
        #region ShowToListview
        public void showHoaDon()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MAHD,KHACHHANG.HOTEN,NGAYLAP,GIOTHANHTOAN,NHANVIEN.HOTEN from HOADON,KHACHHANG,NHANVIEN WHERE KHACHHANG.MAKH=HOADON.MAKH AND HOADON.MANV=NHANVIEN.MANV";           
            cmd.Connection = con.conn;

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
        #endregion
        #region LoadData
        public void showcbbKH()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select HOTEN From KHACHHANG", con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbKh.DataSource = dt;
            cbbKh.DisplayMember = "HOTEN";
            cbbKh.ValueMember = "HOTEN";
        }
        public void showcbbNV()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select HOTEN From NHANVIEN", con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbNV.DataSource = dt;
            cbbNV.DisplayMember = "HOTEN";
            cbbNV.ValueMember = "HOTEN";
        }
        private void frHoaDon_Load(object sender, EventArgs e)
        {
            this.showHoaDon();
            this.showcbbKH();
            this.showcbbNV();
        }
        #endregion
        #region TimKiem
        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }
        #endregion
    }
}
