using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BUS
{
    internal class DonHang_BLL
    {
        private static DonHang_BLL _Instance;
        public static DonHang_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DonHang_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        public void AddDonHang(int MaDH, int MaSP, int SoLuongSP)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            DonHang dh = new DonHang();
            dh.MaDH = MaDH;
            dh.MaSP = MaSP;
            dh.SoLuongSP = SoLuongSP;
            db.DonHangs.Add(dh);
            db.SaveChanges();
        }

        public void AddDonHang(int MaDH, int[] MaSP, int[] SoLuongSP)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            for(int i = 0; i < MaSP.Length; i++)
            {
                DonHang dh = new DonHang();
                dh.MaDH = MaDH;
                dh.MaSP = MaSP[i];
                dh.SoLuongSP = SoLuongSP[i];
                db.DonHangs.Add(dh);
                db.SaveChanges();
            }
        } 

      
        public List<Object> GetListDonHang()
        {
            QuanCaPhePBL3Entities quanCaPhePBL3Entities = new QuanCaPhePBL3Entities();
            List<Object> list = new List<Object>();
            List<DonHang> listDH = quanCaPhePBL3Entities.DonHangs.ToList();
            for (int i = 0; i < listDH.Count; i++)
            {
                Object obj = new
                {
                    MaDH = listDH[i].MaDH,
                    MaSP = listDH[i].MaSP,
                    SoLuongSP = listDH[i].SoLuongSP
                };
                list.Add(obj);
            }
            return list;
        }
        
        public List<Object> GetListDonHangByID(int MaDH)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<DonHang> listDH = db.DonHangs.ToList();
            List<Object> listDHByID = new List<Object>();
            for (int i = 0; i < listDH.Count; i++)
            {
                if (listDH[i].MaDH == MaDH)
                {
                    Object obj = new
                    {
                        MaDH = listDH[i].MaDH,
                        MaSP = listDH[i].MaSP,
                        SoLuongSP = listDH[i].SoLuongSP
                    };
                    listDHByID.Add(obj);
                }
            }
            return listDHByID;
        }
        public DonHang GetDonHang(int maDH, int maSP, int SoLuongSP)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<DonHang> list = db.DonHangs.ToList();
            for(int i=0; i<list.Count; i++)
            {
                if (list[i].MaDH==maDH && list[i].MaSP==maSP && list[i].SoLuongSP==SoLuongSP)
                {
                    return list[i];
                }
            }
            return null;
        }

        public long TinhTien(int maHD)
        {
            long TongTien = 0;
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<Object> listDH = GetListDonHangByID(maHD);
            /*for(int i=0; i<listDH.Count; i++)
            {
                SanPham sp = SanPham_BLL.Instance.GetSanPham(listDH[i].MaSP);
                TongTien += sp.GiaSP * listDH[i].SoLuongSP;
            }*/
            //lấy mã khách hàng
            //HoaDon_BLL.Instance.AddHoaDon(maHD, maHD, maKH, DateTime.Now, TongTien);
            //tạo chi tiết hóa đơn
            return TongTien;
        }
        public void UpdateDonHang(int MaDH, int MaSP, int SoLuongSP)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<DonHang> listDH = db.DonHangs.ToList();
            for(int i=0;i<listDH.Count;i++)
            {
                if (listDH[i].MaDH==MaDH && listDH[i].MaSP == MaSP) 
                {
                    listDH[i].SoLuongSP = SoLuongSP;
                    db.SaveChanges();
                    return;
                }
            }
        }

        public void DeleteDonHang(int MaDH, int MaSP)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<DonHang> listDH = db.DonHangs.ToList();
            for (int i = 0; i < listDH.Count; i++)
            {
                if (listDH[i].MaDH == MaDH && listDH[i].MaSP == MaSP)
                {
                    db.DonHangs.Remove(listDH[i]);
                    db.SaveChanges();
                    return;
                }
            }
        }

        public void DelDonHang(int MaDH)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<DonHang> listDH = db.DonHangs.ToList();
            for (int i = 0; i < listDH.Count; i++)
            {
                if (listDH[i].MaDH == MaDH )
                {
                    db.DonHangs.Remove(listDH[i]);
                    db.SaveChanges();
                }
            }
        }

    }
}
