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
    public partial class Ban : Form
    {
        public Ban()
        {
            InitializeComponent();
            banData.DataSource = BUS.Ban_BLL.Instance.GetListBan();
        }


        private void findButton_Click(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin bàn cần tìm kiếm");
            }
            else
            {
                if(BUS.Ban_BLL.Instance.GetBanByID(Convert.ToInt32(search.Text)).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy bàn");
                }
                else
                banData.DataSource = BUS.Ban_BLL.Instance.GetBanByID(Convert.ToInt32(search.Text));
            }
        }

        private void datBan_Click(object sender, EventArgs e)
        {
            DatBan f = new DatBan();
            this.Hide();
            f.ShowDialog();
            this.Show();
            reLoadData();
        }

        private void reLoadData()
        {
            banData.DataSource = BUS.Ban_BLL.Instance.GetListBan();
        }
    }
}
