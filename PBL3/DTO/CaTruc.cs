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
        public string ThoiGianBD { get; set; }
        public string ThoiGianKT { get; set; }

        public double DoanhThu {  get; set; }

        public ICollection<NhanVien> NhanViens { get; set; }

        public List<NhanVien> nhanViens { get; set; }
    }
}
