using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.DAL
{
    class AccountDetailDAL
    {
        private static AccountDetailDAL instance;
        public static AccountDetailDAL Instance
        {
            get { if (instance == null) instance = new AccountDetailDAL(); return instance; }
            private set { instance = value; }
        }
        private AccountDetailDAL() { }
        public List<ACCOUNT_DETAIL> LoadACCOUNTDETAILList()
        {
            //DOAN_CNPMEntities db = new DOAN_CNPMEntities();
            var accountdetailList = DataProvider.Instance.Entity_DB.ACCOUNT_DETAIL.Select(p => p).ToList();
            return accountdetailList;
        }
    }
}
