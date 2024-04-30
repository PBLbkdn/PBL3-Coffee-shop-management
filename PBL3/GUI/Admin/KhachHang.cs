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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            KHData.DataSource = KhachHang_BLL.Instance.GetListKhachHang(0, null);
        }

        private void searchKH_Click(object sender, EventArgs e)
        {
            string txt = findTextbox.Text;
            KHData.DataSource = KhachHang_BLL.Instance.GetListKhachHang(0, txt);
        }

        private void exitKH_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
