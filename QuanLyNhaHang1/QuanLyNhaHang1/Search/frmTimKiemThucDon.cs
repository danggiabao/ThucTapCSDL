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
    public partial class frmTimKiemThucDon : Form
    {
        DataConnections con = new DataConnections();
        public frmTimKiemThucDon()
        {
            InitializeComponent();
        }
        private void TimKiem(string sql) {
        // lấy hết dữ liệu ở bảng nhân viên
            SqlCommand cm = new SqlCommand(sql, con.conn);   // bắt đầu truy vấn
            cm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cm);     //vận chuyển dữ liệu về
            DataTable dt = new DataTable();                 //tạo 1 kho ảo để chứa dữ liệu
            da.Fill(dt);
            dgvMonAn.DataSource = dt;//hiển thị dữ liệu  
        }
        private void frmTimKiemThucDon_Load(object sender, EventArgs e)
        {
            if (frThucDon.cmb == "Theo Mã Món")
            {
                TimKiem("select MAMON,TENMON,DONGIA,TENNM from MONAN,NHOMMON WHERE MONAN.MANM=NHOMMON.MANM and MAMON LIKE '%" + frThucDon.Temp + "%'");
            }
            if (frThucDon.cmb == "Theo Tên Món")
            {
                TimKiem("select MAMON,TENMON,DONGIA,TENNM from MONAN,NHOMMON WHERE MONAN.MANM=NHOMMON.MANM and TENMON LIKE N'%" + frThucDon.Temp + "%'");
            }
            if (frThucDon.cmb == "Theo Nhóm Món")
            {
                TimKiem("select MAMON,TENMON,DONGIA,TENNM from MONAN,NHOMMON WHERE MONAN.MANM=NHOMMON.MANM and TENNM LIKE N'%" + frThucDon.Temp + "%'");
            }
        }
    }
}
