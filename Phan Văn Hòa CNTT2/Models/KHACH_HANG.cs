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
    
    public partial class KHACH_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH_HANG()
        {
            this.DON_HANG = new HashSet<DON_HANG>();
        }
    
        public int MA_KHACH_HANG { get; set; }
        public string TEN_KHACH_HANG { get; set; }
        public string EMAIL { get; set; }
        public string SO_DIEN_THOAI { get; set; }
        public string DIA_CHI { get; set; }
        public Nullable<System.DateTime> NGAY_TAO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DON_HANG> DON_HANG { get; set; }
    }
}
