//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class STOCK
    {
        public int ST_ID { get; set; }
        public int ST_PROID { get; set; }
        public Nullable<int> ST_PROCARTOON { get; set; }
        public Nullable<int> ST_PROPIECES { get; set; }
        public long ST_PURCHASEINVID { get; set; }
    
        public virtual PRODUCT PRODUCT { get; set; }
        public virtual PURCHASEINVOICE PURCHASEINVOICE { get; set; }
    }
}
