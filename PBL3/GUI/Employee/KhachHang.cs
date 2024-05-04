using PBL3.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI.Employee
{
    public partial class KhachHang : Form
    {
        private int maNV;
        public KhachHang()
        {
            InitializeComponent();
        }

        public KhachHang(int maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
            ten.Text=NhanVien_BLL.Instance.getTenNV(maNV);
            KHData.DataSource = KhachHang_BLL.Instance.GetListKhachHang();
            RefreshData();
        }

        private void RefreshData()
        {
            if (KHData.Columns["MaKH"]!=null)
            {
                KHData.Columns["MaKH"].HeaderText = "Mã khách hàng";
            }
            if (KHData.Columns["TenKH"] != null)
            {
                KHData.Columns["TenKH"].HeaderText = "Họ tên khách hàng";
            }
            if (KHData.Columns["SDT"] != null)
            {
                KHData.Columns["SDT"].HeaderText = "Số điện thoại";
            }
            if (KHData.Columns["MaLKH"]!= null)
            {
                KHData.Columns["MaLKH"].HeaderText = "Mã loại khách hàng";
            }
            if (KHData.Columns["LoaiKH"] != null)
            {
                KHData.Columns["LoaiKH"].HeaderText = "Loại khách hàng";
            }

        }

        private void KHExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
                this.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManHinhChinh_NV manHinhChinh = new ManHinhChinh_NV(maNV);
            manHinhChinh.Show();
            this.Close();
        }

    }
}
