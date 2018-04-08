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
    public partial class frPhucVuKH : Form
    {
        public frPhucVuKH()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4IRSTF4;Initial Catalog=QLNH2_new;Integrated Security=True");
        public void showcbb()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select TENMON From MONAN", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMonAn.DataSource = dt;
            cbbMonAn.DisplayMember = "TENMON";
            cbbMonAn.ValueMember = "TENMON";

        }
        public void showcbbKH()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select HOTEN From KHACHHANG", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbKH.DataSource = dt;
            cbbKH.DisplayMember = "HOTEN";
            cbbKH.ValueMember = "HOTEN";
        }

        private void frPhucVuKH_Load(object sender, EventArgs e)
        {
            this.showcbb();
            this.showcbbKH();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string soban = "";
            soban = txtSoban.Text;
            ListViewItem liv = new ListViewItem(soban);
            liv.SubItems.Add(cbbMonAn.Text);
            //liv.SubItems.Add(cbbKH.Text);
            liv.SubItems.Add(nudSoluong.Text);
            lvPhucVu.Items.Add(liv);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
