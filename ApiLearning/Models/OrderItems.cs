//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiLearning.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItems
    {
        public long OrderItemId { get; set; }
        public Nullable<long> OrderId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
