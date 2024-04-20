using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    internal class HoaDon
    {
        public int MaHD {  get; set; }
        public int MaDH { get; set; }
        public int MaKH { get; set; }
        public DateTime ThoiGian {  get; set; }
        public double TongTien {  get; set; }
        public int MaBan {  get; set; }
        public int MaNV {  get; set; }
        public int MaKM { get; set; }
        public List<Sanpham_Soluong> sanpham_Soluongs { get; set; }

    }
}
