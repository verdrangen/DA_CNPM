//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA_CNPM.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER_REVIEW
    {
        public int ID_UR { get; set; }
        public Nullable<int> ID_REVIEW { get; set; }
        public Nullable<int> ID_ACCOUNT { get; set; }
    
        public virtual ACCOUNT_DETAIL ACCOUNT_DETAIL { get; set; }
        public virtual REVIEW REVIEW { get; set; }
    }
}
