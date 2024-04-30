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
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            TKData.DataSource = TaiKhoan_BLL.Instance.GetListTaiKhoan(0, null);
        }

        private void addTK_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan f = new ThemTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
            TKData.DataSource = TaiKhoan_BLL.Instance.GetListTaiKhoan(0, null);
        }

        private void editTK_Click(object sender, EventArgs e)
        {
            int Manv = 0;
            if (TKData.SelectedRows.Count == 1)
            {
                Manv = Convert.ToInt32(TKData.SelectedRows[0].Cells["MaNV"].Value.ToString());
            }
            SuaTaiKhoan f = new SuaTaiKhoan();
            f.GetThongTin(Manv);
            this.Hide();
            f.ShowDialog();
            this.Show();
            TKData.DataSource = TaiKhoan_BLL.Instance.GetListTaiKhoan(0, null);
        }

        private void deleteTK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (TKData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in TKData.SelectedRows)
                    {
                        int MaNV = Convert.ToInt32(TKData.SelectedRows[0].Cells["MaNV"].Value.ToString());
                        TaiKhoan_BLL.Instance.DeleteTaiKhoan(MaNV);
                    }
                    TKData.DataSource = TaiKhoan_BLL.Instance.GetListTaiKhoan(0, null);
                }
            }
        }

        private void exitTK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
