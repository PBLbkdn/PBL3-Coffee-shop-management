using PBL3.BUS;
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

namespace PBL3.GUI.Admin
{
    public partial class ThemNguyenLieu : Form
    {
        private int maNV;

        public ThemNguyenLieu()
        {
            InitializeComponent();
        }

        public ThemNguyenLieu(int maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
        }
        private void RefreshData()
        {
            NLData.DataSource = NguyenLieu_BLL.Instance.GetListNguyenLieu();
        }
        private void saveNL_Click(object sender, EventArgs e)
        {
            if(maNL.Text == "" || tenNL.Text == "" ||soLuongNhap.Text == "" || giaNhap.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if(ngayNhap.Value > ngayHetHan.Value)
            {
                MessageBox.Show("Ngày nhập không thể sau ngày hết hạn");
                return;
            }
            if(tenNL.Enabled == true)
            {
                
            }
            else
            {
                ChiTietNguyenLieu_BLL.Instance.AddChiTietNguyenLieu(Convert.ToInt32(maNL.Text), ngayNhap.Value, Convert.ToInt32(soLuongNhap.Text), ngayHetHan.Value, Convert.ToInt32(giaNhap.Text));
            }
        }

        private void cancelNL_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void NLData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maNL.Text = NLData.CurrentRow.Cells[0].Value.ToString();
            tenNL.Text = NLData.CurrentRow.Cells[1].Value.ToString();
            tenNL.Enabled = false;
        }
    }
}
