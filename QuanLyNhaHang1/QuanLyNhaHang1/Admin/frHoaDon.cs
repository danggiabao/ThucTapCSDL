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
        public static string Temp;
        public static string cmb;
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
        List<string> list = new List<string>();
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
            txbThanhTien.Text = liv.SubItems[5].Text;
        }
        public void showHoaDon()
        {
            con.OpenConnection();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MAHD,KHACHHANG.MAKH,NGAYLAP,GIOTHANHTOAN,NHANVIEN.MANV,THANHTIEN from HOADON,KHACHHANG,NHANVIEN WHERE KHACHHANG.MAKH=HOADON.MAKH AND HOADON.MANV=NHANVIEN.MANV";
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                liv.SubItems.Add(reader.GetDateTime(2).ToString());
                liv.SubItems.Add(reader.GetDateTime(3).ToString());
                liv.SubItems.Add(reader.GetString(4));
                liv.SubItems.Add(reader.GetInt32(5).ToString());
                list.Add(reader.GetString(0));
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
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Temp = txtTimKiem.Text;
            cmb = cmbTimKiem.Text;
            frmTimKiemHoaDon frmHD = new frmTimKiemHoaDon();
            frmHD.Show();
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
            DialogResult dlr = MessageBox.Show("Bạn muốn thêm hoá đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
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
                cmd.Parameters.Add("@THANHTIEN", SqlDbType.Int).Value = txbThanhTien.Text;
                int ret = cmd.ExecuteNonQuery();
                lvHD.Items.Clear();
                if (ret > 0)
                    showHoaDon();

                MessageBox.Show("Đã thêm thành công", "Thêm");

                txtmahd.ResetText();
                ngaylap.ResetText();
                giott.ResetText();
                cbbkh.ResetText();
                cbbnv.ResetText();
            }
            else
            {
                lvHD.Items.Clear();
                showHoaDon();
            }
        }

        private void SuaHD()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
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
                cmd.Parameters.Add("@THANHTIEN", SqlDbType.Int).Value = txbThanhTien.Text;
                int ret = cmd.ExecuteNonQuery();
                lvHD.Items.Clear();
                if (ret > 0)
                    showHoaDon();
                MessageBox.Show("Đã sửa thành công!", "Sửa");
            }
            else
            {
                lvHD.Items.Clear();
                showHoaDon();
            }

        }

        public void XoaHD()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
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
                MessageBox.Show("Đã xoá thành công!", "Xoá");
            }
            else
            {
                lvHD.Items.Clear();
                showHoaDon();
            }
        }
        #endregion
        #region Button
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool check = true;
            if ((txtmahd.Text != "") &&  (cbbkh.Text !="") && (cbbnv.Text !="")       )
            {
                foreach (string us in list)
                {
                    if (us.Contains(txtmahd.Text))
                    {
                        MessageBox.Show("Mã hoá đơn đã tồn tại!","Thông báo");
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
                    liv.SubItems.Add(txbThanhTien.Text);
                    ThemHD();
                    
                }
            }
            else
            
            {
                MessageBox.Show("Chưa nhập mã hoá đơn, mã nhân viên hoặc mã khách hàng", "Thông báo");
            }
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
            liv.SubItems[5].Text = txbThanhTien.Text;
            SuaHD();
            
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
