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
    public partial class DatMon : Form
    {
        private int maNV;

        public DatMon()
        {
            InitializeComponent();
        }

        public DatMon(int maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ChonBan f = new ChonBan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
