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
    
    public partial class SUPPORT
    {
        public int ID_SUPPORT { get; set; }
        public Nullable<int> ID_ACCOUNT { get; set; }
        public string FEEDBACK { get; set; }
        public Nullable<System.DateTime> POST_DATE { get; set; }
    
        public virtual ACCOUNT_DETAIL ACCOUNT_DETAIL { get; set; }
    }
}
