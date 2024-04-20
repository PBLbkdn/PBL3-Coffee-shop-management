using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    internal class NguyenLieu
    {
        public int MaNL {  get; set; }
        public DateTime NgayNhap { get; set; }
        public string TenNl { get; set; }
        public int SLNhap { get; set; }
        public int SLTonKho { get; set; }
        public DateTime NgayHetHan { get; set; }
        public double GiaNhap {  get; set; }
        public string DonviTinh { get; set; }
    }
}
