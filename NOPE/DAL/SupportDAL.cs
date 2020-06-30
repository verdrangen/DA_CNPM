using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.DAL
{
    class SupportDAL
    {
        private static SupportDAL instance;
        public static SupportDAL Instance
        {
            get { if (instance == null) instance = new SupportDAL(); return instance; }
            private set { instance = value; }
        }
        private SupportDAL() { }
        public List<SUPPORT> LoadSUPPORTList()
        {
            //DOAN_CNPMEntities db = new DOAN_CNPMEntities();
            var supportList = DataProvider.Instance.Entity_DB.SUPPORTs.Select(p => p).ToList();
            return supportList;
        }

    }
}
