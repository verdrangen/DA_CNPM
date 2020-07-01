using DA_CNPM.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.DAL
{
    class BookDAL
    {
        private static BookDAL instance;
        public static BookDAL Instance
        {
            get { if (instance == null) instance = new BookDAL(); return instance; }
            private set { instance = value; }
        }
        private BookDAL() { }
        public List<BOOK> LoadBOOKList()
        {
            var bookList = DataProvider.Instance.Entity_DB.BOOKs.Select(p => p).ToList();
            return bookList;
        }
        public List<BOOK> LoadRandomBook()
        {
            var bookList = DataProvider.Instance.Entity_DB.USP_GetRandomBook().ToList();
            return bookList;
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
    }
}
