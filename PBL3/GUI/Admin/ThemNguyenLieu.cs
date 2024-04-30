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
    public partial class ThemNguyenLieu : Form
    {
        public ThemNguyenLieu()
        {
            InitializeComponent();
        }

        private void saveNL_Click(object sender, EventArgs e)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            var s = db.NguyenLieux.OrderByDescending(p => p.MaNL).FirstOrDefault();
            string manl = Convert.ToString(s.MaNL + 1);
            // NguyenLieu_BLL.Instance.AddNguyenLieu(manl, tenNL.Text, slTK, ngayHetHan.Value, giaNhap.Text, donvi);
            MessageBox.Show("Thêm nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancelNL_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
