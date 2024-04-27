using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Remoting.Contexts;
using PBL3.BUS;
using Guna.UI2.WinForms;

namespace PBL3.GUI
{
    public partial class SuaMon : Form
    {
        public SuaMon()
        {
            InitializeComponent();
        }
        public void GetThongTin(int s)
        {
            string masp = guna2TextBox6.Text;
            string tensp = guna2TextBox1.Text;
            string giasp = guna2TextBox4.Text;
            string loai = "";
            string nhom = guna2TextBox5.Text;
            string donvi = guna2TextBox2.Text;
            SanPham_BLL.Instance.LayThongTinSanPham(s, ref masp, ref tensp, ref giasp, ref loai, ref nhom, ref donvi);
            guna2TextBox6.Text = masp;
            guna2TextBox1 .Text = tensp;    
            guna2TextBox4 .Text = giasp;
            guna2TextBox5.Text = nhom;
            guna2TextBox2.Text = donvi;
            if (loai == "Đồ uống")
                rBdrink.Checked = true;
            else rBdrink.Checked = false;
        }
        private void saveSP_Click(object sender, EventArgs e)
        {
            string loai;
            if (rBdrink.Checked)
            {
                loai = "Đồ uống";
            }
            else loai = "Món ăn";
            SanPham_BLL.Instance.EditSanPham(guna2TextBox6.Text, guna2TextBox1.Text, guna2TextBox4.Text, loai, guna2TextBox5.Text,guna2TextBox2.Text );
            MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}