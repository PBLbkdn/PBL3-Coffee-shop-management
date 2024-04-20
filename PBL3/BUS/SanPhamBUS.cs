using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BUS
{
    internal class SanPhamBUS
    {
        private static SanPhamBUS _Instance;
        public static SanPhamBUS Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new SanPhamBUS();
                return _Instance;
            }
            private set { }
        }
        private SanPhamBUS() { }

        //public List
    }
}
