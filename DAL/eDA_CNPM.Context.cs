﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class DOAN_CNPMEntities : DbContext
{
    public DOAN_CNPMEntities()
        : base("name=DOAN_CNPMEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }

    public virtual DbSet<ACCOUNT_DETAIL> ACCOUNT_DETAIL { get; set; }

    public virtual DbSet<BOOK> BOOKs { get; set; }

    public virtual DbSet<BOOKMARK> BOOKMARKs { get; set; }

    public virtual DbSet<CATEGORY> CATEGORies { get; set; }

    public virtual DbSet<GROUP> GROUPs { get; set; }

    public virtual DbSet<REVIEW> REVIEWs { get; set; }

    public virtual DbSet<SUPPORT> SUPPORTs { get; set; }

    public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

    public virtual DbSet<USER_REVIEW> USER_REVIEW { get; set; }


    public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));


        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }


    public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));


        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }


    public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
    }


    public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
    }


    public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
    }


    public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var new_diagramnameParameter = new_diagramname != null ?
            new ObjectParameter("new_diagramname", new_diagramname) :
            new ObjectParameter("new_diagramname", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
    }


    public virtual int sp_upgraddiagrams()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
    }


    public virtual ObjectResult<ACCOUNT_DETAIL> USP_GetAccountDetailList()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACCOUNT_DETAIL>("USP_GetAccountDetailList");
    }


    public virtual ObjectResult<ACCOUNT_DETAIL> USP_GetAccountDetailList(MergeOption mergeOption)
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACCOUNT_DETAIL>("USP_GetAccountDetailList", mergeOption);
    }


    public virtual ObjectResult<ACCOUNT> USP_GetAccountList()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACCOUNT>("USP_GetAccountList");
    }


    public virtual ObjectResult<ACCOUNT> USP_GetAccountList(MergeOption mergeOption)
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACCOUNT>("USP_GetAccountList", mergeOption);
    }


    public virtual int USP_GetBookList()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_GetBookList");
    }


    public virtual int USP_GetSupportList()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_GetSupportList");
    }


    public virtual ObjectResult<ACCOUNT> USP_Login(string userName, string password, string groupID)
    {

        var userNameParameter = userName != null ?
            new ObjectParameter("userName", userName) :
            new ObjectParameter("userName", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));


        var groupIDParameter = groupID != null ?
            new ObjectParameter("groupID", groupID) :
            new ObjectParameter("groupID", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACCOUNT>("USP_Login", userNameParameter, passwordParameter, groupIDParameter);
    }


    public virtual ObjectResult<ACCOUNT> USP_Login(string userName, string password, string groupID, MergeOption mergeOption)
    {

        var userNameParameter = userName != null ?
            new ObjectParameter("userName", userName) :
            new ObjectParameter("userName", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));


        var groupIDParameter = groupID != null ?
            new ObjectParameter("groupID", groupID) :
            new ObjectParameter("groupID", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACCOUNT>("USP_Login", mergeOption, userNameParameter, passwordParameter, groupIDParameter);
    }


    public virtual ObjectResult<BOOK> USP_GetRandomBook()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BOOK>("USP_GetRandomBook");
    }


    public virtual ObjectResult<BOOK> USP_GetRandomBook(MergeOption mergeOption)
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BOOK>("USP_GetRandomBook", mergeOption);
    }


    public virtual int USP_DELETE_BOOKMARK(Nullable<int> id_bookmark)
    {

        var id_bookmarkParameter = id_bookmark.HasValue ?
            new ObjectParameter("id_bookmark", id_bookmark) :
            new ObjectParameter("id_bookmark", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_DELETE_BOOKMARK", id_bookmarkParameter);
    }


    public virtual int USP_DELETE_REVIEW(Nullable<int> id_review)
    {

        var id_reviewParameter = id_review.HasValue ?
            new ObjectParameter("id_review", id_review) :
            new ObjectParameter("id_review", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_DELETE_REVIEW", id_reviewParameter);
    }


    public virtual int USP_DELETE_SUPPORT(Nullable<int> id_support)
    {

        var id_supportParameter = id_support.HasValue ?
            new ObjectParameter("id_support", id_support) :
            new ObjectParameter("id_support", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_DELETE_SUPPORT", id_supportParameter);
    }


    public virtual ObjectResult<ACCOUNT> USP_GetAccountByUserName(string userName)
    {

        var userNameParameter = userName != null ?
            new ObjectParameter("userName", userName) :
            new ObjectParameter("userName", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACCOUNT>("USP_GetAccountByUserName", userNameParameter);
    }


    public virtual ObjectResult<ACCOUNT> USP_GetAccountByUserName(string userName, MergeOption mergeOption)
    {

        var userNameParameter = userName != null ?
            new ObjectParameter("userName", userName) :
            new ObjectParameter("userName", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACCOUNT>("USP_GetAccountByUserName", mergeOption, userNameParameter);
    }


    public virtual ObjectResult<USP_GetReviewList_Result> USP_GetReviewList()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetReviewList_Result>("USP_GetReviewList");
    }


    public virtual ObjectResult<USP_GetUserReviewList_Result> USP_GetUserReviewList()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetUserReviewList_Result>("USP_GetUserReviewList");
    }


    public virtual int USP_INSERT_BOOKMARK(Nullable<int> id_user, Nullable<int> id_book)
    {

        var id_userParameter = id_user.HasValue ?
            new ObjectParameter("id_user", id_user) :
            new ObjectParameter("id_user", typeof(int));


        var id_bookParameter = id_book.HasValue ?
            new ObjectParameter("id_book", id_book) :
            new ObjectParameter("id_book", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_INSERT_BOOKMARK", id_userParameter, id_bookParameter);
    }


    public virtual int USP_INSERT_REVIEW(Nullable<int> id_book, string comment, string rating)
    {

        var id_bookParameter = id_book.HasValue ?
            new ObjectParameter("id_book", id_book) :
            new ObjectParameter("id_book", typeof(int));


        var commentParameter = comment != null ?
            new ObjectParameter("comment", comment) :
            new ObjectParameter("comment", typeof(string));


        var ratingParameter = rating != null ?
            new ObjectParameter("rating", rating) :
            new ObjectParameter("rating", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_INSERT_REVIEW", id_bookParameter, commentParameter, ratingParameter);
    }


    public virtual int USP_INSERT_SUPPORT(Nullable<int> id_user, string feedback, Nullable<System.DateTime> postdate, string reply)
    {

        var id_userParameter = id_user.HasValue ?
            new ObjectParameter("id_user", id_user) :
            new ObjectParameter("id_user", typeof(int));


        var feedbackParameter = feedback != null ?
            new ObjectParameter("feedback", feedback) :
            new ObjectParameter("feedback", typeof(string));


        var postdateParameter = postdate.HasValue ?
            new ObjectParameter("postdate", postdate) :
            new ObjectParameter("postdate", typeof(System.DateTime));


        var replyParameter = reply != null ?
            new ObjectParameter("reply", reply) :
            new ObjectParameter("reply", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_INSERT_SUPPORT", id_userParameter, feedbackParameter, postdateParameter, replyParameter);
    }


    public virtual ObjectResult<ACCOUNT> USP_UPDATE_ACCOUNT(string user_name, string password, string group_id)
    {

        var user_nameParameter = user_name != null ?
            new ObjectParameter("user_name", user_name) :
            new ObjectParameter("user_name", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));


        var group_idParameter = group_id != null ?
            new ObjectParameter("group_id", group_id) :
            new ObjectParameter("group_id", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACCOUNT>("USP_UPDATE_ACCOUNT", user_nameParameter, passwordParameter, group_idParameter);
    }


    public virtual ObjectResult<ACCOUNT> USP_UPDATE_ACCOUNT(string user_name, string password, string group_id, MergeOption mergeOption)
    {

        var user_nameParameter = user_name != null ?
            new ObjectParameter("user_name", user_name) :
            new ObjectParameter("user_name", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));


        var group_idParameter = group_id != null ?
            new ObjectParameter("group_id", group_id) :
            new ObjectParameter("group_id", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACCOUNT>("USP_UPDATE_ACCOUNT", mergeOption, user_nameParameter, passwordParameter, group_idParameter);
    }


    public virtual int USP_UPDATE_BOOK(Nullable<int> iD_BOOK, string tITLE, string aUTHOR, Nullable<int> iD_CATEGORY, string pUBLISH_YEAR, string pDF_LINK, string oVERVIEW, byte[] cOVER)
    {

        var iD_BOOKParameter = iD_BOOK.HasValue ?
            new ObjectParameter("ID_BOOK", iD_BOOK) :
            new ObjectParameter("ID_BOOK", typeof(int));


        var tITLEParameter = tITLE != null ?
            new ObjectParameter("TITLE", tITLE) :
            new ObjectParameter("TITLE", typeof(string));


        var aUTHORParameter = aUTHOR != null ?
            new ObjectParameter("AUTHOR", aUTHOR) :
            new ObjectParameter("AUTHOR", typeof(string));


        var iD_CATEGORYParameter = iD_CATEGORY.HasValue ?
            new ObjectParameter("ID_CATEGORY", iD_CATEGORY) :
            new ObjectParameter("ID_CATEGORY", typeof(int));


        var pUBLISH_YEARParameter = pUBLISH_YEAR != null ?
            new ObjectParameter("PUBLISH_YEAR", pUBLISH_YEAR) :
            new ObjectParameter("PUBLISH_YEAR", typeof(string));


        var pDF_LINKParameter = pDF_LINK != null ?
            new ObjectParameter("PDF_LINK", pDF_LINK) :
            new ObjectParameter("PDF_LINK", typeof(string));


        var oVERVIEWParameter = oVERVIEW != null ?
            new ObjectParameter("OVERVIEW", oVERVIEW) :
            new ObjectParameter("OVERVIEW", typeof(string));


        var cOVERParameter = cOVER != null ?
            new ObjectParameter("COVER", cOVER) :
            new ObjectParameter("COVER", typeof(byte[]));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_UPDATE_BOOK", iD_BOOKParameter, tITLEParameter, aUTHORParameter, iD_CATEGORYParameter, pUBLISH_YEARParameter, pDF_LINKParameter, oVERVIEWParameter, cOVERParameter);
    }


    public virtual int USP_UPDATE_USER(Nullable<int> id_user, string user_name, string phonenumber, Nullable<System.DateTime> dob, string gender, string email)
    {

        var id_userParameter = id_user.HasValue ?
            new ObjectParameter("id_user", id_user) :
            new ObjectParameter("id_user", typeof(int));


        var user_nameParameter = user_name != null ?
            new ObjectParameter("user_name", user_name) :
            new ObjectParameter("user_name", typeof(string));


        var phonenumberParameter = phonenumber != null ?
            new ObjectParameter("phonenumber", phonenumber) :
            new ObjectParameter("phonenumber", typeof(string));


        var dobParameter = dob.HasValue ?
            new ObjectParameter("dob", dob) :
            new ObjectParameter("dob", typeof(System.DateTime));


        var genderParameter = gender != null ?
            new ObjectParameter("gender", gender) :
            new ObjectParameter("gender", typeof(string));


        var emailParameter = email != null ?
            new ObjectParameter("email", email) :
            new ObjectParameter("email", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_UPDATE_USER", id_userParameter, user_nameParameter, phonenumberParameter, dobParameter, genderParameter, emailParameter);
    }


    public virtual ObjectResult<BOOK> USP_SearchBook(string title)
    {

        var titleParameter = title != null ?
            new ObjectParameter("title", title) :
            new ObjectParameter("title", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BOOK>("USP_SearchBook", titleParameter);
    }


    public virtual ObjectResult<BOOK> USP_SearchBook(string title, MergeOption mergeOption)
    {

        var titleParameter = title != null ?
            new ObjectParameter("title", title) :
            new ObjectParameter("title", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BOOK>("USP_SearchBook", mergeOption, titleParameter);
    }

}

}

