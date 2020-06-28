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
using DA_CNPM.DAL;

namespace DA_CNPM.PLL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           // this.ControlBox = false;
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
            byte[] img = book.COVER;
            MemoryStream byteimg = new MemoryStream(img);
            Image image = new Bitmap(byteimg);
            pictureBox.Image = image;
            pictureBox.Width =  220;
            pictureBox.Height = 293;
            pictureBox.Visible = true;
            Label label = new Label();
            label.AutoEllipsis = true;
            label.Text = book.TITLE;
            label.Width =220;
            label.Height = 27;
            label.Visible = true;

            Panel p1 = new Panel();
            p1.Width = 220;
            p1.Height = 330;
            p1.Controls.Add(pictureBox);
            p1.Controls.Add(label);
            p1.Visible = true;

            pictureBox.Click += delegate (object sender ,EventArgs e) { CheckBook(sender, e, book); };
            label.Click += delegate (object sender, EventArgs e) { CheckBook(sender, e, book); };
            return p1;
        }
        public void CheckBook(object sender ,EventArgs e,BOOK book)
        {

        }
    }
}
