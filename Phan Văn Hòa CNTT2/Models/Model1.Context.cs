﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PhanVanHoa_K22CNTT2Entities : DbContext
    {
        public PhanVanHoa_K22CNTT2Entities()
            : base("name=PhanVanHoa_K22CNTT2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHI_TIET_DON_HANG> CHI_TIET_DON_HANG { get; set; }
        public virtual DbSet<DON_HANG> DON_HANG { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<KICH_THUOC> KICH_THUOC { get; set; }
        public virtual DbSet<QUAN_TRI_VIEN> QUAN_TRI_VIEN { get; set; }
        public virtual DbSet<SAN_PHAM> SAN_PHAM { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TOPPING> TOPPINGs { get; set; }
        public virtual DbSet<TOPPING_TRONG_DON_HANG> TOPPING_TRONG_DON_HANG { get; set; }
    }
}
