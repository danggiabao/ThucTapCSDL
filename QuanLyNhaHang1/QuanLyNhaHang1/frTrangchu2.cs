using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang1
{
    public partial class frTrangchu2 : Form
    {
        public frTrangchu2()
        {
            InitializeComponent();
            
        }
        public string username1;

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frNhanvien f = new frNhanvien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTaiKhoan_Click_1(object sender, EventArgs e)
        {
            frTaiKhoan f = new frTaiKhoan();
            f.name = lb2.Text;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            frThongKe f = new frThongKe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void frTrangchu2_Load(object sender, EventArgs e)
        {
            lb2.Text = username1;
        }
    }
}
