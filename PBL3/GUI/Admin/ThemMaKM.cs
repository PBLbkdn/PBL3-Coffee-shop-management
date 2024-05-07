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

namespace PBL3.GUI
{
    public partial class ThemMaKM : Form
    {
        public ThemMaKM()
        {
            InitializeComponent();
        }

        private void saveKM_Click(object sender, EventArgs e)
        {
            if(startDay.Value > endDay.Value)
            {
                MessageBox.Show("Thời gian bắt đầu không thể sau thời gian kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tenKM.Text == "" || giaTri.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //KhuyenMai_BLL.Instance.AddKhuyenMai(tenKM.Text, startDay.Value, endDay.Value, moTa.Text, giaTri.Text);
            MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
