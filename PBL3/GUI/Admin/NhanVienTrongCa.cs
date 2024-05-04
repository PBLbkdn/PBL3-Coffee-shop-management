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

        private void RefreshData()
        {
            NVCadata.DataSource = CaTruc_BLL.Instance.GetListNhanVien(MaCa, Day.ToString());
            NVCadata.Columns["MaNV"].HeaderText = "Mã nhân viên";
            NVCadata.Columns["HoTenNV"].HeaderText = "Họ tên nhân viên";
            NVCadata.Columns["TenCV"].HeaderText = "Chức vụ";
            NVCadata.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            NVCadata.Columns["GioiTinh"].HeaderText = "Giới tính";
            NVCadata.Columns["Luong"].HeaderText = "Lương";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
                this.Close();
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ThemNhanVienVaoCa f = new ThemNhanVienVaoCa(MaCa, Day, maNV);
            this.Hide();
=======
            ThemNhanVienVaoCa f = new ThemNhanVienVaoCa(MaCa, Day);
>>>>>>> 9d8423669730f19c9633237d6286879ceacbfaac
            f.ShowDialog();
            this.Show();
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
<<<<<<< HEAD

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManHinhChinh manHinhChinh = new ManHinhChinh(maNV);
            manHinhChinh.Show();
            this.Close();
        }

        private void exitCa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
                this.Close();
            }
        }
=======
>>>>>>> 9d8423669730f19c9633237d6286879ceacbfaac
    }
}
