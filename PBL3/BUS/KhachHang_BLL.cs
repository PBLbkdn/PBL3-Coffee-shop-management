using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BUS
{
    internal class KhachHang_BLL
    {
        private static KhachHang_BLL _Instance;
        public static KhachHang_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new KhachHang_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private KhachHang_BLL() { }
        public List<KhachHang> GetListKhachHang(int ID, string name)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            if (ID == 0)
            {
                if (name == null)
                    return db.KhachHangs.ToList();
                else return db.KhachHangs.Where(p => p.TenKH.Contains(name)).ToList();
            }
            else
            {
                var l = db.KhachHangs.Where(p => p.MaKH == ID && p.TenKH.Contains(name));
                return l.ToList();
            }
        }
        public void AddKhachHang(string maso, string hoten, string sdt, string maloaikh)
        {
            KhachHang s = new KhachHang
            {
                MaKH = Convert.ToInt32(maso),
                TenKH = hoten,
                SDT = sdt,
                MaLKH = Convert.ToInt32(maloaikh),
            };
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            db.KhachHangs.Add(s);
            db.SaveChanges();
        }
        public void EditKhachHang(string maso, string hoten, string sdt,  string maloaikh)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            KhachHang sedit = db.KhachHangs.Find(Convert.ToInt32(maso));
            sedit.TenKH = hoten;
            sedit.SDT = sdt;
            sedit.MaLKH = Convert.ToInt32(maloaikh);
            db.SaveChanges();
        }
        public void DeleteKH(int id)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            KhachHang banDelete = db.KhachHangs.Find(id);
            db.KhachHangs.Remove(banDelete);
            db.SaveChanges();
        }
        public void LayThongTinNV(int s, string makh, string hoten, string sdt, string maloaikh)
        {
            makh = s.ToString();
            using (QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities())
            {
                foreach (KhachHang i in db.KhachHangs)
                {
                    if (i.MaKH.ToString() == makh)
                    {
                        hoten = i.TenKH;
                        sdt = i.SDT;
                        maloaikh = i.MaLKH.ToString();
                    }
                }
            }
        }
        public int Check(string s)
        {
            int d = 0;
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            {
                foreach (KhachHang i in db.KhachHangs)
                {
                    if (i.MaKH.ToString() == s)
                        d += 1;
                    break;
                }
            }
            return d;
        }
    }
}
