//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppGiaoHang
{
    using System;
    using System.Collections.Generic;
    
    public partial class XacNhanDonHang
    {
        public string MaNV { get; set; }
        public int MaDH { get; set; }
        public System.DateTime NgayXacNhan { get; set; }
        public System.TimeSpan GioXacNhan { get; set; }
        public string GhiChu { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
