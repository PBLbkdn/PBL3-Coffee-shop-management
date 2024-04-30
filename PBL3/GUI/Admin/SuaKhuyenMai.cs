using PBL3.BUS;
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
    public partial class SuaKhuyenMai : Form
    {
        public SuaKhuyenMai()
        {
            InitializeComponent();
        }
        public void GetThongTin(int s)
        {
            string makm = maKM.Text;
            string tenkm = tenKM.Text;
            DateTime tgianbd = fromDay.Value;
            DateTime tgiankt = toDay.Value;
            string mota = moTa.Text;
            string gtrikm = giaTriKM.Text;
            KhuyenMai_BLL.Instance.LayThongTinKM(s, ref makm, ref tenkm, ref tgianbd, ref tgiankt, ref mota, ref gtrikm);
            maKM.Text = makm;
            tenKM.Text = tenkm;
            fromDay.Value = tgianbd;
            toDay.Value = tgiankt;
            moTa.Text = mota;
            giaTriKM.Text = gtrikm;
        }
        private void saveKM_Click(object sender, EventArgs e)
        {
            KhuyenMai_BLL.Instance.EditKhuyenMai(maKM.Text, tenKM.Text, fromDay.Value, toDay.Value, moTa.Text, giaTriKM.Text);
            MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancelKM_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
