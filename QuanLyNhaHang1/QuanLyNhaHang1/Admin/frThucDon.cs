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
        List<string> list = new List<string>();
        //View 1 : Món ăn
        private void lvThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmamon.Enabled = false;
            btnThemMon.Enabled = false;
            btnXoaMon.Enabled = true;
            btnSuaMon.Enabled = true;
            if (lvThucDon.SelectedItems.Count == 0) return;
            ListViewItem liv = lvThucDon.SelectedItems[0];
            txtmamon.Text = liv.SubItems[0].Text;
            txttenmon.Text = liv.SubItems[1].Text;
            txtdongia.Text = liv.SubItems[2].Text;
            cbbNM.Text = liv.SubItems[3].Text;
        }
        //View 2 : Nhóm món
        private void lvNhomMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmanma.Enabled = false;
            btnThemNM.Enabled = false;
            btnXoaNM.Enabled = true;
            btnSuaNM.Enabled = true;
            if (lvNhomMon.SelectedItems.Count == 0) return;
            ListViewItem liv = lvNhomMon.SelectedItems[0];
            txtmanma.Text = liv.SubItems[0].Text;
            txttennma.Text = liv.SubItems[1].Text;
          
        }
        public void ShowTD()
        {
            btnSuaMon.Enabled = false;
            btnXoaMon.Enabled = false;
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
        #endregion
        #region Load Data
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
            this.ShowTD();
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

        #region Combobox
        string tennm = "";
        private void cbbNM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valuePM = cbbNM.SelectedItem.ToString();
            string[] arrPM = valuePM.Split('-');
            tennm = arrPM[0];
        }

        #endregion

        #region Database
        private void ThemMonAn()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thêm món ăn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ADD_MONAN";
                cmd.Connection = con.conn;
                cmd.Parameters.Add("@MAMON", SqlDbType.VarChar).Value = txtmamon.Text;
                cmd.Parameters.Add("@TENMON", SqlDbType.NVarChar).Value = txttenmon.Text;
                cmd.Parameters.Add("@DONGIA", SqlDbType.Int).Value = Convert.ToInt32("");
                cmd.Parameters.Add("@MANM", SqlDbType.VarChar).Value = cbbNM.Text;                

                int ret = cmd.ExecuteNonQuery();
                lvThucDon.Items.Clear();
                if (ret > 0)
                    ShowTD();

                MessageBox.Show("Đã thêm thành công", "Thêm");

                txtmamon.ResetText();
                txttenmon.ResetText();
                txtdongia.ResetText();
                cbbNM.ResetText();               
            }
            else
            {
                lvThucDon.Items.Clear();
                ShowTD();
            }
        }

        private void SuaMonAn()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ALTER_MONAN";
            cmd.Connection = con.conn;
            cmd.Parameters.Add("@MAMON", SqlDbType.VarChar).Value = txtmamon.Text;
            cmd.Parameters.Add("@TENMON", SqlDbType.NVarChar).Value = txttenmon.Text;
            cmd.Parameters.Add("@DONGIA", SqlDbType.Int).Value = Convert.ToInt32("");
            cmd.Parameters.Add("@TENNM", SqlDbType.VarChar).Value = cbbNM.Text;

            int ret = cmd.ExecuteNonQuery();
            lvThucDon.Items.Clear();
            if (ret > 0)
                ShowTD();

        }

        public void XoaMonAn()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "D_MONAN";
            cmd.Connection = con.conn;

            cmd.Parameters.Add("@MAMON", SqlDbType.VarChar).Value = txtmamon.Text;
            int ret = cmd.ExecuteNonQuery();
            lvThucDon.Items.Clear();
            if (ret > 0)
                ShowTD();
        }
