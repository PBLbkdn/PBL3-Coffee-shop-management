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
            NVCadata.DataSource= CaTruc_BLL.Instance.GetListNhanVien(maCa, day.ToString());
            dayTb.Text = day.Day.ToString();
            monthTb.Text = "Tháng "+day.Month.ToString();
            dayTb.Enabled = false;
            monthTb.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            ThemNhanVienVaoCa f = new ThemNhanVienVaoCa(MaCa, Day);
            f.ShowDialog();
            NVCadata.DataSource = CaTruc_BLL.Instance.GetListNhanVien(MaCa, Day.ToString());
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
                NVCadata.DataSource = CaTruc_BLL.Instance.GetListNhanVien(MaCa, Day.ToString());
            }
        }
    }
}
