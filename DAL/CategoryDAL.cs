using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.DAL
{
    class CategoryDAL
    {
        private static CategoryDAL instance;
        public static CategoryDAL Instance
        {
            get { if (instance == null) instance = new CategoryDAL(); return instance; }
            private set { instance = value; }
        }
        private CategoryDAL() { }
        /*   public List<Book> LoadBookList()
           {
               List<Book> bookList = new List<Book>();
               DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetBookList");
               foreach (DataRow item in data.Rows)
               {
                   Book book = new Book(item);
                   bookList.Add(book);
               }
               return bookList;
           }*/
        public List<CATEGORY> LoadCATEList()
        {
            //DOAN_CNPMEntities db = new DOAN_CNPMEntities();
            var cateList = DataProvider.Instance.Entity_DB.CATEGORies.Select(p => p).ToList();
            return cateList;
        }
    }
}
