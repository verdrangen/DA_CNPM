﻿namespace DA_CNPM.PLL
{
    partial class fBookDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_book_cover = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tb_TieuDe = new System.Windows.Forms.TextBox();
            this.tb_TacGia = new System.Windows.Forms.TextBox();
            this.tb_NXB = new System.Windows.Forms.TextBox();
            this.tb_TheLoai = new System.Windows.Forms.TextBox();
            this.tb_TongQuan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_LinkPDF = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_book_pdf = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book_cover)).BeginInit();
            this.pn_LinkPDF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_book_cover);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 690);
            this.panel1.TabIndex = 0;
            // 
            // pb_book_cover
            // 
            this.pb_book_cover.Location = new System.Drawing.Point(3, 3);
            this.pb_book_cover.Name = "pb_book_cover";
            this.pb_book_cover.Size = new System.Drawing.Size(454, 684);
            this.pb_book_cover.TabIndex = 1;
            this.pb_book_cover.TabStop = false;
            // 
            // tb_TieuDe
            // 
            this.tb_TieuDe.Location = new System.Drawing.Point(641, 15);
            this.tb_TieuDe.Multiline = true;
            this.tb_TieuDe.Name = "tb_TieuDe";
            this.tb_TieuDe.Size = new System.Drawing.Size(484, 38);
            this.tb_TieuDe.TabIndex = 1;
            // 
            // tb_TacGia
            // 
            this.tb_TacGia.Location = new System.Drawing.Point(641, 72);
            this.tb_TacGia.Multiline = true;
            this.tb_TacGia.Name = "tb_TacGia";
            this.tb_TacGia.Size = new System.Drawing.Size(484, 38);
            this.tb_TacGia.TabIndex = 2;
            // 
            // tb_NXB
            // 
            this.tb_NXB.Location = new System.Drawing.Point(641, 184);
            this.tb_NXB.Multiline = true;
            this.tb_NXB.Name = "tb_NXB";
            this.tb_NXB.Size = new System.Drawing.Size(484, 38);
            this.tb_NXB.TabIndex = 4;
            // 
            // tb_TheLoai
            // 
            this.tb_TheLoai.Location = new System.Drawing.Point(641, 127);
            this.tb_TheLoai.Multiline = true;
            this.tb_TheLoai.Name = "tb_TheLoai";
            this.tb_TheLoai.Size = new System.Drawing.Size(484, 38);
            this.tb_TheLoai.TabIndex = 3;
            // 
            // tb_TongQuan
            // 
            this.tb_TongQuan.Location = new System.Drawing.Point(641, 334);
            this.tb_TongQuan.Multiline = true;
            this.tb_TongQuan.Name = "tb_TongQuan";
            this.tb_TongQuan.Size = new System.Drawing.Size(484, 368);
            this.tb_TongQuan.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tiêu đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày xuất bản";
            // 
            // pn_LinkPDF
            // 
            this.pn_LinkPDF.Controls.Add(this.rtb_book_pdf);
            this.pn_LinkPDF.Controls.Add(this.label5);
            this.pn_LinkPDF.Location = new System.Drawing.Point(496, 228);
            this.pn_LinkPDF.Name = "pn_LinkPDF";
            this.pn_LinkPDF.Size = new System.Drawing.Size(629, 100);
            this.pn_LinkPDF.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Link đọc sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mô tả";
            // 
            // rtb_book_pdf
            // 
            this.rtb_book_pdf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_book_pdf.Location = new System.Drawing.Point(145, 4);
            this.rtb_book_pdf.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_book_pdf.Name = "rtb_book_pdf";
            this.rtb_book_pdf.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb_book_pdf.Size = new System.Drawing.Size(480, 92);
            this.rtb_book_pdf.TabIndex = 12;
            this.rtb_book_pdf.Text = "";
            // 
            // fBookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 719);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pn_LinkPDF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_TongQuan);
            this.Controls.Add(this.tb_NXB);
            this.Controls.Add(this.tb_TheLoai);
            this.Controls.Add(this.tb_TacGia);
            this.Controls.Add(this.tb_TieuDe);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fBookDetail";
            this.Text = "fBookDetail";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_book_cover)).EndInit();
            this.pn_LinkPDF.ResumeLayout(false);
            this.pn_LinkPDF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_book_cover;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tb_TieuDe;
        private System.Windows.Forms.TextBox tb_TacGia;
        private System.Windows.Forms.TextBox tb_NXB;
        private System.Windows.Forms.TextBox tb_TheLoai;
        private System.Windows.Forms.TextBox tb_TongQuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pn_LinkPDF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_book_pdf;
    }
}