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
        List<string> lst = new List<string>();
        private void lvHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmahd.Enabled = false;

            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            if (lvHD.SelectedItems.Count == 0) return;
            ListViewItem liv = lvHD.SelectedItems[0];
            txtmahd.Text = liv.SubItems[0].Text;
            cbbkh.Text = liv.SubItems[1].Text;
            ngaylap.Text = liv.SubItems[2].Text;
            giott.Text = liv.SubItems[3].Text;
            cbbnv.Text = liv.SubItems[4].Text;
        }
        public void showHoaDon()
        {
            con.OpenConnection();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MAHD,KHACHHANG.MAKH,NGAYLAP,GIOTHANHTOAN,NHANVIEN.MANV from HOADON,KHACHHANG,NHANVIEN WHERE KHACHHANG.MAKH=HOADON.MAKH AND HOADON.MANV=NHANVIEN.MANV";           
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                liv.SubItems.Add(reader.GetDateTime(2).ToString());
                liv.SubItems.Add(reader.GetDateTime(3).ToString());
                liv.SubItems.Add(reader.GetString(4));          
                lvHD.Items.Add(liv);
            }
            reader.Close();
        }
        #endregion
        #region LoadData
        public void showcbbKH()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from KHACHHANG";
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            cbbkh.Items.Clear();
            while (reader.Read())
            {
                string makh1 = reader.GetString(0);
                
                cbbkh.Items.Add(makh1);
            }
            reader.Close();
        }

        public void showcbbNV()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from NHANVIEN";
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            cbbnv.Items.Clear();
            while (reader.Read())
            {
                string manv1 = reader.GetString(0);
                
                cbbnv.Items.Add(manv1);
            }
            reader.Close();
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
        #region Combobox
        string tenkh = "";
        private void cbbkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valuePM = cbbkh.SelectedItem.ToString();
            string[] arrPM = valuePM.Split('-');
            tenkh = arrPM[0];
        }
        string tennv = "";
        private void cbbnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valuePM = cbbkh.SelectedItem.ToString();
            string[] arrPM = valuePM.Split('-');
            tennv = arrPM[0];
        }
        #endregion
        #region Database
        private void ThemHD()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ADD_HOADON";
            cmd.Connection = con.conn;
            cmd.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = txtmahd.Text;
            cmd.Parameters.Add("@NGAYLAP", SqlDbType.Date).Value = ngaylap.Value;
            cmd.Parameters.Add("@GIOTHANHTOAN", SqlDbType.DateTime).Value = giott.Value;
            cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = cbbnv.Text;
            cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = cbbkh.Text;

            int ret = cmd.ExecuteNonQuery();
            lvHD.Items.Clear();
            if (ret > 0)
                showHoaDon();
        }

        private void SuaHD()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ALTER_HOADON";
            cmd.Connection = con.conn;
            cmd.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = txtmahd.Text;
            cmd.Parameters.Add("@NGAYLAP", SqlDbType.Date).Value = ngaylap.Value;
            cmd.Parameters.Add("@GIOTHANHTOAN", SqlDbType.DateTime).Value = giott.Value;
            cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = cbbnv.Text;
            cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = cbbkh.Text;
            int ret = cmd.ExecuteNonQuery();
            lvHD.Items.Clear();
            if (ret > 0)
                showHoaDon();

        }

        public void XoaHD()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "D_HOADON";
            cmd.Connection = con.conn;

            cmd.Parameters.Add("@MAHD", SqlDbType.NVarChar).Value = txtmahd.Text;
            int ret = cmd.ExecuteNonQuery();
            lvHD.Items.Clear();
            if (ret > 0)
                showHoaDon();
        }
        #endregion
        #region Button
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach (string us in lst)
            {

                if (us.Contains(txtmahd.Text))
                {
                    MessageBox.Show("Mã hoá đơn đã tồn tại !");
                    check = false;
                    break;
                }
                check = true;
            }
            if (check == true)
            {
                ListViewItem liv = new ListViewItem(txtmahd.Text);
                liv.SubItems.Add(tenkh);
                liv.SubItems.Add(ngaylap.Text);
                liv.SubItems.Add(giott.Text);
                liv.SubItems.Add(tennv);
                lvHD.Items.Add(liv);
            }
            ThemHD();
            MessageBox.Show("Đã thêm thành công", "Thêm");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            if (lvHD.SelectedItems.Count == 0) return;
            ListViewItem liv = lvHD.SelectedItems[0];
            liv.SubItems[0].Text = txtmahd.Text;
            liv.SubItems[1].Text = cbbkh.Text;
            liv.SubItems[2].Text = ngaylap.Text;
            liv.SubItems[3].Text = giott.Text;
            liv.SubItems[4].Text = cbbnv.Text;
            SuaHD();
            MessageBox.Show("Đã sửa thành công", "Sửa");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvHD.SelectedItems != null)
            {
                for (int i = 0; i < lvHD.Items.Count; i++)
                {
                    if (lvHD.Items[i].Selected)
                    {
                        lvHD.Items[i].Remove();
                        i--;
                    }
                }
            }
            XoaHD();
            MessageBox.Show("Đã xoá thành công", "Xoá");
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnRs_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtmahd.Enabled = true;
            
            txtmahd.ResetText();
            cbbkh.Refresh();
            cbbkh.ResetText();
            cbbnv.Refresh();
            cbbnv.ResetText();
            ngaylap.ResetText();
            giott.ResetText();
            
        }
    }
}
