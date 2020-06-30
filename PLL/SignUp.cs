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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void rbtn_male_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_male.Checked)
            {
                rbtn_female.Checked = false;
            }
            else
            {
                rbtn_female.Checked = true;
            }
        }

        private void bt_SignUp_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_UserName.Text) || String.IsNullOrEmpty(tb_Pass.Text) &&
                String.IsNullOrEmpty(tb_PhoneNumber.Text) || String.IsNullOrEmpty(tb_Email.Text))
            {
                MessageBox.Show("Dữ liệu nhập chưa đầy đủ!");
                return;
            }
            else if (String.Compare(tb_Pass.Text, tb_rePw.Text) != 0){
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp!");
                return;
            }
            else if (AccountBLL.Instance.FindAccount(tb_UserName.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập trùng! Vui lòng dùng tên khác.");
                return;
            }
            else if (MessageBox.Show("Xác nhận việc đăng kí tài khoản?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                ACCOUNT account = new ACCOUNT { USER_NAME = tb_UserName.Text, PASSWORD = tb_Pass.Text , GROUP_ID = "002"};
                ACCOUNT_DETAIL accdetail = new ACCOUNT_DETAIL
                {
                    USER_NAME = tb_UserName.Text.Trim(),
                    PHONENUMBER = tb_PhoneNumber.Text.Trim(),
                    D_O_B = dtp_dob.Value,
                    GENDER = rbtn_male.Checked ? "Nam" : "Nữ",
                    EMAIL = tb_Email.Text.Trim()
                };
                AccountBLL.Instance.SignUp(account);
                AccountDetailBLL.Instance.SignUp(accdetail);
                MessageBox.Show("Đăng kí thành công.");
                this.Dispose();
            }
        }
    }
}
