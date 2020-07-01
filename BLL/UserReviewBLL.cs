using DA_CNPM.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.BLL
{
    class UserReviewBLL
    {
        private static UserReviewBLL instance;
        public static UserReviewBLL Instance
        {
            get { if (instance == null) instance = new UserReviewBLL(); return instance; }
            private set { instance = value; }
        }
        public List<int> FindAccountIDbyReview(int id)
        {
            var list = DataProvider.Instance.Entity_DB.USER_REVIEW.Where(p => p.ID_REVIEW == id).Select(p => p.ID_ACCOUNT).ToList();
            List<int> accid = list.Where(x => x != null).Select(x => x.Value).ToList();
            return accid;
        }
        public void eSaveChanges_Add(USER_REVIEW ur)
        {
            DataProvider.Instance.Entity_DB.USER_REVIEW.Add(ur);
            DataProvider.Instance.Entity_DB.SaveChanges();
        }
    }
}
