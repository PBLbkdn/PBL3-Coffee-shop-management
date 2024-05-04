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

namespace PBL3.GUI
{
    public partial class ThemNhanVienVaoCa : Form
    {
        private int MaCa;
        private DateTime Day;
        private int maNV;

        public ThemNhanVienVaoCa()
        {
            InitializeComponent();

        }

        public ThemNhanVienVaoCa(int maCa, DateTime day)
        {
            InitializeComponent();
            MaCa = maCa;
            Day = day;
            setComboBox();
            ListNV();
        }

        public ThemNhanVienVaoCa(int maCa, DateTime day, int maNV) : this(maCa, day)
        {
            this.maNV = maNV;
            InitializeComponent();
            MaCa = maCa;
            Day = day;
            setComboBox();
            ListNV();
        }

        private void setComboBox()
        {
            maNVCb.DataSource = NhanVien_BLL.Instance.ListIDNV();
        }
        private void ListNV()
        {
            NVData.DataSource = NhanVien_BLL.Instance.ListNV();
            if (NVData.Columns["MaNV"] != null)
                NVData.Columns["MaNV"].HeaderText = "Mã nhân viên";
            if (NVData.Columns["HoTenNV"] != null)
                NVData.Columns["HoTenNV"].HeaderText = "Họ tên nhân viên";
            if (NVData.Columns["TenCV"] != null)
                NVData.Columns["TenCV"].HeaderText = "Chức vụ";
            if (NVData.Columns["NgaySinh"] != null)
                NVData.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            if (NVData.Columns["GioiTinh"] != null)
                NVData.Columns["GioiTinh"].HeaderText = "Giới tính";
            if (NVData.Columns["Luong"] != null)
                NVData.Columns["Luong"].HeaderText = "Lương";
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (maNVCb.SelectedItem == null) {
                MessageBox.Show("Chọn nhân viên cần thêm");
                return;
            }
            else {
                bool test = NhanVien_BLL.Instance.isValidCaTruc(Convert.ToInt32(maNVCb.SelectedItem), MaCa, Day);
                if (test == false)
                {
                    MessageBox.Show("Nhân viên đã có trong ca trực");
                    return;
                }
                else
                {
                    CaTruc_BLL.Instance.AddNhanVienToCaTruc(Convert.ToInt32(maNVCb.SelectedItem), MaCa, Day.ToString());
                    MessageBox.Show("Thêm nhân viên vào ca thành công");
                    this.Close();
                }
            } 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
