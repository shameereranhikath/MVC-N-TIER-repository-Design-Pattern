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
    
    public partial class SUPPLIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUPPLIER()
        {
            this.PURCHASEINVOICEs = new HashSet<PURCHASEINVOICE>();
        }
    
        public int SUP_ID { get; set; }
        public string SUP_NAME { get; set; }
        public string SUP_ADDRESS { get; set; }
        public string SUP_PHONE { get; set; }
        public decimal SUP_OPENINGBALANCE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PURCHASEINVOICE> PURCHASEINVOICEs { get; set; }
    }
}