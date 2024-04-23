using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BUS
{
    internal class Ban_BLL
    {
        private static Ban_BLL _Instance;
        public static Ban_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Ban_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private Ban_BLL() { }
        public List<Ban> GetListBan()
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            return quanCaPheEntities.Bans.ToList();
        }
        public void AddBan(Ban b)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            quanCaPheEntities.Bans.Add(b);
            quanCaPheEntities.SaveChanges();
        }
        public void EditBan(Ban b)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            Ban banEdit = quanCaPheEntities.Bans.Find(b.MaBan);
            banEdit.TrangThai = b.TrangThai;
            banEdit.ViTri = b.ViTri;
            quanCaPheEntities.SaveChanges();
        }
        public void DeleteBan(int id)
        {
            QuanCaPhePBL3Entities quanCaPheEntities = new QuanCaPhePBL3Entities();
            Ban banDelete = quanCaPheEntities.Bans.Find(id);
            quanCaPheEntities.Bans.Remove(banDelete);
            quanCaPheEntities.SaveChanges();
        }
    }
}
