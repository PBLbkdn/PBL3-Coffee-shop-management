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
        public List<KhuyenMai> GetListKhuyenMai(string name)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            if (name == null)
                return db.KhuyenMais.ToList();
            else return db.KhuyenMais.Where(p => p.TenCT.Contains(name)).ToList();
        }
        public void AddKhuyenMai(string maso, string ten, string BD, string KT, string mota, string gtri)
        {
            KhuyenMai s = new KhuyenMai
            {
                MaKM = Convert.ToInt32(maso),
                TenCT = ten,
                TGBatDau = Convert.ToDateTime(BD),
                TGKetThuc  = Convert.ToDateTime(BD),
                MoTa = mota,
                GiaTriKM = Convert.ToDecimal(gtri)
            };
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            db.KhuyenMais.Add(s);
            db.SaveChanges();
        }
        public void EditKhuyenMai(string maso, string tenct, DateTime tgianbd, DateTime tgiankt, string mota, double gtri)
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
        public void DeleteKH(int id)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            KhuyenMai banDelete = db.KhuyenMais.Find(id);
            db.KhuyenMais.Remove(banDelete);
            db.SaveChanges();
        }
        public void LayThongTinNV(int s, string makm, string tenct, string tgianbd, string tgiankt, string mota, string gtri)
        {
            makm = s.ToString();
            using (QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities())
            {
                foreach (KhuyenMai i in db.KhuyenMais)
                {
                    if (i.MaKM.ToString() == makm)
                    {
                        tenct = i.TenCT;
                        tgianbd = i.TGBatDau.ToString();
                        tgiankt = i.TGKetThuc.ToString();
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
