using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PBL3.DAO
{
    internal class DALQuanCaPhe : DbContext
    {
        public DALQuanCaPhe() : base("name=QuanCaPhe") {
            Database.SetInitializer<DALQuanCaPhe>(new CreateDB());
        }
        public virtual DbSet<DTO.NhanVien> NhanViens { get; set; }
        public virtual DbSet<DTO.ChucVu> ChucVus { get; set; }
        
    
    }
}
