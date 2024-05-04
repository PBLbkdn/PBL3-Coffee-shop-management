using PBL3.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI.Employee
{
    public partial class DatBan : Form
    {
        private int maNV;

        public DatBan()
        {
            InitializeComponent();
            if (Ban_BLL.Instance.GetListBanFree().Count == 0)
            {
                MessageBox.Show("Không có bàn trống");
                this.Close();
            }

            RefreshData();

        }

        public DatBan(int maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
            if (Ban_BLL.Instance.GetListBanFree().Count == 0)
            {
                MessageBox.Show("Không có bàn trống");
                this.Close();
            }

            RefreshData();
        }

        private void RefreshData()
        {
            datBanData.DataSource = Ban_BLL.Instance.GetListBanFree();
            datBanData.Columns["MaBan"].HeaderText = "Mã Bàn";
            datBanData.Columns["TrangThai"].HeaderText = "Trạng Thái";
            datBanData.Columns["ViTri"].HeaderText = "Vị Trí";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (datBanData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bàn");
            }
            else
            {
                int MaBan = Convert.ToInt32(datBanData.SelectedRows[0].Cells["MaBan"].Value);
                string TrangThai = "Bàn đã được đặt trước";
                Ban_BLL.Instance.EditBan(MaBan, TrangThai);
                MessageBox.Show("Đặt bàn thành công");
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            ManHinhChinh_NV manHinhChinh = new ManHinhChinh_NV(maNV);
            manHinhChinh.Show();
            this.Close();
        }
    }
}
