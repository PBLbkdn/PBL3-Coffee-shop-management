using Guna.UI2.WinForms;
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

namespace PBL3.GUI.Admin
{
    public partial class SuaTaiKhoan : Form
    {
        public SuaTaiKhoan()
        {
            InitializeComponent();
        }
        public void GetThongTin(int s)
        {
            string manv = guna2TextBox3.Text;
            string tentk = guna2TextBox1.Text;
            string mk = guna2TextBox4.Text;
            TaiKhoan_BLL.Instance.LayThongTinTaiKhoan(s, ref manv, ref tentk, ref mk);
            guna2TextBox3.Text = manv;
            guna2TextBox1.Text = tentk;
            guna2TextBox4.Text = mk;
        }

        private void SaveTK_Click(object sender, EventArgs e)
        {
            TaiKhoan_BLL.Instance.EditTaiKhoan(guna2TextBox3.Text, guna2TextBox1.Text, guna2TextBox4.Text);
            MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancelTK_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
