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

namespace PBL3.GUI.Employee
{
    public partial class XemThongTinBan : Form
    {
        public XemThongTinBan()
        {
            InitializeComponent();
        }

        public XemThongTinBan(int maBan)
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            MaBan.Visible = false;
            TrangThai.Visible = false;
            ViTri.Visible = false;
            NhanVienPhucVu.Visible = false;
            MaBan.Text = Ban_BLL.Instance.GetBan(1).MaBan.ToString();
            TrangThai.Text = Ban_BLL.Instance.GetBan(1).TrangThai;
            ViTri.Text = Ban_BLL.Instance.GetBan(1).ViTri;
            //nhanvien
            MaBan.Visible = true;
            TrangThai.Visible = true;
            ViTri.Visible = true;
            NhanVienPhucVu.Visible = true;
        }

       
        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            ManHinhChinh_NV manHinhChinh = new ManHinhChinh_NV();
            manHinhChinh.Show();
            this.Close();
        }
    }
}
