//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOL__PSD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailTransaction
    {
        public int trans_id { get; set; }
        public int product_id { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> stock { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual HeaderTransaction HeaderTransaction { get; set; }
    }
}