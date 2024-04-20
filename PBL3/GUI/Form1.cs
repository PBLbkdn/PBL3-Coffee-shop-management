using PBL3.DAO;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<NhanVien> list = new List<NhanVien>();
            string s = @"Data Source=DESKTOP-9SBKOG0\NGUYET;Initial Catalog=QuanCaPhe;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            string query = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dr);
            dataGridView1.DataSource = dataTable;


            //lấy dữ liệu từ NhanVienDao để hiển thị lên datagridview

        }
    }
}

