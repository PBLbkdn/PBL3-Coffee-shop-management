using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    internal class LoaiKhachHang
    {
        public int MaLoaiKH {  get; set; }
        public string TenLoaiKH { get; set; }
        public List<KhuyenMai> khuyenMais { get; set; }
    }
}
