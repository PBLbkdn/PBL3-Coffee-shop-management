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
    public partial class ThongKe_NV : Form
    {
        private int maNV;

        public ThongKe_NV()
        {
            InitializeComponent();
            setTimeToday();

        }

        public ThongKe_NV(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;

            ten.Text = NhanVien_BLL.Instance.getTenNV(maNV);
            setTimeToday();
            Data();
        }

        private void Data()
        {
            int maCa=CaTruc_BLL.Instance.GetCaTrucCoNV(maNV, ngayTK.Value.ToString("yyyy-MM-dd"));
            List<Object> list = new List<Object>();
            list.Add(DoanhThu_BLL.Instance.GetDoanhThuCa(maCa, ngayTK.Value.ToString("yyyy-MM-dd")));
            TkeData.DataSource = list;
            
            
        }
        private void setTimeToday()
        {
            ngayTK.Value = DateTime.Now;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManHinhChinh_NV manHinhChinh = new ManHinhChinh_NV(maNV);
            manHinhChinh.Show();
            this.Close();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
