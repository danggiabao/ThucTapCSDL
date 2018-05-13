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
    public partial class frmTimKiemNhanVien : Form
    {
        DataConnections con = new DataConnections() ;
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }
        private void TimKiemNV(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con.conn);         //bắt đầu truy vấn
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);     //vận chuyển dữ liệu về
            DataTable dt = new DataTable();                 //tạo 1 kho ảo để chứa dữ liệu
            da.Fill(dt);                                    //đổ dữ liệu vào kho
            dgvNhanVien.DataSource = dt;                    //đổ dữ liệu vào dgvNhanVien
        }
        private void frmTimKiemNanVien_Load(object sender, EventArgs e)
        {
            if (frNhanvien.cmb == "Theo Mã Nhân Viên")
            {
                TimKiemNV("select MANV,HOTEN,GIOITINH,NGAYSINH,QUEQUAN from NHANVIEN WHERE MANV LIKE '%" + frNhanvien.Temp + "%'");
            }

            if (frNhanvien.cmb == "Theo Họ Tên")
            {
                TimKiemNV("select MANV,HOTEN,GIOITINH,NGAYSINH,QUEQUAN from NHANVIEN WHERE HOTEN LIKE N'%" + frNhanvien.Temp + "%'");
            }
            if (frNhanvien.cmb == "Theo Quê Quán")
            {
                TimKiemNV("select MANV,HOTEN,GIOITINH,NGAYSINH,QUEQUAN from NHANVIEN WHERE QUEQUAN LIKE '%" + frNhanvien.Temp + "%'");
            }
        }    
    }
}
