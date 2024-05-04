using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.BUS
{
    internal class NhanVien_BLL
    {
        private static NhanVien_BLL _Instance;
        public static NhanVien_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NhanVien_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private NhanVien_BLL() { }
        public List<Object> GetListNhanVien(int ID, string name)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            if (ID == 0)
            {
                if (name == null)
                {
                    //return db.NhanViens.ToList();
                    var l1 = db.NhanViens.Select(p => new { p.MaNV, p.ChucVu.TenCV, p.HoTenNV, p.NgaySinh, p.Luong, GioiTinh = (p.GioiTinh == true) ? "Nam" : "Nữ" });
                    //var l1 = from p in db.NhanViens select new { p.MaNV};
                    return l1.ToList<Object>();
                }
                else
                {
                    var l2 = db.NhanViens.Where(p => p.HoTenNV.Contains(name))
                         .Select(p => new { p.MaNV, p.ChucVu.TenCV, p.HoTenNV, p.NgaySinh, p.Luong, GioiTinh = (p.GioiTinh == true) ? "Nam" : "Nữ" });
                    return l2.ToList<Object>();
                }
            }
            else
            {
                var l = db.NhanViens.Where(p => p.MaCV == ID && p.HoTenNV.Contains(name))
                    .Select(p => new { p.MaNV, p.ChucVu.TenCV, p.HoTenNV, p.NgaySinh, p.Luong, GioiTinh = (p.GioiTinh == true) ? "Nam" : "Nữ" });
                return l.ToList<Object>();
            }
        }
        public void AddNhanVien(string manv, string hoten, DateTime ns, string sdt, string luong, string macv, string gioitinh)
        {
            NhanVien s = new NhanVien
            {
                MaNV = Convert.ToInt32(manv),
                HoTenNV = hoten,
                NgaySinh = ns,
                SDT = sdt,
                Luong = Convert.ToInt32(luong),
                MaCV = Convert.ToInt32(macv),
                GioiTinh = (gioitinh == "Nam") ? true : false
            };
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            db.NhanViens.Add(s);
            db.SaveChanges();
        }
        public void EditNhanVien(string manv, string hoten, DateTime ns, string sdt, string luong, string macv, string gioitinh)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            NhanVien sedit = db.NhanViens.Find(Convert.ToInt32(manv));
            sedit.HoTenNV = hoten;
            sedit.NgaySinh = ns;
            sedit.SDT = sdt;
            sedit.Luong = Convert.ToInt32(luong);
            sedit.MaCV = Convert.ToInt32(macv);
            sedit.GioiTinh = (gioitinh == "Nam") ? true : false;
            db.SaveChanges();
        }
        public void DeleteNV(int id)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            NhanVien nvDelete = db.NhanViens.Find(id);
            db.NhanViens.Remove(nvDelete);
            db.SaveChanges();
        }
        public void LayThongTinNV(int s, ref string manv, ref string hoten, ref DateTime ns, ref string sdt, ref string luong, ref string macv, ref string gioitinh)
        {
            manv = s.ToString();
            using (QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities())
            {
                foreach (NhanVien i in db.NhanViens)
                {
                    if (i.MaNV.ToString() == manv)
                    {
                        hoten = i.HoTenNV;
                        sdt = i.SDT;
                        luong = i.Luong.ToString();
                        macv = i.MaCV.ToString();
                        ns = Convert.ToDateTime(i.NgaySinh);
                        if (Convert.ToBoolean(i.GioiTinh)) gioitinh = "Nam";
                        else gioitinh = "Nữ";
                        break;
                    }
                }
            }
        }
        public int Check(string s)
        {
            int d = 0;
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            {
                foreach (NhanVien i in db.NhanViens)
                {
                    if (i.MaNV.ToString() == s)
                        d += 1;
                    break;
                }
            }
            return d;
        }

        public string getTenNV(int maNV)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            return db.NhanViens.Find(maNV).HoTenNV;
        }
        public List<Int32> ListIDNV()
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<Int32> list = new List<Int32>();
            foreach (NhanVien i in db.NhanViens)
            {
                list.Add(i.MaNV);
            }
            return list;
        }
        public List<Object> ListNV()
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            var l1 = db.NhanViens.Select(p => new { p.MaNV, p.ChucVu.TenCV, p.HoTenNV, p.NgaySinh, p.Luong, p.GioiTinh });
            return l1.ToList<Object>();
        }

        public bool isValidCaTruc(int maNV, int maCa, DateTime day)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<CaTruc> list = db.NhanViens.Find(maNV).CaTrucs.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].NgayTruc == day && list[i].MaCT == maCa)
                    return false;
            }
            return true;
        }

        public int getmaCV(int maNV)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            return db.NhanViens.Find(maNV).MaCV;
        }
    }
}
