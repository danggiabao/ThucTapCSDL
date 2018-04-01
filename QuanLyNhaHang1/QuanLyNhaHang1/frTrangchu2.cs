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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frThongKe f = new frThongKe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            frTaiKhoan f = new frTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
