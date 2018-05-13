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
    public partial class frmTimKiemHoaDon : Form
    {
        DataConnections con = new DataConnections();
        public frmTimKiemHoaDon()
        {
            InitializeComponent();
        }
        private void TimKiemHD(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con.conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);     //vận chuyển dữ liệu về
            DataTable dt = new DataTable();                 //tạo 1 kho ảo để chứa dữ liệu
            da.Fill(dt);
            dgvHoaDon.DataSource = dt;
        }
        private void frmTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            if (frHoaDon.cmb == "THEO MÃ HÓA ĐƠN")
            {
                TimKiemHD("select MAHD,NGAYLAP,GIOTHANHTOAN,MANV,MAKH from HOADON WHERE MAHD LIKE '%" + frHoaDon.Temp + "%'");
            }
            if (frHoaDon.cmb == "Theo Mã khách hàng")
            {
                TimKiemHD("select MAHD,NGAYLAP,GIOTHANHTOAN,NHANVIEN.MANV,KHACHHANG.MAKH from HOADON,KHACHHANG,NHANVIEN WHERE KHACHHANG.MAKH=HOADON.MAKH AND HOADON.MANV=NHANVIEN.MANV and HOADON.MAKH LIKE '%" + frHoaDon.Temp + "%'");

            }
            if (frHoaDon.cmb == "Theo Mã nhân viên")
            {
                TimKiemHD("select MAHD,NGAYLAP,GIOTHANHTOAN,NHANVIEN.MANV,KHACHHANG.MAKH from HOADON,KHACHHANG,NHANVIEN WHERE HOADON.MAKH=KHACHHANG.MAKH AND HOADON.MANV=NHANVIEN.MANV and HOADON.MANV LIKE '%" + frHoaDon.Temp + "%'");
            }
        }

    }
}
