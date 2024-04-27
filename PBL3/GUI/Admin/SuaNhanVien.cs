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
    public partial class SuaNhanVien : Form
    {
        public SuaNhanVien()
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
        public void GetThongTin(int s)
        {
            string manv = guna2TextBox3.Text;
            string hoten = guna2TextBox1.Text;
            DateTime ns = guna2DateTimePicker1.Value;
            string sdt = guna2TextBox2.Text;
            string luong = guna2TextBox4.Text;
            string macv = guna2ComboBox1.SelectedText;
            string gioitinh = guna2ComboBox2.SelectedText;

            NhanVien_BLL.Instance.LayThongTinNV(s, ref manv, ref hoten, ref ns, ref sdt, ref luong, ref macv, ref gioitinh);

            guna2TextBox3.Text = manv;
            guna2TextBox1.Text = hoten;
            guna2DateTimePicker1.Value = ns;
            guna2TextBox2.Text = sdt;
            guna2TextBox4.Text = luong;
            guna2ComboBox1.SelectedItem = macv;
            guna2ComboBox2.SelectedItem = gioitinh;
        }
       
        private void saveNV_Click(object sender, EventArgs e)
        {
            NhanVien_BLL.Instance.EditNhanVien(guna2TextBox3.Text, guna2TextBox1.Text, guna2DateTimePicker1.Value, guna2TextBox2.Text, guna2TextBox4.Text, guna2ComboBox1.SelectedItem.ToString(), guna2ComboBox2.SelectedItem.ToString());
            MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancelNV_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
