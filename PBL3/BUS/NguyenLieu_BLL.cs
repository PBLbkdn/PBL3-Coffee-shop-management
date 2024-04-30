using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BUS
{
    internal class NguyenLieu_BLL
    {
        private static NguyenLieu_BLL _Instance;
        public static NguyenLieu_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NguyenLieu_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private NguyenLieu_BLL() { }
        public List<Object> GetListNguyenLieu(int ID, string name)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();

            if (name == null)
            {
                var l1 = db.NguyenLieux.Select(p => new { p.MaNL, p.TenNL, p.NgayHetHan, p.GiaNhap, p.SLTonKho, p.DonViTinh });
                return l1.ToList<Object>();
            }
            else
            {
                var l2 = db.NguyenLieux.Where(p => p.TenNL.Contains(name))
                    .Select(p => new { p.MaNL, p.TenNL, p.NgayHetHan, p.GiaNhap, p.SLTonKho, p.DonViTinh });
                return l2.ToList<Object>();
            }

        }
        public void AddNguyenLieu(string manl, string tennl, string SLtonkho, DateTime ngayhethan, string gia, string donvi)
        {
            NguyenLieu s = new NguyenLieu
            {
                MaNL = Convert.ToInt32(manl),
                TenNL = tennl,
                SLTonKho = Convert.ToInt32(SLtonkho),
                NgayHetHan = ngayhethan,
                GiaNhap = Convert.ToInt32(gia),
                DonViTinh = donvi
            };
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            db.NguyenLieux.Add(s);
            db.SaveChanges();
        }
        public void EditNguyenLieu(string manl, string tennl, string SLtonkho, DateTime ngayhethan, string gia, string donvi)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            NguyenLieu sedit = db.NguyenLieux.Find(Convert.ToInt32(manl));
            sedit.TenNL = tennl;
            sedit.SLTonKho = Convert.ToInt32(SLtonkho);
            sedit.NgayHetHan = ngayhethan;
            sedit.GiaNhap = Convert.ToInt32(gia);
            sedit.DonViTinh = donvi;
            db.SaveChanges();
        }
        public void DeleteNguyenLieu(int id)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            NguyenLieu nlDelete = db.NguyenLieux.Find(id);
            db.NguyenLieux.Remove(nlDelete);
            db.SaveChanges();
        }
        public void LayThongTinNguyenLieu(int s, ref string manl, ref string tennl, ref string SLtonkho, ref DateTime ngayhethan, ref string gia, ref string donvi)
        {
            manl = s.ToString();
            using (QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities())
            {
                foreach (NguyenLieu i in db.NguyenLieux)
                {
                    if (i.MaNL.ToString() == manl)
                    {
                        tennl = i.TenNL;
                        SLtonkho = i.SLTonKho.ToString();
                        ngayhethan = Convert.ToDateTime(i.NgayHetHan);
                        gia = i.GiaNhap.ToString();
                        donvi = i.DonViTinh.ToString();
                    }
                }
            }
        }
        public int Check(string s)
        {
            int d = 0;
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            {
                foreach (NguyenLieu i in db.NguyenLieux)
                {
                    if (i.MaNL.ToString() == s)
                        d += 1;
                    break;
                }
            }
            return d;
        }
    }
}
