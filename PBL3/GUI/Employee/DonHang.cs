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
    public partial class DonHang : Form
    {
        private int maNV;

        public DonHang()
        {
            InitializeComponent();
        }

        public DonHang(int maNV)
        {
            this.maNV = maNV; InitializeComponent();

            ten.Text = NhanVien_BLL.Instance.getTenNV(maNV);
            donHangData.DataSource = BUS.DonHang_BLL.Instance.GetListDonHang();
            RefreshData();
        }

        private void RefreshData()
        {

            if (donHangData.Columns["MaDH"] != null)
                donHangData.Columns["MaDH"].HeaderText = "Mã đơn hàng";
            if (donHangData.Columns["MaSP"] != null)
                donHangData.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            if (donHangData.Columns["SoLuongSP"] != null)
                donHangData.Columns["SoLuongSP"].HeaderText = "Số lượng sản phẩm";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManHinhChinh_NV manHinhChinh = new ManHinhChinh_NV(maNV);
            this.Hide();
            manHinhChinh.Show();
            this.Close();
        }

        private void donHangExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (timKiemDonHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin đơn hàng cần tìm kiếm");
            }
            else
            {
                donHangData.DataSource = BUS.DonHang_BLL.Instance.GetListDonHangByID(Convert.ToInt32(timKiemDonHang.Text));
                if (donHangData.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng");
                }
                else
                {
                    RefreshData();
                }
            }
        }
    }
}
