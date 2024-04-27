using Guna.UI2.WinForms;
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

namespace PBL3.GUI
{
    public partial class CaLamViec : Form
    {
        public CaLamViec()
        {
            InitializeComponent();
            setMonth(); 
            setYear();
            Label[] week = { dayOfMonday, dayOfTuesday, dayOfWednesday, dayOfThursday, dayOfFriday, dayOfSaturday, dayOfSunday };
            for (int i = 0; i < 7; i++)
            {
                week[i].Visible = false;
            }
            CaTruc_BLL.Instance.AddCaTruc();
        }

        private void setMonth()
        {
            for (int i = 1; i <= 12; i++)
            {
                monthCbb.Items.Add(i);
            }
        }

        private void setYear()
        {
            for (int i = 2024; i <= DateTime.Now.Year; i++)
            {
                yearCbb.Items.Add(i);
            }            
        }

        private void setCalendar()
        {
            //hiện lịch tháng lên màn hình
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime firstDay = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfWeek = (int)firstDay.DayOfWeek;   
            //ngày đầu tiên của tháng là thứ mấy
            int day = 1;
            Label[] week = {dayOfMonday, dayOfTuesday, dayOfWednesday, dayOfThursday, dayOfFriday, dayOfSaturday, dayOfSunday};
            for (int i = 0; i < 7; i++)
            {
                week[i].Visible = true;
                week[i].Text = "";
            }
            for (int i = 0; i < 7; i++)
            {
                if (dayOfWeek == 0)
                {
                    week[6].Text = day.ToString();
                    break;
                }
                if (i + 1 < dayOfWeek )
                {
                    week[i].Text = "";                    
                }
                else
                {
                    week[i].Text = day.ToString();
                    day++;
                }
            }
        }

        //cần test
        private void nextWeek(object sender, EventArgs e)
        {
            if(monthCbb.SelectedItem == null || yearCbb.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tháng và năm trước khi xem lịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime firstDay = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int dayOfWeek = (int)firstDay.DayOfWeek;
             
            
            Label[] week = { dayOfSunday, dayOfMonday, dayOfTuesday, dayOfWednesday, dayOfThursday, dayOfFriday, dayOfSaturday };
            int day=1;
            for(int i = 6; i >= 0; i++)
            {
                if (week[i].Text != "")
                {
                    day = Convert.ToInt32(week[i]);
                    break;
                }
            }
            if(day == daysInMonth)
            {
                return;
            }
            else
            {
                day++;
                DateTime today = new DateTime(year, month, day);
                int dayOfThisWeek = (int)today.DayOfWeek;
                for (int i = 0; i < 7; i++)
                {
                    if (i < dayOfThisWeek)
                    {
                        week[i].Text = "";
                    }
                    else
                    {
                        week[i].Text = day.ToString();
                        day++;
                    }
                }
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monthCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(monthCbb.SelectedItem != null && yearCbb.SelectedItem != null)
            {
                setCalendar();
            }
        }

        private void yearCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(monthCbb.SelectedItem != null && yearCbb.SelectedItem != null)
            {
                setCalendar();
            }
        }

        private void sangThuHai(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfMonday.Text == null) return;
            string day = dayOfMonday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void CaLamViec_Load(object sender, EventArgs e)
        {

        }

        private void chieuT2(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfMonday.Text == null) return;
            string day = dayOfMonday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void toiThuHai(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfMonday.Text == null) return;
            string day = dayOfMonday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void sangThuSau_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfFriday.Text == null) return;
            string day = dayOfFriday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void sangThuBa_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfTuesday.Text == null) return;
            string day = dayOfTuesday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();

        }

        private void sangThuTu_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfWednesday.Text == null) return;
            string day = dayOfWednesday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();

        }

        private void sangThuNam_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfThursday.Text == null) return;
            string day = dayOfThursday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void sangThuBay_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfSaturday.Text == null) return;
            string day = dayOfSaturday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void sangChuNhat_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfSunday.Text == null) return;
            string day = dayOfSunday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void chieuThuBa_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfTuesday.Text == null) return;
            string day = dayOfTuesday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void chieuThuTu_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfWednesday.Text == null) return;
            string day = dayOfWednesday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void chieuThuNam_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfThursday.Text == null) return;
            string day = dayOfThursday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void ChieuThuSau_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfFriday.Text == null) return;
            string day = dayOfFriday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void ChieuThuBay_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfSaturday.Text == null) return;
            string day = dayOfSaturday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void ChieuChuNhat_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfSunday.Text == null) return;
            string day = dayOfSunday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void toiThuBa_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfTuesday.Text == null) return;
            string day = dayOfTuesday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void toiThuTu_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfWednesday.Text == null) return;
            string day = dayOfWednesday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void toiThuNam_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfThursday.Text == null) return;
            string day = dayOfThursday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void toiThuSau_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfFriday.Text == null) return;
            string day = dayOfFriday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void toiThuBay_Click(object sender, EventArgs e)
        {

            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfSaturday.Text == null) return;
            string day = dayOfSaturday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }

        private void toiChuNhat_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string maCa = btn.Tag.ToString();
            if (dayOfSunday.Text == null) return;
            string day = dayOfSunday.Text;
            int dayNum = Convert.ToInt32(day);
            int month = Convert.ToInt32(monthCbb.SelectedItem);
            int year = Convert.ToInt32(yearCbb.SelectedItem);
            DateTime today = new DateTime(year, month, dayNum);
            this.Hide();
            NhanVienTrongCa nhanVienTrongCa = new NhanVienTrongCa(Convert.ToInt32(maCa), today);
            nhanVienTrongCa.Show();
        }
    }
}
