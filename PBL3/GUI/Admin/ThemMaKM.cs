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

namespace PBL3.GUI
{
    public partial class ThemMaKM : Form
    {
        public ThemMaKM()
        {
            InitializeComponent();
        }

        private void saveKM_Click(object sender, EventArgs e)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            var s = db.KhuyenMais.OrderByDescending(p => p.MaKM).FirstOrDefault();
            string makm = Convert.ToString(s.MaKM + 1);
            KhuyenMai_BLL.Instance.AddKhuyenMai(makm, tenKM.Text, guna2DateTimePicker1.Value, guna2DateTimePicker2.Value, moTa.Text, giaTri.Text);
            MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
