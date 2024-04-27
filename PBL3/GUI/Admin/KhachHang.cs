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

namespace PBL3.GUI.Admin
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void KhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KhachHang_BLL.Instance.GetListKhachHang(0, null);
        }

        private void searchKH_Click(object sender, EventArgs e)
        {
            string txt = textboxTenKH.Text;
            dataGridView1.DataSource = KhachHang_BLL.Instance.GetListKhachHang(0, txt);
        }

        private void exitKH_Click(object sender, EventArgs e)
        {
            this.Dispose();
=======
        private void exitKH_Click(object sender, EventArgs e)
        {
            Application.Exit();
>>>>>>> ad2a925fee2710b2773f06a3c7b20b28a3fd18e4
        }
    }
}
