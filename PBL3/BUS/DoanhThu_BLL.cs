using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<Object> GetListDoanhThuCa()
        {
            List<DoanhThu> listDT = GetListDoanhThu();
            List<Object> list = new List<Object>();
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
            for(int i = 0; i < listDT.Count; i++)
            {
                if (listDT[i].NgayTruc.ToString() == NgayTruc)
                {
                    listDT[i].DoanhThuNT = DTNgay;
                    quanCaPhePBL3Entities.SaveChanges();
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
            for(int i = 0; i < listDT.Count; i++)
            {
                if (listDT[i].NgayTruc.ToString() == NgayTruc && listDT[i].MaCT!=MaCT)
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

            DoanhThu doanhThu = new DoanhThu();
            doanhThu.MaCT = MaCT;
            doanhThu.NgayTruc = Convert.ToDateTime(NgayTruc);
            doanhThu.DoanhThuCT = DTCa;
            doanhThu.DoanhThuNT = DTNgay + DTCa;
            
            quanCaPheEntities.DoanhThus.Add(doanhThu);
            DTNgay = doanhThu.DoanhThuNT.Value;
            for(int i=0;i<listDT.Count; i++)
            {
                if (listDT[i].NgayTruc.ToString("MM-dd-yyyy") == NgayTruc && listDT[i].MaCT == MaCT)

                {
                    return;
                }
            }
            
            quanCaPheEntities.SaveChanges();

            UpdateDoanhThu(MaCT, NgayTruc, DTNgay);

        }

        internal List<Object> GetListDoanhThuNgay()
        {
            var l1 = GetListDoanhThu().Select( p => new
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
            List<Object> listDTN = GetListDoanhThu().Select(p => new
            {
                Thang = p.NgayTruc.ToString("MM/yyyy"),
                DoanhThuNT = p.DoanhThuNT
            }).Distinct().ToList<Object>();
            List<Object> listMonth = GetListDoanhThu().Select(p => new
            {
                Thang = p.NgayTruc.ToString("MM/yyyy"),
            }).Distinct().ToList<Object>();
            /*for(int i=0; i < listDTN.Count; i++)
            {
                for (int j=)
            }*/
            return listMonth;
        }
    }
}
