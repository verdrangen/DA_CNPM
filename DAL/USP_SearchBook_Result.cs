
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
    
public partial class USP_SearchBook_Result
{

    public int ID_BOOK { get; set; }

    public string TITLE { get; set; }

    public string AUTHOR { get; set; }

    public Nullable<int> ID_CATEGORY { get; set; }

    public string PUBLISH_YEAR { get; set; }

    public string PDF_LINK { get; set; }

    public string OVERVIEW { get; set; }

    public byte[] COVER { get; set; }

}

}