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
    public partial class frTrangChu : Form
    {
        public frTrangChu()
        {
            InitializeComponent();
        }
        public string username ;
        private void button4_Click(object sender, EventArgs e)
        {
            frNhanvien f = new frNhanvien();
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

        private void btn_Click(object sender, EventArgs e)
        {
            frThucDon f = new frThucDon();
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
            f.name = lb1.Text;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void frTrangChu_Load(object sender, EventArgs e)
        {
            lb1.Text = username;
        }
    }
}
