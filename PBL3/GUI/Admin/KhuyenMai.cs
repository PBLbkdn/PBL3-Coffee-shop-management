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
using System.Xml.Linq;

namespace PBL3.GUI
{
    public partial class KhuyenMai : Form
    {
        private int maNV;

        public KhuyenMai()
        {
            InitializeComponent();
            RefreshData();
        }

        public KhuyenMai(int maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
            ten.Text = NhanVien_BLL.Instance.getTenNV(maNV);
            RefreshData();
        }

        private void RefreshData()
        {
            KMData.DataSource = KhuyenMai_BLL.Instance.GetAllKM();
            if (KMData.Columns["MaKM"] != null)
                KMData.Columns["MaKM"].HeaderText = "Mã khuyến mãi";
            if (KMData.Columns["TenCT"] != null)
                KMData.Columns["TenCT"].HeaderText = "Tên chương trình";
            if (KMData.Columns["TGBatDau"] != null)
                KMData.Columns["TGBatDau"].HeaderText = "Thời gian bắt đầu";
            if (KMData.Columns["TGKetThuc"] != null)
                KMData.Columns["TGKetThuc"].HeaderText = "Thời gian kết thúc";
            if (KMData.Columns["MoTa"] != null)
                KMData.Columns["MoTa"].HeaderText = "Mô tả";
            if (KMData.Columns["GiaTriKM"] != null)
                KMData.Columns["GiaTriKM"].HeaderText = "Giá trị khuyến mãi";
        }
        private void addKM_Click(object sender, EventArgs e)
        {
            ThemMaKM f = new ThemMaKM();
            this.Hide();
            f.ShowDialog();
            this.Show();
            RefreshData();
        }

        private void editKM_Click(object sender, EventArgs e)
        {
            int Makm = 0;
            if (KMData.SelectedRows.Count == 1)
            {
                Makm = Convert.ToInt32(KMData.SelectedRows[0].Cells["MaNV"].Value.ToString());
            }
            SuaKhuyenMai f = new SuaKhuyenMai();
            f.GetThongTin(Makm);
            this.Hide();
            f.ShowDialog();
            this.Show();
            RefreshData();
        }

        private void deleteKM_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (KMData.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow i in KMData.SelectedRows)
                    {
                        int MaKM = Convert.ToInt32(KMData.SelectedRows[0].Cells["MaKM"].Value.ToString());
                        KhuyenMai_BLL.Instance.DeleteKM(MaKM);
                    }
                    KhuyenMai_BLL.Instance.GetAllKM();
                }
            }
            RefreshData();
        }

        private void exitKM_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManHinhChinh manHinhChinh = new ManHinhChinh(maNV);
            this.Hide();
            manHinhChinh.ShowDialog();
            Close();
        }
    }
}
