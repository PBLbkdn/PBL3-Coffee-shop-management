using PBL3.BUS;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBL3.BUS
{
    internal class TaiKhoan_BLL
    {
        private static TaiKhoan_BLL _Instance;
        public static TaiKhoan_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TaiKhoan_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private TaiKhoan_BLL() { }
        public List<TaiKhoan> GetListTaiKhoan(int ID, string name)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();

            if (name == null)
                return db.TaiKhoans.ToList();
            else return db.TaiKhoans.Where(p => p.TenDangNhap.Contains(name)).ToList();

        }
        public void AddTaiKhoan(string manv, string tendangnhap, string mk )
        {
            TaiKhoan s = new TaiKhoan
            {
                MaNV = Convert.ToInt32(manv),
                TenDangNhap = tendangnhap,
                MatKhau = mk           
            };
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            db.TaiKhoans.Add(s);
            db.SaveChanges();
        }
        public void EditTaiKhoan(string manv, string tendangnhap, string mk)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            TaiKhoan sedit = db.TaiKhoans.Find(Convert.ToInt32(manv));
            sedit.TenDangNhap = tendangnhap;
            sedit.MatKhau = mk;            
            db.SaveChanges();
        }
        public void DeleteTaiKhoan(int id)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            TaiKhoan nvDelete = db.TaiKhoans.Find(id);
            db.TaiKhoans.Remove(nvDelete);
            db.SaveChanges();
        }
        public void LayThongTinTaiKhoan(int s, string manv, string tendangnhap, string mk)
        {
            manv = s.ToString();
            using (QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities())
            {
                foreach (TaiKhoan i in db.TaiKhoans)
                {
                    if (i.MaNV.ToString() == manv)
                    {
                        tendangnhap = i.TenDangNhap;
                        mk = i.MatKhau;
                    }
                }
            }
        }
        public int Check(string s)
        {
            int d = 0;
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            {
                foreach (TaiKhoan i in db.TaiKhoans)
                {
                    if (i.MaNV.ToString() == s)
                        d += 1;
                    break;
                }
            }
            return d;
        }
        public int Login(string username, string password, bool chucvu1, bool chucvu2)
        {
            if(!chucvu1 && !chucvu2)
            {
                return 2;               
            }
            else
            {
                QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
                var account = db.TaiKhoans.FirstOrDefault(a => a.TenDangNhap == username && a.MatKhau == password);

                if (account != null)
                {
                    var employee = db.NhanViens.FirstOrDefault(e => e.MaNV == account.MaNV);
                    if (employee != null)
                    {
                        int ma = 0;
                        if (chucvu1) ma = 1;
                        else ma = 2;
                        if (employee.MaCV == ma)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                            
                        }
                    }
                }
                return 4;
            }    
        }
    }
}
/*int x = TaiKhoan_BLL.Instance.Login(username.Text, password.Text, rbManager.Checked, rbStaff.Checked);
switch (x)
{
    case 1:
        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}*/