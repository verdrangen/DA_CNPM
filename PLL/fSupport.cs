using DA_CNPM.BLL;
using DA_CNPM.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_CNPM.PLL
{
    public partial class fSupport : Form
    {
        public fSupport()
        {
            InitializeComponent();
        }
        int id;
        public fSupport(string username)
        {
            InitializeComponent();
            id = FindUserID(username);
        }
        public int FindUserID(string username)
        {
            return AccountDetailBLL.Instance.FindAccount(username).ID_ACCOUNT;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txb_support.Text))
            {
                return;
            }
            else
            {
                SUPPORT sp = new SUPPORT { ID_ACCOUNT = id, FEEDBACK = txb_support.Text.Trim(), POST_DATE = DateTime.Now };
                SupportBLL.Instance.eSaveChanges_Add(sp);
                MessageBox.Show("Cảm ơn bạn đã quan tâm. Phản hồi của bạn đã được gửi.");
                this.Dispose();
            }
        }
    }
}
