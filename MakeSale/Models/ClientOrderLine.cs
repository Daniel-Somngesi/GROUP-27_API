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
    
    public partial class ClientOrderLine
    {
        public int ClientOrderLine1 { get; set; }
        public string ItemPrice { get; set; }
        public string ItemType { get; set; }
        public Nullable<int> ClientOrder_ID { get; set; }
        public Nullable<int> Product_ID { get; set; }
    
        public virtual ClientOrder ClientOrder { get; set; }
        public virtual Product Product { get; set; }
    }
}
