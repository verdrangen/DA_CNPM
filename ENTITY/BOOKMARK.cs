//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA_CNPM.ENTITY
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOOKMARK
    {
        public int ID_BOOKMARK { get; set; }
        public Nullable<int> ID_BOOK { get; set; }
        public Nullable<int> ID_ACCOUNT { get; set; }
    
        public virtual ACCOUNT_DETAIL ACCOUNT_DETAIL { get; set; }
        public virtual BOOK BOOK { get; set; }
    }
}
