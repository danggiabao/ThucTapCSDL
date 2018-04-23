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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
            PullData();
        }
        DataConnections con = new DataConnections();
        #region Event_database
        public void AddTK_Database()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThemTK";
            cmd.Connection = con.conn;

            cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.NVarChar).Value = txtUsername.Text;
            cmd.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = txtPassword.Text;
            if (rdbAdmin.Checked == true)
            {
                cmd.Parameters.Add("@PHANQUYEN", SqlDbType.Int).Value = rdbAdmin.Text;
            }
            else if (rdbnv.Checked == true)
            {
                cmd.Parameters.Add("@PHANQUYEN", SqlDbType.Int).Value = rdbnv.Text;
            }
            else
            {
                cmd.Parameters.Add("@PHANQUYEN", SqlDbType.Int).Value = rdbKt.Text;
            }
            int ret = cmd.ExecuteNonQuery();
            MessageBox.Show("Đăng ký thành công!");
        }
        #endregion
        #region pulldatabase
        List<string> lst = new List<string>();
        public void PullData()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select*from TAIKHOAN";
            cmd.Connection = con.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString(2);
                lst.Add(username);
            }
            reader.Close();
        }
        #endregion
        #region Event_button
        bool check = true;
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            foreach (string us in lst)
            {
                if (us.Contains(txtUsername.Text) || txtPassword.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại hoặc mật khẩu không khớp !", "Thông báo");
                    check = false;
                    break;
                }
                check = true;
            }
            if (check == true)
            {
                AddTK_Database();
            }
        }
        #endregion
    }
}
