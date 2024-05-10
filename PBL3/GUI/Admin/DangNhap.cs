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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();

        }
        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(username.Text.Equals("") || password.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int x = TaiKhoan_BLL.Instance.Login(username.Text, password.Text, rbManager.Checked, rbStaff.Checked);
            
            switch (x)
            {
                case 1:
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int maNV = TaiKhoan_BLL.Instance.GetMaNV(username.Text, password.Text);
                    if (rbManager.Checked)
                    {
                        ManHinhChinh f = new ManHinhChinh(maNV);
                        this.Hide();
                        f.ShowDialog();
                        
                        this.Close();
                    }
                    else
                    {
                        ManHinhChinh_NV f = new ManHinhChinh_NV(maNV);
                        this.Hide();
                        f.ShowDialog();

                        this.Close();
                    }
                    break;
                case 2:
                    MessageBox.Show("Vui lòng chọn chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 3:
                    MessageBox.Show("Chức vụ không phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 4:
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mouseHover(object sender, EventArgs e)
        {
            password.PasswordChar = '\0';
            close.Visible = false;
            open.Visible = true;
        }

        private void mouseLeave(object sender, EventArgs e)
        {

            password.PasswordChar = '*';
            close.Visible = true;
            open.Visible = false;
        }
    }
}
