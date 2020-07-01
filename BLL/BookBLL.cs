using DA_CNPM.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.BLL
{
    class BookBLL
    {
        private static BookBLL instance;
        public static BookBLL Instance
        {
            get { if (instance == null) instance = new BookBLL(); return instance; }
            private set { instance = value; }
        }
        public List<BOOK> bookList { get; set; }
        public List<BOOK> LoadbookList()
        {
            bookList = DataProvider.Instance.Entity_DB.BOOKs.Select(p => p).ToList();
            return bookList;
        }
        public List<BOOK> LoadRandomBook()
        {
            var randomList = DataProvider.Instance.Entity_DB.USP_GetRandomBook().ToList();
            return randomList;
        }
        public void eSaveChanges_Add(BOOK book)
        {
            DataProvider.Instance.Entity_DB.BOOKs.Add(book);
            DataProvider.Instance.Entity_DB.SaveChanges();
        }
        public void eSaveChanges_Update(BOOK book)
        {
            BOOK tmp = DataProvider.Instance.Entity_DB.BOOKs.Find(book.ID_BOOK);
            tmp.TITLE = book.TITLE;
            tmp.AUTHOR = book.AUTHOR;
            tmp.ID_CATEGORY = book.ID_CATEGORY;
            tmp.PUBLISH_YEAR = book.PUBLISH_YEAR;
            tmp.PDF_LINK = book.PDF_LINK;
            tmp.OVERVIEW = book.OVERVIEW;
            tmp.COVER = book.COVER;
            DataProvider.Instance.Entity_DB.SaveChanges();
        }
        public void eSaveChanges_Delete(BOOK book)
        {
            var tmp = DataProvider.Instance.Entity_DB.BOOKs.Find(book.ID_BOOK);
            if (tmp == null)
            {
                DataProvider.Instance.Entity_DB.BOOKs.Add(tmp);
                return;
            }
            DataProvider.Instance.Entity_DB.Entry(tmp).CurrentValues.SetValues(book);
            DataProvider.Instance.Entity_DB.Entry(tmp).State = System.Data.Entity.EntityState.Deleted;
            DataProvider.Instance.Entity_DB.SaveChanges();
        }
        public List<BOOK> SearchBook(string str)
        {
            //return DataProvider.Instance.Entity_DB.USP_SearchBook(str).ToList();
             return DataProvider.Instance.Entity_DB.BOOKs.SqlQuery("select * from dbo.BOOK where dbo.fuConvertToUnsign1(TITLE) LIKE  N'%' + dbo.fuConvertToUnsign1(@title) +'%'",
                 new SqlParameter("@title", str)).ToList();
        }
        public BOOK FindBook(int id)
        {
            return DataProvider.Instance.Entity_DB.BOOKs.Where(p => p.ID_BOOK == id).FirstOrDefault();
        }
    }

}
