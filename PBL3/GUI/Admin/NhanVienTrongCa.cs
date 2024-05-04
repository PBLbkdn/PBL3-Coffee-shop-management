using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BUS;

namespace PBL3.GUI
{
    public partial class NhanVienTrongCa : Form
    {
        private int MaCa;
        private DateTime Day;
        private int maNV;

        public NhanVienTrongCa()
        {
            InitializeComponent();
        }

        public NhanVienTrongCa(int maCa, DateTime day)
        {
            InitializeComponent();
            MaCa = maCa;
            Day = day;
            dayTb.Text = day.Day.ToString();
            monthTb.Text = "Tháng "+day.Month.ToString();
            dayTb.Enabled = false;
            monthTb.Enabled = false;
            RefreshData();
        }

        public NhanVienTrongCa(int maCa, DateTime day, int maNV) : this(maCa, day)
        {
            this.maNV = maNV;
            ten.Text = NhanVien_BLL.Instance.getTenNV(maNV);
            InitializeComponent();
            MaCa = maCa;
            Day = day;
            dayTb.Text = day.Day.ToString();
            monthTb.Text = "Tháng " + day.Month.ToString();
            dayTb.Enabled = false;
            monthTb.Enabled = false;
            RefreshData();
        }

        private void RefreshData()
        {
            NVCadata.DataSource = CaTruc_BLL.Instance.GetListNhanVien(MaCa, Day.ToString());
            if (NVCadata.Columns["MaNV"] != null)
            NVCadata.Columns["MaNV"].HeaderText = "Mã nhân viên";
            if (NVCadata.Columns["HoTenNV"] != null)
            NVCadata.Columns["HoTenNV"].HeaderText = "Họ tên nhân viên";
            if (NVCadata.Columns["TenCV"] != null)
            NVCadata.Columns["TenCV"].HeaderText = "Chức vụ";
            if (NVCadata.Columns["NgaySinh"] != null)
            NVCadata.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            if (NVCadata.Columns["GioiTinh"] != null)
            NVCadata.Columns["GioiTinh"].HeaderText = "Giới tính";
            if (NVCadata.Columns["Luong"] != null)
            NVCadata.Columns["Luong"].HeaderText = "Lương";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            ThemNhanVienVaoCa f = new ThemNhanVienVaoCa(MaCa, Day, maNV);
            f.ShowDialog();
            RefreshData();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (NVCadata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn nhân viên cần xóa");
                return;
            }
            else
            {
                CaTruc_BLL.Instance.DelNhanVienFromCaTruc(Convert.ToInt32(NVCadata.SelectedRows[0].Cells["MaNV"].Value), MaCa, Day.ToString());
                RefreshData();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManHinhChinh manHinhChinh = new ManHinhChinh();
            manHinhChinh.Show();
            this.Close();
        }
    }
}
