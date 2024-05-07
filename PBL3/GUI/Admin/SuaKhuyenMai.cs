using PBL3.BUS;
using PBL3.GUI.Employee;
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
    public partial class SuaKhuyenMai : Form
    {
        private int makm;

        public SuaKhuyenMai(int makm)
        {
            InitializeComponent();
            this.makm = makm;
            maKM.Text = makm.ToString();
            DTO.KhuyenMai km = KhuyenMai_BLL.Instance.GetKhuyenMai(makm);
            tenKM.Text = km.TenCT;
            startDay.Value = km.TGBatDau.Value;
            endDay.Value = km.TGKetThuc.Value;
            moTa.Text = km.MoTa;
            giaTriKM.Text = km.GiaTriKM.ToString();
            TongHoaDon.Text = km.GiaTriDHToiThieu.ToString();
            for(int i=0;i<km.LoaiKhachHangs.Count;i++)
            {
                int maLKH = km.LoaiKhachHangs.ElementAt(i).MaLKH;
                if (maLKH == 1)
                {
                    KHTT.Checked = true;
                }
                if (maLKH == 2)
                {
                    KHM.Checked = true;
                }
                if(maLKH == 3)
                {
                    KH.Checked = true;
                }
            }
        }

        private void saveKM_Click(object sender, EventArgs e)
        {
            if (startDay.Value > endDay.Value)
            {
                MessageBox.Show("Thời gian bắt đầu không thể sau thời gian kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tenKM.Text == "" || giaTriKM.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (KHTT.Checked == false && KH.Checked == false && KHM.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn đối tượng áp dụng khuyến mãi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n;
            if (!int.TryParse(TongHoaDon.Text, out n))
            {
                MessageBox.Show("Giá trị đơn hàng tối thiểu phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(TongHoaDon.Text) < 0)
            {
                MessageBox.Show("Giá trị đơn hàng tối thiểu không thể nhỏ hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal n1;

            if (!decimal.TryParse(giaTriKM.Text, out n1))
            {
                MessageBox.Show("Giá trị khuyến mãi phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDecimal(giaTriKM.Text) <= 0 || Convert.ToDecimal(giaTriKM.Text) >= 1)
            {
                MessageBox.Show("Giá trị khuyến mãi không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            KhuyenMai_BLL.Instance.EditKhuyenMai(maKM.Text, tenKM.Text, startDay.Value, endDay.Value, moTa.Text, giaTriKM.Text, TongHoaDon.Text, KHTT.Checked, KHM.Checked, KH.Checked);
            MessageBox.Show("Cập nhật khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancelKM_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void SuaKMExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
