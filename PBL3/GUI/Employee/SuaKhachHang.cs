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
    public partial class SuaKhachHang : Form
    {
        private string MaKH;
        private string TenKH;
        private string Sdt;
        private string MaLKH;
        public SuaKhachHang(string maKH, string tenKH, string sdt, string maLKH)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.Sdt = sdt;
            this.MaLKH = maLKH;
            InitializeComponent();
            tenKhachHang.Text = tenKH;
            sdtKH.Text = sdt;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(tenKhachHang.Text == "" || sdtKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(sdtKH.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KhachHang_BLL.Instance.EditKhachHang(MaKH, tenKhachHang.Text, sdtKH.Text, MaLKH);
            this.Close();
        }
    }
}
