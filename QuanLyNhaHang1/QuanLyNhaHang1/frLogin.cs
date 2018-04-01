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
using System.Data;

namespace QuanLyNhaHang1
{
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4IRSTF4;Initial Catalog=QLNH2;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txbUsername.Text;
                string mk = txbPassword.Text;
                if ((tk == "") || (mk == ""))
                {
                    MessageBox.Show("Cần nhập đủ tên tài khoản và mật khẩu !", "Thông báo");
                }
                else
                {
                    string sql = "select*from TAIKHOAN where TENDANGNHAP ='" + tk + "' and MATKHAU='" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
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
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa chính xác !", "Thông báo");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !");
            }
          
        }
    }
}
