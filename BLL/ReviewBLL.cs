using DA_CNPM.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.BLL
{
    class ReviewBLL
    {
        private static ReviewBLL instance;
        public static ReviewBLL Instance
        {
            get { if (instance == null) instance = new ReviewBLL(); return instance; }
            private set { instance = value; }
        }
        public List<REVIEW> GetReviewList(int id)
        {
            return DataProvider.Instance.Entity_DB.REVIEWs.Where(p => p.ID_BOOK == id).ToList();
        }
        public void eSaveChanges_Add(REVIEW rv)
        {
            DataProvider.Instance.Entity_DB.REVIEWs.Add(rv);
            DataProvider.Instance.Entity_DB.SaveChanges();
        }
        public int FindAccountIDbyReviewID (int id, string str)
        {
            return DataProvider.Instance.Entity_DB.REVIEWs.Where(p => (p.ID_BOOK == id) && (p.COMMENT == str)).Select(p => p.ID_REVIEW).SingleOrDefault();
        }
    }
}
