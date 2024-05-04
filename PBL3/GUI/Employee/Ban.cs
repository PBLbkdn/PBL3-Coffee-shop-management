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
    public partial class Ban : Form
    {
        private int maNV;

        public Ban()
        {
            InitializeComponent();
            RefreshData();
        }

        public Ban(int maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
            ten.Text = NhanVien_BLL.Instance.getTenNV(maNV);

            RefreshData();
        }

        private void RefreshData()
        {
            banData.DataSource = BUS.Ban_BLL.Instance.GetListBan();
            banData.Columns["MaBan"].HeaderText = "Mã bàn";
            banData.Columns["TrangThai"].HeaderText = "Trạng thái";
            banData.Columns["ViTri"].HeaderText = "Vị trí";

        }
        private void findButton_Click(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin bàn cần tìm kiếm");
            }
            else
            {
                if (BUS.Ban_BLL.Instance.GetBanByID(Convert.ToInt32(search.Text)).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy bàn");
                }
                else
                {
                    banData.DataSource = BUS.Ban_BLL.Instance.GetBanByID(Convert.ToInt32(search.Text));
                    banData.Columns["MaBan"].HeaderText = "Mã bàn";
                    banData.Columns["TrangThai"].HeaderText = "Trạng thái";
                    banData.Columns["ViTri"].HeaderText = "Vị trí";
                }
            }
        }

        private void datBan_Click(object sender, EventArgs e)
        {
            DatBan f = new DatBan(maNV);
            this.Hide();
            f.ShowDialog();
            this.Show();
            RefreshData();
        }

        private void banExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DangNhap dangNhap = new DangNhap();
                this.Hide();
                dangNhap.Show();
                this.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManHinhChinh_NV manHinhChinh = new ManHinhChinh_NV(maNV);
            this.Hide();
            manHinhChinh.Show();
            this.Close();
        }
    }
}
