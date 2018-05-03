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
    public partial class frNhanvien : Form
    {
        public frNhanvien()
        {
            InitializeComponent();
            searchBox.ForeColor = Color.LightGray;
            searchBox.Text = "Tìm kiếm";
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
        }

        DataConnections con = new DataConnections();
        private void frNhanvien_Load(object sender, EventArgs e)
        {
            this.Showlv();
        }

        #region ShowData
        List<string> list = new List<string>();
        public void Showlv()
        {
            con.OpenConnection();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from NHANVIEN";
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string manv = reader.GetString(0);
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                liv.SubItems.Add(reader.GetString(2));
                liv.SubItems.Add(reader.GetDateTime(3).ToString());
                liv.SubItems.Add(reader.GetString(4));
                list.Add(manv);
                lvNV.Items.Add(liv);
            }
            reader.Close();
        }
        #endregion     
        #region SearchBox
        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void searchBox_DragLeave(object sender, EventArgs e)
        {

        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Tìm kiếm";
                searchBox.ForeColor = Color.Gray;
            }
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Tìm kiếm")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }
        #endregion
        #region ListView
        private void lvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbMaNV.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (lvNV.SelectedItems.Count == 0) return;
            ListViewItem liv = lvNV.SelectedItems[0];
            txtbMaNV.Text = liv.SubItems[0].Text;
            txtbTen.Text = liv.SubItems[1].Text;
            if (rdnam.Text.ToLower() == liv.SubItems[2].Text.ToLower())
            {
                rdnam.Checked = true;
                rdnu.Checked = false;
            }
            else
            {
                rdnu.Checked = true;
                rdnam.Checked = false;
            }
            dtNgaySinh.Text = liv.SubItems[3].Text;
            txtbQue.Text = liv.SubItems[4].Text;
        }
        #endregion
        #region DataBase
        private void ThemNV()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thêm nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlr == DialogResult.Yes)
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ADD_NHANVIEN";
                cmd.Connection = con.conn;

                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = txtbMaNV.Text;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = txtbTen.Text;
                if (rdnam.Checked == true)
                {
                    cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = rdnam.Text;
                }
                else
                {
                    cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = rdnu.Text;
                }
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = dtNgaySinh.Value;

                cmd.Parameters.Add("@QUEQUAN", SqlDbType.NVarChar).Value = txtbQue.Text;

                int ret = cmd.ExecuteNonQuery();
                lvNV.Items.Clear();
                if (ret > 0)
                    Showlv();
                MessageBox.Show("Đã thêm thành công", "Thêm");
                rdnam.Checked = false;
                rdnu.Checked = false;
                txtbMaNV.ResetText();
                txtbTen.ResetText();
                txtbQue.ResetText();
                dtNgaySinh.ResetText();
            }
            else
            {
                lvNV.Items.Clear();
                Showlv();
            }       
        }
        private void SuaNV()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn sửa nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ALTER_NHANVIEN";
                cmd.Connection = con.conn;
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = txtbMaNV.Text;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = txtbTen.Text;
                if (rdnam.Checked == true)
                {
                    cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = rdnam.Text;
                }
                else
                {
                    cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = rdnu.Text;
                }
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = dtNgaySinh.Value;

                cmd.Parameters.Add("@QUEQUAN", SqlDbType.NVarChar).Value = txtbQue.Text;
                int ret = cmd.ExecuteNonQuery();
                lvNV.Items.Clear();
                if (ret > 0)
                    Showlv();
                MessageBox.Show("Đã sửa thành công", "Sửa");
                txtbMaNV.Enabled = true;
                rdnam.Checked = false;
                rdnu.Checked = false;
                txtbMaNV.ResetText();
                txtbTen.ResetText();
                txtbQue.ResetText();
                dtNgaySinh.ResetText();
            }
            else
            {
                lvNV.Items.Clear();
                Showlv();
            }
        }
        private void XoaNV()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "D_NHANVIEN";
                cmd.Connection = con.conn;

                cmd.Parameters.Add("@MANV", SqlDbType.NVarChar).Value = txtbMaNV.Text;
                int ret = cmd.ExecuteNonQuery();
                lvNV.Items.Clear();
                if (ret > 0)
                    Showlv();
                MessageBox.Show("Đã xóa thành công !", "Xóa");
                btnThem.Enabled = true;
                txtbMaNV.Enabled = true;
                rdnam.Checked = false;
                rdnu.Checked = false;
                txtbMaNV.ResetText();
                txtbTen.ResetText();
                txtbQue.ResetText();
                dtNgaySinh.ResetText();
            }
            else
            {
                btnThem.Enabled = true;
                txtbMaNV.Enabled = true;
                rdnam.Checked = false;
                rdnu.Checked = false;
                txtbMaNV.ResetText();
                txtbTen.ResetText();
                txtbQue.ResetText();
                dtNgaySinh.ResetText();
                lvNV.Items.Clear();
                Showlv();
            }
        }

        #endregion
        #region Button
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtbMaNV.Text != "")
            {
                bool check = true;
                foreach (string us in list)
                {

                    if (us.Contains(txtbMaNV.Text))
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại !");
                        check = false;
                        break;
                    }
                    check = true;
                }
                if (check == true)
                {
                    ListViewItem liv = new ListViewItem(txtbMaNV.Text);
                    liv.SubItems.Add(txtbTen.Text);
                    if (rdnam.Checked == true)
                    {
                        liv.SubItems.Add(rdnam.Text);
                    }
                    else
                    {
                        liv.SubItems.Add(rdnu.Text);
                    }
                    liv.SubItems.Add(dtNgaySinh.Text);
                    liv.SubItems.Add(txtbQue.Text);
                    lvNV.Items.Add(liv);
                    ThemNV();                    
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã nhân viên", "Thông báo");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            if (lvNV.SelectedItems.Count == 0) return;
            ListViewItem liv = lvNV.SelectedItems[0];
            liv.SubItems[0].Text = txtbMaNV.Text;
            liv.SubItems[1].Text = txtbTen.Text;
            if (rdnam.Checked == true)
            {
                liv.SubItems[2].Text = rdnam.Text;
            }
            else
            {
                liv.SubItems[2].Text = rdnu.Text;
            }
            liv.SubItems[3].Text = dtNgaySinh.Text;
            liv.SubItems[4].Text = txtbQue.Text;
            SuaNV();
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvNV.SelectedItems.Count != 0)
            {
                for (int i = 0; i < lvNV.Items.Count; i++)
                {
                    if (lvNV.Items[i].Selected)
                    {
                        lvNV.Items[i].Remove();
                        i--;
                    }
                }
                XoaNV();
            }
            
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtbMaNV.Enabled = true;
            rdnam.Checked = false;
            rdnu.Checked = false;
            txtbMaNV.ResetText();
            txtbTen.ResetText();
            txtbQue.ResetText();
            dtNgaySinh.ResetText();
        }
        #endregion

        

    }
}
