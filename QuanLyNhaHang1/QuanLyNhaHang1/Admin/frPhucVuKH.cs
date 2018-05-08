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
        List<string> list = new List<string>();
        private void lvKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbMaKH.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (lvKH.SelectedItems.Count == 0) return;
            ListViewItem liv = lvKH.SelectedItems[0];
            txbMaKH.Text = liv.SubItems[0].Text;
            txbTenKH.Text = liv.SubItems[1].Text;
        }
        public void ShowKH()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
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
                list.Add(reader.GetString(0));
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
        #region event_buttonKH
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbMaKH.Text != "")
            {
                bool check = true;
                foreach (string us in list)
                {
                    if (us.Contains(txbMaKH.Text))
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại !");
                        check = false;
                        break;
                    }
                    check = true;
                }
                if (check == true)
                {
                    ListViewItem liv = new ListViewItem(txbMaKH.Text);
                    liv.SubItems.Add(txbTenKH.Text);
                    lvKH.Items.Add(liv);
                    ThemKH();                 
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã khách hàng", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            if (lvKH.SelectedItems.Count == 0) return;
            ListViewItem liv = lvKH.SelectedItems[0];
            liv.SubItems[0].Text = txbMaKH.Text;
            liv.SubItems[1].Text = txbTenKH.Text;        
            SuaKH();           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvKH.SelectedItems.Count != 0)
            {
                for (int i = 0; i < lvKH.Items.Count; i++)
                {
                    if (lvKH.Items[i].Selected)
                    {
                        lvKH.Items[i].Remove();
                        i--;
                    }
                }
                XoaKH();
            }                    
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txbMaKH.Enabled = true;
            txbMaKH.ResetText();
            txbTenKH.ResetText();
            tabPage2.Refresh();
        }
        #endregion
        #region Database_KH
        private void ThemKH()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thêm khách hàng?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ADD_KHACHHANG";
                cmd.Connection = con.conn;
                cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = txbMaKH.Text;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = txbTenKH.Text;         

                int ret = cmd.ExecuteNonQuery();
                lvKH.Items.Clear();
                if (ret > 0)
                    ShowKH();
                MessageBox.Show("Đã thêm thành công", "Thêm");
                txbMaKH.ResetText();
                txbTenKH.ResetText();
            }
            else
            {
                lvKH.Items.Clear();
                ShowKH();
            }
         
        }

        private void SuaKH()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn sửa khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlr == DialogResult.Yes)
            {
                btnThem.Enabled = true;
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ALTER_KHACHHANG";
                cmd.Connection = con.conn;
                cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = txbMaKH.Text;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = txbTenKH.Text;
                int ret = cmd.ExecuteNonQuery();
                lvKH.Items.Clear();
                if (ret > 0)
                    ShowKH();
                MessageBox.Show("Đã sửa thành công", "Sửa");
                txbMaKH.Enabled = true;
                txbMaKH.ResetText();
                txbTenKH.ResetText();
            }
            else
            { 
                lvKH.Items.Clear();
                ShowKH();
            }
            
        }

        public void XoaKH()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlr == DialogResult.Yes)
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "D_KHACHHANG";
                cmd.Connection = con.conn;

                cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = txbMaKH.Text;
                int ret = cmd.ExecuteNonQuery();
                lvKH.Items.Clear();
                if (ret > 0)
                    ShowKH();
                MessageBox.Show("Đã xoá thành công", "Xoá");
                txbMaKH.Enabled = true;
                txbMaKH.ResetText();
                txbTenKH.ResetText();
            }
            else
            {
                txbMaKH.Enabled = true;
                txbMaKH.ResetText();
                txbTenKH.ResetText();
                lvKH.Items.Clear();
                ShowKH();
            }
        }
            

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem liv = new ListViewItem(cbbKH.Text);
            liv.SubItems.Add(cbbMonAn.Text);
            liv.SubItems.Add(nudSoluong.Text);
            lvPhucVu.Items.Add(liv);
        }

        private void txbMaKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
