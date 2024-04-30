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
    public partial class SuaNguyenLieu : Form
    {
        public SuaNguyenLieu()
        {
            InitializeComponent();
        }
        public void GetThongTin(int s)
        {
            // Sửa sau
            /*string manl = maNV.Text;
            string hoten = tenNV.Text;
            DateTime ns = ngaySinh.Value;
            string sdt = soDienThoai.Text;
            string Luong = luong.Text;
            string macv = maCV.SelectedText;
            string gioitinh = gender.SelectedText;

            NguyenLieu_BLL.Instance.LayThongTinNguyenLieu(s, ref manl, ref hoten, ref ns, ref sdt, ref Luong, ref macv, ref gioitinh);

            maNV.Text = manv;
            tenNV.Text = hoten;
            ngaySinh.Value = ns;
            soDienThoai.Text = sdt;
            luong.Text = Luong;
            maCV.SelectedItem = macv;
            gender.SelectedItem = gioitinh;*/
        }
        private void saveNL_Click(object sender, EventArgs e)
        {
            // NguyenLieu_BLL.Instance.EditNguyenLieu(maNL.Text, tenNL.Text, sltk, toDay.Value, giaNhap.Text, donvi);
            MessageBox.Show("Cập nhật nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancelNL_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
