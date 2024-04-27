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
        public List<Object> GetListTaiKhoan(int ID, string name)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();

            if (name == null)
            {
                var l1 = db.TaiKhoans.Select(p => new { p.MaNV, p.NhanVien.HoTenNV, p.TenDangNhap, p.MatKhau });
                return l1.ToList<Object>();
            }
            else
            {
                var l2 = db.TaiKhoans.Where(p => p.NhanVien.HoTenNV.Contains(name)).Select(p => new { p.MaNV, p.NhanVien.HoTenNV, p.TenDangNhap, p.MatKhau });
                return l2.ToList<Object>();
            }

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
        public void LayThongTinTaiKhoan(int s, ref string manv, ref string tendangnhap, ref string mk)
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
