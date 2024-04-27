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
    public partial class ThongKeCa : Form
    {
        public ThongKeCa()
        {
            InitializeComponent();
            setComboBox();
        }

        private void setComboBox()
        {
            CaCb.Items.Add("Ca 1");
            CaCb.Items.Add("Ca 2");
            CaCb.Items.Add("Ca 3");
        }

        private void ThongKeCa_Load(object sender, EventArgs e)
        {

        }

        private void CaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maCa = CaCb.SelectedItem.ToString() == "Ca 1" ? 1 : CaCb.SelectedItem.ToString() == "Ca 2" ? 2 : 3;
            TkeCaData.DataSource = BUS.DoanhThu_BLL.Instance.GetDoanhThuCa(maCa,ngayTK.ToString());
        }

    }
}
