using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    internal class DonHang
    {
        public int MaDH { get; set; }
        public int MaKH {  get; set; }
        public List<Sanpham_Soluong> sanpham_Soluongs { get; set; }
    }
}
