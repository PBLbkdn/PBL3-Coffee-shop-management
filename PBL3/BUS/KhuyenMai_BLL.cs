using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BUS
{
    internal class KhuyenMai_BLL
    {
        private static KhuyenMai_BLL _Instance;
        public static KhuyenMai_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new KhuyenMai_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private KhuyenMai_BLL() { }
        public List<Object> GetListKhuyenMai(DateTime tgianbd, DateTime tgiankt, string name)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            var l = db.KhuyenMais.Where(p => p.TenCT.Contains(name) && p.TGBatDau >= tgianbd && p.TGKetThuc <= tgiankt)
                .Select(p => new { p.MaKM, p.TenCT, p.TGBatDau, p.TGKetThuc, p.MoTa, p.GiaTriKM });
            return l.ToList<Object>();
        }
        public List<Object> GetAllKM()
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            var l1 = db.KhuyenMais.Select(p => new { p.MaKM, p.TenCT, p.TGBatDau, p.TGKetThuc, p.MoTa, p.GiaTriKM });
            return l1.ToList<Object>();
        }
        public void AddKhuyenMai(string maso, string ten, DateTime BD, DateTime KT, string mota, string gtri)
        {
            KhuyenMai s = new KhuyenMai
            {
                MaKM = Convert.ToInt32(maso),
                TenCT = ten,
                TGBatDau = BD,
                TGKetThuc = KT,
                MoTa = mota,
                GiaTriKM = Convert.ToDecimal(gtri)
            };
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            db.KhuyenMais.Add(s);
            db.SaveChanges();
        }
        public void EditKhuyenMai(string maso, string tenct, DateTime tgianbd, DateTime tgiankt, string mota, string gtri)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            KhuyenMai sedit = db.KhuyenMais.Find(Convert.ToInt32(maso));
            sedit.TenCT = tenct;
            sedit.TGBatDau = tgianbd;
            sedit.TGKetThuc = tgiankt;
            sedit.MoTa = mota;
            sedit.GiaTriKM = Convert.ToDecimal(gtri);
            db.SaveChanges();
        }
        public void DeleteKM(int id)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            KhuyenMai banDelete = db.KhuyenMais.Find(id);
            db.KhuyenMais.Remove(banDelete);
            db.SaveChanges();
        }
        public void LayThongTinKM(int s, ref string makm, ref string tenct, ref DateTime tgianbd, ref DateTime tgiankt, ref string mota, ref string gtri)
        {
            makm = s.ToString();
            using (QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities())
            {
                foreach (KhuyenMai i in db.KhuyenMais)
                {
                    if (i.MaKM.ToString() == makm)
                    {
                        tenct = i.TenCT;
                        tgianbd = Convert.ToDateTime(i.TGBatDau);
                        tgiankt = Convert.ToDateTime(i.TGKetThuc);
                        mota = i.MoTa;
                        gtri = i.GiaTriKM.ToString();
                    }
                }
            }
        }
        public int Check(string s)
        {
            int d = 0;
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            {
                foreach (KhuyenMai i in db.KhuyenMais)
                {
                    if (i.MaKM.ToString() == s)
                        d += 1;
                    break;
                }
            }
            return d;
        }
    }
}
