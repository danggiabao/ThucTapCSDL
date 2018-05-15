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
    public partial class frThongKe : Form
    {
        public frThongKe()
        {
            InitializeComponent();
        }

        private void frThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNH2DataSet.DoanhThu' table. You can move, or remove it, as needed.
            this.DoanhThuTableAdapter.Fill(this.QLNH2DataSet.DoanhThu);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
