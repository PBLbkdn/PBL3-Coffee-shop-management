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
            setComboBoxMaCa();
        }

        private void RefreshData()
        {
            foreach (DataGridViewColumn column in thongKeData.Columns)
            {
                if (column.HeaderText == "MaCT")
                {
                    column.HeaderText = "Mã Ca";
                }
                else if (column.HeaderText == "NgayTruc")
                {
                    column.HeaderText = "Ngày Trực";
                }
                else if (column.HeaderText == "DoanhThuCT")
                {
                    column.HeaderText = "Doanh Thu Ca Trực";
                }
                else if (column.HeaderText == "DoanhThuNT")
                {
                    column.HeaderText = "Doanh Thu Ngày Trực";
                }
            }
        }

        private void setComboBoxMaCa()
        {
            MaCaCB.Items.Add("Ca 1");
            MaCaCB.Items.Add("Ca 2");
            MaCaCB.Items.Add("Ca 3");
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
                RefreshData();
                labelCaLamViec.Visible = true;
                MaCaCB.Visible = true;
                labelTG.Visible = true;
                ThoiGian.Visible = true;
                ThoiGian.Enabled = true;
                Tim.Visible = true;
            }
            else if(ThongKe.Equals("Thống kê theo ngày"))
            {
                labelCaLamViec.Visible = false;
                MaCaCB.Visible = false;
                MaCaCB.SelectedItem = null;
                labelTG.Visible = true;
                ThoiGian.Visible = true;
                ThoiGian.Enabled = true;
                Tim.Visible = true;
                thongKeData.DataSource = BUS.DoanhThu_BLL.Instance.GetListDoanhThuNgay();
                RefreshData();
            }
            else if(ThongKe.Equals("Thống kê theo tháng"))
            {
                thongKeData.DataSource = BUS.DoanhThu_BLL.Instance.GetListDoanhThuThang();
                RefreshData();
            }   
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            if(MaCaCB.SelectedItem == null && MaCaCB.Visible==true)
            {
                MessageBox.Show("Vui lòng chọn ca làm việc");
            }
            else if(ThoiGian.Value > DateTime.Now && ThoiGian.Visible == true)
            {
                MessageBox.Show("Vui lòng chọn thời gian hợp lệ");
            }
            else
            {
                List<Object> data = new List<Object>();
                if (MaCaCB.Visible == false)
                {
                    thongKeData.DataSource = null;
                    
                    data=BUS.DoanhThu_BLL.Instance.GetListDoanhThuNgayByNgay(ThoiGian.Value.ToString("yyyy-MM-dd"));
                    
                }
                else
                {
                    int MaCa = MaCaCB.SelectedItem.ToString() == "Ca 1" ? 1 : MaCaCB.SelectedItem.ToString() == "Ca 2" ? 2 : 3;
                    string day = ThoiGian.Value.ToString("yyyy-MM-dd");
                    thongKeData.DataSource = null;
                    data.Add(BUS.DoanhThu_BLL.Instance.GetDoanhThuCa(MaCa, day));
                }
                thongKeData.DataSource = data;
                RefreshData();
                if (thongKeData.DataSource == null)
                {
                    MessageBox.Show("Không có dữ liệu");
                }
            }
        }

        private void TkeExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
