using DA_CNPM.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_CNPM.BLL
{
    class AccountBLL
    {
        private static AccountBLL instance;
        public static AccountBLL Instance
        {
            get { if (instance == null) instance = new AccountBLL(); return instance; }
            private set { instance = value; }
        }
        private AccountBLL() { }
        //public List<ACCOUNT> accountList { get; set; }
        public List<ACCOUNT> LoadACCOUNTList()
        {
            var accountList = DataProvider.Instance.Entity_DB.ACCOUNTs.Select(p => p).ToList();
            return accountList;
        }
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
        public void SignUp(ACCOUNT acc)
        {
            DataProvider.Instance.Entity_DB.ACCOUNTs.Add(acc);
            DataProvider.Instance.Entity_DB.SaveChanges();
        }
        public bool FindAccount(string username)
        {
            return DataProvider.Instance.Entity_DB.ACCOUNTs.Any(p => p.USER_NAME == username);
        }
    }
}
