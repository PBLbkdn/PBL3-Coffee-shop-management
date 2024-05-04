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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

            NVData.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, null);
        }

        private void addNV_Click(object sender, EventArgs e)
        {
            ThemNhanVien f = new ThemNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
            NVData.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, null);

        }

        private void editNV_Click(object sender, EventArgs e)
        {
            int Manv = 0;
            if (NVData.SelectedRows.Count == 1)
            {
                Manv = Convert.ToInt32(NVData.SelectedRows[0].Cells["MaNV"].Value.ToString());
            }
            SuaNhanVien f = new SuaNhanVien();
            f.GetThongTin(Manv);
            this.Hide();
            f.ShowDialog();
            this.Show();
            NVData.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, null);
        }

        private void deleteNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (NVData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in NVData.SelectedRows)
                    {
                        int MaNV = Convert.ToInt32(NVData.SelectedRows[0].Cells["MaNV"].Value.ToString());
                        NhanVien_BLL.Instance.DeleteNV(MaNV);
                    }
                    NVData.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, null);
                }
            }
        }

        private void searchNV_Click(object sender, EventArgs e)
        {
            string txt = nameNVTb.Text;
            NVData.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, txt);
        }

        private void exitNV_Click(object sender, EventArgs e)
        {
            this.Dispose();
            /* DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result == DialogResult.Yes)
             {
                 this.Dispose();
                 DangNhap f = new DangNhap();
                 this.Hide();
                 f.ShowDialog();
                 this.Show();
             }*/
        }
    }
}
