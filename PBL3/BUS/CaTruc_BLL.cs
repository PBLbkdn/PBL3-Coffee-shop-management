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

        public int GetCaTrucCoNV(int maNV, string Day)
        {
            List<CaTruc> list = GetListCaTruc();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].NgayTruc.ToString("yyyy-MM-dd") == Day)
                {
                    for (int j = 0; j < list[i].NhanViens.Count; j++)
                    {
                        if (list[i].NhanViens.ElementAt(j).MaNV == maNV)
                        {
                            return list[i].MaCT;
                        }
                    }
                }
            }
            return -1;
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

        public void TinhDoanhThuCa(string Day, int MaCa)
        {
            QuanCaPhePBL3Entities quanCaPhePBL3Entities = new QuanCaPhePBL3Entities();
            List<HoaDon> hoaDons = quanCaPhePBL3Entities.HoaDons.ToList();
            //giờ bắt đầu
            TimeSpan timeStart = new TimeSpan();
            //giờ kết thúc
            TimeSpan timeEnd = new TimeSpan();
            if (MaCa == 1)
            {
                timeStart = new TimeSpan(7, 0, 0);
                timeEnd = new TimeSpan(12, 0, 0);
            }
            else if (MaCa == 2)
            {
                timeStart = new TimeSpan(12, 0, 0);
                timeEnd = new TimeSpan(17, 0, 0);
            }
            else
            {
                timeStart = new TimeSpan(17, 0, 0);
                timeEnd = new TimeSpan(22, 0, 0);   
            }
            string month = Day.Substring(0, 2);
            string day = Day.Substring(3, 2);
            string year = Day.Substring(6, 4);
            //datetime bắt đầu tính cả giờ phút giây
            DateTime start = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day), timeStart.Hours, timeStart.Minutes, timeStart.Seconds);
            //datetime kết thúc tính cả giờ phút giây
            DateTime end = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day), timeEnd.Hours, timeEnd.Minutes, timeEnd.Seconds);
            long doanhThuCa = 0;
            for(int i = 0; i < hoaDons.Count; i++)
            {
                if (hoaDons[i].ThoiGian >= start && hoaDons[i].ThoiGian <= end)
                {
                    //kiểm tra xem đã có doanh thu của ca trực chưa
                    List<DoanhThu> listDT = quanCaPhePBL3Entities.DoanhThus.ToList();
                    for (int j = 0; j < listDT.Count; j++)
                    {
                        if (listDT[j].MaCT == MaCa && listDT[j].NgayTruc.ToString("MM-dd-yyyy") == Day)
                        {
                            return;
                        }
                    }
                    doanhThuCa += (long)hoaDons[i].TongTien;
                }
            }
            if(hoaDons.Count == 0)
            {
                return;
            }
            //tạo mới doanh thu
            DoanhThu doanhThu = new DoanhThu();
            doanhThu.MaCT = MaCa;
            doanhThu.NgayTruc = Convert.ToDateTime(Day);
            doanhThu.DoanhThuCT = doanhThuCa;
            doanhThu.DoanhThuNT = 0;
            //kiểm tra xem đã có doanh thu của ca đó chưa
            DoanhThu_BLL.Instance.AddDoanhThu(MaCa, Day, doanhThuCa);
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
