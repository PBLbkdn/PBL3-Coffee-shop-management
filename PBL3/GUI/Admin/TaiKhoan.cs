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
            dataGridView1.DataSource = TaiKhoan_BLL.Instance.GetListTaiKhoan(0, null);
        }

        private void addTK_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan f = new ThemTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, null);
        }

        private void editTK_Click(object sender, EventArgs e)
        {
            int Manv = 0;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Manv = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaNV"].Value.ToString());
            }
            SuaTaiKhoan f = new SuaTaiKhoan();
            f.GetThongTin(Manv);
            this.Hide();
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, null);
        }

        private void deleteTK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                    {
                        int MaNV = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaNV"].Value.ToString());
                        NhanVien_BLL.Instance.DeleteNV(MaNV);
                    }
                    dataGridView1.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, null);
                }
            }
        }

        private void exitTK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
