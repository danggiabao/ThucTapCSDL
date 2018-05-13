using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang1
{
    class DataConnections
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-J3GADKO\SQLEXPRESS;Initial Catalog=QLNH2;Integrated Security=True");
        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
