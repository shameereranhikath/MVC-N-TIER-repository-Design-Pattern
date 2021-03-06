﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class InventoryDBEntities : DbContext
    {
        public InventoryDBEntities()
            : base("name=InventoryDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORy> CATEGORIES { get; set; }
        public virtual DbSet<PIDETAIL> PIDETAILS { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTS { get; set; }
        public virtual DbSet<PURCHASEINVOICE> PURCHASEINVOICEs { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<STOCK> STOCKs { get; set; }
        public virtual DbSet<SUPPLIER> SUPPLIERS { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
    
        public virtual ObjectResult<st_getLoginDetails_Result> st_getLoginDetails(string user, string pwd)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<st_getLoginDetails_Result>("st_getLoginDetails", userParameter, pwdParameter);
        }
    
        public virtual ObjectResult<string> st_getUserRolesWRTUser(string user)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("st_getUserRolesWRTUser", userParameter);
        }
    }
}
