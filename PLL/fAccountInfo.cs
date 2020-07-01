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
    public partial class fAccountInfo : Form
    {
        public fAccountInfo()
        {
            InitializeComponent();
        }
        public fAccountInfo(string ad)
        {
            InitializeComponent();
            var account  = AccountDetailBLL.Instance.FindAccount(ad);
            tb_user_name.Text = account.USER_NAME;
            tb_user_phone.Text = account.PHONENUMBER;
            tb_user_dob.Text = account.D_O_B.Value.ToString("dd/MM/yyyy");
            tb_user_gender.Text = account.GENDER;
            tb_user_email.Text = account.EMAIL;
        }
    }
}
