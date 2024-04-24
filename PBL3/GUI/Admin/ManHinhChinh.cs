using PBL3.DTO;
using PBL3.GUI.Admin;
using PBL3.GUI.Employee;
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
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Admin.TaiKhoan f = new Admin.TaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Admin.NhanVien f = new Admin.NhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);          
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        /*private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Picture.Properties.Resources.chinh;
        }*/
    }
}
