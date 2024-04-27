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
<<<<<<< HEAD
            dataGridView1.DataSource =  NhanVien_BLL.Instance.GetListNhanVien(0, null);
        }       

        private void addNV_Click(object sender, EventArgs e)
        {
            ThemNhanVien f = new ThemNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, null);
=======
            NVData.DataSource =  NhanVien_BLL.Instance.GetListNhanVien(0, null);
>>>>>>> ad2a925fee2710b2773f06a3c7b20b28a3fd18e4
        }

        private void editNV_Click(object sender, EventArgs e)
        {
            int Manv = 0;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Manv = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaNV"].Value.ToString());
            }
            SuaNhanVien f = new SuaNhanVien();
            f.GetThongTin(Manv);
            this.Hide();
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, null);
        }

        private void deleteNV_Click(object sender, EventArgs e)
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

        private void searchNV_Click(object sender, EventArgs e)
        {
            string txt = guna2TextBox1.Text;
            dataGridView1.DataSource = NhanVien_BLL.Instance.GetListNhanVien(0, txt);
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
