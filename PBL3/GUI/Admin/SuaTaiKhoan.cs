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
        private int maNV1;

        public SuaTaiKhoan()
        {
            InitializeComponent();
        }

        public SuaTaiKhoan(int maNV1)
        {
            this.maNV1 = maNV1;
            InitializeComponent();
        }

        public void GetThongTin(int s)
        {
            string manv = maNV.Text;
            string tentk = tenNV.Text;
            string mk = password.Text;
            TaiKhoan_BLL.Instance.LayThongTinTaiKhoan(s, ref manv, ref tentk, ref mk);
            maNV.Text = manv;
            tenNV.Text = tentk;
            password.Text = mk;
        }

        private void SaveTK_Click(object sender, EventArgs e)
        {
            TaiKhoan_BLL.Instance.EditTaiKhoan(maNV.Text, tenNV.Text, password.Text);
            MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancelTK_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
