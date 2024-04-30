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
    public partial class SuaNhanVien : Form
    {
        public SuaNhanVien()
        {
            InitializeComponent();
            setCBB1();
            setCBB2();
        }
        public void setCBB1()
        {
            maCV.Items.Add("1");
            maCV.Items.Add("2");
            maCV.Items.Add("3");
            maCV.Items.Add("4");
        }
        public void setCBB2()
        {
            gender.Items.Add("Nam");
            gender.Items.Add("Nữ");
        }
        public void GetThongTin(int s)
        {
            string manv = maNV.Text;
            string hoten = tenNV.Text;
            DateTime ns = ngaySinh.Value;
            string sdt = soDienThoai.Text;
            string Luong = luong.Text;
            string macv = maCV.SelectedText;
            string gioitinh = gender.SelectedText;

            NhanVien_BLL.Instance.LayThongTinNV(s, ref manv, ref hoten, ref ns, ref sdt, ref Luong, ref macv, ref gioitinh);

            maNV.Text = manv;
            tenNV.Text = hoten;
            ngaySinh.Value = ns;
            soDienThoai.Text = sdt;
            luong.Text = Luong;
            maCV.SelectedItem = macv;
            gender.SelectedItem = gioitinh;
        }

        private void saveNV_Click(object sender, EventArgs e)
        {
            NhanVien_BLL.Instance.EditNhanVien(maNV.Text, tenNV.Text, ngaySinh.Value, soDienThoai.Text, luong.Text, maCV.SelectedItem.ToString(), gender.SelectedItem.ToString());
            MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancelNV_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
