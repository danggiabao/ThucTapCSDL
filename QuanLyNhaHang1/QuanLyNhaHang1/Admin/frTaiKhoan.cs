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
    public partial class frTaiKhoan : Form
    {
        public frTaiKhoan()
        {
            InitializeComponent();
        }
        public string name;
        DataConnections con = new DataConnections();

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPass.Checked)
            {
                txbPassword.UseSystemPasswordChar = false;
                txbCfPass.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
                txbCfPass.UseSystemPasswordChar = true;
            }
        }

        private void frTaiKhoan_Load(object sender, EventArgs e)
        {
            txtbUsername.Text = name;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            UpdateTK_ToDatabase();
        }
        public void UpdateTK_ToDatabase()
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DoiMK";
            cmd.Connection = con.conn;
            if(txbCfPass.Text == txbPassword.Text)
            {
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = txbPassword.Text;
                int ret = cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp!","Lưu ý");
            }           
        }
    }
}
