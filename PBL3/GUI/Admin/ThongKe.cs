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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            setComboBox(); 
        }

        private void setComboBox()
        {
            TkeCb.Items.Add("Thống kê theo ca làm việc");
            TkeCb.Items.Add("Thống kê theo ngày");
            TkeCb.Items.Add("Thống kê theo tháng");
        }

        private void TkeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ThongKe = TkeCb.SelectedItem.ToString();
            if(ThongKe.Equals("Thống kê theo ca làm việc"))
            {
                thongKeData.DataSource = BUS.DoanhThu_BLL.Instance.GetListDoanhThuCa();
            }
            else if(ThongKe.Equals("Thống kê theo ngày"))
            {

                thongKeData.DataSource = BUS.DoanhThu_BLL.Instance.GetListDoanhThuNgay();
            }
            else if(ThongKe.Equals("Thống kê theo tháng"))
            {
                thongKeData.DataSource = BUS.DoanhThu_BLL.Instance.GetListDoanhThuThang();
            }   
        }
    }
}
