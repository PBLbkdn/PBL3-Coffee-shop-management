using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BUS
{
    internal class HoaDon_BLL
    {
        private static HoaDon_BLL _Instance;
        public static HoaDon_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new HoaDon_BLL();
                }
                return _Instance;
            }
            private set { }
        }


        public void AddHoaDon(int MaHD, int MaDH, int MaKH, DateTime ThoiGian, long TongTien)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            HoaDon hd = new HoaDon();
            hd.MaHD = MaHD;
            hd.MaDH = MaDH;
            hd.MaKH = MaKH;
            hd.ThoiGian = ThoiGian;
            hd.TongTien = TongTien;
            db.HoaDons.Add(hd);
            db.SaveChanges();
        }

        public List<HoaDon> GetListHoaDon()
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            return db.HoaDons.ToList();
        }
        public List<Object> GetListObject()
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<HoaDon> listHD = db.HoaDons.ToList();
            List<Object> res = new List<Object>();
            foreach (HoaDon hd in listHD)
            {
                res.Add(new { hd.MaHD, hd.MaDH, hd.MaKH, hd.ThoiGian, hd.TongTien });
            }
            return res;
        }
        
        public List<Object> GetListHoaDonByID(int MaHD)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<HoaDon> listHD = db.HoaDons.ToList();
            List<Object> res = new List<Object>();
            foreach (HoaDon hd in listHD)
            {
                if (hd.MaHD == MaHD)
                {
                    res.Add(new { hd.MaHD, hd.MaDH, hd.MaKH, hd.ThoiGian, hd.TongTien });
                }
            }
            return res;
        }
        public void DeleteHoaDon(int MaHD)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            HoaDon hd = db.HoaDons.Where(p => p.MaHD == MaHD).SingleOrDefault();
            db.HoaDons.Remove(hd);
            db.SaveChanges();
        }

        public void UpdateHoaDon(int MaHD, int MaDH, int MaKH, DateTime ThoiGian, long TongTien)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            HoaDon hd = db.HoaDons.Where(p => p.MaHD == MaHD).SingleOrDefault();
            hd.MaDH = MaDH;
            hd.MaKH = MaKH;
            hd.ThoiGian = ThoiGian;
            hd.TongTien = TongTien;
            db.SaveChanges();
        }

        public List<HoaDon> GetListHoaDonByDate(DateTime date)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<HoaDon> listHD = db.HoaDons.ToList();
            List<HoaDon> res = new List<HoaDon>();
            foreach (HoaDon hd in listHD)
            {
                if (hd.ThoiGian == date)
                {
                    res.Add(hd);
                }
            }
            return res;
        }


    }
}
