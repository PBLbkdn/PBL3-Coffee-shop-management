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
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
            setCBB1();
            setCBB2();
        }
        public void setCBB1()
        {
            maChucVu.Items.Add("1");
            maChucVu.Items.Add("2");
            maChucVu.Items.Add("3");
            maChucVu.Items.Add("4");
        }
        public void setCBB2()
        {
            gioiTinh.Items.Add("Nam");
            gioiTinh.Items.Add("Nữ");
        }



        private void saveNV_Click(object sender, EventArgs e)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            var lastEmployee = db.NhanViens.OrderByDescending(p => p.MaNV).FirstOrDefault();
            string manv = Convert.ToString(lastEmployee.MaNV + 1);
            NhanVien_BLL.Instance.AddNhanVien(manv, tenNV.Text, ngaySinh.Value, sdt.Text, luong.Text, maChucVu.SelectedItem.ToString(), gioiTinh.SelectedItem.ToString());
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void huy_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
