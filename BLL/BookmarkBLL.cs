using DA_CNPM.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.BLL
{
    class BookmarkBLL
    {
        private static BookmarkBLL instance;
        public static BookmarkBLL Instance
        {
            get { if (instance == null) instance = new BookmarkBLL(); return instance; }
            private set { instance = value; }
        }
        public List<int> LoadBookmark(int id)
        {
            var list = DataProvider.Instance.Entity_DB.BOOKMARK.Where(p => p.ID_ACCOUNT == id).Select(p => p.ID_BOOK).ToList();
            List<int> bmList = list.Where(x => x != null).Select(x => x.Value).ToList();
            return bmList;
        }
        public void eSaveChanges_Add(BOOKMARK bm)
        {
            DataProvider.Instance.Entity_DB.BOOKMARK.Add(bm);
            DataProvider.Instance.Entity_DB.SaveChanges();
        }
    }
}
