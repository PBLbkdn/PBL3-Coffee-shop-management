using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    internal class CaTruc
    {
        public int MaCT {  get; set; }
        public DateTime NgatTruc { get; set; }
        public TimeSpan ThoiGianBD { get; set; }
        public TimeSpan ThoiGianKT { get; set; }
        public double DoanhThu {  get; set; }

        public List<NhanVien> nhanViens { get; set; }
    }
}
