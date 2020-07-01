using DA_CNPM.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.BLL
{
    public class AccountDetailBLL
    {
        private static AccountDetailBLL instance;
        public static AccountDetailBLL Instance
        {
            get { if (instance == null) instance = new AccountDetailBLL(); return instance; }
            private set { instance = value; }
        }
        private AccountDetailBLL() { }
        public List<ACCOUNT_DETAIL> LoadACCOUNTDETAILList()
        {
            var accountdetailList = DataProvider.Instance.Entity_DB.ACCOUNT_DETAIL.Select(p => p).ToList();
            return accountdetailList;
        }
        public void SignUp(ACCOUNT_DETAIL ad)
        {
            DataProvider.Instance.Entity_DB.ACCOUNT_DETAIL.Add(ad);
            DataProvider.Instance.Entity_DB.SaveChanges();
        }
        public ACCOUNT_DETAIL FindAccount(string username)
        {
            var ad = DataProvider.Instance.Entity_DB.ACCOUNT_DETAIL.Where(p => p.USER_NAME == username).FirstOrDefault();
            return ad;
        }
    }
}
