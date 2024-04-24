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
    public partial class ManHinhChinh_NV : Form
    {
        public ManHinhChinh_NV()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DatMon f = new DatMon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
