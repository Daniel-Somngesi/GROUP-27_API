//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MakeSale.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SaleLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaleLine()
        {
            this.ReturnLines = new HashSet<ReturnLine>();
        }
    
        public int SaleLine_ID { get; set; }
        public Nullable<int> Sale_ID { get; set; }
        public Nullable<int> C_Product_Size_ID { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual C_Product_Size C_Product_Size { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnLine> ReturnLines { get; set; }
        public virtual Sale Sale { get; set; }
    }
}