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


        private void dangxuat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TKeButton_Click(object sender, EventArgs e)
        {
            ThongKe f = new ThongKe();
            this.Hide();
            f.ShowDialog();
        }

        private void CLVButton_Click(object sender, EventArgs e)
        {
            CaLamViec f = new CaLamViec();
            this.Hide();
            f.Show();
        }


        ///>>>
        private void TKButton_Click(object sender, EventArgs e)
        {
            Admin.TaiKhoan f = new Admin.TaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void NVButton_Click(object sender, EventArgs e)
        {
            Admin.NhanVien f = new Admin.NhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

<<<<<<< HEAD
        private void KHButton_Click(object sender, EventArgs e)
=======
        private void CLVButton_Click(object sender, EventArgs e)
        {
            CaLamViec f = new CaLamViec();
            this.Hide();
            f.Show(); 
        }

        private void CLVButton_Click(object sender, EventArgs e)
        {
            GUI.CaLamViec f = new GUI.CaLamViec();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void KHButton_Click(object sender, EventArgs e)
        {
            Admin.KhachHang f = new Admin.KhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void KMButton_Click(object sender, EventArgs e)
        {
            GUI.KhuyenMai f = new GUI.KhuyenMai();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void HDButton_Click(object sender, EventArgs e)
        {

        }

        private void TDButton_Click(object sender, EventArgs e)
        {
            GUI.ThucDon f = new GUI.ThucDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void NLButton_Click(object sender, EventArgs e)
        {
            Admin.NguyenLieu f = new Admin.NguyenLieu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void TKeButton_Click(object sender, EventArgs e)
        {
            Admin.ThongKe f = new Admin.ThongKe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        /*private void ManHinhChinh_Load(object sender, EventArgs e)
>>>>>>> ad2a925fee2710b2773f06a3c7b20b28a3fd18e4
>>>>>>> 325c48bc9835b8c313490f561998ad3c7a00220c
        {
            Admin.KhachHang f = new Admin.KhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void KMButton_Click(object sender, EventArgs e)
        {
            Khuyến_mãi f = new Khuyến_mãi();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void TDButton_Click(object sender, EventArgs e)
        {
            ThucDon f = new ThucDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void NLButton_Click(object sender, EventArgs e)
        {
            Admin.NguyenLieu f = new Admin.NguyenLieu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
