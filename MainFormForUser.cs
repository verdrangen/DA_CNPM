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

namespace DA_CNPM
{
    public partial class MainFormForUser : Form
    {
        public MainFormForUser()
        {
            InitializeComponent();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
          
           String title = tb_Search.Text;
           List <BOOK> bookList = BookBLL.Instance.SearchBook(title);
           pn_Main.Controls.Clear();
            FlowLayoutPanel flp_P1 = new FlowLayoutPanel();
            pn_Main.Controls.Add(flp_P1);
            foreach (BOOK item in bookList)
            {
                flp_P1.Controls.Add(GenPanel(item));
            }


        }
        public Panel GenPanel(BOOK book)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Width = 220;
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
            label.Width = 180;
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
            return p1;
        }
        //public void LoadSearchBook(List<BOOK> bookList)
        //{
        //    foreach (BOOK item in bookList)
        //    {
        //        this.Controls.Add(GenPanel(item));
        //    }
        //}
    }
}
