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
    
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            this.XacNhanDonHangs = new HashSet<XacNhanDonHang>();
        }
    
        public int MaDH { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<System.TimeSpan> GioLap { get; set; }
        public Nullable<int> TienUng { get; set; }
        public string TinhTrang { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<int> MaShipper { get; set; }
        public string GhiChu { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual Shipper Shipper { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XacNhanDonHang> XacNhanDonHangs { get; set; }
    }
}
