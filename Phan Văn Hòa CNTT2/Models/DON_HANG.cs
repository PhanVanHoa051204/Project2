//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Phan_Văn_Hòa_CNTT2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DON_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DON_HANG()
        {
            this.CHI_TIET_DON_HANG = new HashSet<CHI_TIET_DON_HANG>();
        }
    
        public int MA_DON_HANG { get; set; }
        public int MA_KHACH_HANG { get; set; }
        public Nullable<System.DateTime> NGAY_DAT_HANG { get; set; }
        public Nullable<System.DateTime> NGAY_GIAO_HANG { get; set; }
        public string TRANG_THAI { get; set; }
        public Nullable<decimal> TONG_TIEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_DON_HANG> CHI_TIET_DON_HANG { get; set; }
        public virtual KHACH_HANG KHACH_HANG { get; set; }
    }
}
