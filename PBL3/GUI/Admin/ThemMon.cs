using Guna.UI2.WinForms;
using PBL3.BUS;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class ThemMon : Form
    {
        public ThemMon()
        {
            InitializeComponent();
        }

        private void saveSP_Click(object sender, EventArgs e)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            var s = db.SanPhams.OrderByDescending(p => p.MaSP).FirstOrDefault();
            string masp = Convert.ToString(s.MaSP + 1);
            string loai;
            if (rBdrink.Checked)
            {
                loai = "Đồ uống";
            }
            else loai = "Món ăn";
            SanPham_BLL.Instance.AddSanPham(masp, guna2TextBox1.Text, guna2TextBox4.Text, loai, guna2TextBox5.Text, guna2TextBox2.Text);
            MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancelSP_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
