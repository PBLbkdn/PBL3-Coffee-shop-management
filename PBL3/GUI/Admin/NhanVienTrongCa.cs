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
    public partial class NhanVienTrongCa : Form
    {
        public NhanVienTrongCa()
        {
            InitializeComponent();
            QuanCaPheEntities quanCaPheEntities = new QuanCaPheEntities();
            dataGridView1.DataSource= quanCaPheEntities.NhanViens.ToList();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
