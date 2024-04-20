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
<<<<<<< HEAD
        public DateTime NgatTruc { get; set; }
        public string ThoiGianBD { get; set; }
        public string ThoiGianKT { get; set; }
=======
        public DateTime NgayTruc { get; set; }
        public TimeSpan ThoiGianBD { get; set; }
        public TimeSpan ThoiGianKT { get; set; }
>>>>>>> d616ce3b47d6677877e9380d77845868a58e7a59
        public double DoanhThu {  get; set; }

        public ICollection<NhanVien> NhanViens { get; set; }

        public List<NhanVien> nhanViens { get; set; }
    }
}
