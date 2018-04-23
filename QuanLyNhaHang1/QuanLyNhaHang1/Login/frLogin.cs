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
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
        }
        DataConnections con = new DataConnections();      
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #region event_button_checkbox_lable

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "KiemTraDN";
            cmd.Connection = con.conn;

            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txbUsername.Text;
            cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = txbPassword.Text;
            SqlDataReader data = cmd.ExecuteReader();
            var user = data.Read();
            if (user == true)
            {
                if ((int)data["PHANQUYEN"] == 1)// Bảng của admin
                {
                    frTrangChu f = new frTrangChu();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if ((int)data["PHANQUYEN"] == 2)//Bảng của nhân viên
                {
                    frTrangchu1 f = new frTrangchu1();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else//Bảng của kế toán
                {
                    frTrangchu2 f = new frTrangchu2();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            data.Close();
            ///          
        }

        private void checkBox1_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1_show_password.Checked)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbTaoTK_Click(object sender, EventArgs e)
        {
            frmTaoTaiKhoan f = new frmTaoTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion
    }
}

