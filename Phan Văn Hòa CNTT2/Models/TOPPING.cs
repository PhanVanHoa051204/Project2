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

    public partial class TOPPING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOPPING()
        {
            this.TOPPING_TRONG_DON_HANG = new HashSet<TOPPING_TRONG_DON_HANG>();
        }

        public int MA_TOPPING { get; set; }
        public string TEN_TOPPING { get; set; }
        public decimal GIA_TOPPING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOPPING_TRONG_DON_HANG> TOPPING_TRONG_DON_HANG { get; set; }
        
    }
}
