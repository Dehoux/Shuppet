//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserStorage
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.OrderEntry = new HashSet<OrderEntry>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    
        public virtual ICollection<OrderEntry> OrderEntry { get; set; }
    }
}
