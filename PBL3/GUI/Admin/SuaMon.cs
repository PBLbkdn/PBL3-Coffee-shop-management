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
            string masp = maMon.Text;
            string tensp = tenMon.Text;
            string giasp = giaBan.Text;
            string loai = "";
            string nhom = nhomThucDon.Text;
            string donvi = donViTinh.Text;
            SanPham_BLL.Instance.LayThongTinSanPham(s, ref masp, ref tensp, ref giasp, ref loai, ref nhom, ref donvi);
            maMon.Text = masp;
            tenMon.Text = tensp;
            giaBan.Text = giasp;
            nhomThucDon.Text = nhom;
            donViTinh.Text = donvi;
            if (loai == "Đồ uống")
                doUongRb.Checked = true;
            else doUongRb.Checked = false;
        }
        private void saveSP_Click(object sender, EventArgs e)
        {
            string loai;
            if (doUongRb.Checked)
            {
                loai = "Đồ uống";
            }
            else loai = "Món ăn";
            SanPham_BLL.Instance.EditSanPham(maMon.Text, tenMon.Text, giaBan.Text, loai, nhomThucDon.Text, donViTinh.Text);
            MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}