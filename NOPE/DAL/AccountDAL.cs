using DA_CNPM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_CNPM.DAO
{
    class AccountDAL
    {
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { instance = value; }
        }
        private AccountDAL() { }
        public bool Login_Admin(string username, string password)
        {
            try
            {
                using (var context = new DOAN_CNPMEntities())
                {
                    var account = context.USP_Login(username, password, "001").ToList();
                    if (account.Any()) return true;
                    else return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu");
                return false;
            }
           
        }
        public bool Login_User(string username, string password)
        {
            DOAN_CNPMEntities db = DataProvider.Instance.Entity_DB;
            try
            {
                using (var context = new DOAN_CNPMEntities())
                {
                    var account = context.USP_Login(username, password, "002").ToList();
                    if (account.Any()) return true;
                    else return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu");
                return false;
            }
        }
        public List<ACCOUNT> LoadACCOUNTList()
        {
            var accountList = DataProvider.Instance.Entity_DB.ACCOUNTs.Select(p => p).ToList();
            return accountList;
        }
    }
}
