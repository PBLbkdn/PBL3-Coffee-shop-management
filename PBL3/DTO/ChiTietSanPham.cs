//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietSanPham
    {
        public int MaSP { get; set; }
        public int MaNL { get; set; }
        public Nullable<decimal> SLNguyenLieu { get; set; }
    
        public virtual NguyenLieu NguyenLieu { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
