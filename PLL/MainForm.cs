using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_CNPM.BLL;
using DA_CNPM.DAL;

namespace DA_CNPM.PLL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EntityBLL.Instance.LoadEntity_DB();
            LoadRandomBook();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_TheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Signin_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            //this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_SignUp_Click(object sender, EventArgs e)
        {
            SignUp f = new SignUp();
            //this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        public Panel GenPanel(BOOK book)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Width =  220;
            pictureBox.Height = 190;
            pictureBox.Visible = true;
            byte[] img = book.COVER;
            MemoryStream byteimg = new MemoryStream(img);
            Image image = new Bitmap(byteimg);
            pictureBox.Image = image;
            pictureBox.SendToBack();
            pictureBox.Dock = DockStyle.Top;
            Label label = new Label();
            label.AutoEllipsis = true;
            label.Text = book.TITLE;
            label.Width =180;
            label.Height = 20;
            label.Visible = true;
            label.BringToFront();
            label.Dock = DockStyle.Bottom;

            Panel p1 = new Panel();
            p1.Width = 220;
            p1.Height = 220;
            p1.Margin = new Padding(10, 0, 10, 0);
            p1.BackColor = Color.LightGray;
            p1.Controls.Add(pictureBox);
            //label.Left = (p1.Width - label.Width) / 2;
            p1.Controls.Add(label);
            p1.Visible = true;

            //pictureBox.Click += delegate (object sender ,EventArgs e) { CheckBook(sender, e, book); };
            //label.Click += delegate (object sender, EventArgs e) { CheckBook(sender, e, book); };
            pictureBox.Click += RequestLogin;
            label.Click += RequestLogin;
            return p1;
        }
        public void LoadRandomBook()
        {
            foreach (BOOK item in BookBLL.Instance.LoadRandomBook())
            {
                flp_P1.Controls.Add(GenPanel(item));
            }
        } 
        /*public void CheckBook(object sender ,EventArgs e,BOOK book)
        {

        }*/
        void RequestLogin(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập để được xem chi tiết.");
        }
    }
}
