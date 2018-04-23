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
    public partial class frTrangchu1 : Form
    {
        public frTrangchu1()
        {
            InitializeComponent();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            frTaiKhoan f = new frTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frPhucVuKH f = new frPhucVuKH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frHoaDon f = new frHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnKhachHang_Click_1(object sender, EventArgs e)
        {
            frPhucVuKH f = new frPhucVuKH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frThucDon f = new frThucDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            frHoaDon f = new frHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
