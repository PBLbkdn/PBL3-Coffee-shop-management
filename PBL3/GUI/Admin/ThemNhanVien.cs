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

namespace PBL3.GUI.Admin
{
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
            setCBB1();
            setCBB2();
        }
        public void setCBB1()
        {
            guna2ComboBox1.Items.Add("1");
            guna2ComboBox1.Items.Add("2");
            guna2ComboBox1.Items.Add("3");
            guna2ComboBox1.Items.Add("4");
        }
        public void setCBB2()
        {
            guna2ComboBox2.Items.Add("Nam");
            guna2ComboBox2.Items.Add("Nữ");
        }
        
       

        private void saveNV_Click(object sender, EventArgs e)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            var lastEmployee = db.NhanViens.OrderByDescending(p => p.MaNV).FirstOrDefault();
            string manv = Convert.ToString(lastEmployee.MaNV + 1);
            NhanVien_BLL.Instance.AddNhanVien(manv, guna2TextBox1.Text, guna2DateTimePicker1.Value, guna2TextBox2.Text, guna2TextBox3.Text, guna2ComboBox1.SelectedItem.ToString(), guna2ComboBox2.SelectedItem.ToString());
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void huy_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
