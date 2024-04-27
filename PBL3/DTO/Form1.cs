using PBL3.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.DTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lấy thông tin mã ca trực và ngày được chọn từ datagridview
            int MaCT = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaCT"].Value);
           string NgayTruc = dataGridView1.CurrentRow.Cells["NgayTruc"].Value.ToString();
           label1.Text=MaCT.ToString();
           label2.Text = NgayTruc;
            DoanhThu_BLL.Instance.AddDoanhThu(MaCT, NgayTruc, 200000);
            //DataGridView1.DataSource = CaTruc_BLL.Instance.GetListNhanVien(MaCT, NgayTruc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanCaPhePBL3Entities quanCaPhePBL3Entities = new QuanCaPhePBL3Entities();
            dataGridView1.DataSource = Ban_BLL.Instance.GetListBan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DoanhThu_BLL.Instance.GetListDoanhThu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
