using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<Object> GetListKhachHang(int ID, string name)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();

            if (name == null)
            {
                var l1 = db.KhachHangs.Select(p => new { p.MaKH, p.MaLKH, p.TenKH, p.SDT, p.LoaiKhachHang.TenLKH });
                return l1.ToList<Object>();
            }

            else
            {
                var l1 = db.KhachHangs.Where(p => p.TenKH.Contains(name)).Select(p => new { p.MaKH, p.MaLKH, p.TenKH, p.SDT, p.LoaiKhachHang.TenLKH });
                return l1.ToList<Object>();
            }
        }
        public List<Object> GetListKHBySDT(string sdt)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List <object> l = new List<object>();
            foreach (KhachHang i in db.KhachHangs)
            {
                if (i.SDT == sdt)
                {
                    l.Add(new
                    {
                        MaKH = i.MaKH,
                        TenKH = i.TenKH,
                        SDT = i.SDT,
                        MaLKH = i.MaLKH,
                        LKH = i.LoaiKhachHang.TenLKH
                    });
                }
            }
            return l;
        }
        public List<Object> GetListKhachHang()
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<Object> list = new List<Object>();
            foreach (KhachHang i in db.KhachHangs)
            {
                list.Add(new
                {
                    MaKH = i.MaKH,
                    TenKH = i.TenKH,
                    SDT = i.SDT,
                    MaLKH = i.MaLKH,
                    LKH =i.LoaiKhachHang.TenLKH
                });
            }
            return list;
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
        public void EditKhachHang(string maso, string hoten, string sdt, string maloaikh)
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