//đây là bảng nhóm món
        private void ThemNhomMon()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thêm món ăn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ADD_NHOMMON";
                cmd.Connection = con.conn;
                cmd.Parameters.Add("@MANM", SqlDbType.VarChar).Value = txtmanma.Text;
                cmd.Parameters.Add("@TENNM", SqlDbType.NVarChar).Value = txttennma.Text;

                int ret = cmd.ExecuteNonQuery();
                lvNhomMon.Items.Clear();
                if (ret > 0)
                    ShowTD();

                MessageBox.Show("Đã thêm thành công", "Thêm");

                txtmanma.ResetText();
                txttennma.ResetText();
            }
            else
            {
                lvNhomMon.Items.Clear();
                ShowTD();
            }
        }

        private void SuaNhomMon()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ALTER_NHOMMON";
            cmd.Connection = con.conn;
            cmd.Parameters.Add("@MANM", SqlDbType.VarChar).Value = txtmanma.Text;
            cmd.Parameters.Add("@TENNM", SqlDbType.NVarChar).Value = txttennma.Text;
          
            int ret = cmd.ExecuteNonQuery();
            lvNhomMon.Items.Clear();
            if (ret > 0)
                ShowTD();

        }

        public void XoaNhomMon()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "D_NHOMMON";
            cmd.Connection = con.conn;

            cmd.Parameters.Add("@MANM", SqlDbType.VarChar).Value = txtmanma.Text;
            int ret = cmd.ExecuteNonQuery();
            lvNhomMon.Items.Clear();
            if (ret > 0)
                ShowTD();
        }


        #endregion

        #region button
        //LÀM MỚI
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnThemMon.Enabled = true;
            btnSuaMon.Enabled = false;
            btnXoaMon.Enabled = false;
            txtmamon.Enabled = true;

            txtmamon.ResetText();
            txttenmon.ResetText();
            txtdongia.ResetText();
            cbbNM.Refresh();
            cbbNM.ResetText();
        }
        //LÀM MỚI
        private void btnlm_Click(object sender, EventArgs e)
        {
            btnThemNM.Enabled = true;
            btnSuaNM.Enabled = false;
            btnXoaNM.Enabled = false;
            txtmanma.Enabled = true;

            txtmanma.ResetText();
            txttennma.ResetText();
        }
        //THÊM MÓN ĂN
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            bool check = true;
            if ((txtmamon.Text != "") && (cbbNM.Text != "") )
            {
                foreach (string us in list)
                {
                    if (us.Contains(txtmamon.Text))
                    {
                        MessageBox.Show("Mã hoá đơn đã tồn tại!", "Thông báo");
                        check = false;
                        break;
                    }
                    check = true;
                }
                if (check == true)
                {

                    ListViewItem liv = new ListViewItem(txtmamon.Text);
                    liv.SubItems.Add(tennm);
                    liv.SubItems.Add(txtdongia.Text);
                    liv.SubItems.Add(cbbNM.Text);
                    lvThucDon.Items.Add(liv);
                    ThemMonAn();

                }
            }
            else

            {
                MessageBox.Show("Chưa nhập mã hoá đơn, mã nhân viên hoặc mã khách hàng", "Thông báo");
            }
        }
        //SỬA MÓN ĂN
        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            btnThemMon.Enabled = true;
            if (lvThucDon.SelectedItems.Count == 0) return;
            ListViewItem liv = lvThucDon.SelectedItems[0];
            liv.SubItems[0].Text = txtmamon.Text;
            liv.SubItems[1].Text = txttenmon.Text;
            liv.SubItems[2].Text = txtdongia.Text;
            liv.SubItems[3].Text = cbbNM.Text;
            SuaMonAn();
            MessageBox.Show("Đã sửa thành công!", "Sửa");
        }
        //XÓA MÓN ĂN 
        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (lvThucDon.SelectedItems != null)
            {
                for (int i = 0; i < lvThucDon.Items.Count; i++)
                {
                    if (lvThucDon.Items[i].Selected)
                    {
                        lvThucDon.Items[i].Remove();
                        i--;
                    }
                }
            }
            XoaMonAn();
            MessageBox.Show("Đã xoá thành công!", "Xoá");
        }
        //THÊM NHÓM MÓN
        private void btnThemNM_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txtmanma.Text != "") 
            {
                foreach (string us in list)
                {
                    if (us.Contains(txtmanma.Text))
                    {
                        MessageBox.Show("Mã hoá đơn đã tồn tại!", "Thông báo");
                        check = false;
                        break;
                    }
                    check = true;
                }
                if (check == true)
                {

                    ListViewItem liv = new ListViewItem(txtmanma.Text);
                    liv.SubItems.Add(tennm);  
                    lvNhomMon.Items.Add(liv);
                    ThemNhomMon();

                }
            }
            else

            {
                MessageBox.Show("Chưa nhập mã hoá đơn, mã nhân viên hoặc mã khách hàng", "Thông báo");
            }
        }
        //SỬA NHÓM MÓN
        private void btnSuaNM_Click(object sender, EventArgs e)
        {
            btnThemNM.Enabled = true;
            if (lvNhomMon.SelectedItems.Count == 0) return;
            ListViewItem liv = lvNhomMon.SelectedItems[0];
            liv.SubItems[0].Text = txtmanma.Text;
            liv.SubItems[1].Text = txttennma.Text;
            
            SuaNhomMon();
            MessageBox.Show("Đã sửa thành công!", "Sửa");
        }
        //XÓA NHÓM MÓN
        private void btnXoaNM_Click(object sender, EventArgs e)
        {
            if (lvNhomMon.SelectedItems != null)
            {
                for (int i = 0; i < lvNhomMon.Items.Count; i++)
                {
                    if (lvNhomMon.Items[i].Selected)
                    {
                        lvNhomMon.Items[i].Remove();
                        i--;
                    }
                }
            }
            XoaNhomMon();
            MessageBox.Show("Đã xoá thành công!", "Xoá");
        }


        #endregion


    }
}
