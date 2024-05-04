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

namespace PBL3.GUI.Admin
{
    public partial class ThemTaiKhoan : Form
    {
        private int maNV1;

        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        public ThemTaiKhoan(int maNV1)
        {
            this.maNV1 = maNV1;
            InitializeComponent();
        }

        private void saveTK_Click(object sender, EventArgs e)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            TaiKhoan_BLL.Instance.AddTaiKhoan(maNV.Text, tenTK.Text, matKhau.Text);
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void huyTK_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
