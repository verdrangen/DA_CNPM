using DA_CNPM.DAL;
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
        public void LoadcateList()
        {
            //bookList = LoadBOOKList();
            cateList = CategoryDAL.Instance.LoadCATEList();
        }
    }
}
