using DA_CNPM.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNPM.BLL
{
    class CategoryBLL
    {
        private static CategoryBLL instance;
        public static CategoryBLL Instance
        {
            get { if (instance == null) instance = new CategoryBLL(); return instance; }
            private set { instance = value; }
        }
        public List<CATEGORY> cateList { get; set; }
        public List<CATEGORY> LoadcateList()
        {
            cateList = DataProvider.Instance.Entity_DB.CATEGORies.Select(p => p).ToList();
            return cateList;
        }
    }
}
