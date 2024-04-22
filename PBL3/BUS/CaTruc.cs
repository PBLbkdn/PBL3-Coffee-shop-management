using System;
using System.Collections.Generic;
using System.Linq;
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
            QuanCaPheEntities quanCaPheEntities = new QuanCaPheEntities();
            return quanCaPheEntities.CaTrucs.ToList();
        }
        public void AddCaTruc()
        {
            QuanCaPheEntities quanCaPheEntities = new QuanCaPheEntities();
            CaTruc ct = quanCaPheEntities.CaTrucs.OrderByDescending(p => p.NgayTruc).FirstOrDefault();
            if (ct == null)
            {
                ct = new CaTruc();
                ct.MaCT = 1;
                ct.NgayTruc = DateTime.Now;
                ct.ThoiGianBD = new TimeSpan(7, 0, 0);
                ct.ThoiGianKT = new TimeSpan(12, 0, 0);
                quanCaPheEntities.CaTrucs.Add(ct);
                ct.MaCT = 2;
                ct.NgayTruc = DateTime.Now;
                ct.ThoiGianBD = new TimeSpan(12, 0, 0);
                ct.ThoiGianKT = new TimeSpan(17, 0, 0);
                quanCaPheEntities.CaTrucs.Add(ct);
                ct.MaCT = 3;
                ct.NgayTruc = DateTime.Now;
                ct.ThoiGianBD = new TimeSpan(17, 0, 0);
                ct.ThoiGianKT = new TimeSpan(22, 0, 0);
                quanCaPheEntities.CaTrucs.Add(ct);
                quanCaPheEntities.SaveChanges();
            }
            else
            {
                if (DateTime.Now.Date > ct.NgayTruc.Date)
                {
                    CaTruc ct1 = new CaTruc();
                    ct1.MaCT = ct.MaCT + 1;
                    ct1.NgayTruc = DateTime.Now;
                    ct1.ThoiGianBD = new TimeSpan(7, 0, 0);
                    ct1.ThoiGianKT = new TimeSpan(12, 0, 0);
                    quanCaPheEntities.CaTrucs.Add(ct1);
                    ct1.MaCT = 2;
                    ct1.NgayTruc = DateTime.Now;
                    ct1.ThoiGianBD = new TimeSpan(12, 0, 0);
                    ct1.ThoiGianKT = new TimeSpan(17, 0, 0);
                    quanCaPheEntities.CaTrucs.Add(ct);
                    ct1.MaCT = 3;
                    ct1.NgayTruc = DateTime.Now;
                    ct1.ThoiGianBD = new TimeSpan(17, 0, 0);
                    ct1.ThoiGianKT = new TimeSpan(22, 0, 0);
                    quanCaPheEntities.CaTrucs.Add(ct);
                    quanCaPheEntities.SaveChanges();
                }

            }
        }
        public void UpdateCaTruc(CaTruc ct)
        {
            //CaTruc_DAL.Instance.UpdateCaTruc(ct);
        }
        public void DeleteCaTruc(int id)
        {
            //CaTruc_DAL.Instance.DeleteCaTruc(id);
        }
    }
}
