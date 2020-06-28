using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.BLL
{
    class CategoryBLL
    {
        private static BookBLL instance;
        public static BookBLL Instance
        {
            get { if (instance == null) instance = new BookBLL(); return instance; }
            private set { instance = value; }
        }
        public List<BOOK> bookList { get; set; }
        public void LoadbookList()
        {
            //bookList = LoadBOOKList();
            bookList = BookDAL.Instance.LoadBOOKList();
        }
    }
}
