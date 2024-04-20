using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    internal class NhanVien
    {
        public int MaNV {  get; set; }
        public int MaCV { get; set; }
        public string HoTenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT {  get; set; }
        public double Luong {  get; set; }
        public string GioiTinh { get; set; }
    }
}
