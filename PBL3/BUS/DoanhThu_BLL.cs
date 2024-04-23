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

            quanCaPheEntities.SaveChanges();

            UpdateDoanhThu(MaCT, NgayTruc, DTNgay);

        }
    }
}
