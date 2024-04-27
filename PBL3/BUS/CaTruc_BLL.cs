using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;

namespace PBL3.BUS
{
    internal class CaTruc_BLL
    {
        private static CaTruc_BLL _Instance;
        public static CaTruc_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CaTruc_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private CaTruc_BLL() { }
        public List<CaTruc> GetListCaTruc()
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            return quanCaPheEntities.CaTrucs.ToList();
        }

        public List<Object> GetListNhanVien(int idCT, string day)
        {
            //lấy ra nhân viên trong ca trực 
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            List<CaTruc> list = quanCaPheEntities.CaTrucs.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaCT == idCT && list[i].NgayTruc.ToString() == day)
                {
                    //chỉ lấy một vài thông tin của nhân viên
                    var l1 = from p in list[i].NhanViens select new { p.MaNV, p.ChucVu.TenCV, p.HoTenNV, p.NgaySinh, p.Luong, p.GioiTinh };
                    return l1.ToList<Object>();
                }
            }
            return new List<Object>();
            
        }

        public CaTruc newCaTruc1()
        {
            CaTruc ca1 = new CaTruc();
            ca1.MaCT = 1;
            ca1.NgayTruc = DateTime.Now;
            ca1.ThoiGianBD = new TimeSpan(7, 0, 0);
            ca1.ThoiGianKT = new TimeSpan(12, 0, 0);
            return ca1;
        }
        public CaTruc newCaTruc2()
        {
            CaTruc ca2 = new CaTruc();
            ca2.MaCT = 2;
            ca2.NgayTruc = DateTime.Now;
            ca2.ThoiGianBD = new TimeSpan(12, 0, 0);
            ca2.ThoiGianKT = new TimeSpan(17, 0, 0);
            return ca2;
        }
        public CaTruc newCaTruc3()
        {
            CaTruc ca3 = new CaTruc();
            ca3.MaCT = 3;
            ca3.NgayTruc = DateTime.Now;
            ca3.ThoiGianBD = new TimeSpan(17, 0, 0);
            ca3.ThoiGianKT = new TimeSpan(22, 0, 0);
            return ca3;
        }
        public void AddCaTruc()
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            //kiểm tra có ca trực ngày hôm nay chưa

            List<CaTruc> list = quanCaPheEntities.CaTrucs.ToList();

            if (list.ElementAt(list.Count - 1).NgayTruc.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy"))
            {
                return;
            }
             quanCaPheEntities.CaTrucs.Add(newCaTruc1());
             quanCaPheEntities.CaTrucs.Add(newCaTruc2());
             quanCaPheEntities.CaTrucs.Add(newCaTruc3());
             quanCaPheEntities.SaveChanges();

        }

        public void AddNhanVienToCaTruc(int idNV, int id, string day)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            List<CaTruc> list = quanCaPheEntities.CaTrucs.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaCT == id && list[i].NgayTruc.ToString() == day)
                {
                    list[i].NhanViens.Add(quanCaPheEntities.NhanViens.Find(idNV));
                  
                    quanCaPheEntities.SaveChanges();
                    return;
                }
            }
        }

        public void DelNhanVienFromCaTruc(int idNV, int id, string day)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            List<CaTruc> list = quanCaPheEntities.CaTrucs.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaCT == id && list[i].NgayTruc.ToString() == day)
                {
                    list[i].NhanViens.Remove(quanCaPheEntities.NhanViens.Find(idNV));
                    quanCaPheEntities.SaveChanges();
                    return;
                }
            }
        }

        public void DeleteCaTruc(int id, string day)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            List<CaTruc> list = quanCaPheEntities.CaTrucs.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaCT == id && list[i].NgayTruc.ToString() == day)
                {
                    //xóa dòng doanh thu ca trong bảng doanh thu
                    List<DoanhThu> listDT = quanCaPheEntities.DoanhThus.ToList();
                    for (int j = 0; j < listDT.Count; j++)
                    {
                        if (listDT[j].MaCT == id && listDT[j].NgayTruc.ToString() == day)
                        {
                            quanCaPheEntities.DoanhThus.Remove(listDT[j]);
                            quanCaPheEntities.SaveChanges();
                            break;
                        }
                    }
                    //xóa danh sách nhân viên làm việc trong ca ra khỏi ca
                    list[i].NhanViens.Clear();
                    quanCaPheEntities.CaTrucs.Remove(list[i]);
                    quanCaPheEntities.SaveChanges();
                    return;
                }
            }           
        }
    }
}
