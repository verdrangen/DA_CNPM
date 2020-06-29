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
    public partial class fBookDetail : Form
    {
        public fBookDetail()
        {
            InitializeComponent();
        }

        public fBookDetail(BOOK book)
        {
            InitializeComponent();
           
            tb_TieuDe.Text = book.TITLE;
            tb_TacGia.Text = book.AUTHOR;
            tb_NXB.Text = book.PUBLISH_YEAR.ToString();
            rtb_book_pdf.Text = book.PDF_LINK;
            tb_TongQuan.Text = book.OVERVIEW;
            byte[] img = book.COVER;
            MemoryStream byteimg = new MemoryStream(img);
            Image image = new Bitmap(byteimg);
            pb_book_cover.Image = image;
        }
    }
}
