using PBL3.BUS;
using PBL3.GUI.Admin;
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
    public partial class ThucDon : Form
    {
        public ThucDon()
        {
            InitializeComponent();
        }       

        private void addSp_Click(object sender, EventArgs e)
        {
            ThemMon f = new ThemMon();
            this.Hide();
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = SanPham_BLL.Instance.GetListSanPham(0, null);
        }

        private void ThucDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SanPham_BLL.Instance.GetListSanPham(0, null);
        }

        private void editSP_Click(object sender, EventArgs e)
        {
            int Masp = 0;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Masp = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaSP"].Value.ToString());
            }
            SuaMon f = new SuaMon();
            f.GetThongTin(Masp);
            this.Hide();
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, null);
        }

        private void deleteSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                    {
                        int Masp = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaSP"].Value.ToString());
                        NhanVien_BLL.Instance.DeleteNV(Masp);
                    }
                    dataGridView1.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, null);
                }
            }
        }

        private void exitSP_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
