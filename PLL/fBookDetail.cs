using DA_CNPM.BLL;
using DA_CNPM.ENTITY;
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

namespace DA_CNPM.PLL
{
    public partial class fBookDetail : Form
    {
        public fBookDetail()
        {
            InitializeComponent();
            //CategoryBLL.Instance.LoadcateList();
        }
        public fBookDetail(BOOK book, string username)
        {
            InitializeComponent();
            tb_TieuDe.Text = book.TITLE.Trim();
            tb_TacGia.Text = book.AUTHOR;
            foreach (CATEGORY cate in CategoryBLL.Instance.cateList)
            {
                if (book.ID_CATEGORY == cate.ID_CATEGORY)
                {
                    tb_TheLoai.Text = cate.CATE_NAME;
                    break;
                }
                //else MessageBox.Show("NULL");
            }
            tb_NXB.Text = book.PUBLISH_YEAR.ToString();
            ll_book_pdf.Text = book.PDF_LINK;
            ll_book_pdf.LinkArea = new LinkArea(0, book.PDF_LINK.Trim().Length);
            tb_TongQuan.Text = book.OVERVIEW;
            byte[] img = book.COVER;
            MemoryStream byteimg = new MemoryStream(img);
            Image image = new Bitmap(byteimg);
            pb_book_cover.Image = image;
        }

        private void ll_book_pdf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(ll_book_pdf.Text);
        }
    }
}
