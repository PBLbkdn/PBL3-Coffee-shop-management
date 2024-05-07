using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;

namespace PBL3.BUS
{
    internal class DoanhThu_BLL
    {
        private static DoanhThu_BLL _Instance;
        public static DoanhThu_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DoanhThu_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private DoanhThu_BLL() { }

        public object GetDoanhThuCa(int maCa, string ngayTruc)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            List<DoanhThu> listDT = quanCaPheEntities.DoanhThus.ToList();
            for (int j = 0; j < listDT.Count; j++)
            {
                if (listDT[j].MaCT == maCa && listDT[j].NgayTruc.ToString("yyyy-MM-dd") == ngayTruc)
                {
                    return new
                    {
                        MaCT = listDT[j].MaCT,
                        NgayTruc = listDT[j].NgayTruc,
                        DoanhThuCT = listDT[j].DoanhThuCT,
                        DoanhThuNT = listDT[j].DoanhThuNT
                    };
                }
            }
            return null;
        }
        public long GetTongDoanhThuCa(int maCa, DateTime day)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            List<DoanhThu> listDT = quanCaPheEntities.DoanhThus.ToList();

            for (int j = 0; j < listDT.Count; j++)
            {
                if (listDT[j].MaCT == maCa && listDT[j].NgayTruc.Date == day)
                {
                    return listDT[j].DoanhThuCT.Value;
                }
            }
            return 0;
        }
        private void addDoanhThu()
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<HoaDon> hoaDons = db.HoaDons.ToList();
            List<DoanhThu> doanhThus = db.DoanhThus.ToList();
            for(int i = 0; i < hoaDons.Count; i++)
            {
                int maCa = 0;
                TimeSpan timeSpan = new TimeSpan(0, 0, 0);
                timeSpan = hoaDons[i].ThoiGian.Value.TimeOfDay;
                if(timeSpan.Hours >= 7 && timeSpan.Hours < 12)
                {
                    maCa = 1;
                }
                else if(timeSpan.Hours >= 12 && timeSpan.Hours < 17)
                {
                    maCa = 2;
                }
                else
                {
                    maCa = 3;
                }
                if(doanhThus.Where(p => p.NgayTruc.Date.ToString("yyyy-MM-dd") == ((DateTime)hoaDons[i].ThoiGian).ToString("yyyy-MM-dd") && p.MaCT == maCa).Count() == 0)
                {
                   MessageBox.Show(((DateTime)hoaDons[i].ThoiGian).ToString("yyyy-MM-dd") + " " + maCa);
                   CaTruc_BLL.Instance.TinhDoanhThuCa(((DateTime)hoaDons[i].ThoiGian).ToString("yyyy-MM-dd"), maCa);
                }
            }
        }
        public List<Object> GetListDoanhThuCa()
        {
            List<DoanhThu> listDT = GetListDoanhThu();
            List<Object> list = new List<Object>();
            addDoanhThu();
            for (int i = 0; i < listDT.Count; i++)
            {
                list.Add(new
                {
                    MaCT = listDT[i].MaCT,
                    NgayTruc = listDT[i].NgayTruc,
                    DoanhThuCT = listDT[i].DoanhThuCT,
                    DoanhThuNT = listDT[i].DoanhThuNT
                });
            }
            return list;
        }
        public List<DoanhThu> GetListDoanhThu()
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            return quanCaPheEntities.DoanhThus.ToList();
        }

        //update doanh thu ngày của ca trực
        private void UpdateDoanhThu(int MaCT, string NgayTruc, long DTNgay)
        {
            QuanCaPhePBL3Entities quanCaPhePBL3Entities = new QuanCaPhePBL3Entities();
            List<DoanhThu> listDT = quanCaPhePBL3Entities.DoanhThus.ToList();
            for (int i = 0; i < listDT.Count; i++)
            {
                if (listDT[i].NgayTruc.ToString("yyyy-MM-dd") == NgayTruc)
                {
                    listDT[i].DoanhThuNT = DTNgay;
                    quanCaPhePBL3Entities.SaveChanges();
                }
            }
        }

        private void UpdateDoanhThuCa(int MaCT, string NgayTruc, long DTCa)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            List<DoanhThu> listDT = quanCaPheEntities.DoanhThus.ToList();
            for (int i = 0; i < listDT.Count; i++)
            {
                if (listDT[i].MaCT == MaCT && listDT[i].NgayTruc.ToString("yyyy-MM-dd") == NgayTruc)
                {
                    listDT[i].DoanhThuCT = DTCa;

                    quanCaPheEntities.SaveChanges();

                    UpdateDoanhThu(MaCT, NgayTruc, listDT[i].DoanhThuNT.Value);
                }
            }
        }

        //xóa 1 doanh thu ca
        public void DelDoanhThu(int MaCT, string NgayTruc)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            List<DoanhThu> listDT = quanCaPheEntities.DoanhThus.ToList();
            for (int j = 0; j < listDT.Count; j++)
            {
                if (listDT[j].MaCT == MaCT && listDT[j].NgayTruc.ToString() == NgayTruc)
                {
                    quanCaPheEntities.DoanhThus.Remove(listDT[j]);
                    quanCaPheEntities.SaveChanges();
                    break;
                }
            }

            long DTNgayTruc = 0;
            for (int i = 0; i < listDT.Count; i++)
            {
                if (listDT[i].NgayTruc.ToString() == NgayTruc && listDT[i].MaCT != MaCT)
                {
                    DTNgayTruc += listDT[i].DoanhThuCT.Value;
                }
            }
            UpdateDoanhThu(MaCT, NgayTruc, DTNgayTruc);
        }

        //xóa doanh thu ngày 
        public void DelDoanhThuOneDay(string NgayTruc)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            List<DoanhThu> listDT = quanCaPheEntities.DoanhThus.ToList();
            for (int j = 0; j < listDT.Count; j++)
            {
                if (listDT[j].NgayTruc.ToString() == NgayTruc)
                {
                    quanCaPheEntities.DoanhThus.Remove(listDT[j]);
                    quanCaPheEntities.SaveChanges();
                }
            }
        }

        public void AddDoanhThu(int MaCT, string NgayTruc, long DTCa)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            List<DoanhThu> listDT = quanCaPheEntities.DoanhThus.ToList();


            long DTNgay = listDT.Where(p => p.NgayTruc.ToString() == NgayTruc).Sum(p => p.DoanhThuCT).Value;

            for(int i = 0; i < listDT.Count; i++)
            {
                if (listDT[i].MaCT == MaCT && listDT[i].NgayTruc.ToString("yyyy-MM-dd") == NgayTruc.ToString())
                {
                        return;
               
                }
            }


            DoanhThu doanhThu = new DoanhThu();
            doanhThu.MaCT = MaCT;
            doanhThu.NgayTruc = Convert.ToDateTime(NgayTruc);
            doanhThu.DoanhThuCT = DTCa;
            doanhThu.DoanhThuNT = DTNgay + DTCa;

            quanCaPheEntities.DoanhThus.Add(doanhThu);
            DTNgay = doanhThu.DoanhThuNT.Value;

            quanCaPheEntities.SaveChanges();

            UpdateDoanhThu(MaCT, NgayTruc, DTNgay);

        }

        internal List<Object> GetListDoanhThuNgay()
        {
            var l1 = GetListDoanhThu().Select(p => new
            {
                NgayTruc = p.NgayTruc.ToString("MM/dd/yyyy"),
                DoanhThuNT = p.DoanhThuNT
            }).Distinct().ToList<Object>();
            return l1;
        }

        internal List<Object> GetListDoanhThuNgayByNgay(string Date)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            List<DoanhThu> listDT = quanCaPheEntities.DoanhThus.ToList();
            List<Object> list = new List<object>();
            for (int j = 0; j < listDT.Count; j++)
            {
                if (listDT[j].NgayTruc.ToString("yyyy-MM-dd") == Date)
                {
                    list.Add(new
                    {
                        MaCT = listDT[j].MaCT,
                        NgayTruc = listDT[j].NgayTruc,
                        DoanhThuCT = listDT[j].DoanhThuCT,
                        DoanhThuNT = listDT[j].DoanhThuNT
                    });
                }
            }
            return list;
        }
       
        internal List<Object> GetListDoanhThuThang()
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            List<DoanhThu> listDT = db.DoanhThus.ToList();
            var list = listDT.Select(p => new
            {
                Thang = ((DateTime)p.NgayTruc).ToString("MM/yyyy"),
                DoanhThuThang = 0
            }).Distinct().ToList<Object>();
            for(int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < listDT.Count; j++)
                {
                    if (((DateTime)listDT[j].NgayTruc).ToString("MM/yyyy") == list[i].GetType().GetProperty("Thang").GetValue(list[i]).ToString())
                    {
                        list[i].GetType().GetProperty("DoanhThuThang").SetValue(list[i], (long)list[i].GetType().GetProperty("DoanhThuThang").GetValue(list[i]) + (long)listDT[j].DoanhThuNT);
                    }
                }
            }
            return list;
            /*List<Object> listDT = GetListDoanhThuNgay();
            
            var list = listDT.Select(p => new
            {
                Thang = ((DateTime)p.GetType().GetProperty("NgayTruc").GetValue(p)).ToString("MM/yyyy"),
                DoanhThuThang = 0
            }).Distinct().ToList<Object>();


            foreach (Object obj in list)
            {
                for(int i = 0; i < listDT.Count; i++)
                {
                    if (((DateTime)listDT[i].GetType().GetProperty("NgayTruc").GetValue(listDT[i])).ToString("MM/yyyy") == obj.GetType().GetProperty("Thang").GetValue(obj).ToString())
                    {
                        obj.GetType().GetProperty("DoanhThuThang").SetValue(obj, (long)obj.GetType().GetProperty("DoanhThuThang").GetValue(obj) + (long)listDT[i].GetType().GetProperty("DoanhThuNT").GetValue(listDT[i]));
                    }
                   
                }
            }
            return list;*/
        }

        internal List<Object> GetDoanhThuCaNV(int maNV, string maCa, DateTime value)
        {
            int MaCa = (maCa == "Ca 1") ? 1 : (maCa == "Ca 2") ? 2 : 3;
            bool test = NhanVien_BLL.Instance.isValidCaTruc(maNV, MaCa, value);
            List <Object> list = new List<Object>();
            if(test == false)
            {
                foreach (Object obj in HoaDon_BLL.Instance.GetListHDByCa(MaCa, value))
                {
                       list.Add(obj);
                }
                return list;
            }
            else
            {
                return null;
            }
        }

        
    }
}
