using DA_CNPM.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.BLL
{
    class SupportBLL
    {
        private static SupportBLL instance;
        public static SupportBLL Instance
        {
            get { if (instance == null) instance = new SupportBLL(); return instance; }
            private set { instance = value; }
        }
        private SupportBLL() { }
        public List<SUPPORT> LoadSUPPORTList()
        {
            var supportList = DataProvider.Instance.Entity_DB.SUPPORTs.Select(p => p).ToList();
            return supportList;
        }
    }
}
