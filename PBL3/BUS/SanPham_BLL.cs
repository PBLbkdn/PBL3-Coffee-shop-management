using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BUS
{
    internal class SanPham_BLL
    {
        private static SanPham_BLL _Instance;
        public static SanPham_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SanPham_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private SanPham_BLL() { }
        public List<Object> GetListSanPham(int ID, string name)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();  
                var l = db.SanPhams.Select(p => new {p.MaSP, p.TenSP, p.LoaiSP, p.NhomSP, p.DonViSP, p.GiaSP});
                return l.ToList<Object>();                    

        }
        public void AddSanPham(string masp, string tensp, string giasp, string loai, string nhom, string donvi)
        {
            SanPham s = new SanPham
            {
                MaSP = Convert.ToInt32(masp),
                TenSP = tensp,
                GiaSP = Convert.ToInt32(giasp),
                LoaiSP = loai,
                NhomSP = nhom,
                DonViSP = donvi
            };
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            db.SanPhams.Add(s);
            db.SaveChanges();
        }
        public void EditSanPham(string masp, string tensp, string giasp, string loai, string nhom, string donvi)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            SanPham sedit = db.SanPhams.Find(Convert.ToInt32(masp));
            sedit.TenSP = tensp;
            sedit.GiaSP = Convert.ToInt32(giasp);
            sedit.LoaiSP = loai;
            sedit.NhomSP = nhom;
            sedit.DonViSP = donvi;
            db.SaveChanges();
        }
        public void DeleteSanPham(int id)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            SanPham nlDelete = db.SanPhams.Find(id);
            db.SanPhams.Remove(nlDelete);
            db.SaveChanges();
        }
        public void LayThongTinSanPham(int s,ref string masp,ref string tensp, ref string giasp, ref string loai, ref string nhom, ref string donvi)
        {
            masp = s.ToString();
            using (QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities())
            {
                foreach (SanPham i in db.SanPhams)
                {
                    if (i.MaSP.ToString() == masp)
                    {
                        tensp = i.TenSP;
                        giasp = i.GiaSP.ToString();
                        loai = i.LoaiSP;
                        nhom = i.NhomSP;
                        donvi = i.DonViSP.ToString();
                    }
                }
            }
        }
        public int Check(string s)
        {
            int d = 0;
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            {
                foreach (SanPham i in db.SanPhams)
                {
                    if (i.MaSP.ToString() == s)
                        d += 1;
                    break;
                }
            }
            return d;
        }
    }
}
