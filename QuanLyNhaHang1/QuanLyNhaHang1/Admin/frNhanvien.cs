﻿using System;
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
    public partial class frNhanvien : Form
    {
        public frNhanvien()
        {
            InitializeComponent();
            searchBox.ForeColor = Color.LightGray;
            searchBox.Text = "Tìm kiếm";
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4IRSTF4;Initial Catalog=QLNH2;Integrated Security=True");
        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Showlv()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from NHANVIEN";
            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                liv.SubItems.Add(reader.GetString(2));
                liv.SubItems.Add(reader.GetDateTime(3).ToString("dd/MM/yyyy"));
                liv.SubItems.Add(reader.GetString(4));
                lvNV.Items.Add(liv);
            }
            reader.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frNhanvien_Load(object sender, EventArgs e)
        {
            this.Showlv();
        }

        private void searchBox_DragLeave(object sender, EventArgs e)
        {

        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Tìm kiếm";
                searchBox.ForeColor = Color.Gray;
            }
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Tìm kiếm")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }
    }
}
